Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Laporan_Bulan_kembali
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
            Dim laporan As New lap_kembali_bulan
            Dim cryrpt As New ReportDocument
            Dim crtablelogoninfos As New TableLogOnInfos
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo

            Dim crtables As Tables
            Dim crtable As Table

            cryrpt = laporan

            With crconnectioninfo
                .ServerName = Application.StartupPath & "\Database\db.mdb"
                .DatabaseName = Application.StartupPath & "\Database\db.mdb"
                .UserID = ""
                .Password = ""
            End With
            crtables = cryrpt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            Call Koneksi()
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.SelectionFormula = "Month({tbl_total_kembali.tanggal_kembali})=" & Val(cmbbulan.Text) & " and Year({tbl_total_kembali.tanggal_kembali})= " & Val(tahunnn.Value)
            forminpanel(Laporan_Pengembalian_Bulan)
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.ReportSource = cryrpt
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.Refresh()
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.RefreshReport()
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.Zoom(75)
            Laporan_Pengembalian_Bulan.CrystalReportViewer1.Visible = True
        Catch ex As Exception

        End Try
    End Sub
End Class