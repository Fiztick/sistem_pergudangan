<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Barang_Masuk
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
        Me.LblIdBarangMasuk = New System.Windows.Forms.Label()
        Me.BtnYakin = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblIdBarangMasuk
        '
        Me.LblIdBarangMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdBarangMasuk.Location = New System.Drawing.Point(15, 94)
        Me.LblIdBarangMasuk.Name = "LblIdBarangMasuk"
        Me.LblIdBarangMasuk.Size = New System.Drawing.Size(497, 26)
        Me.LblIdBarangMasuk.TabIndex = 7
        Me.LblIdBarangMasuk.Text = "ID Barang Masuk"
        Me.LblIdBarangMasuk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnYakin
        '
        Me.BtnYakin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYakin.Location = New System.Drawing.Point(296, 150)
        Me.BtnYakin.Name = "BtnYakin"
        Me.BtnYakin.Size = New System.Drawing.Size(90, 25)
        Me.BtnYakin.TabIndex = 6
        Me.BtnYakin.Text = "Yakin"
        Me.BtnYakin.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(140, 150)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 25)
        Me.BtnBatal.TabIndex = 5
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Yakin Ingin Menghapus data dengan ID Barang Masuk ini?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Hapus_Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 221)
        Me.Controls.Add(Me.LblIdBarangMasuk)
        Me.Controls.Add(Me.BtnYakin)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Barang_Masuk"
        Me.Text = "Hapus_Barang_Masuk"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblIdBarangMasuk As Label
    Friend WithEvents BtnYakin As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label1 As Label
End Class
