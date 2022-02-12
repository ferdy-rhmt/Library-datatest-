Imports System.Data.OleDb
Public Class Transaksi_Peminjaman

    Sub kondisiawal()
        btnPinjamBuku.Enabled = False
        txtidagt.Focus()
        txtidagt.Text = "AGT"
        txtnamaagt.Text = ""
        txttotalpinjam.Text = "0"
        txtIDBuku.Text = ""
        txtnamabuku.Text = ""
        txtpenerbitbuku.Text = ""
        txttahunterbit.Text = ""
        txtjmlpinjam.Text = ""
        txtjmlpinjam.Enabled = False
        dgvInputPinjaman.Rows.Clear()
    End Sub

    Sub bersih()
        txtIDBuku.Text = ""
        txtnamabuku.Text = ""
        txtpenerbitbuku.Text = ""
        txttahunterbit.Text = ""
        txtjmlpinjam.Text = ""
        txtjmlpinjam.Enabled = False
    End Sub

    Sub nomorotomatis()
        Call Koneksi()
        cmd = New OleDbCommand("Select * from tbl_pinjam where id_pinjam in (select max(id_pinjam) from tbl_pinjam)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = Format(Now, "yyMMdd") + "01"
        Else
            Hitung = Microsoft.VisualBasic.Mid(rd.GetString(0), 8) + 1
            UrutanKode = Format(Now, "MMyydd") + Microsoft.VisualBasic.Right("00" & Hitung, 2)
        End If
        txtidpinjam.Text = "PJ" + UrutanKode
    End Sub

    Sub pengaturan()
        cmd = New OleDbCommand("select * from tbl_pengaturan where id='1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtbataspinjam.Text = rd.Item("batas_buku")
        End If
    End Sub

    Private Sub Transaksi_Peminjaman_Load(sender As Object, e As EventArgs) Handles Me.Load
        call kondisiawal()
        Call nomorotomatis()
        Call pengaturan()
        txttanggal.Text = Format(Now, "dd-MM-yyyy")
    End Sub

    Private Sub btnPinjamBuku_Click(sender As Object, e As EventArgs) Handles btnPinjamBuku.Click
        If txtidagt.Text = "" Or txtpjmsekarang.Text = "0" Then
            MessageBox.Show("Data Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'save ke database tbl_pinjam
        cmd = New OleDbCommand("insert into tbl_pinjam values('" & txtidpinjam.Text &
                                                            "', '" & txttanggal.Text &
                                                              "', '" & txtidagt.Text & "') ", conn)
        cmd.ExecuteNonQuery()

        For baris As Integer = 0 To dgvInputPinjaman.RowCount - 2
            'save ke database tbl_pinjam_detail
            cmd = New OleDbCommand("insert into tbl_pinjam_detail values('" & txtidpinjam.Text & "', '" & dgvInputPinjaman.Rows(baris).Cells(0).Value & "', 'Dipinjam', '" & dgvInputPinjaman.Rows(baris).Cells(4).Value & "', '" & MainForm.lblNamaAdmin.Text & "')", conn)
            cmd.ExecuteNonQuery()

            'pengurangan nilai stok
            cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & dgvInputPinjaman.Rows(baris).Cells(0).Value & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            Dim kurangistok As String = "update tbl_buku set stok = '" & rd.Item("stok") - dgvInputPinjaman.Rows(baris).Cells(4).Value & "' where id_buku = '" & dgvInputPinjaman.Rows(baris).Cells(0).Value & "'"
            cmd = New OleDbCommand(kurangistok, conn)
            cmd.ExecuteNonQuery()
        Next

        MessageBox.Show("Peminjaman Berhasil diSimpan!", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvInputPinjaman.Rows.Clear()
        Call bersih()
        Call nomorotomatis()
        Call kondisiawal()
        dgvsedangpinjam.Columns.Clear()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call kondisiawal()
    End Sub

    Private Sub txtidagt_TextChanged(sender As Object, e As EventArgs) Handles txtidagt.TextChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota = '" & txtidagt.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnamaagt.Text = rd("nama_anggota")
            txtkelassis.Text = rd("kelas")
            txtjurusansis.Text = rd("jurusan")

            'menampilkan history sedang pinjam
            da = New OleDbDataAdapter("select tbl_pinjam_detail.id_pinjam, tbl_pinjam_detail.id_buku, tbl_buku.Judul,penerbit from tbl_pinjam_detail,tbl_pinjam,tbl_buku where tbl_pinjam.id_pinjam=tbl_pinjam_detail.id_pinjam and tbl_buku.id_buku = tbl_pinjam_detail.id_buku and tbl_pinjam.id_anggota='" & txtidagt.Text & "' and tbl_pinjam_detail.keterangan = 'Dipinjam' ", conn)
            ds = New DataSet
            da.Fill(ds)
            dgvsedangpinjam.DataSource = ds.Tables(0)
            dgvsedangpinjam.ReadOnly = True
            dgvsedangpinjam.Columns(0).HeaderText = "ID Pinjam"
            dgvsedangpinjam.Columns(0).Width = 70
            dgvsedangpinjam.Columns(1).HeaderText = "ID Buku"
            dgvsedangpinjam.Columns(1).Width = 60
            dgvsedangpinjam.Columns(2).HeaderText = "Judul Buku"
            dgvsedangpinjam.Columns(3).Width = 150
            txttotalpinjam.Text = dgvsedangpinjam.RowCount - 1

            'batas pinjam
            If Val(txttotalpinjam.Text) > Val(txtbataspinjam.Text) Then
                MessageBox.Show("Pinjaman sudah Maximal!, Anggota ini tidak boleh meminjam lagi", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                dgvInputPinjaman.Rows.Clear()
                Call kondisiawal()
                txtidagt.Focus()
            End If
        Else
            txtnamaagt.Clear()
            txtkelassis.Clear()
            txtjurusansis.Clear()
        End If
    End Sub

    Private Sub txtIDBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & txtIDBuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txtnamabuku.Text = rd.Item("Judul")
                txtpenerbitbuku.Text = rd.Item("penerbit")
                txttahunterbit.Text = rd.Item("tahun_terbit")
                txtjmlpinjam.Focus()
                If Val(rd.Item("stok")) = 0 Then
                    MessageBox.Show("Stok Buku Habis!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtjmlpinjam.Text = ""
                    Call bersih()
                    btnPinjamBuku.Enabled = False
                Else
                    txtjmlpinjam.Text = "1"
                    txtjmlpinjam.Enabled = True
                    txtjmlpinjam.Focus()
                End If
            Else
                MessageBox.Show("Kode Buku Tidak terdaftar di Sistem!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call bersih()
            End If
        End If
    End Sub

    Private Sub txtjmlpinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjmlpinjam.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtjmlpinjam.Text) < 1 Then
                txtjmlpinjam.Text = "1"
            End If
            If txtidagt.Text = "" Or txtIDBuku.Text = "" Then
                MessageBox.Show("Data Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'batas pinjam
            If Val(txttotalpinjam.Text) > Val(txtbataspinjam.Text) Then
                MessageBox.Show("Pinjaman sudah Maximal !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call bersih()
                Exit Sub
            End If

            Dim baris1 As Integer = dgvInputPinjaman.RowCount - 1
            Dim id_buku As String = txtIDBuku.Text

            'cegah pinjaman buku yg sama 2 kali
            cmd = New OleDbCommand("select id_buku from tbl_pinjam_detail,tbl_pinjam,tbl_anggota where tbl_pinjam.id_pinjam = tbl_pinjam_detail.id_pinjam and tbl_pinjam.id_anggota = tbl_anggota.id_anggota and tbl_pinjam_detail.id_buku='" & id_buku & "' and tbl_pinjam.id_anggota='" & txtidagt.Text & "' and tbl_pinjam_detail.keterangan='Dipinjam'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MessageBox.Show("Buku ini sedang Dipinjam oleh Anggota ini !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            'tampil data buku yg akan dipinjam
            cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & txtIDBuku.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                dgvInputPinjaman.Rows.Add(txtIDBuku.Text, txtnamabuku.Text, txtpenerbitbuku.Text, txttahunterbit.Text, txtjmlpinjam.Text)
                Call bersih()
                btnPinjamBuku.Enabled = True
                'cegah data double
                For barisatas As Integer = 0 To dgvInputPinjaman.RowCount - 1
                    For barisbawah As Integer = barisatas + 1 To dgvInputPinjaman.RowCount - 1
                        If dgvInputPinjaman.Rows(barisbawah).Cells(0).Value = dgvInputPinjaman.Rows(barisatas).Cells(0).Value Then
                            MessageBox.Show("Buku sudah ada dalam Transaksi !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dgvInputPinjaman.Rows.RemoveAt(barisbawah)
                            Exit Sub
                        End If
                    Next
                Next
            End If

            'tampil total dipinjam
            txtpjmsekarang.Text = dgvInputPinjaman.RowCount - 1
            txttotalpinjam.Text = txtpjmsekarang.Text + dgvsedangpinjam.RowCount - 1
        End If
    End Sub

    Private Sub txtjmlpinjam_TextChanged(sender As Object, e As EventArgs) Handles txtjmlpinjam.TextChanged
        If Val(txtjmlpinjam.Text) > 1 Then
            MessageBox.Show("Hanya Boleh Meminjam 1 Buku !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtjmlpinjam.Text = "1"
        End If
    End Sub
End Class