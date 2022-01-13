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
        FormHome.bersih()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub btnmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmasuk.Click
        Call koneksi()
        cmd = New OdbcCommand("select * from tbl_user where namaUser='" & txtuser.Text & "' and pwUser='" & txtpass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        FormHome.lblnama.Text = dr("nama")
        FormHome.lbljabatan.Text = dr("jenisUser")
        If dr.HasRows Then
            If dr("jenisUser") = "admin" Then
                FormHome.admin()
            ElseIf dr("jenisUser") = "Dosen" Then
                FormHome.dosen()
            ElseIf dr("jenisUser") = "Mahasiswa" Then
                FormHome.mahasiswa()
            Else
                bersih()
            End If
            MessageBox.Show("Login Berhasil, Selamat datang " + dr("namaUser").ToString + "!")
            FormHome.lblnpm.Text = dr("idUser")
            Me.Hide()
            FormHome.Show()
        Else
            MessageBox.Show("Login Gagal! Username atau Password anda salah")
            Call bersih()
        End If

    End Sub
End Class
