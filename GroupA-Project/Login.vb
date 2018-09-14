Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        pnl_login.Top = ((Me.Height - pnl_login.Height) / 2) - 50
        pnl_login.Left = ((Me.Width - pnl_login.Width) / 2) - 10
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim user = New User()
        Dim loginRepo = New LoginRepository()

        If loginRepo.IsLogin(fld_username.Text, fld_password.Text) Then
            Me.Hide()
            Dashboard.Show()
        Else
            MessageBox.Show("Login Fail")
        End If

    End Sub

End Class
