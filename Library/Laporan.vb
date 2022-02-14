Public Class Laporan
    Private Sub btnLaporanPeminjaman_Click(sender As Object, e As EventArgs) Handles btnLaporanPeminjaman.Click
        forminpanel(New Laporan_Peminjaman_Hari)
    End Sub

    Private Sub btnLaporanPengembalian_Click(sender As Object, e As EventArgs) Handles btnLaporanPengembalian.Click
        forminpanel(New Laporan_Pengembalian_Hari)
    End Sub
End Class