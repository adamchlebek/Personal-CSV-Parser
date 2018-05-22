Public Class var
    Public Shared title As String = "Test"
    Public Shared separatorChar As String
    Public Shared filePath As String = "C:/Test"
    Public Shared generateHeaders As Boolean
    Public Shared removedBlank As Boolean = False

    Public Shared creationTime As DateTime
    Public Shared rowCount As Integer
    Public Shared columnCount As Integer

    Public Shared headers As List(Of String) = New List(Of String)()
    Public Shared headersReference As List(Of String) = New List(Of String)()
    Public Shared removedHeaders As List(Of String) = New List(Of String)()
    Public Shared removedHeadersIndex As List(Of Integer) = New List(Of Integer)()
End Class
