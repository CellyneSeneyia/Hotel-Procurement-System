<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VATNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Procurement_System_DatabaseDataSet1 = New Hotel_Procurement_System.Procurement_System_DatabaseDataSet1()
        Me.combStatus = New System.Windows.Forms.ComboBox()
        Me.combGender = New System.Windows.Forms.ComboBox()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.txxtBalance = New System.Windows.Forms.TextBox()
        Me.txtVATNumber = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.lblVATNumber = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblCounty = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Customer_DetailsTableAdapter = New Hotel_Procurement_System.Procurement_System_DatabaseDataSet1TableAdapters.Customer_DetailsTableAdapter()
        Me.link = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Procurement_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(25, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1023, 573)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.combStatus)
        Me.TabPage1.Controls.Add(Me.combGender)
        Me.TabPage1.Controls.Add(Me.btnEnd)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnPrevious)
        Me.TabPage1.Controls.Add(Me.btnNext)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.lblGender)
        Me.TabPage1.Controls.Add(Me.txtAccountID)
        Me.TabPage1.Controls.Add(Me.txxtBalance)
        Me.TabPage1.Controls.Add(Me.txtVATNumber)
        Me.TabPage1.Controls.Add(Me.txtContactName)
        Me.TabPage1.Controls.Add(Me.txtPostCode)
        Me.TabPage1.Controls.Add(Me.txtCounty)
        Me.TabPage1.Controls.Add(Me.txtTown)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.lblBalance)
        Me.TabPage1.Controls.Add(Me.lblAccountStatus)
        Me.TabPage1.Controls.Add(Me.lblAccount)
        Me.TabPage1.Controls.Add(Me.lblVATNumber)
        Me.TabPage1.Controls.Add(Me.lblContactName)
        Me.TabPage1.Controls.Add(Me.lblPostCode)
        Me.TabPage1.Controls.Add(Me.lblCounty)
        Me.TabPage1.Controls.Add(Me.lblTown)
        Me.TabPage1.Controls.Add(Me.lblAddress)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.lblPhone)
        Me.TabPage1.Controls.Add(Me.lblName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.NamesDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.TownDataGridViewTextBoxColumn, Me.CountyDataGridViewTextBoxColumn, Me.PostCodeDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.VATNumberDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.AccountStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(943, 198)
        Me.DataGridView1.TabIndex = 35
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'NamesDataGridViewTextBoxColumn
        '
        Me.NamesDataGridViewTextBoxColumn.DataPropertyName = "Names"
        Me.NamesDataGridViewTextBoxColumn.HeaderText = "Names"
        Me.NamesDataGridViewTextBoxColumn.Name = "NamesDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'TownDataGridViewTextBoxColumn
        '
        Me.TownDataGridViewTextBoxColumn.DataPropertyName = "Town"
        Me.TownDataGridViewTextBoxColumn.HeaderText = "Town"
        Me.TownDataGridViewTextBoxColumn.Name = "TownDataGridViewTextBoxColumn"
        '
        'CountyDataGridViewTextBoxColumn
        '
        Me.CountyDataGridViewTextBoxColumn.DataPropertyName = "County"
        Me.CountyDataGridViewTextBoxColumn.HeaderText = "County"
        Me.CountyDataGridViewTextBoxColumn.Name = "CountyDataGridViewTextBoxColumn"
        '
        'PostCodeDataGridViewTextBoxColumn
        '
        Me.PostCodeDataGridViewTextBoxColumn.DataPropertyName = "Post Code"
        Me.PostCodeDataGridViewTextBoxColumn.HeaderText = "Post Code"
        Me.PostCodeDataGridViewTextBoxColumn.Name = "PostCodeDataGridViewTextBoxColumn"
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "Contact Name"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "Contact Name"
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        '
        'VATNumberDataGridViewTextBoxColumn
        '
        Me.VATNumberDataGridViewTextBoxColumn.DataPropertyName = "VAT Number"
        Me.VATNumberDataGridViewTextBoxColumn.HeaderText = "VAT Number"
        Me.VATNumberDataGridViewTextBoxColumn.Name = "VATNumberDataGridViewTextBoxColumn"
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        '
        'AccountStatusDataGridViewTextBoxColumn
        '
        Me.AccountStatusDataGridViewTextBoxColumn.DataPropertyName = "Account Status"
        Me.AccountStatusDataGridViewTextBoxColumn.HeaderText = "Account Status"
        Me.AccountStatusDataGridViewTextBoxColumn.Name = "AccountStatusDataGridViewTextBoxColumn"
        '
        'CustomerDetailsBindingSource
        '
        Me.CustomerDetailsBindingSource.DataMember = "Customer Details"
        Me.CustomerDetailsBindingSource.DataSource = Me.Procurement_System_DatabaseDataSet1
        '
        'Procurement_System_DatabaseDataSet1
        '
        Me.Procurement_System_DatabaseDataSet1.DataSetName = "Procurement_System_DatabaseDataSet1"
        Me.Procurement_System_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'combStatus
        '
        Me.combStatus.FormattingEnabled = True
        Me.combStatus.Items.AddRange(New Object() {"Yes", "No"})
        Me.combStatus.Location = New System.Drawing.Point(583, 243)
        Me.combStatus.Name = "combStatus"
        Me.combStatus.Size = New System.Drawing.Size(157, 24)
        Me.combStatus.TabIndex = 32
        '
        'combGender
        '
        Me.combGender.FormattingEnabled = True
        Me.combGender.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        Me.combGender.Location = New System.Drawing.Point(133, 158)
        Me.combGender.Name = "combGender"
        Me.combGender.Size = New System.Drawing.Size(157, 24)
        Me.combGender.TabIndex = 31
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(859, 243)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(89, 23)
        Me.btnEnd.TabIndex = 30
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(859, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 23)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(859, 155)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(89, 23)
        Me.btnPrevious.TabIndex = 28
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(859, 110)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(89, 23)
        Me.btnNext.TabIndex = 27
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(859, 68)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 23)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(859, 27)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 23)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(24, 161)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(59, 16)
        Me.lblGender.TabIndex = 24
        Me.lblGender.Text = "Gender"
        '
        'txtAccountID
        '
        Me.txtAccountID.Location = New System.Drawing.Point(133, 24)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(157, 22)
        Me.txtAccountID.TabIndex = 23
        '
        'txxtBalance
        '
        Me.txxtBalance.Location = New System.Drawing.Point(581, 200)
        Me.txxtBalance.Name = "txxtBalance"
        Me.txxtBalance.Size = New System.Drawing.Size(157, 22)
        Me.txxtBalance.TabIndex = 22
        '
        'txtVATNumber
        '
        Me.txtVATNumber.Location = New System.Drawing.Point(581, 155)
        Me.txtVATNumber.Name = "txtVATNumber"
        Me.txtVATNumber.Size = New System.Drawing.Size(157, 22)
        Me.txtVATNumber.TabIndex = 21
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(583, 110)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(155, 22)
        Me.txtContactName.TabIndex = 20
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(583, 68)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(157, 22)
        Me.txtPostCode.TabIndex = 19
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(583, 24)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(157, 22)
        Me.txtCounty.TabIndex = 18
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(133, 284)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(157, 22)
        Me.txtTown.TabIndex = 17
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(133, 244)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(157, 22)
        Me.txtAddress.TabIndex = 16
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 200)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 22)
        Me.txtEmail.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(133, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(157, 22)
        Me.txtPhone.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(133, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 22)
        Me.txtName.TabIndex = 13
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(409, 203)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(65, 16)
        Me.lblBalance.TabIndex = 12
        Me.lblBalance.Text = "Balance"
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Location = New System.Drawing.Point(409, 246)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(110, 16)
        Me.lblAccountStatus.TabIndex = 11
        Me.lblAccountStatus.Text = "Account Status"
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(24, 27)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(92, 16)
        Me.lblAccount.TabIndex = 10
        Me.lblAccount.Text = "Customer ID"
        '
        'lblVATNumber
        '
        Me.lblVATNumber.AutoSize = True
        Me.lblVATNumber.Location = New System.Drawing.Point(409, 158)
        Me.lblVATNumber.Name = "lblVATNumber"
        Me.lblVATNumber.Size = New System.Drawing.Size(96, 16)
        Me.lblVATNumber.TabIndex = 9
        Me.lblVATNumber.Text = "VAT Number"
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(409, 113)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(105, 16)
        Me.lblContactName.TabIndex = 8
        Me.lblContactName.Text = "Contact Name"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(409, 71)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(80, 16)
        Me.lblPostCode.TabIndex = 7
        Me.lblPostCode.Text = "Post Code"
        '
        'lblCounty
        '
        Me.lblCounty.AutoSize = True
        Me.lblCounty.Location = New System.Drawing.Point(409, 27)
        Me.lblCounty.Name = "lblCounty"
        Me.lblCounty.Size = New System.Drawing.Size(55, 16)
        Me.lblCounty.TabIndex = 6
        Me.lblCounty.Text = "County"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(24, 287)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(45, 16)
        Me.lblTown.TabIndex = 5
        Me.lblTown.Text = "Town"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(24, 246)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(66, 16)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(24, 203)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 16)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(24, 113)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(52, 16)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(24, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Default Settings "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1015, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Credit Control"
        '
        'Customer_DetailsTableAdapter
        '
        Me.Customer_DetailsTableAdapter.ClearBeforeFill = True
        '
        'link
        '
        Me.link.AutoSize = True
        Me.link.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link.Location = New System.Drawing.Point(294, 598)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(450, 20)
        Me.link.TabIndex = 36
        Me.link.TabStop = True
        Me.link.Text = "Click here to view and register for the product to supply"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 661)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Procurement_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents combStatus As System.Windows.Forms.ComboBox
    Friend WithEvents combGender As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents txtAccountID As System.Windows.Forms.TextBox
    Friend WithEvents txxtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtVATNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents txtPostCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCounty As System.Windows.Forms.TextBox
    Friend WithEvents txtTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblAccountStatus As System.Windows.Forms.Label
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents lblVATNumber As System.Windows.Forms.Label
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents lblPostCode As System.Windows.Forms.Label
    Friend WithEvents lblCounty As System.Windows.Forms.Label
    Friend WithEvents lblTown As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Procurement_System_DatabaseDataSet1 As Hotel_Procurement_System.Procurement_System_DatabaseDataSet1
    Friend WithEvents CustomerDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Customer_DetailsTableAdapter As Hotel_Procurement_System.Procurement_System_DatabaseDataSet1TableAdapters.Customer_DetailsTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TownDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VATNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents link As System.Windows.Forms.LinkLabel
End Class
