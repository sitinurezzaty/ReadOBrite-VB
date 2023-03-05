<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim HPNumLabel As System.Windows.Forms.Label
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim StaffNameLabel As System.Windows.Forms.Label
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        HPNumLabel = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        StaffNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Lavender
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(46, 318)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(95, 16)
        PasswordLabel.TabIndex = 55
        PasswordLabel.Text = "PASSWORD"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Lavender
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(46, 252)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(93, 16)
        UsernameLabel.TabIndex = 53
        UsernameLabel.Text = "USERNAME"
        '
        'HPNumLabel
        '
        HPNumLabel.AutoSize = True
        HPNumLabel.BackColor = System.Drawing.Color.Lavender
        HPNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HPNumLabel.Location = New System.Drawing.Point(46, 207)
        HPNumLabel.Name = "HPNumLabel"
        HPNumLabel.Size = New System.Drawing.Size(130, 16)
        HPNumLabel.TabIndex = 51
        HPNumLabel.Text = "PHONE NUMBER"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.Lavender
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffIDLabel.Location = New System.Drawing.Point(46, 143)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(75, 16)
        StaffIDLabel.TabIndex = 49
        StaffIDLabel.Text = "STAFF ID"
        '
        'StaffNameLabel
        '
        StaffNameLabel.AutoSize = True
        StaffNameLabel.BackColor = System.Drawing.Color.Lavender
        StaffNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffNameLabel.Location = New System.Drawing.Point(46, 95)
        StaffNameLabel.Name = "StaffNameLabel"
        StaffNameLabel.Size = New System.Drawing.Size(103, 16)
        StaffNameLabel.TabIndex = 47
        StaffNameLabel.Text = "STAFF NAME"
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.BackColor = System.Drawing.Color.Lavender
        Me.chkShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPass.Location = New System.Drawing.Point(495, 319)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(64, 20)
        Me.chkShowPass.TabIndex = 60
        Me.chkShowPass.Text = "Show"
        Me.chkShowPass.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.MistyRose
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReturn.Location = New System.Drawing.Point(55, 456)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(430, 42)
        Me.btnReturn.TabIndex = 59
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.MistyRose
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegister.Location = New System.Drawing.Point(55, 406)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(430, 42)
        Me.btnRegister.TabIndex = 57
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(175, 249)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(304, 22)
        Me.txtUsername.TabIndex = 54
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(175, 204)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(304, 22)
        Me.txtPhoneNumber.TabIndex = 52
        '
        'txtStaffID
        '
        Me.txtStaffID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.Location = New System.Drawing.Point(175, 140)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(304, 22)
        Me.txtStaffID.TabIndex = 50
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffName.Location = New System.Drawing.Point(175, 92)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(304, 22)
        Me.txtStaffName.TabIndex = 48
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(175, 315)
        Me.txtPassword.MaxLength = 12
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(304, 22)
        Me.txtPassword.TabIndex = 56
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lavender
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "* exp: ROB200001"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lavender
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "* consist of number and letter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "* 8-12 lengths"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "* consist of number and letter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Font = New System.Drawing.Font("NSimSun", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(435, 37)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "LIBRARIAN REGISTRATION"
        '
        'RegistrationPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(605, 515)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkShowPass)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(HPNumLabel)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(StaffNameLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegistrationPage"
        Me.Text = "Registration Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
