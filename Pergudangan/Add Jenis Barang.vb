Public Class Add_Jenis_Barang
    Private Sub Add_Jenis_Barang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Jenis_Barang.Show()
    End Sub

    Private Sub BtnAddJenis_Click(sender As Object, e As EventArgs) Handles BtnAddJenis.Click
        Dim jenis = ComboBoxAddJenis.Text
        Dim satuan = ComboBoxAddSatuan.Text

        Jenis_Barang.barang.AddDataJenisBarangDB(jenis, satuan)
        Jenis_Barang.Activate()
    End Sub
End Class