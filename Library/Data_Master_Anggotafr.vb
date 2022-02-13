Imports System.Data.OleDb
Public Class Data_Master_Anggotafr
    Sub Show_Data_Anggota()
        cmd = New OleDbCommand("select * from tbl_anggota", conn)
        rd = cmd.ExecuteReader
        dgvAddAnggota.Rows.Clear()
        Do While rd.Read = True
            dgvAddAnggota.Rows.Add(rd(0), rd(1), rd(2), rd(3))
        Loop
    End Sub
    Private Sub Data_Master_Anggotafr_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        Call Show_Data_Anggota()
    End Sub

    Private Sub btnAddAnggota_Click(sender As Object, e As EventArgs) Handles btnAddAnggota.Click
        'Database
        Data_Master_Anggotafr_Add.ShowDialog()
        Data_Master_Adminfr_Add.Refresh()
    End Sub

    Private Sub btnDelAnggota_Click(sender As Object, e As EventArgs) Handles btnDelAnggota.Click
        'Database
        cmd = New OleDbCommand("delete * from tbl_anggota where id_anggota like '%" & lblid.Text & "%' ", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil dihapus!")
        forminpanel(New Data_Master_Anggotafr)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcarinama.TextChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where nama_anggota like '%" & txtcarinama.Text & "%' ", conn)
        rd = cmd.ExecuteReader
        dgvAddAnggota.Rows.Clear()
        Do While rd.Read = True
            dgvAddAnggota.Rows.Add(rd(0), rd(1), rd(2), rd(3))
        Loop
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota like '%" & txtcarinama.Text & "%' ", conn)
        rd = cmd.ExecuteReader
        dgvAddAnggota.Rows.Clear()
        Do While rd.Read = True
            dgvAddAnggota.Rows.Add(rd(0), rd(1), rd(2), rd(3))
        Loop
    End Sub

    Private Sub dgvAddAnggota_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAddAnggota.CellMouseClick
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where nama_anggota = '" & dgvAddAnggota.Rows(e.RowIndex).Cells(1).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        lblid.Text = rd.Item("id_anggota")
    End Sub
End Class