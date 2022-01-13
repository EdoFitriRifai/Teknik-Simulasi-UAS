Imports System.Data.Odbc

Module konek
    Public cmd As OdbcCommand
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public dt As DataTable
    Public ds As DataSet

    Public Sub koneksi()
        Dim str As String
        str = "Driver={MySQL ODBC 8.0 ANSI Driver};database=koneksi_appmagang3;server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
 
End Module
