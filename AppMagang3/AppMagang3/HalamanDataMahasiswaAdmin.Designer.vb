<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanDataMahasiswaAdmin
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
        Me.lv = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnpm = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttempatlahir = New System.Windows.Forms.TextBox()
        Me.txttahunmasuk = New System.Windows.Forms.TextBox()
        Me.Jurusan = New System.Windows.Forms.TextBox()
        Me.txtfakultas = New System.Windows.Forms.TextBox()
        Me.datelahir = New System.Windows.Forms.DateTimePicker()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv.GridLines = True
        Me.lv.Location = New System.Drawing.Point(12, 201)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(684, 150)
        Me.lv.TabIndex = 1
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NPM"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tempat Lahir"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tanggal Lahir"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fakultas"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Jurusan"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Tahun Masuk"
        Me.ColumnHeader7.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fakultas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jurusan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tahun Masuk"
        '
        'txtnpm
        '
        Me.txtnpm.Location = New System.Drawing.Point(132, 8)
        Me.txtnpm.Name = "txtnpm"
        Me.txtnpm.Size = New System.Drawing.Size(336, 20)
        Me.txtnpm.TabIndex = 9
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(132, 34)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(336, 20)
        Me.txtnama.TabIndex = 10
        '
        'txttempatlahir
        '
        Me.txttempatlahir.Location = New System.Drawing.Point(132, 60)
        Me.txttempatlahir.Name = "txttempatlahir"
        Me.txttempatlahir.Size = New System.Drawing.Size(336, 20)
        Me.txttempatlahir.TabIndex = 11
        '
        'txttahunmasuk
        '
        Me.txttahunmasuk.Location = New System.Drawing.Point(132, 164)
        Me.txttahunmasuk.Name = "txttahunmasuk"
        Me.txttahunmasuk.Size = New System.Drawing.Size(336, 20)
        Me.txttahunmasuk.TabIndex = 15
        Me.txttahunmasuk.Text = " "
        '
        'Jurusan
        '
        Me.Jurusan.Location = New System.Drawing.Point(132, 138)
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.Size = New System.Drawing.Size(336, 20)
        Me.Jurusan.TabIndex = 14
        '
        'txtfakultas
        '
        Me.txtfakultas.Location = New System.Drawing.Point(132, 112)
        Me.txtfakultas.Name = "txtfakultas"
        Me.txtfakultas.Size = New System.Drawing.Size(336, 20)
        Me.txtfakultas.TabIndex = 13
        '
        'datelahir
        '
        Me.datelahir.Location = New System.Drawing.Point(132, 85)
        Me.datelahir.Name = "datelahir"
        Me.datelahir.Size = New System.Drawing.Size(336, 20)
        Me.datelahir.TabIndex = 16
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(549, 11)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(93, 45)
        Me.btnsimpan.TabIndex = 17
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(549, 73)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(93, 45)
        Me.btnedit.TabIndex = 18
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelet
        '
        Me.btndelet.Location = New System.Drawing.Point(549, 138)
        Me.btndelet.Name = "btndelet"
        Me.btndelet.Size = New System.Drawing.Size(93, 45)
        Me.btndelet.TabIndex = 19
        Me.btndelet.Text = "DELETE"
        Me.btndelet.UseVisualStyleBackColor = True
        '
        'HalamanDataMahasiswaAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(711, 389)
        Me.Controls.Add(Me.btndelet)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.datelahir)
        Me.Controls.Add(Me.txttahunmasuk)
        Me.Controls.Add(Me.Jurusan)
        Me.Controls.Add(Me.txtfakultas)
        Me.Controls.Add(Me.txttempatlahir)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtnpm)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv)
        Me.Name = "HalamanDataMahasiswaAdmin"
        Me.Text = "HalamanDataMahasiswaAdmin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnpm As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttempatlahir As System.Windows.Forms.TextBox
    Friend WithEvents txttahunmasuk As System.Windows.Forms.TextBox
    Friend WithEvents Jurusan As System.Windows.Forms.TextBox
    Friend WithEvents txtfakultas As System.Windows.Forms.TextBox
    Friend WithEvents datelahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelet As System.Windows.Forms.Button
End Class
