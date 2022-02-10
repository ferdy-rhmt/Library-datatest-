Public Class Lainnya
    Private Sub btnDataUbahKS_Click(sender As Object, e As EventArgs) Handles btnDataUbahKS.Click
        Using OpenFileDialog1 As New OpenFileDialog
            With OpenFileDialog1
                .FileName = ""
                .Title = "Open"
                .Filter = "All Files (*.*)|*.*"
                .Multiselect = False
                .ShowDialog()
                .OpenFile()
            End With
        End Using
    End Sub

    Private Sub btnpengaturan_Click(sender As Object, e As EventArgs) Handles btnpengaturan.Click
        Lainnya_Pengaturan.ShowDialog()
        Lainnya_Pengaturan.Refresh()
    End Sub
End Class