<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus_Order_Barang
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
        Me.LblIdOrder = New System.Windows.Forms.Label()
        Me.BtnYakin = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblIdOrder
        '
        Me.LblIdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIdOrder.Location = New System.Drawing.Point(15, 111)
        Me.LblIdOrder.Name = "LblIdOrder"
        Me.LblIdOrder.Size = New System.Drawing.Size(497, 28)
        Me.LblIdOrder.TabIndex = 7
        Me.LblIdOrder.Text = "ID Order"
        Me.LblIdOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnYakin
        '
        Me.BtnYakin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYakin.Location = New System.Drawing.Point(295, 168)
        Me.BtnYakin.Name = "BtnYakin"
        Me.BtnYakin.Size = New System.Drawing.Size(90, 25)
        Me.BtnYakin.TabIndex = 6
        Me.BtnYakin.Text = "Yakin"
        Me.BtnYakin.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.Location = New System.Drawing.Point(139, 168)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(90, 25)
        Me.BtnBatal.TabIndex = 5
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Yakin Ingin Menghapus Order Barang dengan ID Order Ini?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Hapus_Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 261)
        Me.Controls.Add(Me.LblIdOrder)
        Me.Controls.Add(Me.BtnYakin)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hapus_Order_Barang"
        Me.Text = "Hapus_Order_Barang"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblIdOrder As Label
    Friend WithEvents BtnYakin As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents Label1 As Label
End Class
