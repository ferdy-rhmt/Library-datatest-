Imports System.Data.OleDb
Public Class Data_Master_Bukufr_Add

    Sub autonumber()
        cmd = New OleDbCommand("Select * From tbl_buku where id_buku in (select max(id_buku) from tbl_buku)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "00001"
        Else
            Hitung = Microsoft.VisualBasic.Mid(rd.GetString(0), 7) + 1
            UrutanKode = Microsoft.VisualBasic.Mid("000000" & Hitung, 3)
        End If
        txtidbuku.Text = "BK" + UrutanKode
    End Sub
    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        Call autonumber()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmAdd_Click(sender As Object, e As EventArgs) Handles btnConfirmAdd.Click
        If txtidbuku.Text = "" Or txtnamabuku.Text = "" Then
            custMsgBoxx.lblMessage.Text = "Data Tidak Lengkap!"
            custMsgBoxx.ShowDialog()
        Else
            Call Koneksi()
            cmd = New OleDbCommand("insert into tbl_buku values ('" & txtidbuku.Text &
                                                                 "','" & txtnamabuku.Text &
                                                                 "','" & txtpenerbit.Text &
                                                                 "','" & txtterbit.Text &
                                                                 "','" & txtstok.Text &
                                                                 "')", conn)
            cmd.ExecuteNonQuery()
            Data_Master_Bukufr.dgvDaftarBuku.Refresh()
            custMsgBoxx.IconMessage.Image = Library.My.Resources.Resources.checked
            custMsgBoxx.lblMessage.Text = "Input Berhasil!"
            custMsgBoxx.ShowDialog()
            Data_Master.btnDataBuku.PerformClick()
        End If
    End Sub

    Private Sub txtterbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtterbit.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class