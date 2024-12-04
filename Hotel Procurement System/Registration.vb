Public Class Registration

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please Enter a Valid Username")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please Enter a Valid Password")
        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please Enter Valid Details")
        Else : MessageBox.Show("You have registered successfully. You can now proceed.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnProceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProceed.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please save your details before proceeding", "Proceed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Else : MessageBox.Show("You can now proceed.", "Proceed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            CustomerDetails.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class