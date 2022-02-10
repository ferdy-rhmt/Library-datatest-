Imports System.Data.OleDb
Public Class Data_Master_Bukufr
    Sub tampil_data_buku()
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_buku", conn)
        rd = cmd.ExecuteReader
        dgvDaftarBuku.Rows.Clear()
        Do While rd.Read = True
            dgvDaftarBuku.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub

    Private Sub btnAddrak_Click(sender As Object, e As EventArgs) Handles btnAddBuku.Click
        Data_Master_Bukufr_Add.ShowDialog()
        Data_Master_Bukufr_Add.Refresh()
    End Sub

    Private Sub Data_Master_Bukufr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil_data_buku()
    End Sub

    Private Sub btnDelBuku_Click(sender As Object, e As EventArgs) Handles btnDelBuku.Click
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_buku where id_buku like '%" & lblid.Text & "%' ", conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            If MessageBox.Show("Yakin ingin menghapus data " + lblid.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd = New OleDbCommand("delete * from tbl_buku where id_buku like '%" & lblid.Text & "%' ", conn)
                cmd.ExecuteNonQuery()
                Data_Master.btnDataBuku.PerformClick()
                Me.dgvDaftarBuku.Refresh()
            Else
            End If
        Else
            MessageBox.Show("Data telah dihapus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub dgvDaftarBuku_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDaftarBuku.CellMouseClick
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & dgvDaftarBuku.Rows(e.RowIndex).Cells(0).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblid.Text = rd.Item("id_buku")
    End Sub

    Private Sub txtcaribuku_TextChanged(sender As Object, e As EventArgs) Handles txtcaribuku.TextChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_buku where id_buku like '%" & txtcaribuku.Text & "%' ", conn)
        rd = cmd.ExecuteReader
        dgvDaftarBuku.Rows.Clear()
        Do While rd.Read = True
            dgvDaftarBuku.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub

    Private Sub btneditstok_Click(sender As Object, e As EventArgs) Handles btneditstok.Click
        Data_Master_Bukufr_Editstok.ShowDialog()
        Data_Master_Bukufr_Editstok.Refresh()
    End Sub
End Class