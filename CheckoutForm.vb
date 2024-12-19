Public Class CheckoutForm
    Private totalBiaya As Decimal

    Public Sub New(total As Decimal)
        InitializeComponent()
        totalBiaya = total
    End Sub

    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTotal.Text = "Total Biaya: Rp" & totalBiaya.ToString("N2")
    End Sub

    Private Sub ButtonKonfirmasi_Click(sender As Object, e As EventArgs) Handles ButtonKonfirmasi.Click
        MessageBox.Show("Pembayaran berhasil. Terima kasih!")
        Me.Close()
    End Sub
End Class