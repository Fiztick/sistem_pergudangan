<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Barang_Masuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnAddBarangMasuk = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxJumlahMasuk = New System.Windows.Forms.TextBox()
        Me.TextBoxIdOrder = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewOrderBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewOrderBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAddBarangMasuk
        '
        Me.BtnAddBarangMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarangMasuk.Location = New System.Drawing.Point(486, 468)
        Me.BtnAddBarangMasuk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddBarangMasuk.Name = "BtnAddBarangMasuk"
        Me.BtnAddBarangMasuk.Size = New System.Drawing.Size(200, 38)
        Me.BtnAddBarangMasuk.TabIndex = 25
        Me.BtnAddBarangMasuk.Text = "Add Barang Masuk"
        Me.BtnAddBarangMasuk.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-136, 49)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1068, 38)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Masukan Data Barang Masuk untuk Order"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxJumlahMasuk
        '
        Me.TextBoxJumlahMasuk.Location = New System.Drawing.Point(284, 421)
        Me.TextBoxJumlahMasuk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxJumlahMasuk.Name = "TextBoxJumlahMasuk"
        Me.TextBoxJumlahMasuk.Size = New System.Drawing.Size(402, 26)
        Me.TextBoxJumlahMasuk.TabIndex = 22
        '
        'TextBoxIdOrder
        '
        Me.TextBoxIdOrder.Location = New System.Drawing.Point(284, 365)
        Me.TextBoxIdOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxIdOrder.Name = "TextBoxIdOrder"
        Me.TextBoxIdOrder.Size = New System.Drawing.Size(402, 26)
        Me.TextBoxIdOrder.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 421)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Jumlah Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 365)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 29)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Id Order"
        '
        'DataGridViewOrderBarang
        '
        Me.DataGridViewOrderBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrderBarang.Location = New System.Drawing.Point(51, 126)
        Me.DataGridViewOrderBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewOrderBarang.Name = "DataGridViewOrderBarang"
        Me.DataGridViewOrderBarang.RowHeadersWidth = 62
        Me.DataGridViewOrderBarang.Size = New System.Drawing.Size(695, 198)
        Me.DataGridViewOrderBarang.TabIndex = 26
        '
        'Add_Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 584)
        Me.Controls.Add(Me.DataGridViewOrderBarang)
        Me.Controls.Add(Me.BtnAddBarangMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxJumlahMasuk)
        Me.Controls.Add(Me.TextBoxIdOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Add_Barang_Masuk"
        Me.Text = "Add_Barang_Masuk"
        CType(Me.DataGridViewOrderBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddBarangMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxJumlahMasuk As TextBox
    Friend WithEvents TextBoxIdOrder As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewOrderBarang As DataGridView
End Class
