<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status_Request
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NamaBarangMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBarangMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBarangMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaBarangMasuk, Me.JumlahBarangMasuk, Me.StatusBarangMasuk})
        Me.DataGridView1.Location = New System.Drawing.Point(122, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(349, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'NamaBarangMasuk
        '
        Me.NamaBarangMasuk.HeaderText = "Nama Barang Masuk"
        Me.NamaBarangMasuk.Name = "NamaBarangMasuk"
        '
        'JumlahBarangMasuk
        '
        Me.JumlahBarangMasuk.HeaderText = "Jumlah Barang Masuk"
        Me.JumlahBarangMasuk.Name = "JumlahBarangMasuk"
        '
        'StatusBarangMasuk
        '
        Me.StatusBarangMasuk.HeaderText = "Status Barang Masuk"
        Me.StatusBarangMasuk.Name = "StatusBarangMasuk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Status Barang Request"
        '
        'BtnKembali
        '
        Me.BtnKembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnKembali.Location = New System.Drawing.Point(350, 250)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(121, 34)
        Me.BtnKembali.TabIndex = 6
        Me.BtnKembali.Text = "Kembali Ke Gudang"
        Me.BtnKembali.UseVisualStyleBackColor = False
        '
        'Status_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(608, 318)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Status_Request"
        Me.Text = "Status_Request"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NamaBarangMasuk As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBarangMasuk As DataGridViewTextBoxColumn
    Friend WithEvents StatusBarangMasuk As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnKembali As Button
End Class
