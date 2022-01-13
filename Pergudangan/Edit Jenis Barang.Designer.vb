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
        Me.BtnEditJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditJenis.Location = New System.Drawing.Point(561, 239)
        Me.BtnEditJenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(135, 38)
        Me.BtnEditJenis.TabIndex = 7
        Me.BtnEditJenis.Text = "Edit Jenis"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Silahkan Pilih Jenis Barang"
        '
        'ComboBoxEditJenis
        '
        Me.ComboBoxEditJenis.FormattingEnabled = True
        Me.ComboBoxEditJenis.Items.AddRange(New Object() {"Susu", "Pakaian", "Beras", "ATK", "Alat Mandi", "Alat Makan"})
        Me.ComboBoxEditJenis.Location = New System.Drawing.Point(298, 129)
        Me.ComboBoxEditJenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxEditJenis.Name = "ComboBoxEditJenis"
        Me.ComboBoxEditJenis.Size = New System.Drawing.Size(398, 28)
        Me.ComboBoxEditJenis.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Satuan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jenis Barang"
        '
        'ComboBoxEditSatuan
        '
        Me.ComboBoxEditSatuan.FormattingEnabled = True
        Me.ComboBoxEditSatuan.Items.AddRange(New Object() {"Box", "Pcs", "Liter", "Unit", "", ""})
        Me.ComboBoxEditSatuan.Location = New System.Drawing.Point(298, 188)
        Me.ComboBoxEditSatuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxEditSatuan.Name = "ComboBoxEditSatuan"
        Me.ComboBoxEditSatuan.Size = New System.Drawing.Size(398, 28)
        Me.ComboBoxEditSatuan.TabIndex = 10
        '
        'Edit_Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 370)
        Me.Controls.Add(Me.ComboBoxEditJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxEditSatuan)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
