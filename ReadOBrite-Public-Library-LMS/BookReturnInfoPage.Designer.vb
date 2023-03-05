<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookReturnInfoPage
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
        Me.lblRetFines = New System.Windows.Forms.Label()
        Me.lblRetStatus = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblIssueDate = New System.Windows.Forms.Label()
        Me.lblPubName = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectItem = New System.Windows.Forms.Button()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.chkLBooks = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReturnBookLate = New System.Windows.Forms.Button()
        Me.btnFinesPayment = New System.Windows.Forms.Button()
        Me.btnReturnBook = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRetFines
        '
        Me.lblRetFines.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetFines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetFines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetFines.Location = New System.Drawing.Point(196, 335)
        Me.lblRetFines.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetFines.Name = "lblRetFines"
        Me.lblRetFines.Size = New System.Drawing.Size(202, 30)
        Me.lblRetFines.TabIndex = 26
        '
        'lblRetStatus
        '
        Me.lblRetStatus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblRetStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRetStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetStatus.Location = New System.Drawing.Point(196, 293)
        Me.lblRetStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetStatus.Name = "lblRetStatus"
        Me.lblRetStatus.Size = New System.Drawing.Size(202, 30)
        Me.lblRetStatus.TabIndex = 25
        '
        'lblDueDate
        '
        Me.lblDueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(196, 254)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(202, 30)
        Me.lblDueDate.TabIndex = 24
        '
        'lblIssueDate
        '
        Me.lblIssueDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIssueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIssueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIssueDate.Location = New System.Drawing.Point(196, 216)
        Me.lblIssueDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIssueDate.Name = "lblIssueDate"
        Me.lblIssueDate.Size = New System.Drawing.Size(202, 30)
        Me.lblIssueDate.TabIndex = 23
        '
        'lblPubName
        '
        Me.lblPubName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubName.Location = New System.Drawing.Point(196, 178)
        Me.lblPubName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPubName.Name = "lblPubName"
        Me.lblPubName.Size = New System.Drawing.Size(202, 30)
        Me.lblPubName.TabIndex = 22
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(196, 139)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(202, 30)
        Me.lblAuthor.TabIndex = 21
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(196, 100)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(202, 30)
        Me.lblTitle.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 340)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "LATE RETURN FINES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelectItem)
        Me.GroupBox1.Controls.Add(Me.lblIC)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.chkLBooks)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(860, 455)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOK RETURN INFORMATION"
        '
        'btnSelectItem
        '
        Me.btnSelectItem.BackColor = System.Drawing.Color.MistyRose
        Me.btnSelectItem.Location = New System.Drawing.Point(233, 373)
        Me.btnSelectItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(158, 53)
        Me.btnSelectItem.TabIndex = 18
        Me.btnSelectItem.Text = "SELECT BOOK"
        Me.btnSelectItem.UseVisualStyleBackColor = False
        '
        'lblIC
        '
        Me.lblIC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIC.Location = New System.Drawing.Point(186, 71)
        Me.lblIC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(202, 33)
        Me.lblIC.TabIndex = 17
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(186, 33)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(202, 33)
        Me.lblName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "IC NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "BORROWER'S NAME"
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Location = New System.Drawing.Point(411, 33)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(424, 393)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BOOK DETAILS"
        '
        'lblPubYr
        '
        Me.lblPubYr.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPubYr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPubYr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPubYr.Location = New System.Drawing.Point(196, 61)
        Me.lblPubYr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPubYr.Name = "lblPubYr"
        Me.lblPubYr.Size = New System.Drawing.Size(202, 30)
        Me.lblPubYr.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 297)
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
        Me.lblISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.Location = New System.Drawing.Point(196, 23)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(202, 30)
        Me.lblISBN.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "AUTHOR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 258)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "DUE DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ISBN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 65)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "PUBLICATION YEAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 220)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "ISSUE DATE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 182)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PUBLISHER'S NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 104)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "TITLE"
        '
        'chkLBooks
        '
        Me.chkLBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLBooks.FormattingEnabled = True
        Me.chkLBooks.Location = New System.Drawing.Point(183, 235)
        Me.chkLBooks.Margin = New System.Windows.Forms.Padding(2)
        Me.chkLBooks.Name = "chkLBooks"
        Me.chkLBooks.Size = New System.Drawing.Size(205, 61)
        Me.chkLBooks.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LIST OF BOOKS BORROW:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSearch)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.lblSearchBy)
        Me.GroupBox3.Controls.Add(Me.cmbSearch)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(860, 81)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MistyRose
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(584, 24)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 46)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(383, 36)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(158, 22)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearchBy
        '
        Me.lblSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.Location = New System.Drawing.Point(266, 40)
        Me.lblSearchBy.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(139, 20)
        Me.lblSearchBy.TabIndex = 11
        Me.lblSearchBy.Text = "SEARCH BY"
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(112, 37)
        Me.cmbSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(119, 24)
        Me.cmbSearch.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 40)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "SEARCH BY"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MistyRose
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(681, 611)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 47)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "RETURN"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnReturnBookLate
        '
        Me.btnReturnBookLate.BackColor = System.Drawing.Color.MistyRose
        Me.btnReturnBookLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBookLate.Location = New System.Drawing.Point(23, 611)
        Me.btnReturnBookLate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBookLate.Name = "btnReturnBookLate"
        Me.btnReturnBookLate.Size = New System.Drawing.Size(142, 47)
        Me.btnReturnBookLate.TabIndex = 33
        Me.btnReturnBookLate.Text = "RETURN BOOK"
        Me.btnReturnBookLate.UseVisualStyleBackColor = False
        '
        'btnFinesPayment
        '
        Me.btnFinesPayment.BackColor = System.Drawing.Color.MistyRose
        Me.btnFinesPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinesPayment.Location = New System.Drawing.Point(504, 611)
        Me.btnFinesPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinesPayment.Name = "btnFinesPayment"
        Me.btnFinesPayment.Size = New System.Drawing.Size(158, 47)
        Me.btnFinesPayment.TabIndex = 19
        Me.btnFinesPayment.Text = "FINES PAYMENT"
        Me.btnFinesPayment.UseVisualStyleBackColor = False
        '
        'btnReturnBook
        '
        Me.btnReturnBook.BackColor = System.Drawing.Color.MistyRose
        Me.btnReturnBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnBook.Location = New System.Drawing.Point(169, 611)
        Me.btnReturnBook.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturnBook.Name = "btnReturnBook"
        Me.btnReturnBook.Size = New System.Drawing.Size(130, 47)
        Me.btnReturnBook.TabIndex = 36
        Me.btnReturnBook.Text = "RETURN BOOK"
        Me.btnReturnBook.UseVisualStyleBackColor = False
        '
        'BookReturnInfoPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(908, 684)
        Me.Controls.Add(Me.btnReturnBook)
        Me.Controls.Add(Me.btnFinesPayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReturnBookLate)
        Me.Name = "BookReturnInfoPage"
        Me.Text = "Book Return Info Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRetFines As Label
    Friend WithEvents lblRetStatus As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents lblIssueDate As Label
    Friend WithEvents lblPubName As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSelectItem As Button
    Friend WithEvents lblIC As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents chkLBooks As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearchBy As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReturnBookLate As Button
    Friend WithEvents btnFinesPayment As Button
    Friend WithEvents btnReturnBook As Button
End Class
