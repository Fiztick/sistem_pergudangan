Public Class Pergudangan
    Private Sub Pergudangan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
    End Sub

    Private Sub btnjenisBarang_Click(sender As Object, e As EventArgs) Handles btnjenisBarang.Click
        Jenis_Barang.Show()
    End Sub

    Private Sub BtnBarangGudang_Click(sender As Object, e As EventArgs) Handles BtnBarangGudang.Click
        Barang_Gudang.Show()
    End Sub

    Private Sub BtnOrderBarang_Click(sender As Object, e As EventArgs) Handles BtnOrderBarang.Click
        Order_Barang.Show()
    End Sub

    Private Sub BtnmasukBarang_Click(sender As Object, e As EventArgs) Handles BtnmasukBarang.Click
        Masuk_Barang.Show()
    End Sub
End Class