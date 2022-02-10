Public Class Login_Admin
    Private Sub Login_Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoginAdmin_loadedTR()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call Login_term()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call cancel_login_term()
    End Sub

    Private Sub txtusername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class