Imports System.Data.OleDb
Public Class Transaksi_Pengembalian
    Sub bersih_transaksi()
        txtIDBuku.Clear()
        txtnamabuku.Clear()
        txttglpinjam.Clear()
        txtdipinjam.Clear()
        txtidpinjam.Clear()
        txtlamapinjam.Clear()
        txtterlambat.Clear()
        txtdenda.Clear()
        txttotaldenda.Clear()
        txtIDBuku.Focus()
    End Sub
    Sub bersih_anggota()
        txtidagt.Clear()
        txtnamaagt.Clear()
        txtkelassis.Clear()
        txtidagt.Focus()
    End Sub

    Sub nomoroto()
        Call Koneksi()
        cmd = New OleDbCommand("Select * from tbl_kembali where id_kembali in (select max(id_kembali) from tbl_kembali)", conn)
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
        txtidkembali.Text = "KB" + UrutanKode
    End Sub

    Sub pengaturan()
        cmd = New OleDbCommand("select * from tbl_pengaturan where id='1'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtbataspinjamhari.Text = rd("batas_hari")
            txtdendaperhari.Text = rd("denda_hari")
        End If
    End Sub

    Sub hitung_total_denda()
        Dim hitung As Double
        For baris As Integer = 0 To dgvInputkembali.RowCount - 1
            hitung = hitung + dgvInputkembali.Rows(baris).Cells(6).Value
        Next
        txttotaldenda.Text = hitung
    End Sub

    Private Sub Transaksi_Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call bersih_transaksi()
        Call bersih_anggota()
        Call nomoroto()
        Call pengaturan()
        dgvInputkembali.Refresh()
        txtidagt.Clear()
        txtnamaagt.Clear()
        txtidagt.Focus()
        txttanggal.Text = Format(Now, "dd-MM-yyyy")
    End Sub

    Private Sub txtidagt_TextChanged(sender As Object, e As EventArgs) Handles txtidagt.TextChanged
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_anggota where id_anggota = '" & txtidagt.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnamaagt.Text = rd("nama_anggota")
            txtkelassis.Text = rd("kelas")

            da = New OleDbDataAdapter("select tbl_pinjam_detail.id_pinjam, tbl_pinjam_detail.id_buku, tbl_buku.Judul,penerbit from tbl_pinjam_detail,tbl_pinjam,tbl_buku where tbl_pinjam_detail.id_pinjam=tbl_pinjam.id_pinjam and tbl_buku.id_buku = tbl_pinjam_detail.id_buku and tbl_pinjam.id_anggota='" & txtidagt.Text & "' and tbl_pinjam_detail.keterangan = 'Dipinjam' ", conn)
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
        Else
            txtnamaagt.Clear()
            txtkelassis.Clear()
            If txtidagt.Text = "" Then
                dgvsedangpinjam.DataSource = ""
            End If
        End If
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Call bersih_transaksi()
        Call bersih_anggota()
        dgvInputkembali.Rows.Clear()
        If txtidagt.Text = "" Then
            dgvsedangpinjam.DataSource = ""
        End If
    End Sub

    Private Sub txtIDBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from qry_pinjam where id_anggota = '" & txtidagt.Text & "' and id_buku='" & txtIDBuku.Text & "' and keterangan = 'Dipinjam'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txtnamabuku.Text = rd("Judul")
                txttglpinjam.Text = Format(DateValue(rd.Item("tanggal_pinjam")), "dd-MM-yyyy")
                txtdipinjam.Text = rd("jumlah_pinjam")
                txtidpinjam.Text = rd("id_pinjam")
                'hitung lama pinjam
                Dim tgl1 As Date
                tgl1 = Format(DateValue(rd.Item("tanggal_pinjam")), "dd-MM-yyyy")
                If txttglpinjam.Text = Format(Today, "dd-MM-yyyy") Then
                    txtlamapinjam.Text = 0
                Else
                    txtlamapinjam.Text = DateAndTime.DateDiff(DateInterval.Day, tgl1, Today())
                End If

                'cari denda
                If Val(txtlamapinjam.Text) <= Val(txtbataspinjamhari.Text) Then
                    txtterlambat.Text = 0
                    txtdenda.Text = 0
                Else
                    txtterlambat.Text = Val(txtlamapinjam.Text) - Val(txtbataspinjamhari.Text)
                    txtdenda.Text = Val(txtdendaperhari.Text) * Val(txtterlambat.Text)
                End If
                txtdenda.Focus()
            Else
                MessageBox.Show("Anggota tidak pernah meminjam buku ini!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnaddkembali_Click(sender As Object, e As EventArgs) Handles btnaddkembali.Click
        If txtidagt.Text = "" Or txtnamaagt.Text = "" Or txtkelassis.Text = "" Then
            MessageBox.Show("Data Anggota Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtIDBuku.Text = "" Or txtnamabuku.Text = "" Or txtidpinjam.Text = "" Then
            MessageBox.Show("Data Buku Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dgvInputkembali.Rows.Add(txtIDBuku.Text, txtnamabuku.Text, txttglpinjam.Text, txtdipinjam.Text, txtidpinjam.Text, txtlamapinjam.Text, txtterlambat.Text, txtdenda.Text)
            Call bersih_transaksi()
            btnkembalibuku.Enabled = True
            For barisatas As Integer = 0 To dgvInputkembali.RowCount - 1
                For barisbawah As Integer = barisatas + 1 To dgvInputkembali.RowCount - 1
                    If dgvInputkembali.Rows(barisbawah).Cells(0).Value = dgvInputkembali.Rows(barisatas).Cells(0).Value Then
                        MessageBox.Show("Buku sudah dalam proses pengembalian !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dgvInputkembali.Rows.RemoveAt(barisbawah)
                        Exit Sub
                    End If
                Next
            Next
            Call bersih_transaksi()
            Call hitung_total_denda()
        End If
    End Sub

    Private Sub txtdenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdenda.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtidagt.Text = "" Or txtnamaagt.Text = "" Or txtkelassis.Text = "" Then
                MessageBox.Show("Data Anggota Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtIDBuku.Text = "" Or txtnamabuku.Text = "" Or txtidpinjam.Text = "" Then
                MessageBox.Show("Data Buku Belum diisi dengan benar !!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                dgvInputkembali.Rows.Add(txtIDBuku.Text, txtnamabuku.Text, txttglpinjam.Text, txtdipinjam.Text, txtidpinjam.Text, txtlamapinjam.Text, txtterlambat.Text, txtdenda.Text)
                Call bersih_transaksi()
                btnkembalibuku.Enabled = True
                For barisatas As Integer = 0 To dgvInputkembali.RowCount - 1
                    For barisbawah As Integer = barisatas + 1 To dgvInputkembali.RowCount - 1
                        If dgvInputkembali.Rows(barisbawah).Cells(0).Value = dgvInputkembali.Rows(barisatas).Cells(0).Value Then
                            MessageBox.Show("Buku sudah dalam proses pengembalian !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dgvInputkembali.Rows.RemoveAt(barisbawah)

                            Exit Sub
                        End If
                    Next
                Next
                Call bersih_transaksi()
                Call hitung_total_denda()
            End If
        End If
    End Sub

    Private Sub btnkembalibuku_Click(sender As Object, e As EventArgs) Handles btnkembalibuku.Click
        If txtidagt.Text = "" Or txtnamaagt.Text = "" Or dgvInputkembali.RowCount - 1 = 0 Then
            MessageBox.Show("Data Belum Lengkap !", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cmd = New OleDbCommand("insert into tbl_kembali values ('" & txtidkembali.Text &
                                                                "','" & txttanggal.Text &
                                                                "','" & txtidagt.Text &
                                                                "','" & txttotaldenda.Text &
                                                                "') ", conn)
            cmd.ExecuteNonQuery()

            For baris As Integer = 0 To dgvInputkembali.RowCount - 2
                'save ke tabel kembali detail
                cmd = New OleDbCommand("insert into tbl_kembali_detail values('" & txtidkembali.Text &
                                                                          "', '" & dgvInputkembali.Rows(baris).Cells(0).Value &
                                                                          "', '" & dgvInputkembali.Rows(baris).Cells(5).Value &
                                                                          "', '" & dgvInputkembali.Rows(baris).Cells(6).Value &
                                                                          "', '" & dgvInputkembali.Rows(baris).Cells(7).Value &
                                                                          "', '" & dgvInputkembali.Rows(baris).Cells(3).Value &
                                                                          "')", conn)
                cmd.ExecuteNonQuery()

                'penambahan nilai stok
                cmd = New OleDbCommand("select * from tbl_buku where id_buku = '" & dgvInputkembali.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                Dim tambahstok As String = "update tbl_buku set stok = '" & rd.Item("stok") + dgvInputkembali.Rows(baris).Cells(3).Value & "' where id_buku = '" & dgvInputkembali.Rows(baris).Cells(0).Value & "'"
                cmd = New OleDbCommand(tambahstok, conn)
                cmd.ExecuteNonQuery()

                'ubah status dipinjam jadi dikembalikan
                cmd = New OleDbCommand("select * from tbl_pinjam_detail where id_buku = '" & dgvInputkembali.Rows(baris).Cells(0).Value & "' and id_pinjam = '" & dgvInputkembali.Rows(baris).Cells(4).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    cmd = New OleDbCommand("update tbl_pinjam_detail set keterangan = 'Dikembalikan' where id_buku = '" & dgvInputkembali.Rows(baris).Cells(0).Value & "' and id_pinjam = '" & dgvInputkembali.Rows(baris).Cells(4).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Pengembalian Berhasil disimpan !", "Berhasil!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvInputkembali.Rows.Clear()
            Call bersih_transaksi()
            Call bersih_anggota()
            Call nomoroto()
        End If

    End Sub
End Class