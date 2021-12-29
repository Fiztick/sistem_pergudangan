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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxEditJenis = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnEditJenis
        '
        Me.BtnEditJenis.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditJenis.Location = New System.Drawing.Point(312, 174)
        Me.BtnEditJenis.Name = "BtnEditJenis"
        Me.BtnEditJenis.Size = New System.Drawing.Size(86, 23)
        Me.BtnEditJenis.TabIndex = 7
        Me.BtnEditJenis.Text = "Edit Jenis"
        Me.BtnEditJenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(331, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Silahkan Pilih Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jenis Barang"
        '
        'ComboBoxEditJenis
        '
        Me.ComboBoxEditJenis.FormattingEnabled = True
        Me.ComboBoxEditJenis.Items.AddRange(New Object() {"Pcs", "Kilogram", "Box", "Unit", "Liter", "Lusin", "Meter"})
        Me.ComboBoxEditJenis.Location = New System.Drawing.Point(169, 123)
        Me.ComboBoxEditJenis.Name = "ComboBoxEditJenis"
        Me.ComboBoxEditJenis.Size = New System.Drawing.Size(229, 21)
        Me.ComboBoxEditJenis.TabIndex = 4
        '
        'Edit_Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 265)
        Me.Controls.Add(Me.BtnEditJenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxEditJenis)
        Me.Name = "Edit_Jenis_Barang"
        Me.Text = "Edit_Jenis_Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditJenis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEditJenis As ComboBox
End Class
