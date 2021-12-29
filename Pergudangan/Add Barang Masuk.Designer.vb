<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Barang_Masuk
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
        Me.BtnAddBarangMasuk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxJumlahMasuk = New System.Windows.Forms.TextBox()
        Me.TextBoxIdOrder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridBarangMasuk = New System.Windows.Forms.DataGridView()
        Me.IdOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddBarangMasuk
        '
        Me.BtnAddBarangMasuk.Font = New System.Drawing.Font("Orbitron", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarangMasuk.Location = New System.Drawing.Point(661, 153)
        Me.BtnAddBarangMasuk.Name = "BtnAddBarangMasuk"
        Me.BtnAddBarangMasuk.Size = New System.Drawing.Size(133, 25)
        Me.BtnAddBarangMasuk.TabIndex = 25
        Me.BtnAddBarangMasuk.Text = "Add Barang Masuk"
        Me.BtnAddBarangMasuk.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(205, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Masukan Data Masuk Barang"
        '
        'TextBoxJumlahMasuk
        '
        Me.TextBoxJumlahMasuk.Location = New System.Drawing.Point(525, 116)
        Me.TextBoxJumlahMasuk.Name = "TextBoxJumlahMasuk"
        Me.TextBoxJumlahMasuk.Size = New System.Drawing.Size(269, 20)
        Me.TextBoxJumlahMasuk.TabIndex = 22
        '
        'TextBoxIdOrder
        '
        Me.TextBoxIdOrder.Location = New System.Drawing.Point(525, 72)
        Me.TextBoxIdOrder.Name = "TextBoxIdOrder"
        Me.TextBoxIdOrder.Size = New System.Drawing.Size(269, 20)
        Me.TextBoxIdOrder.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(383, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Jumlah Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Id Order"
        '
        'DataGridBarangMasuk
        '
        Me.DataGridBarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBarangMasuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdOrder, Me.JumlahMasuk})
        Me.DataGridBarangMasuk.Location = New System.Drawing.Point(61, 72)
        Me.DataGridBarangMasuk.Name = "DataGridBarangMasuk"
        Me.DataGridBarangMasuk.Size = New System.Drawing.Size(246, 150)
        Me.DataGridBarangMasuk.TabIndex = 26
        '
        'IdOrder
        '
        Me.IdOrder.HeaderText = "ID Order"
        Me.IdOrder.Name = "IdOrder"
        '
        'JumlahMasuk
        '
        Me.JumlahMasuk.HeaderText = "Jumlah Masuk"
        Me.JumlahMasuk.Name = "JumlahMasuk"
        '
        'Add_Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 261)
        Me.Controls.Add(Me.DataGridBarangMasuk)
        Me.Controls.Add(Me.BtnAddBarangMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxJumlahMasuk)
        Me.Controls.Add(Me.TextBoxIdOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Add_Barang_Masuk"
        Me.Text = "Add_Barang_Masuk"
        CType(Me.DataGridBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddBarangMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxJumlahMasuk As TextBox
    Friend WithEvents TextBoxIdOrder As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridBarangMasuk As DataGridView
    Friend WithEvents IdOrder As DataGridViewTextBoxColumn
    Friend WithEvents JumlahMasuk As DataGridViewTextBoxColumn
End Class
