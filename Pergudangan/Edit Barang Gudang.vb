Public Class Edit_Barang_Gudang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNamaBarang.Text = Barang_Gudang.barang.namaBarangProperty
        TxtStock.Text = Barang_Gudang.barang.stockBarangProperty
        ComboBoxJenisBarang.SelectedItem = Barang_Gudang.barang.jenisBarangProperty
    End Sub

    Private Sub BtnEditBarang_Click(sender As Object, e As EventArgs) Handles BtnEditBarang.Click
        Barang_Gudang.barang.namaBarangProperty = TxtNamaBarang.Text
        Barang_Gudang.barang.stockBarangProperty = TxtStock.Text
        Barang_Gudang.barang.jenisBarangProperty = ComboBoxJenisBarang.Text

        Barang_Gudang.barang.UpdateDataBarangByIDDB(Barang_Gudang.selectedTableBarang,
                                                    Barang_Gudang.barang.jenisBarangProperty,
                                                    Barang_Gudang.barang.namaBarangProperty,
                                                    Barang_Gudang.barang.stockBarangProperty)

        Barang_Gudang.Activate()
    End Sub
End Class