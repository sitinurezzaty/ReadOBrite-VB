<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReturnPage
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPaymentStatus = New System.Windows.Forms.Label()
        Me.lblRetFines = New System.Windows.Forms.Label()
        Me.lblRetStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblPubName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPubYr = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBorrowerName = New System.Windows.Forms.TextBox()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.btnDisplayBook = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPayment)
        Me.GroupBox2.Controls.Add(Me.lblPaymentStatus)
        Me.GroupBox2.Controls.Add(Me.lblRetFines)
        Me.GroupBox2.Controls.Add(Me.lblRetStatus)
        Me.GroupBox2.Controls.Add(Me.lblDueDate)
        Me.GroupBox2.Controls.Add(Me.lblIssueDate)
        Me.GroupBox2.Controls.Add(Me.lblPubName)
        Me.GroupBox2.Controls.Add(Me.lblAuthor)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblPubYr)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lblISBN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(41, 229)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(463, 455)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BOOK DETAILS"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(14, 43)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(146, 16)
        Me.lblPayment.TabIndex = 29
        Me.lblPayment.Text = "PAYMENT STATUS"
        '
        'lblPaymentStatus
        '
        Me.lblPaymentStatus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPaymentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentStatus.Location = New System.Drawing.Point(196, 34)
        Me.lblPaymentStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPaymentStatus.Name = "lblPaymentStatus"
        Me.lblPaymentStatus.Size = New System.Drawing.Size(202, 30)
        Me.lblPaymentStatus.TabIndex = 30
        '
        'lblRetFines
        '
        Me.lblRetFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetFines.Location = New System.Drawing.Point(196, 401)
        Me.lblRetFines.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetFines.Name = "lblRetFines"
        Me.lblRetFines.Size = New System.Drawing.Size(202, 30)
        Me.lblRetFines.TabIndex = 26
        '
        'lblRetStatus
        '
        Me.lblRetStatus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetStatus.Location = New System.Drawing.Point(196, 361)
        Me.lblRetStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetStatus.Name = "lblRetStatus"
        Me.lblRetStatus.Size = New System.Drawing.Size(202, 30)
        Me.lblRetStatus.TabIndex = 25
        '
        'lblDueDate
        '
        Me.lblDueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(196, 322)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(202, 30)
        Me.lblDueDate.TabIndex = 24
        '
        'lblIssueDate
        '
        Me.lblIssueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.Location = New System.Drawing.Point(196, 282)
        Me.lblIssueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(202, 30)
        Me.lblIssueDate.TabIndex = 23
        '
        'lblPubName
        '
        Me.lblPubName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubName.Location = New System.Drawing.Point(196, 242)
        Me.lblPubName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPubName.Name = "lblPubName"
        Me.lblPubName.Size = New System.Drawing.Size(202, 30)
        Me.lblPubName.TabIndex = 22
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(196, 201)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(202, 30)
        Me.lblAuthor.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(196, 157)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 30)
        Me.lblTitle.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 402)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "LATE RETURN FINES"
        '
        'lblPubYr
        '
        Me.lblPubYr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubYr.Location = New System.Drawing.Point(196, 120)
        Me.lblPubYr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPubYr.Name = "lblPubYr"
        Me.lblPubYr.Size = New System.Drawing.Size(202, 30)
        Me.lblPubYr.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 362)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(179, 16)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "LATE RETURN STATUS"
        '
        'lblISBN
        '
        Me.lblISBN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(196, 76)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(202, 30)
        Me.lblISBN.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "AUTHOR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 323)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "DUE DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 120)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PUBLICATION YEAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 283)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "ISSUE DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 243)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PUBLISHER'S NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "TITLE"
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.MistyRose
        Me.btnReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(537, 229)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(158, 47)
        Me.btnReturnBook.TabIndex = 20
        Me.btnReturnBook.Text = "RETURN BOOK"
        Me.btnReturnBook.UseMnemonic = False
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.MistyRose
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(537, 306)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(158, 47)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseMnemonic = False
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "BORROWER'S NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "BOOK NAME:"
        '
        'txtBorrowerName
        '
        Me.txtBorrowerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerName.Location = New System.Drawing.Point(189, 37)
        Me.txtBorrowerName.Name = "txtBorrowerName"
        Me.txtBorrowerName.Size = New System.Drawing.Size(298, 22)
        Me.txtBorrowerName.TabIndex = 24
        '
        'txtBookName
        '
        Me.txtBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookName.Location = New System.Drawing.Point(189, 69)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(298, 22)
        Me.txtBookName.TabIndex = 25
        '
        'btnDisplayBook
        '
        Me.btnDisplayBook.BackColor = System.Drawing.Color.MistyRose
        Me.btnDisplayBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayBook.Location = New System.Drawing.Point(524, 39)
        Me.btnDisplayBook.Name = "btnDisplayBook"
        Me.btnDisplayBook.Size = New System.Drawing.Size(158, 52)
        Me.btnDisplayBook.TabIndex = 26
        Me.btnDisplayBook.Text = "DISPLAY BOOK"
        Me.btnDisplayBook.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "ISSUE DATE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(381, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "DUE DATE:"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIssueDate.Location = New System.Drawing.Point(129, 124)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpIssueDate.TabIndex = 29
        '
        'dtpDueDate
        '
        Me.dtpDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Location = New System.Drawing.Point(496, 124)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpDueDate.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDisplayBook)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBorrowerName)
        Me.GroupBox1.Controls.Add(Me.txtBookName)
        Me.GroupBox1.Controls.Add(Me.dtpIssueDate)
        Me.GroupBox1.Controls.Add(Me.dtpDueDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 170)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH BY:"
        '
        'BookReturnPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(800, 705)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookReturnPage"
        Me.Text = "BookReturnPage"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblRetFines As Label
    Friend WithEvents lblRetStatus As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblIssueDate As Label
    Friend WithEvents lblPubName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblPubYr As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReturnBook As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBorrowerName As TextBox
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents btnDisplayBook As Button
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblPaymentStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpIssueDate As DateTimePicker
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
End Class
