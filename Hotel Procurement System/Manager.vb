Public Class Manager

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

        cmbPaymentApprovalStatus.Text = "Pending"
        cmbTenderApprovalStatus.Text = "Pending"

    End Sub

    Private Sub btnApproveTender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproveTender.Click
        Dim iApproveTender As DialogResult
        iApproveTender = MessageBox.Show("Please Confirm the Tender Approval", "Approve Tender", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iApproveTender = DialogResult.OK Then
            MessageBox.Show("Tender Successfully Approved", "Approve Tender")
            cmbTenderApprovalStatus.Text = "Approved"

        Else : MessageBox.Show("Tender Approval Cancelled", "Approval Tender")
        End If
    End Sub

    Private Sub btnApprovePaymentRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApprovePaymentRequest.Click
        Dim iApprovePaymentRequest As DialogResult
        iApprovePaymentRequest = MessageBox.Show("Please Confirm the Payment Approval Request", "Payment Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iApprovePaymentRequest = DialogResult.OK Then
            MessageBox.Show("Payment Approval Successfuly Requested", "Payment Request")
            cmbPaymentApprovalStatus.Text = "Approved"

        Else : MessageBox.Show("Payment Approval Request Cancelled", "Payment Request")
        End If
    End Sub

    Private Sub btnDeclineTender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeclineTender.Click
        Dim iDeclineTender As DialogResult
        iDeclineTender = MessageBox.Show("Please Confirm the Tender Decline", "Decline Tender", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iDeclineTender = DialogResult.OK Then
            MessageBox.Show("Tender Successfully Declined", "Decline Tender")
            cmbTenderApprovalStatus.Text = "Decline"

        Else : MessageBox.Show("Tender Decline Cancelled", "Decline Tender")
        End If
    End Sub

    Private Sub btnDeclinePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeclinePayment.Click
        Dim iDeclinePaymentRequest As DialogResult
        iDeclinePaymentRequest = MessageBox.Show("Please Confirm the Payment Decline", "Payment Decline", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iDeclinePaymentRequest = DialogResult.OK Then
            MessageBox.Show("Payment Request Successfully Declined", "Payment Decline")
            cmbPaymentApprovalStatus.Text = "Decline"

        Else : MessageBox.Show("Payment Request Cancelled", "Payment Declined")
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
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

    Private Sub Manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet2.Manager_Approval' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet.Manager_Approval' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbPaymentApprovalStatus.Text = "Approved" Or cmbPaymentApprovalStatus.Text = "Declined" Then
            FinanceApproval.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ManagerApprovalBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Manager_ApprovalTableAdapter.Update(Me.Procurement_System_DatabaseDataSet2)
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ManagerApprovalBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnNext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ManagerApprovalBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        ManagerApprovalBindingSource.MovePrevious()
    End Sub
End Class