<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Jenis_Barang
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
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnYakin = New System.Windows.Forms.Button()
        Me.LblJenis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yakin Ingin Menghapus Jenis Barang ini?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(113, 153)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 25)
        Me.BtnBatal.TabIndex = 1
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnYakin
        '
        Me.BtnYakin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYakin.Location = New System.Drawing.Point(269, 153)
        Me.BtnYakin.Name = "BtnYakin"
        Me.BtnYakin.Size = New System.Drawing.Size(90, 25)
        Me.BtnYakin.TabIndex = 2
        Me.BtnYakin.Text = "Yakin"
        Me.BtnYakin.UseVisualStyleBackColor = True
        '
        'LblJenis
        '
        Me.LblJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenis.Location = New System.Drawing.Point(15, 99)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(451, 26)
        Me.LblJenis.TabIndex = 3
        Me.LblJenis.Text = "Jenis Barang"
        Me.LblJenis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Hapus_Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 261)
        Me.Controls.Add(Me.LblJenis)
        Me.Controls.Add(Me.BtnYakin)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Jenis_Barang"
        Me.Text = "Hapus_Jenis_Barang"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnYakin As Button
    Friend WithEvents LblJenis As Label
End Class
