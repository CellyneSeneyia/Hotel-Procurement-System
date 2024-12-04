Public Class FinanceApproval

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        txtCustomerID.Text = Products.txtCustomerID.Text
        txtFirstname.Text = Products.txtFirstname.Text
        txtSurname.Text = Products.txtSurname.Text
        txtPhone.Text = Products.txtPhone.Text
        cmbOrderType.Text = Products.cmbOrderType.Text
        DofOrder.Text = Products.DofOrder.Text
        cmbItem.Text = Products.cmbItem.Text
        cmbBrand.Text = Products.cmbBrand.Text
        txtQuantity.Text = Products.txtQuantity.Text
        cmbPaymentMethod.Text = Products.cmbPaymentMethod.Text
        txtCost.Text = Products.txtCost.Text
        txtTotalCost.Text = Products.txtTotalCost.Text

        cmbPaymentStatus.Text = "Pending"
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        Dim iApprove As DialogResult
        iApprove = MessageBox.Show("Please confirm Payment Approval", "Approve", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iApprove = DialogResult.OK Then
            MessageBox.Show("Payment succesfully Approved", "Approval")
            cmbPaymentStatus.Text = "Approved"
        Else : MessageBox.Show("Approval Cancelled", "Approval")
        End If
    End Sub

    Private Sub btnSubmitResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitResults.Click
        Dim iSubmit As DialogResult
        iSubmit = MessageBox.Show("Please Confirm Your Submission", "Submit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iSubmit = DialogResult.OK Then
            MessageBox.Show("Results Succesfully Submitted", "Submit")
        Else : MessageBox.Show("Submission Cancelled")
        End If
        Products.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecline.Click
        Dim iDecline As DialogResult
        iDecline = MessageBox.Show("Please confirm Payment Decline", "Decline", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iDecline = DialogResult.OK Then
            MessageBox.Show("Payment succesfully Declined", "Decline")
            cmbPaymentStatus.Text = "Declined"
        Else : MessageBox.Show("Decline Cancelled", "Decline")
            Products.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FinanceApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet.Finance_Approval' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        FinanceApprovalBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        FinanceApprovalBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        FinanceApprovalBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Finance_ApprovalTableAdapter.Update(Me.Procurement_System_DatabaseDataSet)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        FinanceApprovalBindingSource.AddNew()
    End Sub
End Class