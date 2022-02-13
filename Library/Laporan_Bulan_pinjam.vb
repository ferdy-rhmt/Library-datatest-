Imports CrystalDecisions.CrystalReports.Engine
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
            Dim cryrpt As New ReportDocument
            Dim laporan As New lap_pinjam_bulan
            cryrpt = laporan

            laporan_peminjaman.CrystalReportViewer1.SelectionFormula = "Month({tbl_total_pinjam.tanggal_pinjam})=" & Val(cmbbulan.Text) & " and Year({tbl_total_pinjam.tanggal_pinjam})= " & Val(tahunnn.Value)
            forminpanel(laporan_peminjaman)
            laporan_peminjaman.CrystalReportViewer1.ReportSource = cryrpt
            laporan_peminjaman.CrystalReportViewer1.Refresh()
            laporan_peminjaman.CrystalReportViewer1.RefreshReport()
            laporan_peminjaman.CrystalReportViewer1.Zoom(75)
        Catch ex As Exception

        End Try
    End Sub
End Class