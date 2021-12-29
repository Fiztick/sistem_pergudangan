<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Order_Barang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxIdBarang = New System.Windows.Forms.TextBox()
        Me.TextBoxJumlahOrder = New System.Windows.Forms.TextBox()
        Me.DateTimeOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnOrderBarang = New System.Windows.Forms.Button()
        Me.DataGridOrderBarang = New System.Windows.Forms.DataGridView()
        Me.IdBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(410, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(410, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jumlah Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Orbitron", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal Order"
        '
        'TextBoxIdBarang
        '
        Me.TextBoxIdBarang.Location = New System.Drawing.Point(556, 83)
        Me.TextBoxIdBarang.Name = "TextBoxIdBarang"
        Me.TextBoxIdBarang.Size = New System.Drawing.Size(275, 20)
        Me.TextBoxIdBarang.TabIndex = 13
        '
        'TextBoxJumlahOrder
        '
        Me.TextBoxJumlahOrder.Location = New System.Drawing.Point(556, 129)
        Me.TextBoxJumlahOrder.Name = "TextBoxJumlahOrder"
        Me.TextBoxJumlahOrder.Size = New System.Drawing.Size(275, 20)
        Me.TextBoxJumlahOrder.TabIndex = 14
        '
        'DateTimeOrder
        '
        Me.DateTimeOrder.Location = New System.Drawing.Point(556, 176)
        Me.DateTimeOrder.Name = "DateTimeOrder"
        Me.DateTimeOrder.Size = New System.Drawing.Size(275, 20)
        Me.DateTimeOrder.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Orbitron", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(425, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Masukan Data barang yang diorder"
        '
        'BtnOrderBarang
        '
        Me.BtnOrderBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderBarang.Location = New System.Drawing.Point(727, 212)
        Me.BtnOrderBarang.Name = "BtnOrderBarang"
        Me.BtnOrderBarang.Size = New System.Drawing.Size(104, 25)
        Me.BtnOrderBarang.TabIndex = 17
        Me.BtnOrderBarang.Text = "Order Barang"
        Me.BtnOrderBarang.UseVisualStyleBackColor = True
        '
        'DataGridOrderBarang
        '
        Me.DataGridOrderBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrderBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBarang, Me.JumlahOrder, Me.TanggalOrder})
        Me.DataGridOrderBarang.Location = New System.Drawing.Point(12, 82)
        Me.DataGridOrderBarang.Name = "DataGridOrderBarang"
        Me.DataGridOrderBarang.Size = New System.Drawing.Size(341, 150)
        Me.DataGridOrderBarang.TabIndex = 18
        '
        'IdBarang
        '
        Me.IdBarang.HeaderText = "ID Barang"
        Me.IdBarang.Name = "IdBarang"
        '
        'JumlahOrder
        '
        Me.JumlahOrder.HeaderText = "Jumlah Order"
        Me.JumlahOrder.Name = "JumlahOrder"
        '
        'TanggalOrder
        '
        Me.TanggalOrder.HeaderText = "Tanggal Order"
        Me.TanggalOrder.Name = "TanggalOrder"
        '
        'Add_Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 261)
        Me.Controls.Add(Me.DataGridOrderBarang)
        Me.Controls.Add(Me.BtnOrderBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeOrder)
        Me.Controls.Add(Me.TextBoxJumlahOrder)
        Me.Controls.Add(Me.TextBoxIdBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Add_Order_Barang"
        Me.Text = "Add_Order_Barang"
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxIdBarang As TextBox
    Friend WithEvents TextBoxJumlahOrder As TextBox
    Friend WithEvents DateTimeOrder As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnOrderBarang As Button
    Friend WithEvents DataGridOrderBarang As DataGridView
    Friend WithEvents IdBarang As DataGridViewTextBoxColumn
    Friend WithEvents JumlahOrder As DataGridViewTextBoxColumn
    Friend WithEvents TanggalOrder As DataGridViewTextBoxColumn
End Class
