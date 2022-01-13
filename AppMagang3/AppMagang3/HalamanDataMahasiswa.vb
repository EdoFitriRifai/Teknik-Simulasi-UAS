Imports System.Data.Odbc
Public Class HalamanDataMahasiswa
    Sub tampildatalv()
        koneksi()
        cmd = New OdbcCommand("select * from tblmahasiswa", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            lv.Items.Clear()
            While dr.Read
                Dim data As ListViewItem = lv.Items.Add(dr("npm"))
                data.SubItems.Add(dr("namaMahasiswa"))
                data.SubItems.Add(dr("tempatLahir"))
                data.SubItems.Add(dr("tanggalLahir"))
                data.SubItems.Add(dr("fakultas"))
                data.SubItems.Add(dr("jurusan"))
                data.SubItems.Add(dr("tahunMasuk"))
            End While
        Else
            lv.Items.Clear()
        End If
    End Sub
    Private Sub HalamanDataMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampildatalv()
    End Sub
End Class