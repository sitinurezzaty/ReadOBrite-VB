Imports System.Data.OleDb
Public Class RegistrationPage
    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb;"
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' To check if the text box has no input, will display an error message
        If txtStaffName.Text = Nothing Or txtStaffID.Text = Nothing Or txtPhoneNumber.Text = Nothing Or txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Please fill in the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If conn.State = ConnectionState.Closed Then
            ' Open connection
            conn.Open()
        End If

        ' For check the data that has been insert by user
        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM [User] WHERE [Username] = @Username OR [Password] = @Password", conn)
            cmd.Parameters.AddWithValue("@StaffID", OleDbType.VarChar).Value = txtStaffID.Text.Trim
            cmd.Parameters.AddWithValue("@StaffName", OleDbType.VarChar).Value = txtStaffName.Text.Trim
            cmd.Parameters.AddWithValue("@HPNum", OleDbType.VarChar).Value = txtPhoneNumber.Text.Trim
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar)
            If count > 0 Then
                ' If user enter the same data that already have in dtaabase, it will display error message
                MessageBox.Show("Opps, this credentials has already been take!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        ' SQL for insert the new user in database
        Using create As New OleDbCommand("INSERT INTO [User]([StaffID],[StaffName],[HPNum],[Username],[Password])VALUES(@StaffID,@StaffName,@HPNum,@Username,@Password)", conn)
            create.Parameters.AddWithValue("@StaffID", OleDbType.VarChar).Value = txtStaffID.Text.Trim
            create.Parameters.AddWithValue("@StaffName", OleDbType.VarChar).Value = txtStaffName.Text.Trim
            create.Parameters.AddWithValue("@HPNum", OleDbType.VarChar).Value = txtPhoneNumber.Text.Trim
            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim

            If create.ExecuteNonQuery Then
                ' Information to user that the acccount has been successfully inserted into the database
                MessageBox.Show("Account has been registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear the textbox
                txtStaffID.Clear()
                txtStaffName.Clear()
                txtPhoneNumber.Clear()
                txtUsername.Clear()
                txtPassword.Clear()
            End If

            conn.Close()
        End Using
    End Sub

    Private Sub RegistrationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbSource
    End Sub

    ' User click button Return - return to StartUp page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim startUpForm As StartUpPage
        startUpForm = New StartUpPage
        Me.Hide()
        startUpForm.Show()
    End Sub

    ' User tick checkbox Show for password
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class