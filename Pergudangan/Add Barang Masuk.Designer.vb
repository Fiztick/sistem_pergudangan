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
        Me.SuspendLayout()
        '
        'BtnAddBarangMasuk
        '
        Me.BtnAddBarangMasuk.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarangMasuk.Location = New System.Drawing.Point(289, 212)
        Me.BtnAddBarangMasuk.Name = "BtnAddBarangMasuk"
        Me.BtnAddBarangMasuk.Size = New System.Drawing.Size(135, 31)
        Me.BtnAddBarangMasuk.TabIndex = 25
        Me.BtnAddBarangMasuk.Text = "Add Barang Masuk"
        Me.BtnAddBarangMasuk.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 18)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Masukan Data Masuk Barang"
        '
        'TextBoxJumlahMasuk
        '
        Me.TextBoxJumlahMasuk.Location = New System.Drawing.Point(224, 156)
        Me.TextBoxJumlahMasuk.Name = "TextBoxJumlahMasuk"
        Me.TextBoxJumlahMasuk.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxJumlahMasuk.TabIndex = 22
        '
        'TextBoxIdOrder
        '
        Me.TextBoxIdOrder.Location = New System.Drawing.Point(224, 109)
        Me.TextBoxIdOrder.Name = "TextBoxIdOrder"
        Me.TextBoxIdOrder.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxIdOrder.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Jumlah Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Orbitron", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Id Order"
        '
        'Add_Barang_Masuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 306)
        Me.Controls.Add(Me.BtnAddBarangMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxJumlahMasuk)
        Me.Controls.Add(Me.TextBoxIdOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Add_Barang_Masuk"
        Me.Text = "Add_Barang_Masuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddBarangMasuk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxJumlahMasuk As TextBox
    Friend WithEvents TextBoxIdOrder As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
