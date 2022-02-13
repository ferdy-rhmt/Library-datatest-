Imports System.Data.OleDb
Public Class Data_Master_Adminfr_Add
    Sub bersih()
        txtNameAdmin.Text = ""
        txtpassw.Text = ""
        txtretypepassw.Text = ""
    End Sub
    Sub nomoroto()
        Dim urutan As String
        Dim hitung As Long
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_admin where id_admin in (select max(id_admin) from tbl_admin)", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "001"
        Else
            hitung = Microsoft.VisualBasic.Mid(rd.GetString(0), 6) + 1
            urutan = Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        txtidadmin.Text = "adm" + urutan
    End Sub

    Private Sub Data_Master_RakBukufr_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Call nomoroto()
        Me.Refresh()
        Call bersih()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        Me.Close()
    End Sub

    Private Sub btnshowpass1_Click(sender As Object, e As EventArgs) Handles btnshowpass1.Click
        If txtpassw.UseSystemPasswordChar = True Then
            txtpassw.UseSystemPasswordChar = False
        Else
            txtpassw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnshowpass2_Click(sender As Object, e As EventArgs) Handles btnshowpass2.Click
        If txtretypepassw.UseSystemPasswordChar = True Then
            txtretypepassw.UseSystemPasswordChar = False
        Else
            txtretypepassw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnConfirmAdd_Click(sender As Object, e As EventArgs) Handles btnConfirmAdd.Click
        If txtpassw.Text <> txtretypepassw.Text Then
            MessageBox.Show("Password tidak sama!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Koneksi()
            cmd = New OleDbCommand("insert into tbl_admin values ('" & txtidadmin.Text &
                                                      "','" & txtNameAdmin.Text &
                                                      "','" & txtretypepassw.Text &
                                                      "','" & cblevel.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Data_Master_Adminfr.dgvAddAdmin.Refresh()
            Data_Master.btnDataAdmin.PerformClick()
            Call nomoroto()
            Call bersih()
        End If
    End Sub
End Class