<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabel_Request
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
        Me.TabelReqBarang = New System.Windows.Forms.DataGridView()
        Me.NamaBarangReq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBarangReq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanBarangReq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        CType(Me.TabelReqBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabelReqBarang
        '
        Me.TabelReqBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabelReqBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelReqBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaBarangReq, Me.JumlahBarangReq, Me.SatuanBarangReq})
        Me.TabelReqBarang.Location = New System.Drawing.Point(151, 59)
        Me.TabelReqBarang.Name = "TabelReqBarang"
        Me.TabelReqBarang.Size = New System.Drawing.Size(364, 150)
        Me.TabelReqBarang.TabIndex = 0
        '
        'NamaBarangReq
        '
        Me.NamaBarangReq.HeaderText = "Nama Barang Req"
        Me.NamaBarangReq.Name = "NamaBarangReq"
        '
        'JumlahBarangReq
        '
        Me.JumlahBarangReq.HeaderText = "Jumlah Barang Req"
        Me.JumlahBarangReq.Name = "JumlahBarangReq"
        '
        'SatuanBarangReq
        '
        Me.SatuanBarangReq.HeaderText = "Satuan Barang Req"
        Me.SatuanBarangReq.Name = "SatuanBarangReq"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(373, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tabel Request Barang Gudang"
        '
        'BtnTutup
        '
        Me.BtnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnTutup.Location = New System.Drawing.Point(412, 215)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(103, 35)
        Me.BtnTutup.TabIndex = 6
        Me.BtnTutup.Text = "Status Request"
        Me.BtnTutup.UseVisualStyleBackColor = False
        '
        'Tabel_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(688, 274)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TabelReqBarang)
        Me.Name = "Tabel_Request"
        Me.Text = "Tabel_Request"
        CType(Me.TabelReqBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabelReqBarang As DataGridView
    Friend WithEvents NamaBarangReq As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBarangReq As DataGridViewTextBoxColumn
    Friend WithEvents SatuanBarangReq As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnTutup As Button
End Class
