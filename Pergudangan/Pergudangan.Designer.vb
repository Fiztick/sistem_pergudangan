﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pergudangan
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
        Me.btnjenisBarang = New System.Windows.Forms.Button()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnOrderBarang = New System.Windows.Forms.Button()
        Me.BtnmasukBarang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnjenisBarang
        '
        Me.btnjenisBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjenisBarang.Location = New System.Drawing.Point(36, 95)
        Me.btnjenisBarang.Name = "btnjenisBarang"
        Me.btnjenisBarang.Size = New System.Drawing.Size(93, 43)
        Me.btnjenisBarang.TabIndex = 0
        Me.btnjenisBarang.Text = "Jenis Barang"
        Me.btnjenisBarang.UseVisualStyleBackColor = True
        '
        'BtnBarang
        '
        Me.BtnBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarang.Location = New System.Drawing.Point(135, 95)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(91, 43)
        Me.BtnBarang.TabIndex = 1
        Me.BtnBarang.Text = "Barang Gudang"
        Me.BtnBarang.UseVisualStyleBackColor = True
        '
        'BtnOrderBarang
        '
        Me.BtnOrderBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderBarang.Location = New System.Drawing.Point(232, 95)
        Me.BtnOrderBarang.Name = "BtnOrderBarang"
        Me.BtnOrderBarang.Size = New System.Drawing.Size(81, 43)
        Me.BtnOrderBarang.TabIndex = 2
        Me.BtnOrderBarang.Text = "Order Barang"
        Me.BtnOrderBarang.UseVisualStyleBackColor = True
        '
        'BtnmasukBarang
        '
        Me.BtnmasukBarang.Font = New System.Drawing.Font("Orbitron", 8.249999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnmasukBarang.Location = New System.Drawing.Point(319, 95)
        Me.BtnmasukBarang.Name = "BtnmasukBarang"
        Me.BtnmasukBarang.Size = New System.Drawing.Size(87, 43)
        Me.BtnmasukBarang.TabIndex = 3
        Me.BtnmasukBarang.Text = "Masuk Barang"
        Me.BtnmasukBarang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Orbitron", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Silahkan pilih salah satu form"
        '
        'Pergudangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 213)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnmasukBarang)
        Me.Controls.Add(Me.BtnOrderBarang)
        Me.Controls.Add(Me.BtnBarang)
        Me.Controls.Add(Me.btnjenisBarang)
        Me.Name = "Pergudangan"
        Me.Text = "Pergudangan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnjenisBarang As Button
    Friend WithEvents BtnBarang As Button
    Friend WithEvents BtnOrderBarang As Button
    Friend WithEvents BtnmasukBarang As Button
    Friend WithEvents Label1 As Label
End Class
