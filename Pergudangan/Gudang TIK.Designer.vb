<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gudang_TIK
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
        Me.TabelGudangBarang = New System.Windows.Forms.DataGridView()
        Me.BtnReq = New System.Windows.Forms.Button()
        Me.BtnJual = New System.Windows.Forms.Button()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Btn = New System.Windows.Forms.Button()
        CType(Me.TabelGudangBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Data Barang Gudang TIK"
        '
        'TabelGudangBarang
        '
        Me.TabelGudangBarang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabelGudangBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabelGudangBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaBarang, Me.JumlahBarang, Me.SatuanBarang, Me.KodeBarang})
        Me.TabelGudangBarang.GridColor = System.Drawing.SystemColors.Highlight
        Me.TabelGudangBarang.Location = New System.Drawing.Point(148, 69)
        Me.TabelGudangBarang.Name = "TabelGudangBarang"
        Me.TabelGudangBarang.Size = New System.Drawing.Size(451, 150)
        Me.TabelGudangBarang.TabIndex = 4
        '
        'BtnReq
        '
        Me.BtnReq.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReq.Location = New System.Drawing.Point(257, 235)
        Me.BtnReq.Name = "BtnReq"
        Me.BtnReq.Size = New System.Drawing.Size(103, 44)
        Me.BtnReq.TabIndex = 3
        Me.BtnReq.Text = "Request Barang"
        Me.BtnReq.UseVisualStyleBackColor = False
        '
        'BtnJual
        '
        Me.BtnJual.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnJual.Location = New System.Drawing.Point(378, 235)
        Me.BtnJual.Name = "BtnJual"
        Me.BtnJual.Size = New System.Drawing.Size(103, 44)
        Me.BtnJual.TabIndex = 6
        Me.BtnJual.Text = "Jual Barang"
        Me.BtnJual.UseVisualStyleBackColor = False
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "NamaBarang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'JumlahBarang
        '
        Me.JumlahBarang.HeaderText = "JumlahBarang"
        Me.JumlahBarang.Name = "JumlahBarang"
        '
        'SatuanBarang
        '
        Me.SatuanBarang.HeaderText = "SatuanBarang"
        Me.SatuanBarang.Name = "SatuanBarang"
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "KodeBarang"
        Me.KodeBarang.Name = "KodeBarang"
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.Red
        Me.BtnLogout.Location = New System.Drawing.Point(148, 235)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(103, 44)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn.Location = New System.Drawing.Point(496, 235)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(103, 44)
        Me.Btn.TabIndex = 8
        Me.Btn.Text = "Status Request"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'Gudang_TIK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(745, 321)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.BtnJual)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabelGudangBarang)
        Me.Controls.Add(Me.BtnReq)
        Me.Name = "Gudang_TIK"
        Me.Text = "Gudang_TIK"
        CType(Me.TabelGudangBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TabelGudangBarang As DataGridView
    Friend WithEvents BtnReq As Button
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBarang As DataGridViewTextBoxColumn
    Friend WithEvents SatuanBarang As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents BtnJual As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Btn As Button
End Class
