Public Class Hapus_Barang_Gudang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblnamaBarang.Text = Barang_Gudang.barang.namaBarangProperty()
    End Sub

    Private Sub BtnYakin_Click(sender As Object, e As EventArgs) Handles BtnYakin.Click
        Barang_Gudang.barang.DeleteDataBarangByIDDB(Barang_Gudang.selectedTableBarang)
        Me.Close()
        Barang_Gudang.Activate()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class