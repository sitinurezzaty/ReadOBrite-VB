Imports System.Data.OleDb
Imports System.TimeSpan

Public Class BookReturnPage
    ' User click button Return Book
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        ' Confirmation message forn return book
        MessageBox.Show("Are You Sure You Want To Return The Book?")
        ' Get the value of ISBN from label
        Dim ISBN As String
        ISBN = lblISBN.Text

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection
        conn.Open()

        ' Get value of date today
        Dim dateNow As Date = Today.ToString("d")

        ' Check if the variable ISBN either empty or has data
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

    ' User click button Display Book
    Private Sub btnDisplayBook_Click(sender As Object, e As EventArgs) Handles btnDisplayBook.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        ' Open connection
        conn.Open()

        ' Declare variables
        Dim intDays, intDaysDB As Integer
        Dim strSqlBook As String
        Dim issueDate, dueDate As DateTime
        Dim issueDateDB, dueDateDB As DateTime
        Dim tsDB As TimeSpan

        ' Get the value of date from the date time picker in the form
        issueDate = Me.dtpIssueDate.Value.Date
        dueDate = Me.dtpDueDate.Value.Date

        ' Get the duration of date between due date and issue date
        Dim ts As TimeSpan = dueDate.Subtract(issueDate)

        ' Convert the value of ts from timespan to int
        intDays = Convert.ToInt32(ts.Days)

        ' SQL to display the details of the borrower and book inside the label based on borrower name and book name
        strSqlBook = "SELECT BK.ISBN, BK.YearPublish, BK.Title, BK.Author, BK.PublisherName, BO.IssueDate, BO.DueDate, BO.LateRetStatus, LR.StatusPayment, LR.LateRetFines
                      FROM Book BK, Borrower BR, Borrow BO, LRFines LR
                      WHERE BK.ISBN = BO.ISBN
                      AND BO.BorrowerID = BR.BorrowerID
                      AND LR.BorrowID = BO.BorrowID
                      AND BK.Title = '" + txtBookName.Text + "'
                      AND BR.BorrowerName = '" + txtBorrowerName.Text + "'"

        Dim cmdDispBook As New OleDbCommand(strSqlBook, conn)
        Dim readerDispBook As OleDbDataReader
        readerDispBook = cmdDispBook.ExecuteReader()

        ' Retrieve the value from the sql
        While readerDispBook.Read()
            ' retrieve the value of IssueDate and DueDate from database first to get the date duration
            issueDateDB = readerDispBook("IssueDate")
            dueDateDB = readerDispBook("DueDate")
            tsDB = dueDate.Subtract(issueDate)
            intDaysDB = Convert.ToInt32(tsDB.Days)
            'MsgBox(intDaysDB & "DATABASE Click")

            ' Compare if the duration of the days that we have calculate same with the duration of days that we calculate in DB
            ' then display the data into label
            If intDaysDB = intDays Then
                ' Retrieve the value for StatusPayment, ISBN, YearPublish, Title, Author, PublisherName
                ' IssueDate, DueDate, LateRetStatus, and LateRetFines from database to be display inside the label
                lblPaymentStatus.Text = readerDispBook("StatusPayment")
                lblISBN.Text = readerDispBook("ISBN")
                lblPubYr.Text = readerDispBook("YearPublish")
                lblTitle.Text = readerDispBook("Title")
                lblAuthor.Text = readerDispBook("Author")
                lblPubName.Text = readerDispBook("PublisherName")
                lblIssueDate.Text = readerDispBook("IssueDate")
                lblDueDate.Text = readerDispBook("DueDate")
                lblRetStatus.Text = readerDispBook("LateRetStatus")
                Dim amtFines As Decimal = readerDispBook("LateRetFines")
                lblRetFines.Text = amtFines.ToString("C")

            Else
                ' Display error message
                MessageBox.Show("Sorry, you have clicked wronged Due Date or Issue Date",
                            "Help Information: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End While

        conn.Close()
    End Sub

    ' User click button Return to return to BookReturnInfo Page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        BookReturnInfoPage.Show()
    End Sub

    Private Sub BookReturnPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class