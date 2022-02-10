Imports System.Data.OleDb
Public Class laporan_peminjaman
    Private Sub laporan_peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MunculData()
    End Sub

    Private Sub MunculData()
        Call Koneksi()
        da = New OleDbDataAdapter("Select Kode,Nama_Buku,Nama_Siswa,Kelas_Siswa,Lama_Pinjam,Tanggal from tbl_bukudipinjam", conn)
        ds = New DataSet
        da.Fill(ds, "tbl_bukudipinjam")
        dgvDaftarPinjaman.DataSource = ds.Tables("tbl_bukudipinjam")
    End Sub
End Class