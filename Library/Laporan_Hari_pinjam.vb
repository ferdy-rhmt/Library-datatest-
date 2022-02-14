Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Hari_pinjam

    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        date1.Value = Format(Today, "dd-MM-yyyy")
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        Try
            Dim laporan As New lap_pinjam
            Dim cryrpt As New ReportDocument
            cryrpt = laporan

            Laporan_Peminjaman_Hari.CrystalReportViewer1.SelectionFormula = "({tbl_pinjam.tanggal_pinjam})=#" & date1.Text & "#"
            forminpanel(Laporan_Peminjaman_Hari)
            Laporan_Peminjaman_Hari.CrystalReportViewer1.ReportSource = cryrpt
            Laporan_Peminjaman_Hari.CrystalReportViewer1.Refresh()
            Laporan_Peminjaman_Hari.CrystalReportViewer1.RefreshReport()
            Laporan_Peminjaman_Hari.CrystalReportViewer1.Zoom(75)
        Catch ex As Exception

        End Try
    End Sub
End Class