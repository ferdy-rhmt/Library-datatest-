Imports System.Data.OleDb
Public Class Data_Master_Anggotafr_Add
    Sub bersih()
        txtNamaAnggota.Text = ""
        cmbkelas1.SelectedIndex = 0
        cmbkelas2.SelectedIndex = 0
        cmbjurusan.SelectedIndex = 0
    End Sub
    Sub kondisi_awal()
        txtIDanggota.ReadOnly = True
        txtNamaAnggota.PlaceholderText = "Nama Siswa"
    End Sub

    Sub autonumber()
        cmd = New OleDbCommand("Select * From tbl_anggota where id_anggota in (select max(id_anggota) from tbl_anggota)", conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            UrutanKode = "00001"
        Else
            Hitung = Microsoft.VisualBasic.Mid(rd.GetString(0), 8) + 1
            UrutanKode = Microsoft.VisualBasic.Mid("000000" & Hitung, 3)
        End If
        txtIDanggota.Text = "AGT" + UrutanKode
    End Sub

    Private Sub Data_Master_RakBukufr_Add_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Call autonumber()
        Me.Refresh()
        Call kondisi_awal()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmAdd_Click(sender As Object, e As EventArgs) Handles btnConfirmAdd.Click
        If txtIDanggota.Text = "" Or txtNamaAnggota.Text = "" Then
            custMsgBoxx.lblMessage.Text = "Data Tidak Lengkap!"
            custMsgBoxx.ShowDialog()
        Else
            Call Koneksi()
            cmd = New OleDbCommand("insert into tbl_anggota values ('" & txtIDanggota.Text &
                                                                 "','" & txtNamaAnggota.Text &
                                                                 "','" & cmbkelas1.Text + "." + cmbkelas2.Text &
                                                                 "','" & cmbjurusan.Text &
                                                                 "')", conn)
            cmd.ExecuteNonQuery()
            Data_Master_Anggotafr.dgvAddAnggota.Refresh()
            custMsgBoxx.IconMessage.Image = Library.My.Resources.Resources.checked
            custMsgBoxx.lblMessage.Text = "Input Berhasil!"
            custMsgBoxx.ShowDialog()
            Data_Master.btnDataAnggota.PerformClick()
            Call autonumber()
            Call bersih()
        End If
    End Sub
End Class