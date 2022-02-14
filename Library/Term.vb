Imports System.Data.OleDb
Module Term

    Public conn As New OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public rd As OleDbDataReader
    Public cmd As OleDbCommand
    Public mydb As String
    Public Sub Koneksi()
        Try
            mydb = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=Database\db.mdb"
            conn = New OleDbConnection(mydb)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error Database")
        End Try
    End Sub


    'function for loaded Form for the first time
    '//////////Main Form 
    Public Sub KondisiAwal_Mainform()
        MainForm.pnlkiri.Width = 270
        MainForm.lblhover1.Visible = False
        MainForm.lblhover2.Visible = False
        MainForm.lblhover3.Visible = False
        MainForm.lblhover4.Visible = False
    End Sub
    '/////////Login Admin
    Public Sub KondisiAwal_LoginAdmin()
        Login_Admin.Guna2ShadowForm1.SetShadowForm(Login_Admin)
        Login_Admin.txtusername.Text = ""
        Login_Admin.txtpassword.Text = ""
        Login_Admin.txtusername.PlaceholderText = "ID Admin"
        Login_Admin.txtpassword.PlaceholderText = "Password"
    End Sub
    Public Sub LoginAdmin_loadedTR()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Login_Admin)
        Login_Admin.Visible = False
        Login_Admin.Guna2AnimateWindow1.SetAnimateWindow(Login_Admin)
        Login_Admin.Guna2ShadowForm1.SetShadowForm(Login_Admin)
        Call KondisiAwal_LoginAdmin()
        Login_Admin.txtusername.Focus()
    End Sub


    'function for active square 
    Public Sub Hover1()
        MainForm.lblhover1.Visible = True
        MainForm.lblhover2.Visible = False
        MainForm.lblhover3.Visible = False
        MainForm.lblhover4.Visible = False
    End Sub
    Public Sub Hover2()
        MainForm.lblhover1.Visible = False
        MainForm.lblhover2.Visible = True
        MainForm.lblhover3.Visible = False
        MainForm.lblhover4.Visible = False
    End Sub
    Public Sub Hover3()
        MainForm.lblhover1.Visible = False
        MainForm.lblhover2.Visible = False
        MainForm.lblhover3.Visible = True
        MainForm.lblhover4.Visible = False
    End Sub
    Public Sub Hover4()
        MainForm.lblhover1.Visible = False
        MainForm.lblhover2.Visible = False
        MainForm.lblhover3.Visible = False
        MainForm.lblhover4.Visible = True
    End Sub
    Public Sub Hover5()
        MainForm.lblhover1.Visible = False
        MainForm.lblhover2.Visible = False
        MainForm.lblhover3.Visible = False
        MainForm.lblhover4.Visible = False
    End Sub



    'function for make panel as parent form
    Public Sub forminpanel(ByVal newform As Object)
        If MainForm.panelcont.Controls.Count > 0 Then
            MainForm.panelcont.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(newform, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        MainForm.panelcont.Controls.Add(fh)
        MainForm.panelcont.Tag = fh
        fh.Show()
    End Sub



    'function for Side Menu Button
    Public Sub OpenSide()
        If MainForm.pnlkiri.Width = 270 Then
            MainForm.pnlkiri.Visible = False
            MainForm.BunifuTransition1.Show(MainForm.pnlkiri)
            MainForm.pnlkiri.Width = 90
            MainForm.lblmenuutama.Text = "Menu"
            MainForm.btnDataMaster.Text = ""
            MainForm.btnLaporan.Text = ""
            MainForm.btnTransaksi.Text = ""
            MainForm.btnLainnya.Text = ""
            MainForm.btnLogout.Text = ""
        Else
            MainForm.pnlkiri.Visible = False
            MainForm.BunifuTransition2.Show(MainForm.pnlkiri)
            MainForm.pnlkiri.Width = 270
            MainForm.lblmenuutama.Text = "Menu Utama"
            MainForm.btnDataMaster.Text = "    Data Master"
            MainForm.btnLaporan.Text = "    Laporan"
            MainForm.btnTransaksi.Text = "    Transaksi"
            MainForm.btnLainnya.Text = "    Other"
            MainForm.btnLogout.Text = "    Logout"
        End If
    End Sub



    'function for Menu Button
    Public Sub btnData_Master_cl()
        Call Hover1()
        MainForm.lblnamamenu.Text = "Data Master"
        MainForm.lblnamamenu.Visible = True
        Transaksi.Close()
        Laporan.Close()
        Lainnya.Close()
    End Sub
    Public Sub btnTransaksi_cl()
        Call Hover2()
        MainForm.lblnamamenu.Text = "Transaksi"
        MainForm.lblnamamenu.Visible = True
        Data_Master.Close()
        Laporan.Close()
        Lainnya.Close()
    End Sub
    Public Sub btnLaporan_cl()
        Call Hover3()
        MainForm.lblnamamenu.Text = "Laporan"
        MainForm.lblnamamenu.Visible = True
        Data_Master.Close()
        Transaksi.Close()
        Lainnya.Close()
    End Sub
    Public Sub btnLainnya_cl()
        Call Hover4()
        MainForm.lblnamamenu.Text = "Lainnya"
        MainForm.lblnamamenu.Visible = True
        Data_Master.Close()
        Transaksi.Close()
        Laporan.Close()
    End Sub
    Public Sub btnLogout_cl()
        Call Hover5()
        MainForm.lblnamamenu.Visible = False
        Data_Master.Close()
        Transaksi.Close()
        Laporan.Close()
        Lainnya.Close()
        Login_Admin.ShowDialog()
    End Sub



    'function for button login admin
    Public Sub Login_term()
        If Login_Admin.txtusername.Text = "" Or Login_Admin.txtpassword.Text = "" Then
            custMsgBoxx.lblMessage.Text = "Username and Password must be filled in!"
            custMsgBoxx.IconMessage.Image = Library.My.Resources.Resources.cancel
            custMsgBoxx.ShowDialog()
        Else
            Call Koneksi()
            cmd = New OleDbCommand("select * from tbl_admin where id_admin = '" & Login_Admin.txtusername.Text & "' and pwd = '" & Login_Admin.txtpassword.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                If MainForm.Visible = False Then
                    MainForm.lblidadmin.Text = rd("id_admin")
                    MainForm.lblNamaAdmin.Text = rd("nama_admin")
                    MainForm.lblleveladmin.Text = rd("level_admin")
                    MainForm.Refresh()
                    MainForm.Visible = False
                    MainForm.Guna2AnimateWindow1.SetAnimateWindow(MainForm)
                    Login_Admin.Close()
                Else
                    MainForm.lblidadmin.Text = rd("id_admin")
                    MainForm.lblNamaAdmin.Text = rd("nama_admin")
                    MainForm.lblleveladmin.Text = rd("level_admin")
                    MainForm.Refresh()
                    Login_Admin.Close()
                End If
            Else
                MessageBox.Show("Cek ID Admin dan Password anda," & vbNewLine & "Pastikan benar dan sudah terdaftar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Login_Admin.txtpassword.Text = ""
            End If
        End If
    End Sub
    Public Sub cancel_login_term()
        End
    End Sub
End Module