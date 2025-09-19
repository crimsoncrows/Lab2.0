Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Public username1 As String = "Jose"
    Public username2 As String = "Carding"
    Public username3 As String = "Juana"

    Public password1 As String = "1234"
    Public password2 As String = "Juana"
    Public password3 As String = "secret"

    Public balance1 As Integer = 5000
    Public balance2 As Integer = 0
    Public balance3 As Integer = 6000



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles closebtn.Click

        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim home As New home(Me)

        If (txtUser.Text.Equals(username1) AndAlso txtPass.Text.Equals(password1)) Then

            home.lblAccountBalance.Text = balance1.ToString
            home.lblUser.Text = username1
            MessageBox.Show("Welcome " + txtUser.Text, "Logging You In", MessageBoxButtons.OK, MessageBoxIcon.Information)

            home.Show()

        ElseIf (txtUser.Text.Equals(username2) AndAlso txtPass.Text.Equals(password2)) Then

            home.lblAccountBalance.Text = balance2.ToString
            home.lblUser.Text = username2
            MessageBox.Show("Welcome " + txtUser.Text, "Logging You In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            home.Show()
            Me.Hide()

        ElseIf (txtUser.Text.Equals(username3) AndAlso txtPass.Text.Equals(password3)) Then

            home.lblAccountBalance.Text = balance3.ToString
            home.lblUser.Text = username3
            MessageBox.Show("Welcome " + txtUser.Text, "Logging You In", MessageBoxButtons.OK, MessageBoxIcon.Information)
            home.Show()
            Me.Hide()

        Else

            MessageBox.Show("Wrong password or username", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If









    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtUser.Text = ""
        txtPass.Text = ""

    End Sub
End Class
