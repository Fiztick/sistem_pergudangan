<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konfirmasi_Jual
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
        Me.BtnYakin = New System.Windows.Forms.Button()
        Me.BtnRagu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apakah Kamu Yakin Ingin Menjual Barang"
        '
        'BtnYakin
        '
        Me.BtnYakin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnYakin.Location = New System.Drawing.Point(315, 156)
        Me.BtnYakin.Name = "BtnYakin"
        Me.BtnYakin.Size = New System.Drawing.Size(77, 33)
        Me.BtnYakin.TabIndex = 2
        Me.BtnYakin.Text = "Yakin, Jual"
        Me.BtnYakin.UseVisualStyleBackColor = False
        '
        'BtnRagu
        '
        Me.BtnRagu.BackColor = System.Drawing.Color.Red
        Me.BtnRagu.Location = New System.Drawing.Point(156, 156)
        Me.BtnRagu.Name = "BtnRagu"
        Me.BtnRagu.Size = New System.Drawing.Size(87, 33)
        Me.BtnRagu.TabIndex = 3
        Me.BtnRagu.Text = "Ragu, Kembali"
        Me.BtnRagu.UseVisualStyleBackColor = False
        '
        'Konfirmasi_Jual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(563, 245)
        Me.Controls.Add(Me.BtnRagu)
        Me.Controls.Add(Me.BtnYakin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Konfirmasi_Jual"
        Me.Text = "Konfirmasi_Jual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnYakin As Button
    Friend WithEvents BtnRagu As Button
End Class
