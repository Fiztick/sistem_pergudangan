Public Class Edit_Jenis_Barang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxEditJenis.SelectedItem = Jenis_Barang.barang.jenisBarangProperty
        ComboBoxEditSatuan.SelectedItem = Jenis_Barang.barang.satuanProperty
    End Sub

    Private Sub BtnEditJenis_Click(sender As Object, e As EventArgs) Handles BtnEditJenis.Click
        Jenis_Barang.barang.jenisBarangProperty = ComboBoxEditJenis.Text
        Jenis_Barang.barang.satuanProperty = ComboBoxEditSatuan.Text

        Jenis_Barang.barang.UpdateDataJenisBarangByIDDB(Jenis_Barang.selectedTableJenisBarang,
                                                        Jenis_Barang.barang.jenisBarangProperty,
                                                        Jenis_Barang.barang.satuanProperty)

        Jenis_Barang.Activate()
    End Sub
End Class