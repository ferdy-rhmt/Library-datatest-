Imports System.Data.OleDb
Public Class Lainnya_Ubahpass
    Sub bersih()
        txtpassbaru.Text = ""
        txtpassbaruretype.Text = ""
    End Sub
    Sub tampil()
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_admin where id_admin = '" & txtid.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnama.Text = rd("nama_admin")
            txtpasslama.Text = rd("pwd")
        End If
    End Sub

    Sub set_level()
        If MainForm.lblleveladmin.Text = "Master" Then
            txtid.Enabled = True
            txtid.ReadOnly = False
        Else
            txtid.Enabled = False
            txtid.ReadOnly = True
        End If
    End Sub
    Private Sub Data_Master_RakBuku_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Me.Refresh()
        Call tampil()
        txtid.Text = MainForm.lblidadmin.Text
        Call set_level()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If txtid.Text = "" Or txtpassbaru.Text = "" Or txtpassbaruretype.Text = "" Then
            MessageBox.Show("Isi Data Dengan Benar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtpassbaru.Text <> txtpassbaruretype.Text Then
            MessageBox.Show("Password tidak sama!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Koneksi()
            cmd = New OleDbCommand("update tbl_admin set pwd = '" & txtpassbaruretype.Text & "' where id_admin ='" & txtid.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Password berhasil diubah !", "Berhasil!", MessageBoxButtons.OK)
            Call tampil()
            Call bersih()
        End If
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        Call tampil()
    End Sub
End Class