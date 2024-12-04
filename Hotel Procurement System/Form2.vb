Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Procurement_System_DatabaseDataSet1.Customer_Details' table. You can move, or remove it, as needed.
        Me.Customer_DetailsTableAdapter.Fill(Me.Procurement_System_DatabaseDataSet1.Customer_Details)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        CustomerDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        CustomerDetailsBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        CustomerDetailsBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        CustomerDetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Customer_DetailsTableAdapter.Update(Me.Procurement_System_DatabaseDataSet1)
    End Sub

    Private Sub link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link.LinkClicked
        Products.Show()

    End Sub
End Class