Public Class Jenis_Barang
    Public Shared barang As barang
    Public Shared selectedTableJenisBarang As Integer

    Private Sub Jenis_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        barang = New barang()
        ReloadDataTableDB()
    End Sub

    Private Sub ReloadDataTableDB()
        DataGridJenisBarang.DataSource = barang.GetDataJenisBarangDB
    End Sub

    Private Sub BtnAddJenis_Click(sender As Object, e As EventArgs) Handles BtnAddJenis.Click
        Add_Jenis_Barang.Show()
    End Sub

    Private Sub DataGridJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridJenisBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = DataGridJenisBarang.Rows(index)
        selectedTableJenisBarang = selectedRow.Cells(0).Value
    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        If selectedTableJenisBarang = 0 Then
            MessageBox.Show("Tolong pilih data yang ingin di update")
        Else
            Dim dataselected As List(Of String) = barang.GetDataJenisBarangByIDDB(selectedTableJenisBarang)

            barang.jenisBarangProperty = dataselected(0)
            barang.satuanProperty = dataselected(1)

            Edit_Jenis_Barang.Show()
        End If
    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        If selectedTableJenisBarang = 0 Then
            MessageBox.Show("Tolong pilih data yang ingin di hapus")
        Else
            Dim dataselected As List(Of String) = barang.GetDataJenisBarangByIDDB(selectedTableJenisBarang)

            barang.jenisBarangProperty = dataselected(0)

            Hapus_Jenis_Barang.Show()
        End If
    End Sub
End Class