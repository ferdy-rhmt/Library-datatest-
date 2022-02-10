Public Class Transaksi
    Private Sub btnTransaksiPeminjaman_Click(sender As Object, e As EventArgs) Handles btnTransaksiPeminjaman.Click
        forminpanel(New Transaksi_Peminjaman)
    End Sub

    Private Sub btnTransaksiPengembalian_Click(sender As Object, e As EventArgs) Handles btnTransaksiPengembalian.Click
        forminpanel(New Transaksi_Pengembalian)
    End Sub
End Class