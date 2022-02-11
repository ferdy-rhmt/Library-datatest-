Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Login_Admin.ShowDialog()
        Call KondisiAwal_Mainform()
    End Sub


#Region "Menu Button"
    Private Sub btnDataMaster_Click(sender As Object, e As EventArgs) Handles btnDataMaster.Click
        If lblleveladmin.Text = "Master" Then
            Data_Master.btnDataAdmin.Enabled = True
            Data_Master.btnDataAnggota.Enabled = True
            Data_Master.btnDataBuku.Enabled = True
        Else
            Data_Master.btnDataAdmin.Enabled = False
            Data_Master.btnDataAnggota.Enabled = False
            Data_Master.btnDataBuku.Enabled = False
        End If
        Call btnData_Master_cl()
        forminpanel(Data_Master)
    End Sub
    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        Call btnTransaksi_cl()
        forminpanel(Transaksi)
    End Sub
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Call btnLaporan_cl()
        forminpanel(Laporan)
    End Sub
    Private Sub btnLainnya_Click(sender As Object, e As EventArgs) Handles btnLainnya.Click
        Call btnLainnya_cl()
        forminpanel(Lainnya)
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call btnLogout_cl()
    End Sub
#End Region


    Private Sub btnOpenside_Click(sender As Object, e As EventArgs) Handles btnOpenside.Click
        Call OpenSide()
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class