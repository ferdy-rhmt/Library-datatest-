Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Laporan_Peminjaman_Hari

    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        date1.Value = Format(Today, "dd-MM-yyyy")
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Dim cryrpt As New ReportDocument
            Dim laporan As New lap_pinjam
            cryrpt = laporan

            laporan_peminjaman.CrystalReportViewer1.SelectionFormula = "({tbl_pinjam.tanggal_pinjam})='" & date1.Text & "'"
            forminpanel(laporan_peminjaman)
            laporan_peminjaman.CrystalReportViewer1.ReportSource = cryrpt
            laporan_peminjaman.CrystalReportViewer1.Refresh()
            laporan_peminjaman.CrystalReportViewer1.RefreshReport()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class