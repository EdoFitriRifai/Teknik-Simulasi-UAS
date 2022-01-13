<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanBerkasMasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnenter = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Status"
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(95, 20)
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(310, 20)
        Me.txtnpm.TabIndex = 3
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(95, 58)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(310, 20)
        Me.txtnama.TabIndex = 4
        '
        'cmbstatus
        '
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Location = New System.Drawing.Point(95, 98)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(310, 21)
        Me.cmbstatus.TabIndex = 5
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv.Location = New System.Drawing.Point(22, 142)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(671, 181)
        Me.lv.TabIndex = 6
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID DAFTAR"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tanggal Daftar"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Tempat Magang"
        Me.ColumnHeader3.Width = 130
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Alamat Tempat Magang"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "NPM"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Durasi Magang"
        Me.ColumnHeader6.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        '
        'btnenter
        '
        Me.btnenter.Location = New System.Drawing.Point(526, 34)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.Size = New System.Drawing.Size(88, 29)
        Me.btnenter.TabIndex = 7
        Me.btnenter.Text = "ENTER"
        Me.btnenter.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(526, 82)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(88, 29)
        Me.btnsimpan.TabIndex = 8
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'HalamanBerkasMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 362)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnenter)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HalamanBerkasMasuk"
        Me.Text = "HalamanBerkasMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnpm As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents btnenter As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
