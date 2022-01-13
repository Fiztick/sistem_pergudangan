<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_Barang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnHapusOrder = New System.Windows.Forms.Button()
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.DataGridOrderBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Order Barang Gudang"
        '
        'BtnHapusOrder
        '
        Me.BtnHapusOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusOrder.Location = New System.Drawing.Point(172, 232)
        Me.BtnHapusOrder.Name = "BtnHapusOrder"
        Me.BtnHapusOrder.Size = New System.Drawing.Size(190, 30)
        Me.BtnHapusOrder.TabIndex = 8
        Me.BtnHapusOrder.Text = "Hapus Order Barang"
        Me.BtnHapusOrder.UseVisualStyleBackColor = True
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddOrder.Location = New System.Drawing.Point(172, 196)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(190, 30)
        Me.BtnAddOrder.TabIndex = 6
        Me.BtnAddOrder.Text = "Add Order Barang"
        Me.BtnAddOrder.UseVisualStyleBackColor = True
        '
        'DataGridOrderBarang
        '
        Me.DataGridOrderBarang.AllowUserToAddRows = False
        Me.DataGridOrderBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrderBarang.Location = New System.Drawing.Point(31, 72)
        Me.DataGridOrderBarang.Name = "DataGridOrderBarang"
        Me.DataGridOrderBarang.RowHeadersWidth = 62
        Me.DataGridOrderBarang.Size = New System.Drawing.Size(464, 112)
        Me.DataGridOrderBarang.TabIndex = 5
        '
        'Order_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusOrder)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Controls.Add(Me.DataGridOrderBarang)
        Me.Name = "Order_Barang"
        Me.Text = "Order_Barang"
        CType(Me.DataGridOrderBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapusOrder As Button
    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents DataGridOrderBarang As DataGridView
End Class
