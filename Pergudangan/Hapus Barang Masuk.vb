Public Class Hapus_Barang_Masuk
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblIdBarangMasuk.Text = Masuk_Barang.barang.idBarangMasukProperty
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnYakin_Click(sender As Object, e As EventArgs) Handles BtnYakin.Click
        Masuk_Barang.barang.DeleteDataMasukBarangByIDDB(Masuk_Barang.barang.idBarangMasukProperty)
        Me.Close()
    End Sub
End Class