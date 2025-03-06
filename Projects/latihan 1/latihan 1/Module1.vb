Imports System.Data.OleDb

Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Dim lokasiDB As String

    Public Sub koneksi()
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.13.0;data source="
    End Sub

End Module
