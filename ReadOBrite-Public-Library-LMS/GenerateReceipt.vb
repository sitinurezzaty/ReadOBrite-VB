Imports System.Data.OleDb
Imports System.Drawing

Public Class GenerateReceipt
    Public Shared intIndex As Integer

    'Get all borrower's name and add in cmbName
    Private Sub GenerateReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlGetName As String

        sqlGetName = "Select BR.BorrowerName From Borrower BR"

        Dim cmdGetName As New OleDbCommand(sqlGetName, conn)
        Dim readerName As OleDbDataReader
        readerName = cmdGetName.ExecuteReader()

        cmbName.Items.Clear()
        While readerName.Read()
            cmbName.Items.Add(readerName("BorrowerName"))
        End While
    End Sub

    'User clicked any name in combo box
    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlGetAll, selectedName As String
        'Get selected name
        selectedName = cmbName.SelectedItem.ToString()
        sqlGetAll = "Select BK.Title
                     From LRFines LR, Book BK, Borrow BO, Borrower BR
                     Where LR.BorrowID = BO.BorrowID
                     And BO.ISBN = BK.ISBN
                     And BO.BorrowerID = BR.BorrowerID
                     And BR.BorrowerName='" + selectedName + "'"

        Dim cmdGetName As New OleDbCommand(sqlGetAll, conn)
        Dim readerAll As OleDbDataReader
        readerAll = cmdGetName.ExecuteReader()

        Dim title As String

        cmbTitle.Items.Clear()
        While readerAll.Read()
            Try
                'Get title and add it in cmbTitle
                title = readerAll("Title")
                cmbTitle.Items.Add(title)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End While

        lblAmtFines.Text = ""
        lblPayment.Text = ""
        lblBalance.Text = ""
        lblDatePymnt.Text = ""
    End Sub

    'User select any item in cmbTitle
    Private Sub cmbTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTitle.SelectedIndexChanged
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim sqlDetails, selectedTitle As String
        'Get selected title
        selectedTitle = cmbTitle.SelectedItem.ToString()

        sqlDetails = "Select LR.LateRetFines, LR.Payment, LR.DatePayment
                      From LRFines LR, Book BK, Borrow BO
                      Where LR.BorrowID = BO.BorrowID
                      And BO.ISBN = BK.ISBN
                      And BK.Title='" + selectedTitle + "'"

        Dim cmdDetails As New OleDbCommand(sqlDetails, conn)
        Dim readerDetails As OleDbDataReader
        readerDetails = cmdDetails.ExecuteReader()

        Dim amtFines, payment, balance As Decimal
        Dim datePymnt As DateTime

        While readerDetails.Read()
            'Get details of payment
            amtFines = readerDetails("LateRetFines")
            payment = readerDetails("Payment")
            datePymnt = readerDetails("DatePayment")

            balance = payment - amtFines

            lblAmtFines.Text = amtFines.ToString("C")
            lblPayment.Text = payment.ToString("C")
            lblBalance.Text = balance.ToString("C")
            lblDatePymnt.Text = datePymnt.ToShortDateString
        End While
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
        conn.Open()

        Dim selectedTitle, text, sqlGetID, resitNo, stringNum As String
        selectedTitle = cmbTitle.SelectedItem.ToString()

        sqlGetID = "Select LR.BorrowID, LR.LateRetID
                    From LRFines LR, Book BK, Borrow BO
                    Where LR.BorrowID = BO.BorrowID
                    And BO.ISBN = BK.ISBN
                    And BK.Title='" + selectedTitle + "'"

        Dim cmdId As New OleDbCommand(sqlGetID, conn)
        Dim readerID As OleDbDataReader
        readerID = cmdId.ExecuteReader()
        readerID.Read()

        Dim retID As Integer
        retID = readerID("LateRetID")

        stringNum = String.Format("{0:00000}", retID)
        text = "NUM"

        resitNo = text + stringNum

        Try
            'selectedTitle = cmbTitle.SelectedItem.ToString()

            TextBox1.Text = ""
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)

            TextBox1.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
            TextBox1.AppendText(vbTab + vbTab + vbTab + vbTab & "READ O'BRITE MANAGEMENT SYSTEM" + vbNewLine)
            TextBox1.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText("" + vbNewLine)
            TextBox1.AppendText(vbTab + "RESIT NO: " + resitNo + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "DATE PAYMENT: " & lblDatePymnt.Text + vbNewLine)


            TextBox1.AppendText(vbTab + "NAME: " + vbTab & cmbName.SelectedItem.ToString().ToUpper() + vbTab + vbTab + vbNewLine + vbNewLine + vbNewLine)
            TextBox1.AppendText(vbTab + "BOOK TITLE: " + vbTab + vbTab & selectedTitle.ToUpper() + vbNewLine + vbNewLine)
            TextBox1.AppendText(vbTab + "AMOUNT FINES: " + vbTab & lblAmtFines.Text + vbNewLine + vbNewLine)
            TextBox1.AppendText(vbTab + "PAYMENT: " + vbTab + vbTab & lblPayment.Text + vbNewLine + vbNewLine)
            TextBox1.AppendText(vbTab + "BALANCE: " + vbTab + vbTab & lblBalance.Text + vbNewLine + vbNewLine)

            TextBox1.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)
            TextBox1.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + "      THANK YOU!" + vbNewLine)
            TextBox1.AppendText("----------------------------------------------------------------------------------------------------------------------------------------------------" + vbNewLine)

            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error occurred! " & ex.Message.ToString(), "Cannot Print: LMS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawString(TextBox1.Text, New Font("Arial", 12), Brushes.Black, New Point(0, 0))
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
        BookReturnInfoPage.Show()
    End Sub
End Class