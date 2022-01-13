Public Class FormHome

    Private Sub FormHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnpm.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        HalamanMahsiswaBM.Show()
    End Sub

    Private Sub btnformulir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnformulir.Click
        HalamanFormulirMagang.Show()
    End Sub
End Class