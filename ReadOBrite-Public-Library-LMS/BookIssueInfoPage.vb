Imports System.Data.OleDb
Public Class BookIssueInfoPage
    Private Sub BorrowerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BorrowerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReadOBrite_dbDataSet)

    End Sub

    Private Sub BookIssueInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReadOBrite_dbDataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.ReadOBrite_dbDataSet.Borrower)

        cmbSearch.Items.Add("ISBN")
        cmbSearch.Items.Add("Author")
        cmbSearch.Items.Add("Title")

        lblSearchBy.Visible = False
        txtSearch.Visible = False

        btnGoBorrowersInfoPg.Visible = False
    End Sub

    'Click button return
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Exit this page. Return to menu page
        Me.Close()
        MenuListPage.Show()
    End Sub

    'Click combobox search
    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        If cmbSearch.SelectedIndex = 0 Then
            lblSearchBy.Text = "ISBN"
        ElseIf cmbSearch.SelectedIndex = 1 Then
            lblSearchBy.Text = "Author"
        ElseIf cmbSearch.SelectedIndex = 2 Then
            lblSearchBy.Text = "Title"
        End If

        lblSearchBy.Visible = True
        txtSearch.Visible = True
    End Sub

    'Click button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim strsql As String

        'If user clicked ISBN | Author | Title, sql compare what user clicked
        If cmbSearch.SelectedIndex = 0 Then
            strsql = "select ISBN,Title from Book where ISBN='" + txtSearch.Text + "'"
        ElseIf cmbSearch.SelectedIndex = 1 Then
            strsql = "select ISBN,Title from Book where Author='" + txtSearch.Text + "'"
        ElseIf cmbSearch.SelectedIndex = 2 Then
            strsql = "select ISBN,Title from Book where Title='" + txtSearch.Text + "'"
        End If

        Dim cmd As New OleDbCommand(strsql, conn)
        Dim myReader As OleDbDataReader
        myReader = cmd.ExecuteReader()
        myReader.Read()

        Try
            'Get book details
            lblISBN.Text = myReader("ISBN")
            lblBookTitle.Text = myReader("Title")
        Catch ex As Exception
            txtSearch.Text = ""
            lblISBN.Text = ""
            lblBookTitle.Text = ""

            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Data: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Click button Search Name
    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        'While user search, borrower table will filter data
        Try
            Me.BorrowerTableAdapter.FillBy(Me.ReadOBrite_dbDataSet.Borrower, txtSearchName.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlBorrower As String
        sqlBorrower = "Select BR.BorrowerID, BR.BorrowerName From Borrower BR 
                       where BR.BorrowerName='" + txtSearchName.Text + "'"

        'Get Borrower details - ID and Name
        Dim cmdBorrower As New OleDbCommand(sqlBorrower, conn)
        Dim readerBorrower As OleDbDataReader
        readerBorrower = cmdBorrower.ExecuteReader()
        readerBorrower.Read()

        Try
            'Store ID and Name in label
            lblBorrowerID2.Text = readerBorrower("BorrowerID")
            lblBorrowerName2.Text = readerBorrower("BorrowerName")
        Catch ex As Exception
            lblBorrowerID2.Text = ""
            lblBorrowerName2.Text = ""
            txtSearchName.Text = ""

            MessageBox.Show("Data Cannot Be Found: " & ex.Message.ToString(),
                            "Search Name: LMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please Click Button Go To Borrower's Information Page To Add New Borrower",
                            "Help Information: LMS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'If data not exists button Go To Borrower's Info Page will visible
            btnGoBorrowersInfoPg.Visible = True
        End Try
    End Sub

    'Click button issue - Insert Data into Database
    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        Try
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
            conn.Open()

            Dim strsql, status As String
            status = "Not Returned"

            'Get date value from DateTimePicker
            Dim issueDate, dueDate, retDate As DateTime
            'issueDate = DTPIssueDate.Value.Date
            issueDate = Me.dtPicker.Value.Date
            'dueDate = DTPDueDate.Value.Date
            dueDate = Me.dtPicker2.Value.Date
            retDate = DTPIssueDate.Value.Date

            'sql insert data
            strsql = "INSERT INTO Borrow([IssueDate], [DueDate], [ReturnDate], [Status], [ISBN], [BorrowerID]) 
                      VALUES (?, ?, ?, ?, ?, ?)"

            'execute sql
            'Return date will has the same value as issue date bcs at return page, return date will be updated
            Dim cmd As New OleDbCommand(strsql, conn)
            cmd.Parameters.Add(New OleDbParameter("IssueDate", CType(issueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("DueDate", CType(dueDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("ReturnDate", CType(retDate, Date)))
            cmd.Parameters.Add(New OleDbParameter("Status", CType(status, String)))
            cmd.Parameters.Add(New OleDbParameter("ISBN", CType(lblISBN.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BorrowerID", CType(lblBorrowerID2.Text, String)))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Successfully Saved!", "Record Saved: LMS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Error occurred! " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or
                   MsgBoxStyle.Information, "Issue Book Failed!")
        End Try
    End Sub

    Private Sub btnGoBorrowersInfoPg_Click(sender As Object, e As EventArgs) Handles btnGoBorrowersInfoPg.Click
        'Me.Close()
        'BorrowersInfoPage.Show()

        Dim BorrowerForm As BorrowersInfoPage
        BorrowerForm = New BorrowersInfoPage
        Me.Hide()
        BorrowerForm.Show()
    End Sub
End Class