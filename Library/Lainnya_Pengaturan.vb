Imports System.Data.OleDb
Public Class Lainnya_Pengaturan
    Sub tampil()
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_pengaturan where id = '1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtbatasbuku.Value = rd("batas_buku")
            txtbatashari.Value = rd("batas_hari")
            txtdenda.Text = rd("denda_hari")
        End If
    End Sub
    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        Call tampil()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmAdd_Click(sender As Object, e As EventArgs) Handles btnConfirmAdd.Click
        If txtbatasbuku.Value = "0" Or txtbatashari.Value = "0" Or txtdenda.Text = "" Or txtdenda.Text = "0" Then
            MessageBox.Show("Pengaturan Tidak dapat disimpan!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd = New OleDbCommand("update tbl_pengaturan set id ='1', batas_buku ='" & txtbatasbuku.Value & "', batas_hari ='" & txtbatashari.Value & "', denda_hari ='" & txtdenda.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pengaturan Berhasil disimpan!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class