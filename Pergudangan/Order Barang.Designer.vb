<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Barang
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
        Me.BtnHapusOrder = New System.Windows.Forms.Button()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.DataGridOrderBarang = New System.Windows.Forms.DataGridView()
        Me.IdBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Order Barang Gudang"
        '
        'BtnHapusOrder
        '
        Me.BtnHapusOrder.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusOrder.Location = New System.Drawing.Point(297, 244)
        Me.BtnHapusOrder.Name = "BtnHapusOrder"
        Me.BtnHapusOrder.Size = New System.Drawing.Size(115, 37)
        Me.BtnHapusOrder.TabIndex = 8
        Me.BtnHapusOrder.Text = "Hapus Order Barang"
        Me.BtnHapusOrder.UseVisualStyleBackColor = True
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOrder.Location = New System.Drawing.Point(61, 243)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(102, 37)
        Me.BtnAddOrder.TabIndex = 6
        Me.BtnAddOrder.Text = "Add Order Barang"
        Me.BtnAddOrder.UseVisualStyleBackColor = True
        '
        'DataGridOrderBarang
        '
        Me.DataGridOrderBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrderBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBarang, Me.JumlahOrder, Me.TanggalOrder})
        Me.DataGridOrderBarang.Location = New System.Drawing.Point(72, 73)
        Me.DataGridOrderBarang.Name = "DataGridOrderBarang"
        Me.DataGridOrderBarang.Size = New System.Drawing.Size(340, 150)
        Me.DataGridOrderBarang.TabIndex = 5
        '
        'IdBarang
        '
        Me.IdBarang.HeaderText = "ID Barang"
        Me.IdBarang.Name = "IdBarang"
        '
        'JumlahOrder
        '
        Me.JumlahOrder.HeaderText = "Jumlah Order"
        Me.JumlahOrder.Name = "JumlahOrder"
        '
        'TanggalOrder
        '
        Me.TanggalOrder.HeaderText = "Tanggal Order"
        Me.TanggalOrder.Name = "TanggalOrder"
        '
        'Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusOrder)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Controls.Add(Me.DataGridOrderBarang)
        Me.Name = "Order_Barang"
        Me.Text = "Order_Barang"
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapusOrder As Button
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents DataGridOrderBarang As DataGridView
    Friend WithEvents IdBarang As DataGridViewTextBoxColumn
    Friend WithEvents JumlahOrder As DataGridViewTextBoxColumn
    Friend WithEvents TanggalOrder As DataGridViewTextBoxColumn
End Class
