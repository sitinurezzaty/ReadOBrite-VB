Public Class UserInfoPage

    'this OleDbDataAdapter serves as bridge to our connection and SQL statementts
    Dim da As New OleDb.OleDbDataAdapter
    Dim con As New OleDb.OleDbConnection
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub UserInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")
    End Sub

    ' User click button Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' SQL for display the details of the user based on their staff ID or staff username
        sql = "SELECT * FROM [User] where StaffID='" & txtSearchID.Text & "'" &
              " OR Username= '" & txtSearchUsername.Text & "'"
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table and store into new datagridview(dtgStaffResult)
            dtgStaffResult.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    ' User cick button List Staff
    Private Sub btnListStaff_Click(sender As Object, e As EventArgs) Handles btnListStaff.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            ' Open connection
            con.Open()
            ' To display all the user in our database
            sql = "Select * FROM [User]"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            ' bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da.Fill(dt)
            'get the datasource of datagridview from our data table and store into new datagridview(dtgStaffResult)
            dtgStaffResult.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    ' to display inside the label in the form
    ' the details of the staff will changed according to what user clicked in the datagridview(dtgStaffResult)
    Private Sub dtgStaffResult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgStaffResult.CellContentClick
        txtStaffID.Text = dtgStaffResult.CurrentRow.Cells(0).Value
        txtUsername.Text = dtgStaffResult.CurrentRow.Cells(3).Value
        txtStaffName.Text = dtgStaffResult.CurrentRow.Cells(1).Value
        txtPhoneNumber.Text = dtgStaffResult.CurrentRow.Cells(2).Value
    End Sub

    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            ' open connection
            con.Open()
            ' Put [] between name user because user name is default variable
            ' SQL for update the details of the staff inside our databse
            sql = "UPDATE [User] SET StaffName='" & txtStaffName.Text & "', HPNum='" & txtPhoneNumber.Text & "', " &
             " Username='" & txtUsername.Text & "' WHERE StaffID='" & txtStaffID.Text & "'"
            cmd.Connection = con
            cmd.CommandText = sql

            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Staff records has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnDeleteStaff_Click(sender As Object, e As EventArgs) Handles btnDeleteStaff.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            ' Open connection
            con.Open()
            ' SQL for delete the details of user based on their staffID
            sql = "Delete * from [User] WHERE StaffID='" & txtStaffID.Text & "'"
            cmd.Connection = con
            cmd.CommandText = sql

            ' Confirmation message
            Select Case MsgBox("Are you sure want to DELETE this record ?", MsgBoxStyle.YesNo, "Delete")
                ' If user click button YES in the message box, user data will be deleted
                Case MsgBoxResult.Yes
                    Dim i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Staff records has been deleted successfully!")

                    Else
                        MsgBox("No record has been deleted!")
                    End If
                Case MsgBoxResult.No
                    MsgBox("Check the record again!")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    ' User click button Return - return to the menu list page
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim menuForm As MenuListPage
        menuForm = New MenuListPage
        Me.Hide()
        menuForm.Show()
    End Sub

End Class