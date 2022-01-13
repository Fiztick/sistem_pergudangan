Public Class Barang_Gudang
    Public Shared barang As barang
    Public Shared selectedTableBarang As Integer
    Public Shared selectedTableJenisBarang

    Private Sub Barang_Gudang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        barang = New barang()
        ReloadDataTableDB()
    End Sub

    Private Sub ReloadDataTableDB()
        DataGridBarangGudang.DataSource = barang.GetDataBarangGudangDB()
    End Sub

    Private Sub BtnAddBarang_Click(sender As Object, e As EventArgs) Handles BtnAddBarang.Click
        Add_Barang_Gudang.Show()
    End Sub

    Private Sub DataGridBarangGudang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBarangGudang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = DataGridBarangGudang.Rows(index)
        selectedTableBarang = selectedRow.Cells(0).Value
        selectedTableJenisBarang = selectedRow.Cells(1).Value
        ' Cek jika DB kosong
        If IsDBNull(selectedTableJenisBarang) Then
            MessageBox.Show("Data Kosong")
        Else
            selectedTableJenisBarang = barang.GetIDJenisBarangByJenisBarang(selectedTableJenisBarang)
        End If
    End Sub

    Private Sub BtnEditBarang_Click(sender As Object, e As EventArgs) Handles BtnEditBarang.Click
        If selectedTableBarang = 0 And selectedTableJenisBarang = 0 Then
            MessageBox.Show("Tolong pilih data yang ingin di update")
        Else
            Dim dataselected As List(Of String) = barang.GetDataBarangByIDDB(selectedTableBarang, selectedTableJenisBarang)

            barang.jenisBarangProperty = dataselected(0)
            barang.namaBarangProperty = dataselected(1)
            barang.stockBarangProperty = dataselected(2)

            Edit_Barang_Gudang.Show()
        End If
    End Sub

    Private Sub BtnHapusBarang_Click(sender As Object, e As EventArgs) Handles BtnHapusBarang.Click
        If selectedTableBarang = 0 Then
            MessageBox.Show("Tolong pilih data yang ingin di hapus")
        Else
            Dim dataselected As List(Of String) = barang.GetDataBarangByIDDB(selectedTableBarang, selectedTableJenisBarang)

            barang.namaBarangProperty = dataselected(1)

            Hapus_Barang_Gudang.Show()
        End If
    End Sub

    Private Sub Barang_Gudang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Pergudangan.Show()
    End Sub
End Class