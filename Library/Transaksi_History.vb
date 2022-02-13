Imports System.Data.OleDb
Public Class Transaksi_History
    Sub tampil()
        Call Koneksi()
        cmd = New OleDbCommand("Select * from qry_pinjam where keterangan = '" & lbljenis.Text & "'", conn)
        rd = cmd.ExecuteReader
        dgvhistory.Rows.Clear()
        Do While rd.Read = True
            dgvhistory.Rows.Add(rd.Item("id_pinjam"), rd.Item("tanggal_pinjam"), rd.Item("id_anggota"), rd.Item("nama_anggota"), rd.Item("id_buku"), rd.Item("Judul"), rd.Item("jumlah_pinjam"))
            txttotal.Text = dgvhistory.RowCount - 1
        Loop
    End Sub
    Private Sub Transaksi_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call tampil()
    End Sub

    Private Sub txt_keterangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_keterangan.SelectedIndexChanged

        If txt_keterangan.Text = "Peminjaman" Then
            lbljenis.Text = "Dipinjam"
            dgvhistory.Columns(0).HeaderText = "ID Pinjam"
            dgvhistory.Columns(1).HeaderText = "Tanggal Pinjam"
            dgvhistory.Columns(6).HeaderText = "Dipinjam"
            Call Koneksi()
            Call tampil()
        ElseIf txt_keterangan.Text = "Pengembalian" Then
            lbljenis.Text = "Dikembalikan"
            dgvhistory.Columns(0).HeaderText = "ID Kembali"
            dgvhistory.Columns(1).HeaderText = "Tanggal Kembali"
            dgvhistory.Columns(6).HeaderText = "Dikembalikan"
            Call Koneksi()
            Call tampil()
        Else

        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Call Koneksi()
        cmd = New OleDbCommand("Select * from qry_pinjam where nama_anggota like '%" & txtcari.Text & "%' and keterangan = '" & lbljenis.Text & "'", conn)
        rd = cmd.ExecuteReader
        dgvhistory.Rows.Clear()
        Do While rd.Read = True
            dgvhistory.Rows.Add(rd.Item("id_pinjam"), rd.Item("tanggal_pinjam"), rd.Item("id_anggota"), rd.Item("nama_anggota"), rd.Item("id_buku"), rd.Item("Judul"), rd.Item("jumlah_pinjam"))
        Loop
    End Sub
End Class