<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnFindFile = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.cbHeaders = New System.Windows.Forms.CheckBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDev = New System.Windows.Forms.Button()
        Me.hdColumnCount = New System.Windows.Forms.Label()
        Me.txtHeaderCount = New System.Windows.Forms.TextBox()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.lblSeperator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(122, 129)
        Me.txtTitle.MaxLength = 22
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(228, 26)
        Me.txtTitle.TabIndex = 2
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(210, 102)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(45, 24)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Title"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnFindFile
        '
        Me.btnFindFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindFile.Location = New System.Drawing.Point(146, 28)
        Me.btnFindFile.Name = "btnFindFile"
        Me.btnFindFile.Size = New System.Drawing.Size(177, 40)
        Me.btnFindFile.TabIndex = 1
        Me.btnFindFile.Text = "Find File"
        Me.btnFindFile.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(174, 329)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(118, 41)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(204, 71)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 13)
        Me.lblFileName.TabIndex = 6
        '
        'cbHeaders
        '
        Me.cbHeaders.AutoSize = True
        Me.cbHeaders.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHeaders.Location = New System.Drawing.Point(156, 295)
        Me.cbHeaders.Name = "cbHeaders"
        Me.cbHeaders.Size = New System.Drawing.Size(167, 28)
        Me.cbHeaders.TabIndex = 4
        Me.cbHeaders.Text = "Headers in File?"
        Me.cbHeaders.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(400, 28)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(61, 40)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.Visible = False
        '
        'btnDev
        '
        Me.btnDev.Location = New System.Drawing.Point(13, 13)
        Me.btnDev.Name = "btnDev"
        Me.btnDev.Size = New System.Drawing.Size(54, 39)
        Me.btnDev.TabIndex = 8
        Me.btnDev.Text = "Dev"
        Me.btnDev.UseVisualStyleBackColor = True
        '
        'hdColumnCount
        '
        Me.hdColumnCount.AutoSize = True
        Me.hdColumnCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdColumnCount.Location = New System.Drawing.Point(164, 234)
        Me.hdColumnCount.Name = "hdColumnCount"
        Me.hdColumnCount.Size = New System.Drawing.Size(128, 24)
        Me.hdColumnCount.TabIndex = 10
        Me.hdColumnCount.Text = "Header Count"
        '
        'txtHeaderCount
        '
        Me.txtHeaderCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeaderCount.Location = New System.Drawing.Point(202, 261)
        Me.txtHeaderCount.MaxLength = 3
        Me.txtHeaderCount.Name = "txtHeaderCount"
        Me.txtHeaderCount.Size = New System.Drawing.Size(53, 29)
        Me.txtHeaderCount.TabIndex = 9
        Me.txtHeaderCount.Text = "0"
        Me.txtHeaderCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSeparator
        '
        Me.txtSeparator.Enabled = False
        Me.txtSeparator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeparator.Location = New System.Drawing.Point(214, 198)
        Me.txtSeparator.MaxLength = 1
        Me.txtSeparator.Name = "txtSeparator"
        Me.txtSeparator.Size = New System.Drawing.Size(29, 29)
        Me.txtSeparator.TabIndex = 3
        Me.txtSeparator.Text = ","
        Me.txtSeparator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSeperator
        '
        Me.lblSeperator.AutoSize = True
        Me.lblSeperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeperator.Location = New System.Drawing.Point(144, 171)
        Me.lblSeperator.Name = "lblSeperator"
        Me.lblSeperator.Size = New System.Drawing.Size(177, 24)
        Me.lblSeperator.TabIndex = 4
        Me.lblSeperator.Text = "Separator Character"
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 381)
        Me.Controls.Add(Me.hdColumnCount)
        Me.Controls.Add(Me.txtHeaderCount)
        Me.Controls.Add(Me.btnDev)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cbHeaders)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSeperator)
        Me.Controls.Add(Me.txtSeparator)
        Me.Controls.Add(Me.btnFindFile)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(489, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(489, 420)
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnFindFile As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblFileName As Label
    Friend WithEvents cbHeaders As CheckBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnDev As Button
    Friend WithEvents hdColumnCount As Label
    Friend WithEvents txtHeaderCount As TextBox
    Friend WithEvents txtSeparator As TextBox
    Friend WithEvents lblSeperator As Label
End Class
