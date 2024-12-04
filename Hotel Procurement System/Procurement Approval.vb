Public Class Procurement_Approval

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


        cmbTenderApprovalStatus.Text = "Pending"
    End Sub

    Private Sub btnApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprove.Click
        Dim iApprove As DialogResult
        iApprove = MessageBox.Show("Please confirm Tender Approval", "Approve", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iApprove = DialogResult.OK Then
            MessageBox.Show("Tender succesfully Approved", "Approval")
            cmbTenderApprovalStatus.Text = "Approved"
        ElseIf iApprove = DialogResult.Cancel Then
            cmbTenderApprovalStatus.Text = "Pending"
        Else : MessageBox.Show("Approval Cancelled", "Approval")
        End If
    End Sub

    Private Sub btnDecline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecline.Click
        Dim iDecline As DialogResult
        iDecline = MessageBox.Show("Are You Sure of the Decline?", "Decline", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iDecline = DialogResult.Yes Then
            MessageBox.Show("Tender succesfully Declined", "Decline")
            cmbTenderApprovalStatus.Text = "Declined"
        Else : MessageBox.Show("Decline Cancelled", "Decline")
        End If
    End Sub

    Private Sub btnSubmitResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitResults.Click

        Dim iSubmit As DialogResult
        iSubmit = MessageBox.Show("Please Confirm Your Submission", "Submit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iSubmit = DialogResult.OK Then
            MessageBox.Show("Results Succesfully Submitted", "Submit")
            Manager.Show()
            Me.Close()
        Else : MessageBox.Show("Submission Cancelled")
        End If


    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Procurement_Approval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet.Procurement_Approval' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ProcurementApprovalBindingSource.AddNew()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        ProcurementApprovalBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ProcurementApprovalBindingSource.MoveNext()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ProcurementApprovalBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Procurement_ApprovalTableAdapter.Update(Me.Procurement_System_DatabaseDataSet)
    End Sub
End Class