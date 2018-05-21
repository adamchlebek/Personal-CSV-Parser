Public Class Form1
    Dim ofd As New OpenFileDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnFindFile.Left = (Me.ClientSize.Width / 2) - (btnFindFile.Width / 2)
        lblSeperator.Left = (Me.ClientSize.Width / 2) - (lblSeperator.Width / 2)
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)
        txtSeparator.Left = (Me.ClientSize.Width / 2) - (txtSeparator.Width / 2)
        txtTitle.Left = (Me.ClientSize.Width / 2) - (txtTitle.Width / 2)
        btnSubmit.Left = (Me.ClientSize.Width / 2) - (btnSubmit.Width / 2)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        var.title = txtTitle.Text
        var.separatorChar = txtSeparator.Text
    End Sub

    Private Sub btnFindFile_Click(sender As Object, e As EventArgs) Handles btnFindFile.Click
        ofd.ShowDialog()
        var.filePath = ofd.FileName
        If My.Computer.FileSystem.FileExists(var.filePath) Then
            btnFindFile.Text = "File Linked"
            btnFindFile.Enabled = False
            lblFileName.Text = var.filePath
            lblFileName.Left = (Me.ClientSize.Width / 2) - (lblFileName.Width / 2)
        End If
    End Sub
End Class
