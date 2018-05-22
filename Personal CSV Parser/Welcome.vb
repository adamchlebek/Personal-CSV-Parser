Imports System.IO
Imports System.Text.RegularExpressions
Public Class Welcome
    Dim ofd As New OpenFileDialog
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        btnFindFile.Left = (Me.ClientSize.Width / 2) - (btnFindFile.Width / 2)
        lblSeperator.Left = (Me.ClientSize.Width / 2) - (lblSeperator.Width / 2)
        lblTitle.Left = (Me.ClientSize.Width / 2) - (lblTitle.Width / 2)
        txtSeparator.Left = (Me.ClientSize.Width / 2) - (txtSeparator.Width / 2)
        txtTitle.Left = (Me.ClientSize.Width / 2) - (txtTitle.Width / 2)
        btnSubmit.Left = (Me.ClientSize.Width / 2) - (btnSubmit.Width / 2)
        cbHeaders.Left = (Me.ClientSize.Width / 2) - (cbHeaders.Width / 2)
        hdColumnCount.Left = (Me.ClientSize.Width / 2) - (hdColumnCount.Width / 2)
        txtHeaderCount.Left = (Me.ClientSize.Width / 2) - (txtHeaderCount.Width / 2)

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
            var.rowCount = countRows()
            var.columnCount = txtHeaderCount.Text

            Me.Hide()
            Information.Show()
        End If

        If var.generateHeaders Then
            generateHeaders()
        End If
    End Sub

    Private Sub btnFindFile_Click(sender As Object, e As EventArgs) Handles btnFindFile.Click
        ofd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        ofd.ShowDialog()
        var.filePath = ofd.FileName
        If My.Computer.FileSystem.FileExists(var.filePath) Then
            btnFindFile.Text = "File Linked"
            btnFindFile.Enabled = False
            lblFileName.Text = var.filePath
            lblFileName.Left = (Me.ClientSize.Width / 2) - (lblFileName.Width / 2)
            btnView.Visible = True
            getSeparator()
            txtSeparator.Text = var.separatorChar
            txtSeparator.Enabled = True
            txtHeaderCount.Text = countColumns()
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
        var.filePath = "C:\Users\adam.chlebek\Documents\Address Book.csv"
        var.title = "Dev Test"
        var.separatorChar = "~"
        var.rowCount = countRows()
        var.columnCount = countColumns()
        generateHeaders()

        Me.Hide()
        Information.Show()
    End Sub

    Function countRows()
        Dim rowCount As Integer = 0
        Try
            rowCount = File.ReadAllLines(var.filePath).Length
        Catch ex As Exception
            MsgBox("File invalid.")
        End Try
        Return rowCount + 1
    End Function

    Function countColumns()
        Dim columnCount As Integer = 0
        Dim separator As Char = var.separatorChar
        Try
            Dim lines = File.ReadAllLines(var.filePath)
            columnCount = lines(0).Split(var.separatorChar).Count()
        Catch ex As Exception
            MsgBox("File invalid.")
        End Try

        Return columnCount
    End Function

    Public Sub generateHeaders()
        Using reader = New StreamReader(var.filePath)
            Dim line = reader.ReadLine()
            Dim values = line.Split(var.separatorChar)
            For i As Integer = 0 To var.columnCount
                Try
                    If values(i) = Nothing Then
                        values(i) = "$$$$$$"
                    End If

                    var.headers.Add(values(i))
                Catch ex As Exception

                End Try
            Next
        End Using
    End Sub

    Public Sub getSeparator()
        Dim separator As Char
        Try
            separator = InputBox("Please input the separator used for the CSV File. (Default is ,)")
            var.separatorChar = separator
        Catch
            MsgBox("Please input a single character.")
        End Try
    End Sub
End Class
