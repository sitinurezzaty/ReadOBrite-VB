<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookDetailsPage
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
        Me.txtAddPublisher = New System.Windows.Forms.TextBox()
        Me.txtAddAuthor = New System.Windows.Forms.TextBox()
        Me.txtAddTitle = New System.Windows.Forms.TextBox()
        Me.txtAddYear = New System.Windows.Forms.TextBox()
        Me.txtAddISBN = New System.Windows.Forms.TextBox()
        Me.txtQuickSearch = New System.Windows.Forms.TextBox()
        Me.lblQuickSearch = New System.Windows.Forms.Label()
        Me.btnTextBoxFilter = New System.Windows.Forms.Button()
        Me.btnQuickSearch = New System.Windows.Forms.Button()
        Me.txtBookAuthor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBookTittle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtBookISBN = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtAddCategory = New System.Windows.Forms.TextBox()
        Me.btnBDetailsReturn = New System.Windows.Forms.Button()
        Me.btnBDetailsDelete = New System.Windows.Forms.Button()
        Me.btnBDetailsUpdate = New System.Windows.Forms.Button()
        Me.btnBDetailsAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtgResult = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBDetailsList = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAddPublisher
        '
        Me.txtAddPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddPublisher.Location = New System.Drawing.Point(203, 155)
        Me.txtAddPublisher.Name = "txtAddPublisher"
        Me.txtAddPublisher.Size = New System.Drawing.Size(199, 22)
        Me.txtAddPublisher.TabIndex = 10
        '
        'txtAddAuthor
        '
        Me.txtAddAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddAuthor.Location = New System.Drawing.Point(203, 123)
        Me.txtAddAuthor.Name = "txtAddAuthor"
        Me.txtAddAuthor.Size = New System.Drawing.Size(199, 22)
        Me.txtAddAuthor.TabIndex = 9
        '
        'txtAddTitle
        '
        Me.txtAddTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddTitle.Location = New System.Drawing.Point(203, 90)
        Me.txtAddTitle.Name = "txtAddTitle"
        Me.txtAddTitle.Size = New System.Drawing.Size(199, 22)
        Me.txtAddTitle.TabIndex = 8
        '
        'txtAddYear
        '
        Me.txtAddYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddYear.Location = New System.Drawing.Point(203, 58)
        Me.txtAddYear.Name = "txtAddYear"
        Me.txtAddYear.Size = New System.Drawing.Size(199, 22)
        Me.txtAddYear.TabIndex = 7
        '
        'txtAddISBN
        '
        Me.txtAddISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddISBN.Location = New System.Drawing.Point(203, 31)
        Me.txtAddISBN.Name = "txtAddISBN"
        Me.txtAddISBN.Size = New System.Drawing.Size(199, 22)
        Me.txtAddISBN.TabIndex = 6
        '
        'txtQuickSearch
        '
        Me.txtQuickSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuickSearch.Location = New System.Drawing.Point(151, 136)
        Me.txtQuickSearch.Name = "txtQuickSearch"
        Me.txtQuickSearch.Size = New System.Drawing.Size(252, 22)
        Me.txtQuickSearch.TabIndex = 10
        '
        'lblQuickSearch
        '
        Me.lblQuickSearch.AutoSize = True
        Me.lblQuickSearch.Location = New System.Drawing.Point(22, 139)
        Me.lblQuickSearch.Name = "lblQuickSearch"
        Me.lblQuickSearch.Size = New System.Drawing.Size(123, 16)
        Me.lblQuickSearch.TabIndex = 9
        Me.lblQuickSearch.Text = "QUICK SEARCH:"
        '
        'btnTextBoxFilter
        '
        Me.btnTextBoxFilter.BackColor = System.Drawing.Color.MistyRose
        Me.btnTextBoxFilter.Location = New System.Drawing.Point(469, 21)
        Me.btnTextBoxFilter.Name = "btnTextBoxFilter"
        Me.btnTextBoxFilter.Size = New System.Drawing.Size(201, 34)
        Me.btnTextBoxFilter.TabIndex = 8
        Me.btnTextBoxFilter.Text = "USE TEXT BOX SEARCH"
        Me.btnTextBoxFilter.UseVisualStyleBackColor = False
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.BackColor = System.Drawing.Color.MistyRose
        Me.btnQuickSearch.Location = New System.Drawing.Point(469, 61)
        Me.btnQuickSearch.Name = "btnQuickSearch"
        Me.btnQuickSearch.Size = New System.Drawing.Size(201, 34)
        Me.btnQuickSearch.TabIndex = 7
        Me.btnQuickSearch.Text = "USE QUICK SEARCH"
        Me.btnQuickSearch.UseVisualStyleBackColor = False
        '
        'txtBookAuthor
        '
        Me.txtBookAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookAuthor.Location = New System.Drawing.Point(151, 99)
        Me.txtBookAuthor.Name = "txtBookAuthor"
        Me.txtBookAuthor.Size = New System.Drawing.Size(252, 22)
        Me.txtBookAuthor.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "PUBLISHER:"
        '
        'txtBookTittle
        '
        Me.txtBookTittle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTittle.Location = New System.Drawing.Point(151, 65)
        Me.txtBookTittle.Name = "txtBookTittle"
        Me.txtBookTittle.Size = New System.Drawing.Size(252, 22)
        Me.txtBookTittle.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "AUTHOR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TITTLE:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.MistyRose
        Me.btnSearch.Location = New System.Drawing.Point(520, 128)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(101, 39)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtBookISBN
        '
        Me.txtBookISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookISBN.Location = New System.Drawing.Point(151, 36)
        Me.txtBookISBN.Name = "txtBookISBN"
        Me.txtBookISBN.Size = New System.Drawing.Size(252, 22)
        Me.txtBookISBN.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "CATEGORY OF BOOK:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "AUTHOR:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "BOOK TITLE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "YEAR PUBLICATION:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MistyRose
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(68, 354)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 36)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.txtAddCategory)
        Me.GroupBox3.Controls.Add(Me.txtAddPublisher)
        Me.GroupBox3.Controls.Add(Me.txtAddAuthor)
        Me.GroupBox3.Controls.Add(Me.btnBDetailsReturn)
        Me.GroupBox3.Controls.Add(Me.txtAddTitle)
        Me.GroupBox3.Controls.Add(Me.btnBDetailsDelete)
        Me.GroupBox3.Controls.Add(Me.txtAddYear)
        Me.GroupBox3.Controls.Add(Me.btnBDetailsUpdate)
        Me.GroupBox3.Controls.Add(Me.txtAddISBN)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.btnBDetailsAdd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(731, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 476)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BOOK DETAILS:"
        '
        'txtAddCategory
        '
        Me.txtAddCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddCategory.Location = New System.Drawing.Point(203, 189)
        Me.txtAddCategory.Name = "txtAddCategory"
        Me.txtAddCategory.Size = New System.Drawing.Size(199, 22)
        Me.txtAddCategory.TabIndex = 11
        '
        'btnBDetailsReturn
        '
        Me.btnBDetailsReturn.BackColor = System.Drawing.Color.MistyRose
        Me.btnBDetailsReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBDetailsReturn.Location = New System.Drawing.Point(310, 420)
        Me.btnBDetailsReturn.Name = "btnBDetailsReturn"
        Me.btnBDetailsReturn.Size = New System.Drawing.Size(92, 36)
        Me.btnBDetailsReturn.TabIndex = 24
        Me.btnBDetailsReturn.Text = "RETURN"
        Me.btnBDetailsReturn.UseVisualStyleBackColor = False
        '
        'btnBDetailsDelete
        '
        Me.btnBDetailsDelete.BackColor = System.Drawing.Color.MistyRose
        Me.btnBDetailsDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBDetailsDelete.Location = New System.Drawing.Point(258, 354)
        Me.btnBDetailsDelete.Name = "btnBDetailsDelete"
        Me.btnBDetailsDelete.Size = New System.Drawing.Size(110, 36)
        Me.btnBDetailsDelete.TabIndex = 23
        Me.btnBDetailsDelete.Text = "DELETE"
        Me.btnBDetailsDelete.UseVisualStyleBackColor = False
        '
        'btnBDetailsUpdate
        '
        Me.btnBDetailsUpdate.BackColor = System.Drawing.Color.MistyRose
        Me.btnBDetailsUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBDetailsUpdate.Location = New System.Drawing.Point(258, 298)
        Me.btnBDetailsUpdate.Name = "btnBDetailsUpdate"
        Me.btnBDetailsUpdate.Size = New System.Drawing.Size(110, 36)
        Me.btnBDetailsUpdate.TabIndex = 22
        Me.btnBDetailsUpdate.Text = "UPDATE"
        Me.btnBDetailsUpdate.UseVisualStyleBackColor = False
        '
        'btnBDetailsAdd
        '
        Me.btnBDetailsAdd.BackColor = System.Drawing.Color.MistyRose
        Me.btnBDetailsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBDetailsAdd.Location = New System.Drawing.Point(71, 298)
        Me.btnBDetailsAdd.Name = "btnBDetailsAdd"
        Me.btnBDetailsAdd.Size = New System.Drawing.Size(107, 36)
        Me.btnBDetailsAdd.TabIndex = 21
        Me.btnBDetailsAdd.Text = "ADD"
        Me.btnBDetailsAdd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ISBN:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtgResult)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(676, 237)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULT:"
        '
        'dtgResult
        '
        Me.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgResult.Location = New System.Drawing.Point(25, 21)
        Me.dtgResult.Name = "dtgResult"
        Me.dtgResult.Size = New System.Drawing.Size(628, 196)
        Me.dtgResult.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtQuickSearch)
        Me.GroupBox1.Controls.Add(Me.lblQuickSearch)
        Me.GroupBox1.Controls.Add(Me.btnTextBoxFilter)
        Me.GroupBox1.Controls.Add(Me.btnQuickSearch)
        Me.GroupBox1.Controls.Add(Me.txtBookAuthor)
        Me.GroupBox1.Controls.Add(Me.txtBookTittle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtBookISBN)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 181)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH BY:"
        '
        'btnBDetailsList
        '
        Me.btnBDetailsList.BackColor = System.Drawing.Color.MistyRose
        Me.btnBDetailsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDetailsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBDetailsList.Location = New System.Drawing.Point(544, 231)
        Me.btnBDetailsList.Name = "btnBDetailsList"
        Me.btnBDetailsList.Size = New System.Drawing.Size(158, 36)
        Me.btnBDetailsList.TabIndex = 25
        Me.btnBDetailsList.Text = "LIST BOOKS"
        Me.btnBDetailsList.UseVisualStyleBackColor = False
        '
        'BookDetailsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1210, 544)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBDetailsList)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "BookDetailsPage"
        Me.Text = "Book Details Page"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dtgResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAddPublisher As TextBox
    Friend WithEvents txtAddAuthor As TextBox
    Friend WithEvents txtAddTitle As TextBox
    Friend WithEvents txtAddYear As TextBox
    Friend WithEvents txtAddISBN As TextBox
    Friend WithEvents txtQuickSearch As TextBox
    Friend WithEvents lblQuickSearch As Label
    Friend WithEvents btnTextBoxFilter As Button
    Friend WithEvents btnQuickSearch As Button
    Friend WithEvents txtBookAuthor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBookTittle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtBookISBN As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtAddCategory As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtgResult As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBDetailsList As Button
    Friend WithEvents btnBDetailsReturn As Button
    Friend WithEvents btnBDetailsDelete As Button
    Friend WithEvents btnBDetailsUpdate As Button
    Friend WithEvents btnBDetailsAdd As Button
End Class
