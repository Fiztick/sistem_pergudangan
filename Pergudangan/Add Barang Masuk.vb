Public Class Add_Barang_Masuk
    Public Shared selectedTableViewOrderBarang
    Public Shared selectedTableViewOrderBarangJumlahMasuk

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        TextBoxIdOrder.Enabled = False
    End Sub

    Private Sub Add_Barang_Masuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDB()
    End Sub

    Private Sub ReloadDataTableDB()
        DataGridViewOrderBarang.DataSource = Masuk_Barang.barang.GetDataOrderBarangDB()
    End Sub

    Private Sub DataGridViewOrderBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewOrderBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridViewOrderBarang.Rows(index)
        selectedTableViewOrderBarang = selectedrow.Cells(0).Value
        selectedTableViewOrderBarangJumlahMasuk = selectedrow.Cells(3).Value
        If IsDBNull(selectedTableViewOrderBarang) And IsDBNull(selectedTableViewOrderBarangJumlahMasuk) Then
            MessageBox.Show("Data Kosong")
        Else
            TextBoxIdOrder.Text = selectedTableViewOrderBarang
            TextBoxJumlahMasuk.Text = selectedTableViewOrderBarangJumlahMasuk
        End If
    End Sub

    Private Sub BtnAddBarangMasuk_Click(sender As Object, e As EventArgs) Handles BtnAddBarangMasuk.Click
        Dim idOrder = TextBoxIdOrder.Text
        Dim jumlahMasuk = TextBoxJumlahMasuk.Text
        Dim jumlahOrder As Integer

        If selectedTableViewOrderBarang = 0 Then
            MessageBox.Show("Tolong pilih data barang yang akan ditambahkan")
        Else
            Masuk_Barang.barang.AddDataMasukBarangDB(idOrder, jumlahMasuk)
            jumlahOrder = Masuk_Barang.barang.GetDataJumlahMasukOrderBarangByIDDB(idOrder)
            jumlahOrder = jumlahOrder - jumlahMasuk
            If jumlahOrder <= 0 Then
                Masuk_Barang.barang.UpdateStatusOrderBarangByIDDB(idOrder)
                Order_Barang.Activate()
                Masuk_Barang.Activate()
                Me.Activate()
            Else
                Masuk_Barang.barang.UpdateJumlahOrderBarangByIDDB(idOrder, jumlahOrder)
                Order_Barang.Activate()
                Masuk_Barang.Activate()
                Me.Activate()
            End If
            Me.Close()
        End If
    End Sub
End Class