<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Jenis_Barang
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
        Me.BtnAddJenis = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxAddSatuan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxAddJenis = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnAddJenis
        '
        Me.BtnAddJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddJenis.Location = New System.Drawing.Point(380, 162)
        Me.BtnAddJenis.Name = "BtnAddJenis"
        Me.BtnAddJenis.Size = New System.Drawing.Size(90, 25)
        Me.BtnAddJenis.TabIndex = 7
        Me.BtnAddJenis.Text = "Add Jenis"
        Me.BtnAddJenis.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Silahkan Pilih Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jenis Barang"
        '
        'ComboBoxAddSatuan
        '
        Me.ComboBoxAddSatuan.FormattingEnabled = True
        Me.ComboBoxAddSatuan.Items.AddRange(New Object() {"Box", "Pcs", "Liter", "Unit", "", ""})
        Me.ComboBoxAddSatuan.Location = New System.Drawing.Point(195, 122)
        Me.ComboBoxAddSatuan.Name = "ComboBoxAddSatuan"
        Me.ComboBoxAddSatuan.Size = New System.Drawing.Size(275, 21)
        Me.ComboBoxAddSatuan.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Satuan"
        '
        'ComboBoxAddJenis
        '
        Me.ComboBoxAddJenis.FormattingEnabled = True
        Me.ComboBoxAddJenis.Items.AddRange(New Object() {"Susu", "Pakain", "Beras", "ATK", "Alat Mandi", "Alat Makan"})
        Me.ComboBoxAddJenis.Location = New System.Drawing.Point(195, 78)
        Me.ComboBoxAddJenis.Name = "ComboBoxAddJenis"
        Me.ComboBoxAddJenis.Size = New System.Drawing.Size(275, 21)
        Me.ComboBoxAddJenis.TabIndex = 9
        '
        'Add_Jenis_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 261)
        Me.Controls.Add(Me.ComboBoxAddJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAddJenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxAddSatuan)
        Me.Name = "Add_Jenis_Barang"
        Me.Text = "Add_Jenis_Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddJenis As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxAddSatuan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxAddJenis As ComboBox
End Class
