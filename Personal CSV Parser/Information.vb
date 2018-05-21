Public Class Information
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = var.title
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)
    End Sub
End Class