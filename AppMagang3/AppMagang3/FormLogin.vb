Imports System.Data.Odbc
Public Class FormLogin

    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
        txtuser.Focus()

    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Call bersih()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub btnmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmasuk.Click
        Call koneksi()
        cmd = New OdbcCommand("select * from tbadmin where namaAdmin='" & txtuser.Text & "' and pwAdmin='" & txtpass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        FormHome.lblnpm.Text = dr("idAdmin")
        If dr.HasRows Then
            If dr("level") = "Admin" Then
                FormHome.lblnama.Text = dr("namaAdmin")
                FormHome.lbljabatan.Text = dr("level")
            ElseIf dr("level") = "Dosen" Then
                FormHome.lblnama.Text = dr("namaAdmin")
                FormHome.lbljabatan.Text = dr("level")
            ElseIf dr("level") = "Mahasiswa" Then
                FormHome.lblnama.Text = dr("namaAdmin")
                FormHome.lbljabatan.Text = dr("level")
            Else
                bersih()
            End If
            MessageBox.Show("Login Berhasil, Selamat datang " + dr("namaAdmin").ToString + "!")
            Me.Hide()
            FormHome.Show()
        Else
            MessageBox.Show("Login Gagal! Username atau Password anda salah")
            Call bersih()
        End If

    End Sub
End Class
