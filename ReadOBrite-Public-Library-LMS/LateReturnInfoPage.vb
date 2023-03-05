Imports System.Data.OleDb

Public Class LateReturnInfoPage

    Public Shared strTitleBook(10) As String

    Private Sub LateReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearch.Items.Add("Borrower's Name")
        cmbSearch.Items.Add("IC Number")
        lblSearchBy.Visible = False
        txtSearch.Visible = False
    End Sub

    'Clicked Combobox Search
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "Borrower's Name"
        Else
            lblSearchBy.Text = "IC Number"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    'Clicked button return
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    'Clicked button search - to get borrower's details
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlSearch, sqlGetTtile As String

        'Get Name, IC and HPNum based on txtSearch
        If (cmbSearch.SelectedIndex = 0) Or (cmbSearch.SelectedIndex = 1) Then
            sqlSearch = "Select BR.BorrowerName, BR.ICNum, BR.HPNum
                         From Borrower BR, Borrow BO
                         Where BR.BorrowerID = BO.BorrowerID
                         And BO.Status = 'Not Returned'
                         And (BR.BorrowerName='" + txtSearch.Text + "'
                         OR BR.ICNum='" + txtSearch.Text + "')"
        End If

        'Get all details of book and dates based on txtSearch
        sqlGetTtile = "Select BK.Title
                   From Book BK, Borrow BO, Borrower BR
                   Where BK.ISBN = BO.ISBN
                   And BR.BorrowerID = BO.BorrowerID
                   And BO.Status = 'Not Returned'
                   And (BR.BorrowerName='" + txtSearch.Text + "'
                   OR BR.ICNum='" + txtSearch.Text + "')"

        Dim cmdBook As New OleDbCommand(sqlGetTtile, conn)
        Dim cmdSearch As New OleDbCommand(sqlSearch, conn)

        Dim myReader, readerTitle As OleDbDataReader
        myReader = cmdSearch.ExecuteReader()
        myReader.Read()
        readerTitle = cmdBook.ExecuteReader()

        Dim intI As Integer
        listBooksNotReturned.Items.Clear()
        Try
            'Read data from db and add into ListBooksBorrowed
            While readerTitle.Read()
                listBooksNotReturned.Items.Add(readerTitle("Title"))
            End While

            'Count how many books in the list then store them too in array variable: strTitleBook(10)
            For intI = 0 To listBooksNotReturned.Items.Count - 1
                strTitleBook(intI) = listBooksNotReturned.Items(intI).ToString()
                MessageBox.Show(strTitleBook(intI))
            Next
        Catch ex As Exception
            MessageBox.Show("No Books Borrowed! | Data Cannot Be Found! " & ex.Message.ToString(),
                            "Search Borrower: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Try
            'Borrower's Details
            lblName.Text = myReader("BorrowerName")
            lblIC.Text = myReader("ICNum")
            lblHPNum.Text = myReader("HPNum")
        Catch ex As Exception
            lblName.Text = ""
            lblIC.Text = ""
            lblHPNum.Text = ""
            txtSearch.Text = ""

            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                                "Search Borrower/Book: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conn.Close()
    End Sub

    'Clicked title in listbox and get all data needed
    Private Sub listBooksNotReturned_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBooksNotReturned.SelectedIndexChanged
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim intIndex As Integer
        Dim strBook, sqlBook As String
        Dim amtFines As Decimal = 0

        'Count num books in listbox then store in strBook to compare
        For intIndex = 0 To listBooksNotReturned.Items.Count - 1
            strBook = listBooksNotReturned.SelectedItem.ToString()
            If strBook = strTitleBook(intIndex) Then
                MessageBox.Show("Hello " + strBook)
            End If
        Next

        'Get all details of book and dates based on title and borrower's name
        sqlBook = "Select BK.ISBN, BK.YearPublish, BK.Title, BK.Author, BK.PublisherName, BO.IssueDate, BO.DueDate 
                   From Book BK, Borrow BO, Borrower BR
                   Where BK.ISBN = BO.ISBN
                   And BR.BorrowerID = BO.BorrowerID
                   And BO.Status = 'Not Returned'
                   And BR.BorrowerName='" + lblName.Text + "'
                   And BK.Title='" + strBook + "'"

        Dim cmdBooks As New OleDbCommand(sqlBook, conn)
        Dim readerBook As OleDbDataReader
        readerBook = cmdBooks.ExecuteReader()
        readerBook.Read()

        Try
            'Details of books
            lblISBN.Text = readerBook("ISBN")
            lblPubYr.Text = readerBook("YearPublish")
            lblTitle.Text = readerBook("Title")
            lblAuthor.Text = readerBook("Author")
            lblPubNm.Text = readerBook("PublisherName")

            'Details of date
            lblIssueDate.Text = readerBook("IssueDate")
            lblDueDate.Text = readerBook("DueDate")

            'Details of fines. May get (-)number since Today-DueDate. Refer db
            amtFines = calcFines()
            lblLateRetFines.Text = amtFines.ToString("C")
            lblTotalFines.Text = amtFines.ToString("C")
        Catch ex As Exception
            MessageBox.Show("Error Occurred!" & ex.Message.ToString())
        End Try
    End Sub

    Public Function calcFines()
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlGetDate As String
        Dim amtFines As Decimal = 0
        Dim todayDate As Date = Today.ToString("d")
        Dim duedate As Date
        Dim span As TimeSpan
        Dim intDays As Integer

        'Get DueDate of books that not returned yet
        sqlGetDate = "Select BO.DueDate From Borrow BO, Borrower BR, Book BK
                      Where BO.BorrowerID = BR.BorrowerID
                      And BO.ISBN = BK.ISBN
                      And BO.Status = 'Not Returned'
                      And BR.BorrowerName='" + lblName.Text + "'
                      And BK.ISBN='" + lblISBN.Text + "'"

        Dim cmdDate As New OleDbCommand(sqlGetDate, conn)
        Dim readerDate As OleDbDataReader
        readerDate = cmdDate.ExecuteReader()
        readerDate.Read()

        duedate = readerDate("DueDate")

        span = todayDate - duedate
        intDays = span.TotalDays.ToString()

        amtFines = intDays * 0.7

        conn.Close()

        Return amtFines
    End Function

    'Save payment record in database
    Private Sub btnGenRecipt_Click(sender As Object, e As EventArgs) Handles btnGenRecipt.Click
        Dim amtFines, decPayment As Decimal
        amtFines = calcFines()
        decPayment = txtPayment.Text

        Dim todayDate As DateTime
        todayDate = DTPPayment.Value.Date

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlPayment, sqlGetBorrowID As String

        sqlGetBorrowID = "Select BO.BorrowID FROM Borrow BO, Borrower BR 
                          WHERE BO.BorrowerID = BR.BorrowerID
                          AND BO.ISBN='" + lblISBN.Text + "'
                          And BR.BorrowerName='" + lblName.Text + "'"
        Dim cmdID As New OleDbCommand(sqlGetBorrowID, conn)
        Dim myReader As OleDbDataReader
        myReader = cmdID.ExecuteReader()
        myReader.Read()

        Dim statusPayment As String
        statusPayment = "Not Successful"

        Dim intBorrowID As Integer
        intBorrowID = myReader("BorrowID")

        sqlPayment = "INSERT INTO LRFines([LateRetFines], [Payment], [DatePayment], [StatusPayment], [BorrowID])
                      VALUES (?, ?, ?, ?, ?)"

        Dim cmdPayment As New OleDbCommand(sqlPayment, conn)
        cmdPayment.Parameters.Add(New OleDbParameter("LateRetFines", CType(amtFines, Decimal)))
        cmdPayment.Parameters.Add(New OleDbParameter("Payment", CType(decPayment, Decimal)))
        cmdPayment.Parameters.Add(New OleDbParameter("DatePayment", CType(todayDate, Date)))
        cmdPayment.Parameters.Add(New OleDbParameter("StatusPayment", CType(statusPayment, String)))
        cmdPayment.Parameters.Add(New OleDbParameter("BorrowID", CType(intBorrowID, Integer)))

        Try
            cmdPayment.ExecuteNonQuery()
            MessageBox.Show("Payment Record Successfully Saved!", "Successfully Saved!", MessageBoxButtons.OK)

            ' Update sql status
            Dim sqlBookPayment As String
            sqlBookPayment = "UPDATE LRFines LR, Borrow B
                                    SET LR.StatusPayment = '" + "Successful" + "'
                                    WHERE LR.BorrowID = B.BorrowID"

            Dim cmdStatusPayment As New OleDbCommand(sqlBookPayment, conn)
            Dim readerPayment As OleDbDataReader
            readerPayment = cmdStatusPayment.ExecuteReader()

        Catch ex As Exception
            MsgBox("Error On Inserting Payment Record! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                MsgBoxStyle.Information, "Insert Payment Record Failed!")
        End Try

        Me.Hide()
        GenerateReceipt.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
        'Clear borrower details
        lblName.Text = ""
        lblIC.Text = ""
        lblHPNum.Text = ""

        'Clear book details
        listBooksNotReturned.Items.Clear()

        lblISBN.Text = ""
        lblPubYr.Text = ""
        lblTitle.Text = ""
        lblAuthor.Text = ""
        lblPubNm.Text = ""

        lblIssueDate.Text = ""
        lblDueDate.Text = ""
        lblLateRetFines.Text = ""

        'Clear fines payment
        lblTotalFines.Text = ""
        txtPayment.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        GenerateReceipt.Show()
    End Sub

End Class