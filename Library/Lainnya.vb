Public Class Lainnya
    Private Sub btnDataUbahKS_Click(sender As Object, e As EventArgs) Handles btnDataUbahKS.Click
        Lainnya_Ubahpass.ShowDialog()
        Lainnya_Ubahpass.Refresh()
    End Sub

    Private Sub btnpengaturan_Click(sender As Object, e As EventArgs) Handles btnpengaturan.Click
        Lainnya_Pengaturan.ShowDialog()
        Lainnya_Pengaturan.Refresh()
    End Sub
End Class