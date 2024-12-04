Public Class MainForm

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "Hotel" And txtPassword.Text = "Login" Then
            Products.Show()
        ElseIf txtUsername.Text = "Hotel" And txtPassword.Text = "Finance" Then
            FinanceApproval.Show()
        ElseIf txtUsername.Text = "Hotel" And txtPassword.Text = "Procurement" Then
            Procurement_Approval.Show()
        ElseIf txtUsername.Text = "Hotel" And txtPassword.Text = "Manager" Then
            Manager.Show()
        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Valid Login Details")
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Please Enter a Valid Username")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please Enter a Valid Password")
        Else
            MessageBox.Show("You have entered incorrect login details. Please try  again", "login")
        End If
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registration.Show()
    End Sub

    Private Sub txtShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckShow.CheckedChanged
        If CheckShow.CheckState = CheckState.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class