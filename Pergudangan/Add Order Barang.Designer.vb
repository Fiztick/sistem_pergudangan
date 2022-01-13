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
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 374)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 442)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jumlah Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 498)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal Order"
        '
        'TextBoxIdBarang
        '
        Me.TextBoxIdBarang.Location = New System.Drawing.Point(282, 378)
        Me.TextBoxIdBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxIdBarang.Name = "TextBoxIdBarang"
        Me.TextBoxIdBarang.Size = New System.Drawing.Size(410, 26)
        Me.TextBoxIdBarang.TabIndex = 13
        '
        'TextBoxJumlahOrder
        '
        Me.TextBoxJumlahOrder.Location = New System.Drawing.Point(282, 445)
        Me.TextBoxJumlahOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxJumlahOrder.Name = "TextBoxJumlahOrder"
        Me.TextBoxJumlahOrder.Size = New System.Drawing.Size(410, 26)
        Me.TextBoxJumlahOrder.TabIndex = 14
        '
        'DateTimeOrder
        '
        Me.DateTimeOrder.Location = New System.Drawing.Point(282, 500)
        Me.DateTimeOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimeOrder.Name = "DateTimeOrder"
        Me.DateTimeOrder.Size = New System.Drawing.Size(410, 26)
        Me.DateTimeOrder.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(117, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(553, 37)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Masukan Data barang yang diorder"
        '
        'BtnOrderBarang
        '
        Me.BtnOrderBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderBarang.Location = New System.Drawing.Point(536, 547)
        Me.BtnOrderBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOrderBarang.Name = "BtnOrderBarang"
        Me.BtnOrderBarang.Size = New System.Drawing.Size(156, 38)
        Me.BtnOrderBarang.TabIndex = 17
        Me.BtnOrderBarang.Text = "Order Barang"
        Me.BtnOrderBarang.UseVisualStyleBackColor = True
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(46, 128)
        Me.DataGridViewBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.RowHeadersWidth = 62
        Me.DataGridViewBarang.Size = New System.Drawing.Size(701, 203)
        Me.DataGridViewBarang.TabIndex = 18
        '
        'Add_Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 641)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Controls.Add(Me.BtnOrderBarang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeOrder)
        Me.Controls.Add(Me.TextBoxJumlahOrder)
        Me.Controls.Add(Me.TextBoxIdBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Add_Order_Barang"
        Me.Text = "Add_Order_Barang"
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridViewBarang As DataGridView
End Class
