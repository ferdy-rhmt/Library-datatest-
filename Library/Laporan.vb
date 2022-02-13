Public Class Laporan
    Private Sub btnLaporanPeminjaman_Click(sender As Object, e As EventArgs) Handles btnLaporanPeminjaman.Click
        forminpanel(New laporan_peminjaman)
    End Sub

    Private Sub btnLaporanPengembalian_Click(sender As Object, e As EventArgs) Handles btnLaporanPengembalian.Click
        forminpanel(New laporan_pengembalian)
    End Sub
End Class