Public Class Order_Barang
    Public Shared barang As barang
    Public Shared selectedTableOrderBarang As Integer

    Private Sub Order_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        barang = New barang()
        ReloadDataTableDB()
    End Sub

    Private Sub ReloadDataTableDB()
        DataGridOrderBarang.DataSource = barang.GetDataOrderBarangDB()
    End Sub

    Private Sub BtnAddOrder_Click(sender As Object, e As EventArgs) Handles BtnAddOrder.Click
        Add_Order_Barang.Show()
    End Sub

    Private Sub BtnHapusOrder_Click(sender As Object, e As EventArgs) Handles BtnHapusOrder.Click
        If selectedTableOrderBarang = 0 Then
            MessageBox.Show("Pilih order yang akan dihapus!")
        Else
            Hapus_Order_Barang.Show()
        End If
    End Sub

    Private Sub datagridorderbarang_cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOrderBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridOrderBarang.Rows(index)
        selectedTableOrderBarang = selectedrow.Cells(0).Value

        barang.idBarangProperty = selectedTableOrderBarang
    End Sub

    Private Sub DataGridOrderBarang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOrderBarang.CellContentClick

    End Sub
End Class