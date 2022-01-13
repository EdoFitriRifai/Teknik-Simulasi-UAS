Public Class FormHome
    Sub bersih()
        lbljabatan.Text = ""
        lblnama.Text = ""
        lblnpm.Text = ""
        lbltitle.Text = ""
    End Sub
    Sub awal()
        panelberkasmasuk.Visible = False
        paneldatamahasiswa.Visible = False
        paneldatamahasiswaadmin.Visible = False
        panelinputberkas.Visible = False
        panelstatus.Visible = False
    End Sub
    Sub admin()
        panelberkasmasuk.Visible = True
        paneldatamahasiswaadmin.Visible = True
        panelinputberkas.Visible = True
        panelstatus.Visible = True
    End Sub
    Sub dosen()
        panelberkasmasuk.Visible = True
        paneldatamahasiswa.Visible = True
        panelstatus.Visible = True
    End Sub
    Sub mahasiswa()
        panelberkasmasuk.Visible = True
        panelstatus.Visible = True
    End Sub
    Private Sub FormHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        awal()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub btnformulir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbltitle.Text = btnformulir.Text
        Me.panelUtama.Controls.Clear()
        HalamanFormulirMagang.TopLevel = False
        HalamanFormulirMagang.AutoSize = False
        HalamanFormulirMagang.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanFormulirMagang.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanFormulirMagang)
        HalamanFormulirMagang.Show()
    End Sub

    Private Sub btnstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbltitle.Text = btnstatus.Text
        Me.panelUtama.Controls.Clear()
        HalamanStatusPemohonan.TopLevel = False
        HalamanStatusPemohonan.AutoSize = False
        HalamanStatusPemohonan.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanStatusPemohonan.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanStatusPemohonan)
        HalamanStatusPemohonan.Show()
    End Sub

    Private Sub btnberkasmasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbltitle.Text = btnberkasmasuk.Text
        Me.panelUtama.Controls.Clear()
        HalamanBerkasMasuk.TopLevel = False
        HalamanBerkasMasuk.AutoSize = False
        HalamanBerkasMasuk.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanBerkasMasuk.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanBerkasMasuk)
        HalamanBerkasMasuk.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbltitle.Text = btndatamahasiswa.Text
        Me.panelUtama.Controls.Clear()
        HalamanDataMahasiswa.TopLevel = False
        HalamanDataMahasiswa.AutoSize = False
        HalamanDataMahasiswa.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanDataMahasiswa.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanDataMahasiswa)
        HalamanDataMahasiswa.Show()
    End Sub

    Private Sub btndatamahasiswaadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbltitle.Text = btndatamahasiswaadmin.Text
        Me.panelUtama.Controls.Clear()
        HalamanDataMahasiswaAdmin.TopLevel = False
        HalamanDataMahasiswaAdmin.AutoSize = False
        HalamanDataMahasiswaAdmin.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanDataMahasiswaAdmin.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanDataMahasiswaAdmin)
        HalamanDataMahasiswaAdmin.Show()
    End Sub

    Private Sub btndashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndashboard.Click
        lbltitle.Text = btndashboard.Text
        Me.panelUtama.Controls.Clear()
        HalamanDashboard.TopLevel = False
        HalamanDashboard.AutoSize = False
        HalamanDashboard.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        HalamanDashboard.Dock = DockStyle.None
        Me.panelUtama.Controls.Add(HalamanDashboard)
        HalamanDashboard.Show()
    End Sub
End Class