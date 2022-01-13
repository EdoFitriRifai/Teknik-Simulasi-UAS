Imports System.Data.Odbc
Public Class HalamanBerkasMasuk
    Sub bersih()
        txtnama.Text = ""
        txtnpm.Text = ""
        cmbstatus.Text = ""
        cmbstatus.Items.Add("Diterima")
        cmbstatus.Items.Add("Ditolak")
        lv.Items.Clear()
        tampildatalv()
        txtnpm.Focus()
    End Sub
    Sub tampildatalv()
        koneksi()
        cmd = New OdbcCommand("select * from tbl_formulir", conn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            lv.Items.Clear()
            While dr.Read
                Dim data As ListViewItem = lv.Items.Add(dr("idDaftar"))
                data.SubItems.Add(dr("tglDaftar"))
                data.SubItems.Add(dr("namaTempatMagang"))
                data.SubItems.Add(dr("alamatTempatMagang"))
                data.SubItems.Add(dr("npm"))
                data.SubItems.Add(dr("durasiMagang"))
                data.SubItems.Add(dr("status"))
            End While
        Else
            lv.Items.Clear()
        End If
    End Sub
    Private Sub HalamanBerkasMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bersih()
    End Sub


    Private Sub btnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnenter.Click
        koneksi()
        cmd = New OdbcCommand("select * from tbl_formulir where npm='" & txtnpm.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("NPM Tidak Ada, Silakan Coba Lagi")
        Else
            cmbstatus.Text = dr.Item("status")
            tampildatalv()
        End If
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        koneksi()
        Dim edit As String = "update tbl_formulir set status='" & cmbstatus.Text & "' where npm='" & txtnpm.Text & "'"
        cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        tampildatalv()
    End Sub
End Class