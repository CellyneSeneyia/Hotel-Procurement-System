Public Class Products

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click

        Const Rice_cost = 130
        Const Beans_cost = 180
        Const Maizeflour_Cost = 100
        Const Wheatflour_Cost = 100
        Const Meat_Cost = 400
        Const Sugar_Cost = 150
        Const Milk_Cost = 80
        Const Water_Cost = 100


        Dim RiceCost As Double = Rice_cost
        Dim BeansCost As Double = Beans_cost
        Dim MaizeflourCost As Double = Maizeflour_Cost
        Dim WheatflourCost As Double = Wheatflour_Cost
        Dim MeatCost As Double = Meat_Cost
        Dim SugarCost As Double = Sugar_Cost
        Dim MilkCost As Double = Milk_Cost
        Dim WaterCost As Double = Water_Cost

        If Me.cmbItem.SelectedItem = "Rice" Then
            txtTotalCost.Text = RiceCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 130")
            cmbBrand.Text = ("Mwea")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Beans" Then
            txtTotalCost.Text = BeansCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 180")
            cmbBrand.Text = ("Yellow")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Maize Flour" Then
            txtTotalCost.Text = MaizeflourCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 160")
            cmbBrand.Text = ("Raha")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Wheat Flour" Then
            txtTotalCost.Text = WheatflourCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 120")
            cmbBrand.Text = ("Raha")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Meat" Then
            txtTotalCost.Text = MeatCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 400")
            cmbBrand.Text = ("Beef")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Sugar" Then
            txtTotalCost.Text = SugarCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 150")
            cmbBrand.Text = ("Tranzoia")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Milk" Then
            txtTotalCost.Text = MilkCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 80")
            cmbBrand.Text = ("Rainbow")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If Me.cmbItem.SelectedItem = "Water" Then
            txtTotalCost.Text = RiceCost * Val(txtQuantity.Text)
            txtCost.Text = ("Ksh 150")
            cmbBrand.Text = ("Keringet")
            cmbPaymentMethod.Text = ("Mpesa")
        End If
        If txtCustomerID.Text = "" Then
            MessageBox.Show("Customer ID can't be empty")
        End If
        If txtFirstname.Text = "" Then
            MessageBox.Show("Firstname can't be empty")
        End If
        If txtSurname.Text = "" Then
            MessageBox.Show("Surname can't be empty")
        End If
        If txtPhone.Text = "" Then
            MessageBox.Show("Phone number can't be empty")
        End If
        If cmbOrderType.Text = "" Then
            MessageBox.Show("Please select the order type")
        End If
        If DofOrder.Text = "" Then
            MessageBox.Show("Please select the date of order")
        End If
        If cmbItem.Text = "" Then
            MessageBox.Show("Please select the item")
        End If
        If txtQuantity.Text = "" Then
            MessageBox.Show("Please insert the Quantity")
        End If
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnRequestPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestPayment.Click

        Dim iRequest As DialogResult
        iRequest = MessageBox.Show("Please Confirm the Payment Request", "Payment Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iRequest = DialogResult.OK Then
            MessageBox.Show("Payment Successfully Requested", "Payment Request")
            Manager.Show()

        Else : MessageBox.Show("Payment Request Cancelled", "Payment Request")
        End If
    End Sub

    Private Sub btnSubmitTenderRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitTenderRequest.Click

        Dim iSubmit As DialogResult
        iSubmit = MessageBox.Show("Please Confirm the Tender Submission", "Tender Submission", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If iSubmit = DialogResult.OK Then
            MessageBox.Show("Tender Successfully Submitted", "Tender Submission")
            Procurement_Approval.Show()

        Else : MessageBox.Show("Submission Cancelled", "Tender Submission")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        OrderPlacementDetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Manager.cmbTenderApprovalStatus.Text = "Approved" Then
            ComboTenderRequest.Text = "Approved"
        ElseIf Manager.cmbTenderApprovalStatus.Text = "Declined" Then
            ComboTenderRequest.Text = "Declined"
        Else : ComboTenderRequest.Text = "Pending"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If FinanceApproval.cmbPaymentStatus.Text = "Approved" Then
            ComboPaymentRequest.Text = "Approved"
        ElseIf FinanceApproval.cmbPaymentStatus.Text = "Declined" Then
            ComboPaymentRequest.Text = "Declined"
        Else : ComboPaymentRequest.Text = "Pending"
        End If
    End Sub

    Private Sub Products_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet1.Order_Placement_Details' table. You can move, or remove it, as needed.


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtCustomerID.Text = Val(txtCustomerID.Text) + 1
        OrderPlacementDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    End Sub
End Class