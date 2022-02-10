Imports System.Data.OleDb
Public Class Data_Master_Bukufr_Editstok
    Sub bersih()
        txtnamabuku.Clear()
        txtpenerbit.Clear()
        txtterbit.Clear()
        txtidbuku.Focus()
        txtstok.Value = "1"
        txtstok.Enabled = False
    End Sub
    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        Call bersih()
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
            cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & txtidbuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            cmd = New OleDbCommand("update tbl_buku set stok = '" & txtstok.Value & "' where id_buku ='" & txtidbuku.Text & "'", conn)
            cmd.ExecuteNonQuery()

            Data_Master_Bukufr.dgvDaftarBuku.Refresh()
            custMsgBoxx.IconMessage.Image = Library.My.Resources.Resources.checked
            custMsgBoxx.lblMessage.Text = "Input Berhasil!"
            custMsgBoxx.ShowDialog()
            Data_Master.btnDataBuku.PerformClick()
        End If
    End Sub

    Private Sub txtstok_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub txtidbuku_TextChanged(sender As Object, e As EventArgs) Handles txtidbuku.TextChanged
        cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & txtidbuku.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txtnamabuku.Text = rd("Judul")
            txtpenerbit.Text = rd("penerbit")
            txtterbit.Text = rd("tahun_terbit")
            txtstok.Enabled = True
            txtstok.Value = rd("stok")
        Else
            Call bersih()
        End If
    End Sub
End Class