Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Hari_kembali

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
            Dim cryrpt As New ReportDocument
            Dim laporan As New lap_kembali
            cryrpt = laporan

            laporan_pengembalian.CrystalReportViewer1.SelectionFormula = "({tbl_kembali.tanggal_kembali})=#" & date1.Text & "#"
            forminpanel(laporan_pengembalian)
            laporan_pengembalian.CrystalReportViewer1.ReportSource = cryrpt
            laporan_pengembalian.CrystalReportViewer1.Refresh()
            laporan_pengembalian.CrystalReportViewer1.RefreshReport()
            laporan_pengembalian.CrystalReportViewer1.Zoom(75)
        Catch ex As Exception

        End Try
    End Sub
End Class