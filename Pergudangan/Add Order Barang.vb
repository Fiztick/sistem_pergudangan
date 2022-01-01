Public Class Add_Order_Barang
    Public Shared selectedTableViewBarang
    Public Shared selectedTableViewBarangIdBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDB()

        DateTimeOrder.Format = DateTimePickerFormat.Custom
        DateTimeOrder.CustomFormat = "yyyy/MM/dd"
        DateTimeOrder.Value = Today
        DateTimeOrder.Enabled = False
        TextBoxIdBarang.Enabled = False
    End Sub

    Public Sub ReloadDataTableDB()
        DataGridViewBarang.DataSource = Order_Barang.barang.GetDataBarangGudangDB
    End Sub

    Private Sub BtnOrderBarang_Click(sender As Object, e As EventArgs) Handles BtnOrderBarang.Click
        Dim idBarang = TextBoxIdBarang.Text
        Dim jumlahOrder = TextBoxJumlahOrder.Text
        Dim tanggalOrder = DateTimeOrder.Value.ToShortDateString

        If selectedTableViewBarang = 0 Then
            MessageBox.Show("Tolong pilih data barang yang ingin di order")
        Else
            Order_Barang.barang.AddDataOrderBarangDB(idBarang, tanggalOrder, jumlahOrder)
            Order_Barang.Activate()
        End If
    End Sub

    Private Sub DataGridViewBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridViewBarang.Rows(index)
        selectedTableViewBarang = selectedrow.Cells(0).Value

        TextBoxIdBarang.Text = selectedTableViewBarang
    End Sub
End Class