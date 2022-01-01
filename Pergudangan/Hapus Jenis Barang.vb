Public Class Hapus_Jenis_Barang
    Private Sub Hapus_Jenis_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblJenis.Text = Jenis_Barang.barang.jenisBarangProperty
    End Sub

    Private Sub BtnYakin_Click(sender As Object, e As EventArgs) Handles BtnYakin.Click
        Jenis_Barang.barang.DeleteDataJenisBarangByIDDB(Jenis_Barang.selectedTableJenisBarang)
        Me.Close()
        Jenis_Barang.Activate()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class