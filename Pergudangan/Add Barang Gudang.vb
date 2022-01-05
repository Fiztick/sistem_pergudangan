Public Class Add_Barang_Gudang
    Private Sub BtnAddBarang_Click(sender As Object, e As EventArgs) Handles BtnAddBarang.Click
        Dim namaBarang = TxtNamaBarang.Text
        Dim jenisBarang = ComboBoxJenisBarang.Text
        Dim stockBarang = TxtStock.Text

        Barang_Gudang.barang.AddDataBarangDB(jenisBarang, namaBarang, stockBarang)
        Barang_Gudang.Activate()
        Me.Close()
    End Sub
End Class