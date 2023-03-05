Public Class BookDetailsPage

    ' OleDbDataAdapter serves as a bridge between a DataSet and data source for retrieving and saving data
    Dim da As New OleDb.OleDbDataAdapter
    ' Open the connection
    Dim con As New OleDb.OleDbConnection
    ' dt: Temporary or imaginary tables in the memory of computer that have same value with our dataset
    Dim dt As New DataTable
    Dim sql As String

    Private Sub BookDetailsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Link our connection with our database in the source
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User10\source\repos\ReadOBrite-Public-Library-LMS\ReadOBrite_db.accdb")

        ' Disable the button, label and textbox for quick search
        lblQuickSearch.Visible = False
        btnTextBoxFilter.Enabled = False
        txtQuickSearch.Visible = False
    End Sub

    ' User click button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' SQL statement for SEARCH either using ISBN OR Book Title OR Book Author
        sql = "SELECT * FROM Book where ISBN='" & txtBookISBN.Text & "'" &
              " OR Title= '" & txtBookTittle.Text & "' OR Author='" & txtBookAuthor.Text & "'"
        Try
            ' Open the connection
            con.Open()
            ' Bind the SQL and the connection through OleDBDataAdapter and to stored the data
            da = New OleDb.OleDbDataAdapter(sql, con)
            ' Fill the data into our imaginary table
            da.Fill(dt)
            ' Get the datasource of datagridview from our data table and store to the new datagridview(dtgresult) in our form
            dtgResult.DataSource = dt

        Catch ex As Exception
            ' Throw an error exception if something went wrong
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        ' Close connection
        con.Close()
    End Sub

    ' User click button quick search
    Private Sub btnQuickSearch_Click(sender As Object, e As EventArgs) Handles btnQuickSearch.Click
        ' Enable the button, textbox for quick search function
        txtQuickSearch.Visible = True
        lblQuickSearch.Visible = True

        ' Disable the button, textbox for search function
        btnSearch.Enabled = False
        btnTextBoxFilter.Enabled = True
        txtBookTittle.Enabled = False
        txtBookAuthor.Enabled = False
        txtBookISBN.Enabled = False

        ' the color for text box search function will change color
        txtBookAuthor.BackColor = Color.LightSkyBlue
        txtBookTittle.BackColor = Color.LightSkyBlue
        txtBookISBN.BackColor = Color.LightSkyBlue

        ' CLear/refresh the datagridview(dtgResult)
        dtgResult.DataSource = Nothing
        dtgResult.RefreshEdit()
    End Sub

    ' User click button Use Textbox Search
    Private Sub btnTextBoxFilter_Click(sender As Object, e As EventArgs) Handles btnTextBoxFilter.Click
        ' Disable the textbox, label and button for quick search
        txtQuickSearch.Visible = False
        lblQuickSearch.Visible = False
        btnTextBoxFilter.Enabled = False
        btnSearch.Enabled = True

        ' Enable the text box for search function
        txtBookTittle.Enabled = True
        txtBookAuthor.Enabled = True
        txtBookISBN.Enabled = True

        ' the color for text box search function will change color
        txtBookISBN.BackColor = Color.Yellow
        txtBookTittle.BackColor = Color.Yellow
        txtBookAuthor.BackColor = Color.Yellow

        ' CLear/refresh the datagridview(dtgResult)
        dtgResult.DataSource = Nothing
        dtgResult.RefreshEdit()
    End Sub

    ' User insert the input in quick search textbox
    Private Sub txtQuickSearch_TextChanged(sender As Object, e As EventArgs) Handles txtQuickSearch.TextChanged
        ' Filter the data according to what user insert
        ' SQL statements for QUICK SEARCH function
        sql = "SELECT * FROM Book WHERE ISBN like '%" & txtQuickSearch.Text & "%' or Author LIKE '%" & txtQuickSearch.Text & "%' or Title LIKE '%" & txtQuickSearch.Text & "%'"

        dt = New DataTable
        Try
            ' Open the connection
            con.Open()
            ' Bind the SQL and the connection through OleDBDataAdapter to stored the data
            da = New OleDb.OleDbDataAdapter(sql, con)
            ' Value of data will be fill into dt which is our imaginary data table
            da.Fill(dt)
            ' Get the datasource of datagridview from our data table and store into our datagridview(dtgresult) in form
            dtgResult.DataSource = dt

        Catch ex As Exception
            ' Throw an error exception if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        ' Close connection
        con.Close()
    End Sub

    ' User click button Return - Return to menu list page
    Private Sub btnBDetailsReturn_Click(sender As Object, e As EventArgs) Handles btnBDetailsReturn.Click
        Dim menuForm As MenuListPage
        menuForm = New MenuListPage
        Me.Hide()
        menuForm.Show()
    End Sub

    ' User click button List Book
    Private Sub btnBDetailsList_Click(sender As Object, e As EventArgs) Handles btnBDetailsList.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter

            ' Open the connection
            con.Open()

            ' SQL to display all the book from our database
            sql = "SELECT * from Book"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            dtgResult.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    ' Insert each data into the label in the form based on the datagridview
    ' It changed according to what user click inside the datagridview(dtgResult)
    Private Sub dtgResult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgResult.CellContentClick
        txtAddISBN.Text = dtgResult.CurrentRow.Cells(0).Value
        txtAddYear.Text = dtgResult.CurrentRow.Cells(1).Value
        txtAddTitle.Text = dtgResult.CurrentRow.Cells(2).Value
        txtAddAuthor.Text = dtgResult.CurrentRow.Cells(3).Value
        txtAddPublisher.Text = dtgResult.CurrentRow.Cells(4).Value
        txtAddCategory.Text = dtgResult.CurrentRow.Cells(5).Value
    End Sub

    ' User click button Update
    Private Sub btnBDetailsUpdate_Click(sender As Object, e As EventArgs) Handles btnBDetailsUpdate.Click
        Try
            Dim sql As String
            ' Open the command to retrieve value in database
            Dim cmd As New OleDb.OleDbCommand
            ' Open connection
            con.Open()

            ' SQL for Update the details of the book: YearPublish|Title|Author|Publisher|Category and store back into the database
            sql = "UPDATE Book SET YearPublish='" & txtAddYear.Text & "', Title='" & txtAddTitle.Text & "', " &
             " Author='" & txtAddAuthor.Text & "', PublisherName='" & txtAddPublisher.Text & "', Category='" & txtAddCategory.Text & "' WHERE ISBN='" & txtAddISBN.Text & "'"
            cmd.Connection = con
            cmd.CommandText = sql

            ' To check either the query has run successfully
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Book records has been UPDATED successfully!")

            Else
                MsgBox("No record has been UPDATED!")
            End If

        Catch ex As Exception
            ' Display error message
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    ' User click button Add
    Private Sub btnBDetailsAdd_Click(sender As Object, e As EventArgs) Handles btnBDetailsAdd.Click
        'Clear all the input in the label if button Add was clicked
        txtAddISBN.Text = ""
        txtAddYear.Text = ""
        txtAddPublisher.Text = ""
        txtAddAuthor.Text = ""
        txtAddCategory.Text = ""
        txtAddTitle.Text = ""
    End Sub

    ' User click button save 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            ' Open connection
            con.Open()
            ' SQL to save the new data of the book inside the database 
            sql = "INSERT INTO Book (ISBN,YearPublish,Title,Author,PublisherName,Category) values ('" & txtAddISBN.Text & "', '" & txtAddYear.Text & "', '" & txtAddTitle.Text & "', '" & txtAddAuthor.Text & "', '" & txtAddPublisher.Text & "', '" & txtAddCategory.Text & "');"
            cmd.Connection = con
            cmd.CommandText = sql

            ' Check if the query had run successfully
            Dim i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New book has been added successfully!")
            Else
                MsgBox("Error in inserted new book!")
            End If

        Catch ex As Exception
            ' Display error message
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    ' User click button Delete
    Private Sub btnBDetailsDelete_Click(sender As Object, e As EventArgs) Handles btnBDetailsDelete.Click
        Try
            Dim sql As String
            Dim cmd As New OleDb.OleDbCommand
            ' Open connection
            con.Open()
            'SQL for delete Book based on their ISBN number
            sql = "DELETE * from Book WHERE ISBN='" & txtAddISBN.Text & "'"
            cmd.Connection = con
            cmd.CommandText = sql

            ' Ask the user for confirmation message if they really want to delete the data
            Select Case MsgBox("Are you sure want to DELETE this record ?", MsgBoxStyle.YesNo, "Delete")
                ' If user click button YES in the message box, the data will be deleted from our database
                Case MsgBoxResult.Yes
                    Dim i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Book records has been deleted successfully!")

                    Else
                        MsgBox("No record has been deleted!")
                    End If
                Case MsgBoxResult.No
                    MsgBox("Check the record again!")
            End Select

        Catch ex As Exception
            ' Display error message
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

End Class