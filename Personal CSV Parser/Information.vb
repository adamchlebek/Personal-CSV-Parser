Imports System
Imports System.IO
Imports System.Text
Public Class Information
    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Me.CenterToScreen()

    End Sub

    Function findFileCreation()
        var.creationTime = File.GetLastWriteTime(var.filePath)
        Return var.creationTime
    End Function


    Public Sub viewItems()
        lblTitle.Text = var.title
        lblFilePath.Text = var.filePath
        lblRowCount.Text = var.rowCount
        lblColumnCount.Text = var.columnCount
        lblDateCreated.Text = findFileCreation()

        hdDateCreated.Left = (Me.ClientSize.Width / 2) - (hdDateCreated.Width / 2) + 1
        hdCorrect.Left = (Me.ClientSize.Width / 2) - (hdCorrect.Width / 2)
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)
        lblFilePath.Left = (Me.ClientSize.Width / 2) - (lblFilePath.Width / 2)
        lblDateCreated.Left = (Me.ClientSize.Width / 2) - (lblDateCreated.Width / 2)
        hdHeaders.Left = (Me.ClientSize.Width / 2) - (hdHeaders.Width / 2)

        lblRowCount.Left = (Me.pnlRows.Width / 2) - (lblRowCount.Width / 2)
        lblColumnCount.Left = (Me.pnlColumns.Width / 2) - (lblColumnCount.Width / 2)

        btnYes.FlatStyle = FlatStyle.Flat
        btnYes.ForeColor = System.Drawing.Color.Black
        btnYes.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        btnNo.FlatStyle = FlatStyle.Flat
        btnNo.ForeColor = System.Drawing.Color.Black
        btnNo.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray

        lblTitle.Visible = True
        lblFilePath.Visible = True
        hdDateCreated.Visible = True
        hdColumns.Visible = True
        hdRow.Visible = True
        lblDateCreated.Visible = True
        lblRowCount.Visible = True
        lblColumnCount.Visible = True
        pnlColumns.Visible = True
        pnlFilePath.Visible = True
        pnlRows.Visible = True
        ptnDateCreated.Visible = True
        hdCorrect.Visible = True
        btnYes.Visible = True
        btnNo.Visible = True
        hdHeaders.Visible = True
        pnlHeaders.Visible = True
        lbHeaders.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim finished As Boolean = False

        If pbLoading.Value < 100 Then
            pbLoading.Value += 5
        End If

        If pbLoading.Value = 100 Then
            finished = True
        End If

        If finished Then
            pbLoading.Visible = False
            viewItems()
            addHeaders()
            Timer1.Enabled = False
        End If

    End Sub

    Public Sub addHeaders()
        For i As Integer = 1 To var.headers.Count()
            Try
                lbHeaders.Items.Add(var.headers.Item(i - 1))
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

    End Sub

    Private Sub lbHeaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbHeaders.SelectedIndexChanged
        btnRemove.Visible = True
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        var.headers.Remove(lbHeaders.SelectedItem)
        var.removedHeaders.Add(lbHeaders.SelectedItem)
        indexReference()

        Try
            ListBox1.Items.Add(lbHeaders.SelectedItem)
            lbHeaders.Items.Remove(lbHeaders.SelectedItem)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateList()
        If var.removedBlank = False Then
            For i As Integer = 1 To var.headersReference.Count()
                If var.headersReference.Item(i - 1) = "" Then
                    var.removedHeadersIndex.Add(i - 1)
                End If
                var.headers.Remove(var.removedHeadersIndex.Item(i - 1))
            Next
        End If

        var.removedBlank = True

        If var.removedBlank Then
            For i As Integer = 1 To var.headers.Count()
                ListBox2.Items.Add(var.headers.Item(i - 1))
            Next
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnRemoveBlank.Click
        UpdateList()
    End Sub

    Public Sub indexReference()
        For Each head As String In var.removedHeaders
            For i As Integer = 1 To var.headersReference.Count
                If head.Equals(var.headersReference.Item(i - 1)) Then
                    var.removedHeadersIndex.Add(i)
                End If
            Next
        Next
    End Sub
End Class