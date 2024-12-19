
Public Class MainForm
    ' Konstanta harga barang
    Private Const HARGA_PRODUK_A As Decimal = 100000
    Private Const HARGA_PRODUK_B As Decimal = 150000
    Private Const HARGA_PRODUK_C As Decimal = 200000

    ' Variabel untuk total biaya
    Private totalBiaya As Decimal = 0

    'Enumeration status pembayaran
    Private Enum StatusPembayaran
        BelumDibayar
        SudahDibayar
    End Enum

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxProduk.Items.AddRange(New String() {"Produk A", "Produk B", "Produk C"})
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim produk As String = ComboBoxProduk.SelectedItem
        Dim jumlah As Integer

        If Integer.TryParse(TextBoxJumlah.Text, jumlah) AndAlso jumlah > 0 Then
            Dim harga As Decimal
            Select Case produk
                Case "Produk A" : harga = HARGA_PRODUK_A
                Case "Produk B" : harga = HARGA_PRODUK_B
                Case "Produk C" : harga = HARGA_PRODUK_C
                Case Else
                    MessageBox.Show("Pilih produk yang valid.")
                    Exit Sub
            End Select

            totalBiaya += harga * jumlah
            DataGridViewKeranjang.Rows.Add(produk, jumlah, harga, harga * jumlah)
        Else
            MessageBox.Show("Masukkan jumlah yang valid.")
        End If
    End Sub
    Private Sub ButtonCheckout_Click(sender As Object, e As EventArgs) Handles ButtonCheckout.Click
        Dim checkoutForm As New CheckoutForm(totalBiaya)
        checkoutForm.ShowDialog()
    End Sub

End Class