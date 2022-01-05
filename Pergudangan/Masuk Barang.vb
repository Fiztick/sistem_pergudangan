Public Class Masuk_Barang
    Public Shared barang As barang
    Public Shared selectedTableMasukBarang As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        barang = New barang()
    End Sub

    Private Sub Masuk_Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDB()
    End Sub

    Private Sub ReloadDataTableDB()
        DataGridMasukBarang.DataSource = barang.GetDataBarangMasuk()
    End Sub

    Private Sub BtnAddBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnAddBarangMasuk.Click
        Add_Barang_Masuk.Show()
    End Sub

    Private Sub BtnHapusBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnHapusBarangMasuk.Click
        If selectedTableMasukBarang = 0 Then
            MessageBox.Show("Tolong pilih data yang ingin di hapus")
        Else
            barang.idBarangMasukProperty = selectedTableMasukBarang
            Hapus_Barang_Masuk.Show()
        End If
    End Sub

    Private Sub DataGridMasukBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridMasukBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        selectedRow = DataGridMasukBarang.Rows(index)
        selectedTableMasukBarang = selectedRow.Cells(0).Value
    End Sub
End Class