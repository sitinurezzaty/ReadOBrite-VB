<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuListPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuListPage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookIssuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LateReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimerDate = New System.Windows.Forms.Label()
        Me.lblTimerTime = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(598, 222)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BorrowerToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookDetailsToolStripMenuItem, Me.BookIssuesToolStripMenuItem, Me.BookReturnToolStripMenuItem, Me.LateReturnToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BookDetailsToolStripMenuItem
        '
        Me.BookDetailsToolStripMenuItem.Name = "BookDetailsToolStripMenuItem"
        Me.BookDetailsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.BookDetailsToolStripMenuItem.Text = "Book Details"
        '
        'BookIssuesToolStripMenuItem
        '
        Me.BookIssuesToolStripMenuItem.Name = "BookIssuesToolStripMenuItem"
        Me.BookIssuesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.BookIssuesToolStripMenuItem.Text = "Book Issues"
        '
        'BookReturnToolStripMenuItem
        '
        Me.BookReturnToolStripMenuItem.Name = "BookReturnToolStripMenuItem"
        Me.BookReturnToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.BookReturnToolStripMenuItem.Text = "Book Return"
        '
        'LateReturnToolStripMenuItem
        '
        Me.LateReturnToolStripMenuItem.Name = "LateReturnToolStripMenuItem"
        Me.LateReturnToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.LateReturnToolStripMenuItem.Text = "Late Return "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BorrowerToolStripMenuItem
        '
        Me.BorrowerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerDetailsToolStripMenuItem})
        Me.BorrowerToolStripMenuItem.Name = "BorrowerToolStripMenuItem"
        Me.BorrowerToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.BorrowerToolStripMenuItem.Text = "Borrower"
        '
        'BorrowerDetailsToolStripMenuItem
        '
        Me.BorrowerDetailsToolStripMenuItem.Name = "BorrowerDetailsToolStripMenuItem"
        Me.BorrowerDetailsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BorrowerDetailsToolStripMenuItem.Text = "Borrower Details"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.UserToolStripMenuItem.Text = "User "
        '
        'UserDetailsToolStripMenuItem
        '
        Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
        Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UserDetailsToolStripMenuItem.Text = "User Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "WELCOME TO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LIBRARY MANAGEMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(243, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SYSTEM"
        '
        'Timer1
        '
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(20, 269)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 16)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "DATE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TIME:"
        '
        'lblTimerDate
        '
        Me.lblTimerDate.BackColor = System.Drawing.Color.Transparent
        Me.lblTimerDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimerDate.Location = New System.Drawing.Point(97, 267)
        Me.lblTimerDate.Name = "lblTimerDate"
        Me.lblTimerDate.Size = New System.Drawing.Size(116, 23)
        Me.lblTimerDate.TabIndex = 9
        '
        'lblTimerTime
        '
        Me.lblTimerTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimerTime.Location = New System.Drawing.Point(97, 302)
        Me.lblTimerTime.Name = "lblTimerTime"
        Me.lblTimerTime.Size = New System.Drawing.Size(116, 23)
        Me.lblTimerTime.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox2.Location = New System.Drawing.Point(0, 245)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(598, 105)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(311, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "USERNAME:"
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(427, 292)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(157, 33)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuListPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 341)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTimerTime)
        Me.Controls.Add(Me.lblTimerDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "MenuListPage"
        Me.Text = "Menu List Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookIssuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LateReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowerDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTimerDate As Label
    Friend WithEvents lblTimerTime As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUsername As Label
End Class
