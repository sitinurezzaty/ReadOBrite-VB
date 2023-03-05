' Import function to open connection
Imports System.Data.OleDb
Imports System.TimeSpan

Public Class BookReturnInfoPage
    Private Sub BookReturnInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the label and textbox for search
        lblSearchBy.Visible = False
        txtSearch.Visible = False

        ' Disable the button for return book, return book late and also fines payment
        btnReturnBook.Visible = False
        btnReturnBookLate.Visible = False
        btnFinesPayment.Visible = False

        ' Insert Name, and IC Number in the combo box
        cmbSearch.Items.Add("Name")
        cmbSearch.Items.Add("IC Number")
    End Sub

    ' User choose input inside the combo box
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        ' To display the label based on the result that user have chosen in combo box
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "Name"
        Else
            lblSearchBy.Text = "IC Number"
        End If

        ' Enable the label and text box for search 
        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    ' User click button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Open the connection
        Dim conn As New OleDbConnection
        ' Connect the connection with our source
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        ' Declare the variable of sql that we want to use
        Dim strsql, sqlListBook As String

        If (cmbSearch.SelectedIndex = 0) Or (cmbSearch.SelectedIndex = 1) Then
            ' SQL for search based on borrower name and their ic number
            strsql = "select BorrowerName, ICNum from Borrower where BorrowerName='" + txtSearch.Text + "' OR " _
                        & "ICNum='" + txtSearch.Text + "'"
        End If

        Dim cmd As New OleDbCommand(strsql, conn)
        ' Using the OleDBDataReader to retrieve our data in our database
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader()
        myReader.Read()

        Try
            ' Retrieve the value of BorrowerName and ICNum from the database
            lblName.Text = myReader("BorrowerName")
            lblIC.Text = myReader("ICNum")
        Catch ex As Exception
            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        sqlListBook = "Select B.ISBN, B.Title From Book B, Borrow BO, Borrower BR 
                        Where B.ISBN = BO.ISBN
                        And BO.BorrowerID = BR.BorrowerID
                        And BR.ICNum='" + lblIC.Text + "'
                        And BR.BorrowerName='" + lblName.Text + "'
                        AND BO.Status= '" + "Not Returned" + "'"

        Dim cmdListBook As New OleDbCommand(sqlListBook, conn)
        Dim readerListBook As OleDbDataReader
        readerListBook = cmdListBook.ExecuteReader()

        Try
            ' Clear the check box
            chkLBooks.Items.Clear()
            While readerListBook.Read()
                ' Retrieve the value of Title book from the database
                ' Add the title of the book into the check list box
                chkLBooks.Items.Add(readerListBook("Title"))
            End While
        Catch ex As Exception

        End Try
    End Sub

    ' User click button Back and will return to menu list page  
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MenuListPage.Show()
    End Sub

    ' User click button Select Book
    Private Sub btnSelectItem_Click(sender As Object, e As EventArgs) Handles btnSelectItem.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection 
        conn.Open()

        ' Declare the variables
        Dim sqlBook As String
        Dim amtFines As Decimal = 0
        Dim retStatus1 As Boolean
        Dim bookISBN As String
        ' Date
        Dim duedate As Date
        Dim intIndex As Integer

        For intIndex = 0 To chkLBooks.CheckedItems.Count - 1
            Dim title As String = chkLBooks.CheckedItems(intIndex)
            ' SQL for display the details of the book based on what user tick inside the check box
            sqlBook = "Select B.ISBN, B.YearPublish, B.Title, B.Author, B.PublisherName, BO.IssueDate,
                    BO.DueDate, BO.LateRetStatus From Book B, Borrow BO, Borrower BR
                    Where B.ISBN = BO.ISBN
                    And BO.BorrowerID = BR.BorrowerID
                    And BR.ICNum='" & lblIC.Text & "'
                    And B.Title='" & title & "'
                    AND BO.Status= '" & "Not Returned" & "'"

            Dim cmdBook As New OleDbCommand(sqlBook, conn)
            Dim readerBook As OleDbDataReader
            readerBook = cmdBook.ExecuteReader()

            ' Retrieve the value first of late return status either true or false
            While readerBook.Read()
                ' Retrieve the value of DueDate, LateRetStatus, ISBN from database
                duedate = readerBook("DueDate")
                retStatus1 = readerBook("LateRetStatus")
                bookISBN = readerBook("ISBN")

                ' Function for calculate fines (calcFines)
                amtFines = calcFines(amtFines, retStatus1, duedate, bookISBN)
                ' Procedure to display the details of the book
                bookDisplay(amtFines)
            End While
        Next
        conn.Close()
    End Sub

    ' To display the details of the book in the label
    Sub bookDisplay(ByVal amtFines As Decimal)
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection
        conn.Open()

        Dim sql1 As String

        Dim intIndex As Integer
        For intIndex = 0 To chkLBooks.CheckedItems.Count - 1
            Dim title As String = chkLBooks.CheckedItems(intIndex)
            ' SQL for display the details of the book based on what user tick inside the check box
            sql1 = "Select B.ISBN, B.YearPublish, B.Title, B.Author, B.PublisherName, BO.IssueDate,
                    BO.DueDate, BO.LateRetStatus From Book B, Borrow BO, Borrower BR
                    Where B.ISBN = BO.ISBN
                    And BO.BorrowerID = BR.BorrowerID
                    And BR.ICNum='" & lblIC.Text & "'
                    And B.Title='" & title & "'
                    AND BO.Status= '" & "Not Returned" & "'"

            Dim cmdBook As New OleDbCommand(sql1, conn)
            Dim readerBook As OleDbDataReader
            readerBook = cmdBook.ExecuteReader()

            ' Retrieve the value first of late return status either true or false
            While readerBook.Read()
                lblISBN.Text = readerBook("ISBN")
                lblPubYr.Text = readerBook("YearPublish")
                lblTitle.Text = readerBook("Title")
                lblAuthor.Text = readerBook("Author")
                lblPubName.Text = readerBook("PublisherName")
                lblIssueDate.Text = readerBook("IssueDate")
                lblDueDate.Text = readerBook("DueDate")
                lblRetStatus.Text = readerBook("LateRetStatus")

                ' Change the status of late Return from true and false into yes or no
                If lblRetStatus.Text = True Then
                    lblRetStatus.Text = "YES"
                    MessageBox.Show("You have late return fines that need to be settled!", "Return Book Failed: LMS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblRetFines.Text = amtFines.ToString("C")
                    MsgBox("Please click button payment fines")
                    ' Enable the button Fines Payment and button for Return Book late
                    btnFinesPayment.Visible = True
                    btnReturnBookLate.Visible = True

                Else
                    lblRetStatus.Text = "NO"
                    amtFines = 0.00
                    MessageBox.Show("You have does not have late return fines that need to be settled!", "Return Book Failed: LMS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblRetFines.Text = amtFines.ToString("C")
                    ' Disable the button Fines Payment
                    btnFinesPayment.Visible = False
                    ' Enable the button for Return Book 
                    btnReturnBook.Visible = True
                End If

            End While
        Next
    End Sub

    ' To calculate the amount of fines for borrower that return late the book
    Function calcFines(ByVal amtFines As Decimal, ByRef retStatus1 As Boolean, ByVal duedate As Date, ByVal bookISBN As String)
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection
        conn.Open()

        ' declare variable
        Dim sql As String
        Dim intDays As Integer
        ' Get the value of date today
        Dim retDate As Date = Today.ToString("d")

        ' Count total day(duration) between selected date and due date using timespan
        Dim ts As TimeSpan = retDate.Subtract(duedate)

        ' convert the value of ts(timespan) into integer value
        intDays = Convert.ToInt32(ts.Days)
        'MsgBox(intDays)

        ' Compare if total day greater than 0, LateRetStatus will be TRUE inside the database
        If intDays > 0 Then
            sql = "UPDATE Borrow B, Borrower BO
                        SET B.LateRetStatus = True
                        WHERE B.BorrowerID = BO.BorrowerID
                        AND BO.ICNum = '" & lblIC.Text & "'
                        AND B.ISBN = '" & bookISBN & "'"

            Dim cmdLateRetStatus As New OleDbCommand(sql, conn)
            Dim i = cmdLateRetStatus.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Book records has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If


            Try
                cmdLateRetStatus.ExecuteNonQuery()
                MessageBox.Show("Update Late Return Status Success!", "Return Book Success: LMS",
                            MessageBoxButtons.OK)
            Catch ex As Exception
                MsgBox("Error Occured! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Update Late Return Status Failed!")
            End Try
        End If
        ' Calculate the total fines based on the days that they have late returned
        amtFines = intDays * 0.7

        conn.Close()
        ' Return the value amtFines
        Return amtFines
    End Function

    Private Sub btnStatusPayment_Click(sender As Object, e As EventArgs) Handles btnReturnBookLate.Click
        Me.Close()
        BookReturnPage.Show()
    End Sub

    ' User click button Fines Payment 
    ' to paid the charge fines before they return the book
    Private Sub btnFinesPayment_Click(sender As Object, e As EventArgs) Handles btnFinesPayment.Click
        Me.Hide()
        LateReturnInfoPage.Show()
    End Sub

    ' User click button Return Book
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        ' Ask if the user confirm to return the book
        MessageBox.Show("Are You Sure You Want To Return The Book?")
        Dim ISBN As String
        'Get the value ISBN for the input that have display inside the lblISBN.text
        ISBN = lblISBN.Text

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection
        conn.Open()

        ' Get today date
        Dim dateNow As Date = Today.ToString("d")

        ' Check if the ISBN had empty data
        If String.IsNullOrEmpty(ISBN) Then
            MessageBox.Show("Please Select Book To Be Returned!", "Return Book Failed: LMS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Try
            Dim sqlDate As String
            ' SQL for update the return date based on the date borrower return the book and the status=Returned
            sqlDate = "UPDATE Borrow B SET B.ReturnDate='" + dateNow + "', B.Status='" + "Returned" + "' WHERE B.ISBN='" + ISBN + "'"

            Dim cmdDate As New OleDbCommand(sqlDate, conn)
            cmdDate.Parameters.Add(New OleDbParameter("ReturnDate", CType(dateNow, Date)))

            cmdDate.ExecuteNonQuery()
            MessageBox.Show("Book Is Successfully Returned!", "Return Book Success: LMS",
                            MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Error Occured! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Return Book Failed!")
        End Try
        conn.Close()
    End Sub
End Class