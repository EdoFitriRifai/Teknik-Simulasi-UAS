<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanStatusPemohonan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idformuli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.durasimagang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 100)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.idformuli, Me.tanggal, Me.status, Me.durasimagang})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(776, 254)
        Me.DataGridView1.TabIndex = 1
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        '
        'idformuli
        '
        Me.idformuli.HeaderText = "ID Formulir"
        Me.idformuli.Name = "idformuli"
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'durasimagang
        '
        Me.durasimagang.HeaderText = "Durasi Magang"
        Me.durasimagang.Name = "durasimagang"
        '
        'HalamanStatusPemohonan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HalamanStatusPemohonan"
        Me.Text = "HalamanStatusPemohonan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idformuli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents durasimagang As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
