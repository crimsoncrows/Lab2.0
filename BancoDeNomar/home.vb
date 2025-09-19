Public Class home

    Private parentForm As Form1
    Public withdraw As Integer
    Public deposit As Integer

    Public Sub New(parentForm As Form1)
        InitializeComponent()
        Me.parentForm = parentForm
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles panelTitleBar.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBoxUser.Click

    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        If (Val(txtAmount.Text) <= (Val(lblAccountBalance.Text)) AndAlso (Not txtAmount.Text.Equals(""))) Then

            withdraw = (Val(lblAccountBalance.Text)) - Val(txtAmount.Text)
            lblAccountBalance.Text = withdraw.ToString()
            lblStatMsg.Visible = True
            lblStatMsg.Text = "Withdraw of " + txtAmount.Text.ToString + " success."

            'update from other hidden form, retain the new value'
            If (lblUser.Text.Equals("Jose")) Then
                parentForm.balance1 = withdraw

            ElseIf (lblUser.Text.Equals("Carding")) Then
                parentForm.balance2 = withdraw

            ElseIf (lblUser.Text.Equals("Juana")) Then
                parentForm.balance3 = withdraw
            End If

        End If

        If (Val(txtAmount.Text) > (Val(lblAccountBalance.Text))) Then
            MessageBox.Show("No more funds to withdraw. You can deposit again.", "Withdrawal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click



        deposit = (Val(lblAccountBalance.Text)) + Val(txtAmount.Text)
        lblAccountBalance.Text = deposit.ToString()
        lblStatMsg.Visible = True
        lblStatMsg.Text = "Deposit of " + txtAmount.Text + " success."

        'update from login, retain the new value'
        If (lblUser.Text.Equals("Jose")) Then
            parentForm.balance1 = deposit

        ElseIf (lblUser.Text.Equals("Carding")) Then
            parentForm.balance2 = deposit

        ElseIf (lblUser.Text.Equals("Juana")) Then
            parentForm.balance3 = deposit
        End If





    End Sub

    Private Sub btnClearAmt_Click(sender As Object, e As EventArgs) Handles btnClearAmt.Click

        txtAmount.Text = ""

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        parentForm.Show()
        parentForm.txtPass.Text = ""
        parentForm.txtUser.Text = ""

        Me.Close()

    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged

    End Sub
End Class