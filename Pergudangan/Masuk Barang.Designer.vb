﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Masuk_Barang
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
        Me.BtnHapusBarangMasuk = New System.Windows.Forms.Button()
        Me.BtnAddBarangMasuk = New System.Windows.Forms.Button()
        Me.DataGridMasukBarang = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridMasukBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Masuk Barang Gudang"
        '
        'BtnHapusBarangMasuk
        '
        Me.BtnHapusBarangMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusBarangMasuk.Location = New System.Drawing.Point(369, 89)
        Me.BtnHapusBarangMasuk.Name = "BtnHapusBarangMasuk"
        Me.BtnHapusBarangMasuk.Size = New System.Drawing.Size(190, 30)
        Me.BtnHapusBarangMasuk.TabIndex = 12
        Me.BtnHapusBarangMasuk.Text = "Hapus Barang Masuk"
        Me.BtnHapusBarangMasuk.UseVisualStyleBackColor = True
        '
        'BtnAddBarangMasuk
        '
        Me.BtnAddBarangMasuk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddBarangMasuk.Location = New System.Drawing.Point(369, 53)
        Me.BtnAddBarangMasuk.Name = "BtnAddBarangMasuk"
        Me.BtnAddBarangMasuk.Size = New System.Drawing.Size(190, 30)
        Me.BtnAddBarangMasuk.TabIndex = 11
        Me.BtnAddBarangMasuk.Text = "Add Barang Masuk"
        Me.BtnAddBarangMasuk.UseVisualStyleBackColor = True
        '
        'DataGridMasukBarang
        '
        Me.DataGridMasukBarang.AllowUserToAddRows = False
        Me.DataGridMasukBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMasukBarang.Location = New System.Drawing.Point(12, 53)
        Me.DataGridMasukBarang.Name = "DataGridMasukBarang"
        Me.DataGridMasukBarang.Size = New System.Drawing.Size(343, 150)
        Me.DataGridMasukBarang.TabIndex = 10
        '
        'Masuk_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 237)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnHapusBarangMasuk)
        Me.Controls.Add(Me.BtnAddBarangMasuk)
        Me.Controls.Add(Me.DataGridMasukBarang)
        Me.Name = "Masuk_Barang"
        Me.Text = "Masuk_Barang"
        CType(Me.DataGridMasukBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnHapusBarangMasuk As Button
    Friend WithEvents BtnAddBarangMasuk As Button
    Friend WithEvents DataGridMasukBarang As DataGridView
End Class
