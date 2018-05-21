Public Class Welcome
    Dim ofd As New OpenFileDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnFindFile.Left = (Me.ClientSize.Width / 2) - (btnFindFile.Width / 2)
        lblSeperator.Left = (Me.ClientSize.Width / 2) - (lblSeperator.Width / 2)
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)
        txtSeparator.Left = (Me.ClientSize.Width / 2) - (txtSeparator.Width / 2)
        txtTitle.Left = (Me.ClientSize.Width / 2) - (txtTitle.Width / 2)
        btnSubmit.Left = (Me.ClientSize.Width / 2) - (btnSubmit.Width / 2)
        cbHeaders.Left = (Me.ClientSize.Width / 2) - (cbHeaders.Width / 2)

        btnFindFile.FlatStyle = FlatStyle.Flat
        btnFindFile.ForeColor = System.Drawing.Color.Black
        btnFindFile.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnFindFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.ForeColor = System.Drawing.Color.Black
        btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnView.FlatStyle = FlatStyle.Flat
        btnView.ForeColor = System.Drawing.Color.Black
        btnView.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim title As Boolean = True
        Dim file As Boolean = True

        If txtTitle.Text = "" Or txtTitle.Text = " " Then
            MessageBox.Show("Please enter a title for your document.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            title = False
        End If

        If var.filePath = " " Or var.filePath = Nothing Then
            MessageBox.Show("Please select a file to link.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            file = False
        End If

        If title And file Then
            var.title = txtTitle.Text
            var.separatorChar = txtSeparator.Text

            Me.Hide()
            Information.Show()
        End If
    End Sub

    Private Sub btnFindFile_Click(sender As Object, e As EventArgs) Handles btnFindFile.Click
        ofd.ShowDialog()
        var.filePath = ofd.FileName
        If My.Computer.FileSystem.FileExists(var.filePath) Then
            btnFindFile.Text = "File Linked"
            btnFindFile.Enabled = False
            lblFileName.Text = var.filePath
            lblFileName.Left = (Me.ClientSize.Width / 2) - (lblFileName.Width / 2)
            btnView.Visible = True
        End If
    End Sub

    Private Sub cbHeaders_CheckedChanged(sender As Object, e As EventArgs) Handles cbHeaders.CheckedChanged
        Select Case MsgBox("Would you like the program to try to generate headers?", MsgBoxStyle.YesNo, "Generate Headers")
            Case MsgBoxResult.Yes
                var.generateHeaders = True
            Case MsgBoxResult.No
                var.generateHeaders = False
        End Select
    End Sub

    Private Sub btnDev_Click(sender As Object, e As EventArgs) Handles btnDev.Click
        Me.Hide()
        Information.Show()
    End Sub
End Class
