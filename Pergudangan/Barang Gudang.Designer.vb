<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang_Gudang
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
        Me.DataGridBarangGudang = New System.Windows.Forms.DataGridView()
        Me.BtnAddBarang = New System.Windows.Forms.Button()
        Me.BtnEditBarang = New System.Windows.Forms.Button()
        Me.BtnHapusBarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridBarangGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridBarangGudang
        '
        Me.DataGridBarangGudang.AllowUserToAddRows = False
        Me.DataGridBarangGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBarangGudang.Location = New System.Drawing.Point(40, 65)
        Me.DataGridBarangGudang.Name = "DataGridBarangGudang"
        Me.DataGridBarangGudang.RowHeadersWidth = 62
        Me.DataGridBarangGudang.Size = New System.Drawing.Size(464, 132)
        Me.DataGridBarangGudang.TabIndex = 0
        '
        'BtnAddBarang
        '
        Me.BtnAddBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarang.Location = New System.Drawing.Point(176, 213)
        Me.BtnAddBarang.Name = "BtnAddBarang"
        Me.BtnAddBarang.Size = New System.Drawing.Size(190, 30)
        Me.BtnAddBarang.TabIndex = 1
        Me.BtnAddBarang.Text = "Add Barang Gudang"
        Me.BtnAddBarang.UseVisualStyleBackColor = True
        '
        'BtnEditBarang
        '
        Me.BtnEditBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditBarang.Location = New System.Drawing.Point(176, 249)
        Me.BtnEditBarang.Name = "BtnEditBarang"
        Me.BtnEditBarang.Size = New System.Drawing.Size(190, 30)
        Me.BtnEditBarang.TabIndex = 2
        Me.BtnEditBarang.Text = "Edit Barang Gudang"
        Me.BtnEditBarang.UseVisualStyleBackColor = True
        '
        'BtnHapusBarang
        '
        Me.BtnHapusBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusBarang.Location = New System.Drawing.Point(176, 285)
        Me.BtnHapusBarang.Name = "BtnHapusBarang"
        Me.BtnHapusBarang.Size = New System.Drawing.Size(190, 30)
        Me.BtnHapusBarang.TabIndex = 3
        Me.BtnHapusBarang.Text = "Hapus Barang Gudang"
        Me.BtnHapusBarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Macam Macam Barang Gudang"
        '
        'Barang_Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 352)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusBarang)
        Me.Controls.Add(Me.BtnEditBarang)
        Me.Controls.Add(Me.BtnAddBarang)
        Me.Controls.Add(Me.DataGridBarangGudang)
        Me.Name = "Barang_Gudang"
        Me.Text = "Barang_Gudang"
        CType(Me.DataGridBarangGudang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridBarangGudang As DataGridView
    Friend WithEvents BtnAddBarang As Button
    Friend WithEvents BtnEditBarang As Button
    Friend WithEvents BtnHapusBarang As Button
    Friend WithEvents Label1 As Label
End Class
