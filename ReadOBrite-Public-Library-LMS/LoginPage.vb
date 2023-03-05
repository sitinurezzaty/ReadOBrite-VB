' Import the function to open connection
Imports System.Data.OleDb
Public Class LoginPage

    Dim conn As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim dbSource As String = "Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb;"

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = dbProvider & dbSource
    End Sub

    ' User click button Submit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Check if the username and the password have value, if not display error message
        If txtLoginUsername.Text = Nothing Or txtLoginPassword.Text = Nothing Then
            MessageBox.Show("Please enter your correct credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If conn.State = ConnectionState.Closed Then
            ' Open connection
            conn.Open()
        End If

        ' To check for user password and username 
        Using login As New OleDbCommand("SELECT COUNT(*) FROM [User] where [Username] = @Username AND [Password] = @Password", conn)
            login.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtLoginUsername.Text.Trim
            login.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtLoginPassword.Text.Trim

            Dim loginCount = Convert.ToInt32(login.ExecuteScalar())
            ' If the sql successful then it will go to menu page
            If loginCount > 0 Then
                Me.Hide()
                Dim menuList As New MenuListPage
                ' To send the value username of current user to menuListPage
                MenuListPage.menuList = txtLoginUsername.Text
                MenuListPage.Show()
            Else
                MessageBox.Show("Opps, Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Clear the textbox for username and password if user enter wrong input
                txtLoginUsername.Clear()
                txtLoginPassword.Clear()
            End If
        End Using
        conn.Close()
    End Sub

    ' User click button Return to return to StartUp Page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim startUpForm As StartUpPage
        startUpForm = New StartUpPage
        Me.Hide()
        startUpForm.Show()
    End Sub

    ' User tick button Show at password
    Private Sub chckShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckShowPass.CheckedChanged
        ' To show password if the user check the chcekbox
        If chckShowPass.Checked = True Then
            txtLoginPassword.UseSystemPasswordChar = False
        Else
            txtLoginPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class