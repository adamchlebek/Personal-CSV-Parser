<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.hdDateCreated = New System.Windows.Forms.Label()
        Me.pnlFilePath = New System.Windows.Forms.Panel()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.hdRow = New System.Windows.Forms.Label()
        Me.ptnDateCreated = New System.Windows.Forms.Panel()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.pnlColumns = New System.Windows.Forms.Panel()
        Me.lblColumnCount = New System.Windows.Forms.Label()
        Me.hdCorrect = New System.Windows.Forms.Label()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.hdColumns = New System.Windows.Forms.Label()
        Me.pnlRows = New System.Windows.Forms.Panel()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.pnlFilePath.SuspendLayout()
        Me.ptnDateCreated.SuspendLayout()
        Me.pnlColumns.SuspendLayout()
        Me.pnlRows.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.btnNo)
        Me.Panel1.Controls.Add(Me.btnYes)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.hdDateCreated)
        Me.Panel1.Controls.Add(Me.pnlFilePath)
        Me.Panel1.Controls.Add(Me.hdRow)
        Me.Panel1.Controls.Add(Me.ptnDateCreated)
        Me.Panel1.Controls.Add(Me.pnlColumns)
        Me.Panel1.Controls.Add(Me.hdCorrect)
        Me.Panel1.Controls.Add(Me.pbLoading)
        Me.Panel1.Controls.Add(Me.hdColumns)
        Me.Panel1.Controls.Add(Me.pnlRows)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 441)
        Me.Panel1.TabIndex = 0
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(241, 299)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(161, 51)
        Me.btnNo.TabIndex = 24
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        Me.btnNo.Visible = False
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(25, 299)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(161, 51)
        Me.btnYes.TabIndex = 23
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        Me.btnYes.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(101, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(233, 31)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Title Of Document"
        Me.lblTitle.Visible = False
        '
        'hdDateCreated
        '
        Me.hdDateCreated.AutoSize = True
        Me.hdDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdDateCreated.Location = New System.Drawing.Point(145, 103)
        Me.hdDateCreated.Name = "hdDateCreated"
        Me.hdDateCreated.Size = New System.Drawing.Size(134, 25)
        Me.hdDateCreated.TabIndex = 15
        Me.hdDateCreated.Text = "Date Created:"
        Me.hdDateCreated.Visible = False
        '
        'pnlFilePath
        '
        Me.pnlFilePath.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFilePath.Controls.Add(Me.lblFilePath)
        Me.pnlFilePath.Location = New System.Drawing.Point(-2, 48)
        Me.pnlFilePath.Name = "pnlFilePath"
        Me.pnlFilePath.Size = New System.Drawing.Size(435, 36)
        Me.pnlFilePath.TabIndex = 14
        Me.pnlFilePath.Visible = False
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(183, 10)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(63, 17)
        Me.lblFilePath.TabIndex = 1
        Me.lblFilePath.Text = "File Path"
        '
        'hdRow
        '
        Me.hdRow.AutoSize = True
        Me.hdRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdRow.Location = New System.Drawing.Point(73, 187)
        Me.hdRow.Name = "hdRow"
        Me.hdRow.Size = New System.Drawing.Size(60, 25)
        Me.hdRow.TabIndex = 17
        Me.hdRow.Text = "Rows"
        Me.hdRow.Visible = False
        '
        'ptnDateCreated
        '
        Me.ptnDateCreated.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ptnDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptnDateCreated.Controls.Add(Me.lblDateCreated)
        Me.ptnDateCreated.Location = New System.Drawing.Point(-2, 131)
        Me.ptnDateCreated.Name = "ptnDateCreated"
        Me.ptnDateCreated.Size = New System.Drawing.Size(435, 36)
        Me.ptnDateCreated.TabIndex = 16
        Me.ptnDateCreated.Visible = False
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateCreated.Location = New System.Drawing.Point(149, 10)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(132, 17)
        Me.lblDateCreated.TabIndex = 1
        Me.lblDateCreated.Text = "0/00/0000 00:00PM"
        '
        'pnlColumns
        '
        Me.pnlColumns.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlColumns.Controls.Add(Me.lblColumnCount)
        Me.pnlColumns.Location = New System.Drawing.Point(241, 215)
        Me.pnlColumns.Name = "pnlColumns"
        Me.pnlColumns.Size = New System.Drawing.Size(161, 40)
        Me.pnlColumns.TabIndex = 18
        Me.pnlColumns.Visible = False
        '
        'lblColumnCount
        '
        Me.lblColumnCount.AutoSize = True
        Me.lblColumnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColumnCount.Location = New System.Drawing.Point(60, 11)
        Me.lblColumnCount.Name = "lblColumnCount"
        Me.lblColumnCount.Size = New System.Drawing.Size(16, 17)
        Me.lblColumnCount.TabIndex = 3
        Me.lblColumnCount.Text = "0"
        '
        'hdCorrect
        '
        Me.hdCorrect.AutoSize = True
        Me.hdCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdCorrect.Location = New System.Drawing.Point(102, 258)
        Me.hdCorrect.Name = "hdCorrect"
        Me.hdCorrect.Size = New System.Drawing.Size(237, 25)
        Me.hdCorrect.TabIndex = 22
        Me.hdCorrect.Text = "Is this information correct?"
        Me.hdCorrect.Visible = False
        '
        'pbLoading
        '
        Me.pbLoading.Location = New System.Drawing.Point(25, 201)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(377, 23)
        Me.pbLoading.TabIndex = 21
        '
        'hdColumns
        '
        Me.hdColumns.AutoSize = True
        Me.hdColumns.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdColumns.Location = New System.Drawing.Point(278, 187)
        Me.hdColumns.Name = "hdColumns"
        Me.hdColumns.Size = New System.Drawing.Size(90, 25)
        Me.hdColumns.TabIndex = 20
        Me.hdColumns.Text = "Columns"
        Me.hdColumns.Visible = False
        '
        'pnlRows
        '
        Me.pnlRows.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRows.Controls.Add(Me.lblRowCount)
        Me.pnlRows.Location = New System.Drawing.Point(25, 215)
        Me.pnlRows.Name = "pnlRows"
        Me.pnlRows.Size = New System.Drawing.Size(161, 40)
        Me.pnlRows.TabIndex = 19
        Me.pnlRows.Visible = False
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowCount.Location = New System.Drawing.Point(59, 11)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(16, 17)
        Me.lblRowCount.TabIndex = 2
        Me.lblRowCount.Text = "0"
        '
        'Timer1
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(159, 356)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 69)
        Me.ListBox1.TabIndex = 25
        '
        'Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 441)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(445, 480)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(445, 480)
        Me.Name = "Information"
        Me.Text = "Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlFilePath.ResumeLayout(False)
        Me.pnlFilePath.PerformLayout()
        Me.ptnDateCreated.ResumeLayout(False)
        Me.ptnDateCreated.PerformLayout()
        Me.pnlColumns.ResumeLayout(False)
        Me.pnlColumns.PerformLayout()
        Me.pnlRows.ResumeLayout(False)
        Me.pnlRows.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents hdDateCreated As Label
    Friend WithEvents pnlFilePath As Panel
    Friend WithEvents lblFilePath As Label
    Friend WithEvents hdRow As Label
    Friend WithEvents ptnDateCreated As Panel
    Friend WithEvents lblDateCreated As Label
    Friend WithEvents pnlColumns As Panel
    Friend WithEvents lblColumnCount As Label
    Friend WithEvents hdCorrect As Label
    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents hdColumns As Label
    Friend WithEvents pnlRows As Panel
    Friend WithEvents lblRowCount As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents ListBox1 As ListBox
End Class
