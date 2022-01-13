Imports System.Data.Odbc
Public Class HalamanStatusPemohonan
    Sub tampildatalv()
        koneksi()
        cmd = New OdbcCommand("select * from tbl_formulir", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            lv.Items.Clear()
            While dr.Read
                Dim data As ListViewItem = lv.Items.Add(dr("idDaftar"))
                data.SubItems.Add(dr("tglDaftar"))
                data.SubItems.Add(dr("status"))
            End While
        Else
            lv.Items.Clear()
        End If
    End Sub
    
    Private Sub HalamanStatusPemohonan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildatalv()
    End Sub
End Class