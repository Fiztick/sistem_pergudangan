<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jenis_Barang
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
        Me.DataGridJenisBarang = New System.Windows.Forms.DataGridView()
        Me.Janis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnAddJenis = New System.Windows.Forms.Button()
        Me.BtnEditJenis = New System.Windows.Forms.Button()
        Me.BtnHapusJenis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridJenisBarang
        '
        Me.DataGridJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJenisBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Janis_barang})
        Me.DataGridJenisBarang.Location = New System.Drawing.Point(92, 60)
        Me.DataGridJenisBarang.Name = "DataGridJenisBarang"
        Me.DataGridJenisBarang.Size = New System.Drawing.Size(190, 84)
        Me.DataGridJenisBarang.TabIndex = 0
        '
        'Janis_barang
        '
        Me.Janis_barang.HeaderText = "Jenis Barang"
        Me.Janis_barang.Name = "Janis_barang"
        '
        'BtnAddJenis
        '
        Me.BtnAddJenis.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddJenis.Location = New System.Drawing.Point(92, 161)
        Me.BtnAddJenis.Name = "BtnAddJenis"
        Me.BtnAddJenis.Size = New System.Drawing.Size(190, 31)
        Me.BtnAddJenis.TabIndex = 1
        Me.BtnAddJenis.Text = "Add Jenis Barang"
        Me.BtnAddJenis.UseVisualStyleBackColor = True
        '
        'BtnEditJenis
        '
        Me.BtnEditJenis.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditJenis.Location = New System.Drawing.Point(92, 198)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(190, 31)
        Me.BtnEditJenis.TabIndex = 2
        Me.BtnEditJenis.Text = "Edit Jenis Barang"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'BtnHapusJenis
        '
        Me.BtnHapusJenis.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusJenis.Location = New System.Drawing.Point(92, 235)
        Me.BtnHapusJenis.Name = "BtnHapusJenis"
        Me.BtnHapusJenis.Size = New System.Drawing.Size(190, 31)
        Me.BtnHapusJenis.TabIndex = 3
        Me.BtnHapusJenis.Text = "Hapus Jenis Barang"
        Me.BtnHapusJenis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Jenis Jenis Barang Gudang"
        '
        'Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 318)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusJenis)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.BtnAddJenis)
        Me.Controls.Add(Me.DataGridJenisBarang)
        Me.Name = "Jenis_Barang"
        Me.Text = "Jenis_Barang"
        CType(Me.DataGridJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridJenisBarang As DataGridView
    Friend WithEvents Janis_barang As DataGridViewTextBoxColumn
    Friend WithEvents BtnAddJenis As Button
    Friend WithEvents BtnEditJenis As Button
    Friend WithEvents BtnHapusJenis As Button
    Friend WithEvents Label1 As Label
End Class
