Public Class MenuListPage
    ' Function for display the username of current user
    Public Shared menuList

    ' User click menu Exit - Return to StartUp page
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        StartUpPage.Show()
    End Sub

    ' User click menu BookDetails - Redirect to BookDetails page
    Private Sub BookDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookDetailsToolStripMenuItem.Click
        Me.Hide()
        BookDetailsPage.Show()
    End Sub

    ' User click menu BookReturn - Redirect to BookReturn page
    Private Sub BookReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookReturnToolStripMenuItem.Click
        Me.Close()
        BookReturnInfoPage.Show()
    End Sub

    ' User click menu BookIssue - Redirect to BookIssue page
    Private Sub BookIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookIssuesToolStripMenuItem.Click
        Me.Close()
        BookIssueInfoPage.Show()
    End Sub

    ' User click menu LateReturn - Redirect to LateReturn page
    Private Sub LateReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LateReturnToolStripMenuItem.Click
        Me.Close()
        LateReturnInfoPage.Show()
    End Sub

    ' User click menu BorrowersInfo - Redirect to BorrowersInfo page
    Private Sub BorrowerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowerDetailsToolStripMenuItem.Click
        Me.Close()
        BorrowersInfoPage.Show()
    End Sub

    ' User click menu UserDetails - Redirect to UserDetails page
    Private Sub UserDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserDetailsToolStripMenuItem.Click
        Me.Close()
        UserInfoPage.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MenuListPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ' To display the username of current user that have login into our system
        lblUsername.Text = menuList
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' To display the current date and time in the form
        lblTimerDate.Text = Date.Now.ToString("dd MMM yyyy")
        lblTimerTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

End Class