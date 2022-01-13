<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Barang_Gudang
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
        Me.BtnEditBarang = New System.Windows.Forms.Button()
        Me.ComboBoxJenisBarang = New System.Windows.Forms.ComboBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEditBarang
        '
        Me.BtnEditBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditBarang.Location = New System.Drawing.Point(697, 306)
        Me.BtnEditBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditBarang.Name = "BtnEditBarang"
        Me.BtnEditBarang.Size = New System.Drawing.Size(135, 38)
        Me.BtnEditBarang.TabIndex = 15
        Me.BtnEditBarang.Text = "Edit Barang"
        Me.BtnEditBarang.UseVisualStyleBackColor = True
        '
        'ComboBoxJenisBarang
        '
        Me.ComboBoxJenisBarang.FormattingEnabled = True
        Me.ComboBoxJenisBarang.Items.AddRange(New Object() {"Susu", "Pakaian", "Beras", "ATK", "Alat Mandi", "Alat Makan"})
        Me.ComboBoxJenisBarang.Location = New System.Drawing.Point(240, 202)
        Me.ComboBoxJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxJenisBarang.Name = "ComboBoxJenisBarang"
        Me.ComboBoxJenisBarang.Size = New System.Drawing.Size(592, 28)
        Me.ComboBoxJenisBarang.TabIndex = 14
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(240, 258)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(592, 26)
        Me.TxtStock.TabIndex = 13
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(240, 145)
        Me.TxtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(592, 26)
        Me.TxtNamaBarang.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 258)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Stock Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(614, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Masukan Data Barang yang ingin diedit"
        '
        'Edit_Barang_Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 402)
        Me.Controls.Add(Me.BtnEditBarang)
        Me.Controls.Add(Me.ComboBoxJenisBarang)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtNamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Edit_Barang_Gudang"
        Me.Text = "Edit_Barang_Gudang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEditBarang As Button
    Friend WithEvents ComboBoxJenisBarang As ComboBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtNamaBarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
