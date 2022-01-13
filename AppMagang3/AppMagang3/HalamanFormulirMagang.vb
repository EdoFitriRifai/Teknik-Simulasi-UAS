Imports System.Data.Odbc
Public Class HalamanFormulirMagang
    Dim tglMySQL As String

    Private Sub HalamanFormulirMagang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnKirim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKirim.Click
        If txtNpm.Text = "" Or txtNama.Text = "" Or txtSemester.Text = "" Or txtFakultas.Text = "" Or txtProdi.Text = "" Or txtNamaInstansi.Text = "" Or txtAlamatInstansi.Text = "" Or cmbDurasiMagang.SelectedIndex = -1 Then
            MsgBox("Tidak Boleh Kosong")
            'bersih()
        Else
            MsgBox("Ok")
            koneksi()
            tglMySQL = Format(Today, "yyyy-MM-dd")
            Dim simpan As String = "insert into tbl_formulir values ('" & "1" & "','" & tglMySQL & "','" & txtNamaInstansi.Text & "','" & cmbDurasiMagang.Text & "','" & txtAlamatInstansi.Text & "','" & txtNpm.Text & "','" & "Pending" & "')"
            cmd = New OdbcCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            'Call liatdata()
            'Call bersih()
        End If
    End Sub
End Class