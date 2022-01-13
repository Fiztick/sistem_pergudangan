<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Barang_Gudang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNamaBarang = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenisBarang = New System.Windows.Forms.ComboBox()
        Me.BtnAddBarang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(738, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukan Data Barang yang ingin di tambahkan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 200)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 257)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock Barang"
        '
        'TxtNamaBarang
        '
        Me.TxtNamaBarang.Location = New System.Drawing.Point(262, 143)
        Me.TxtNamaBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNamaBarang.Name = "TxtNamaBarang"
        Me.TxtNamaBarang.Size = New System.Drawing.Size(592, 26)
        Me.TxtNamaBarang.TabIndex = 4
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(262, 257)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(592, 26)
        Me.TxtStock.TabIndex = 5
        '
        'ComboBoxJenisBarang
        '
        Me.ComboBoxJenisBarang.FormattingEnabled = True
        Me.ComboBoxJenisBarang.Items.AddRange(New Object() {"Susu", "Pakaian", "Beras", "ATK", "Alat Mandi", "Alat Makan"})
        Me.ComboBoxJenisBarang.Location = New System.Drawing.Point(262, 200)
        Me.ComboBoxJenisBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBoxJenisBarang.Name = "ComboBoxJenisBarang"
        Me.ComboBoxJenisBarang.Size = New System.Drawing.Size(592, 28)
        Me.ComboBoxJenisBarang.TabIndex = 6
        '
        'BtnAddBarang
        '
        Me.BtnAddBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarang.Location = New System.Drawing.Point(717, 317)
        Me.BtnAddBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddBarang.Name = "BtnAddBarang"
        Me.BtnAddBarang.Size = New System.Drawing.Size(135, 38)
        Me.BtnAddBarang.TabIndex = 7
        Me.BtnAddBarang.Text = "Add Barang"
        Me.BtnAddBarang.UseVisualStyleBackColor = True
        '
        'Add_Barang_Gudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 402)
        Me.Controls.Add(Me.BtnAddBarang)
        Me.Controls.Add(Me.ComboBoxJenisBarang)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtNamaBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Add_Barang_Gudang"
        Me.Text = "Add_Barang_Gudang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNamaBarang As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents ComboBoxJenisBarang As ComboBox
    Friend WithEvents BtnAddBarang As Button
End Class
