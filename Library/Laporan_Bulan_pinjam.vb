Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Laporan_Bulan_pinjam
    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        tahunnn.Value = Format(Today, "yyyy")
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        Try
            Dim laporan As New lap_pinjam_bulan
            Dim cryrpt As New ReportDocument
            cryrpt = laporan

            laporan_peminjaman_bulan.CrystalReportViewer1.SelectionFormula = "Month({tbl_total_pinjam.tanggal_pinjam})=" & Val(cmbbulan.Text) & " and Year({tbl_total_pinjam.tanggal_pinjam})= " & Val(tahunnn.Value)
            forminpanel(laporan_peminjaman_bulan)
            laporan_peminjaman_bulan.CrystalReportViewer1.ReportSource = cryrpt
            laporan_peminjaman_bulan.CrystalReportViewer1.Refresh()
            laporan_peminjaman_bulan.CrystalReportViewer1.RefreshReport()
            laporan_peminjaman_bulan.CrystalReportViewer1.Zoom(75)
        Catch ex As Exception

        End Try
    End Sub
End Class