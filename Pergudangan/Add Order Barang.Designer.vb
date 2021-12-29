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
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Id Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Jumlah Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tanggal Order"
        '
        'TextBoxIdBarang
        '
        Me.TextBoxIdBarang.Location = New System.Drawing.Point(254, 86)
        Me.TextBoxIdBarang.Name = "TextBoxIdBarang"
        Me.TextBoxIdBarang.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxIdBarang.TabIndex = 13
        '
        'TextBoxJumlahOrder
        '
        Me.TextBoxJumlahOrder.Location = New System.Drawing.Point(254, 133)
        Me.TextBoxJumlahOrder.Name = "TextBoxJumlahOrder"
        Me.TextBoxJumlahOrder.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxJumlahOrder.TabIndex = 14
        '
        'DateTimeOrder
        '
        Me.DateTimeOrder.Location = New System.Drawing.Point(254, 179)
        Me.DateTimeOrder.Name = "DateTimeOrder"
        Me.DateTimeOrder.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeOrder.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(135, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Masukan Data barang yang diorder"
        '
        'BtnOrderBarang
        '
        Me.BtnOrderBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderBarang.Location = New System.Drawing.Point(343, 221)
        Me.BtnOrderBarang.Name = "BtnOrderBarang"
        Me.BtnOrderBarang.Size = New System.Drawing.Size(111, 31)
        Me.BtnOrderBarang.TabIndex = 17
        Me.BtnOrderBarang.Text = "Order Barang"
        Me.BtnOrderBarang.UseVisualStyleBackColor = True
        '
        'Add_Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 278)
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
End Class
