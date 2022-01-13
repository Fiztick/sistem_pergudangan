<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pergudangan
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
        Me.btnjenisBarang = New System.Windows.Forms.Button()
        Me.BtnBarangGudang = New System.Windows.Forms.Button()
        Me.BtnOrderBarang = New System.Windows.Forms.Button()
        Me.BtnmasukBarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnjenisBarang
        '
        Me.btnjenisBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjenisBarang.Location = New System.Drawing.Point(123, 158)
        Me.btnjenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnjenisBarang.Name = "btnjenisBarang"
        Me.btnjenisBarang.Size = New System.Drawing.Size(285, 46)
        Me.btnjenisBarang.TabIndex = 0
        Me.btnjenisBarang.Text = "Jenis Barang"
        Me.btnjenisBarang.UseVisualStyleBackColor = True
        '
        'BtnBarangGudang
        '
        Me.BtnBarangGudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarangGudang.Location = New System.Drawing.Point(123, 264)
        Me.BtnBarangGudang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBarangGudang.Name = "BtnBarangGudang"
        Me.BtnBarangGudang.Size = New System.Drawing.Size(285, 46)
        Me.BtnBarangGudang.TabIndex = 1
        Me.BtnBarangGudang.Text = "Barang Gudang"
        Me.BtnBarangGudang.UseVisualStyleBackColor = True
        '
        'BtnOrderBarang
        '
        Me.BtnOrderBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderBarang.Location = New System.Drawing.Point(466, 158)
        Me.BtnOrderBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOrderBarang.Name = "BtnOrderBarang"
        Me.BtnOrderBarang.Size = New System.Drawing.Size(285, 46)
        Me.BtnOrderBarang.TabIndex = 2
        Me.BtnOrderBarang.Text = "Order Barang"
        Me.BtnOrderBarang.UseVisualStyleBackColor = True
        '
        'BtnmasukBarang
        '
        Me.BtnmasukBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnmasukBarang.Location = New System.Drawing.Point(466, 264)
        Me.BtnmasukBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnmasukBarang.Name = "BtnmasukBarang"
        Me.BtnmasukBarang.Size = New System.Drawing.Size(285, 46)
        Me.BtnmasukBarang.TabIndex = 3
        Me.BtnmasukBarang.Text = "Masuk Barang"
        Me.BtnmasukBarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sistem Pergudangan"
        '
        'Pergudangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnmasukBarang)
        Me.Controls.Add(Me.BtnOrderBarang)
        Me.Controls.Add(Me.BtnBarangGudang)
        Me.Controls.Add(Me.btnjenisBarang)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Pergudangan"
        Me.Text = "Pergudangan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnjenisBarang As Button
    Friend WithEvents BtnBarangGudang As Button
    Friend WithEvents BtnOrderBarang As Button
    Friend WithEvents BtnmasukBarang As Button
    Friend WithEvents Label1 As Label
End Class
