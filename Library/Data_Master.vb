Public Class Data_Master
    Private Sub Data_Master_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnDataAdmin_Click(sender As Object, e As EventArgs) Handles btnDataAdmin.Click
        forminpanel(New Data_Master_Adminfr)
    End Sub

    Private Sub btnDataAnggota_Click(sender As Object, e As EventArgs) Handles btnDataAnggota.Click
        forminpanel(New Data_Master_Anggotafr)
    End Sub

    Private Sub btnDataBuku_Click(sender As Object, e As EventArgs) Handles btnDataBuku.Click
        forminpanel(New Data_Master_Bukufr)
    End Sub
End Class