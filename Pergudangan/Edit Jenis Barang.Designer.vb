<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Jenis_Barang
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
        Me.BtnEditJenis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxEditJenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEditSatuan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnEditJenis
        '
        Me.BtnEditJenis.Font = New System.Drawing.Font("Orbitron", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditJenis.Location = New System.Drawing.Point(376, 159)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(90, 25)
        Me.BtnEditJenis.TabIndex = 7
        Me.BtnEditJenis.Text = "Edit Jenis"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Silahkan Pilih Jenis Barang"
        '
        'ComboBoxEditJenis
        '
        Me.ComboBoxEditJenis.FormattingEnabled = True
        Me.ComboBoxEditJenis.Items.AddRange(New Object() {"Susu", "Pakian", "Beras", "ATK", "Alat Mandi", "Alat Makan", ""})
        Me.ComboBoxEditJenis.Location = New System.Drawing.Point(199, 84)
        Me.ComboBoxEditJenis.Name = "ComboBoxEditJenis"
        Me.ComboBoxEditJenis.Size = New System.Drawing.Size(267, 21)
        Me.ComboBoxEditJenis.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Satuan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jenis Barang"
        '
        'ComboBoxEditSatuan
        '
        Me.ComboBoxEditSatuan.FormattingEnabled = True
        Me.ComboBoxEditSatuan.Items.AddRange(New Object() {"Box", "Pcs", "Liter", "Unit", "", ""})
        Me.ComboBoxEditSatuan.Location = New System.Drawing.Point(199, 122)
        Me.ComboBoxEditSatuan.Name = "ComboBoxEditSatuan"
        Me.ComboBoxEditSatuan.Size = New System.Drawing.Size(267, 21)
        Me.ComboBoxEditSatuan.TabIndex = 10
        '
        'Edit_Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 261)
        Me.Controls.Add(Me.ComboBoxEditJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxEditSatuan)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Edit_Jenis_Barang"
        Me.Text = "Edit_Jenis_Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditJenis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxEditJenis As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEditSatuan As ComboBox
End Class
