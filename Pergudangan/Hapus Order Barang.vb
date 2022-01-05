Public Class Hapus_Order_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblIdOrder.Text = Order_Barang.selectedTableOrderBarang
    End Sub

    Private Sub BtnYakin_Click(sender As Object, e As EventArgs) Handles BtnYakin.Click
        Order_Barang.barang.DeleteDataOrderBarangByIDDB(Order_Barang.selectedTableOrderBarang)
        Me.Close()
        Order_Barang.Activate()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub
End Class