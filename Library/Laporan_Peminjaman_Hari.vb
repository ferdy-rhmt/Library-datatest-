Public Class Laporan_Peminjaman_Hari
    Private Sub laporan_peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnPinjamBuku_Click(sender As Object, e As EventArgs) Handles btnPinjamBuku.Click
        If cbjenis.SelectedIndex = 0 Then
            Laporan_Hari_pinjam.ShowDialog()
        ElseIf cbjenis.SelectedIndex = 1 Then
            Laporan_Bulan_pinjam.ShowDialog()
            forminpanel(New Laporan_Pengembalian_Bulan)
        Else
            MessageBox.Show("Data Tidak Ada!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        CrystalReportViewer1.ExportReport()
    End Sub
End Class