Imports System.Data.OleDb
Public Class Data_Master_Adminfr
    Sub tampildata()
        Call Koneksi()
        cmd = New OleDbCommand("select * from tbl_admin", conn)
        rd = cmd.ExecuteReader
        dgvAddAdmin.Rows.Clear()
        Do While rd.Read()
            dgvAddAdmin.Rows.Add(rd(0), rd(1), rd(2), rd(3))
        Loop
    End Sub

    Private Sub Data_Master_Adminfr_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvAddAdmin.Rows.Clear()
        Call tampildata()
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        'Database
        Data_Master_Adminfr_Add.ShowDialog()
        Data_Master_Adminfr_Add.Refresh()
    End Sub

    Private Sub btnDelAdmin_Click(sender As Object, e As EventArgs) Handles btnDelAdmin.Click
        cmd = New OleDbCommand("delete * from tbl_admin where id_admin like '%" & lblidadmin.Text & "%' ", conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data Berhasil dihapus!")

        forminpanel(New Data_Master_Adminfr)
    End Sub

    Public Sub dgvAddAdmin_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvAddAdmin.CellFormatting
        If (e.ColumnIndex <> -1 AndAlso dgvAddAdmin.Columns(e.ColumnIndex).Name = "pwd") Then
            If (Not e.Value Is Nothing) Then
                e.Value = New String("*", e.Value.ToString().Length)
            End If
        End If
    End Sub

    Private Sub dgvAddAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAddAdmin.CellClick
        Dim i As Integer
        i = dgvAddAdmin.CurrentRow.Index

        MessageBox.Show(" ID Admin " + " = " + dgvAddAdmin.Item(0, i).Value & vbNewLine &
                        " Password " + " = " + dgvAddAdmin.Item(2, i).Value, "Info Admin", MessageBoxButtons.OK)
    End Sub

    Private Sub dgvAddAdmin_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAddAdmin.CellMouseClick
        Dim i As Integer
        i = dgvAddAdmin.CurrentRow.Index

        lblidadmin.Text = dgvAddAdmin.Item(0, i).Value
    End Sub
End Class