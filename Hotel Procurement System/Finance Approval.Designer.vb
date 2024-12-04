<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinanceApproval
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
        Me.grpMakeOrder = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.FinanceApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Procurement_System_DatabaseDataSet = New Hotel_Procurement_System.Procurement_System_DatabaseDataSet()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.cmbOrderType = New System.Windows.Forms.ComboBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DofOrder = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQuanity = New System.Windows.Forms.Label()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MethodOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostPerItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentApprovalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.lblPaymentrApprovalStatus = New System.Windows.Forms.Label()
        Me.btnSubmitResults = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Finance_ApprovalTableAdapter = New Hotel_Procurement_System.Procurement_System_DatabaseDataSetTableAdapters.Finance_ApprovalTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpMakeOrder.SuspendLayout()
        CType(Me.FinanceApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Procurement_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMakeOrder
        '
        Me.grpMakeOrder.Controls.Add(Me.txtPhone)
        Me.grpMakeOrder.Controls.Add(Me.btnCompute)
        Me.grpMakeOrder.Controls.Add(Me.lblPhone)
        Me.grpMakeOrder.Controls.Add(Me.cmbItem)
        Me.grpMakeOrder.Controls.Add(Me.cmbBrand)
        Me.grpMakeOrder.Controls.Add(Me.Label2)
        Me.grpMakeOrder.Controls.Add(Me.txtTotalCost)
        Me.grpMakeOrder.Controls.Add(Me.lblTotalCost)
        Me.grpMakeOrder.Controls.Add(Me.cmbPaymentMethod)
        Me.grpMakeOrder.Controls.Add(Me.cmbOrderType)
        Me.grpMakeOrder.Controls.Add(Me.txtCustomerID)
        Me.grpMakeOrder.Controls.Add(Me.txtFirstname)
        Me.grpMakeOrder.Controls.Add(Me.txtSurname)
        Me.grpMakeOrder.Controls.Add(Me.Label8)
        Me.grpMakeOrder.Controls.Add(Me.DofOrder)
        Me.grpMakeOrder.Controls.Add(Me.Label9)
        Me.grpMakeOrder.Controls.Add(Me.Label10)
        Me.grpMakeOrder.Controls.Add(Me.Label11)
        Me.grpMakeOrder.Controls.Add(Me.Label12)
        Me.grpMakeOrder.Controls.Add(Me.Label13)
        Me.grpMakeOrder.Controls.Add(Me.txtCost)
        Me.grpMakeOrder.Controls.Add(Me.lblCost)
        Me.grpMakeOrder.Controls.Add(Me.txtQuantity)
        Me.grpMakeOrder.Controls.Add(Me.lblBrand)
        Me.grpMakeOrder.Controls.Add(Me.lblItem)
        Me.grpMakeOrder.Controls.Add(Me.lblQuanity)
        Me.grpMakeOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMakeOrder.Location = New System.Drawing.Point(353, 12)
        Me.grpMakeOrder.Name = "grpMakeOrder"
        Me.grpMakeOrder.Size = New System.Drawing.Size(708, 336)
        Me.grpMakeOrder.TabIndex = 10
        Me.grpMakeOrder.TabStop = False
        Me.grpMakeOrder.Text = "Make Orders "
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Phone Number", True))
        Me.txtPhone.Location = New System.Drawing.Point(178, 184)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 61
        '
        'FinanceApprovalBindingSource
        '
        Me.FinanceApprovalBindingSource.DataMember = "Finance Approval"
        Me.FinanceApprovalBindingSource.DataSource = Me.Procurement_System_DatabaseDataSet
        '
        'Procurement_System_DatabaseDataSet
        '
        Me.Procurement_System_DatabaseDataSet.DataSetName = "Procurement_System_DatabaseDataSet"
        Me.Procurement_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(560, 290)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(127, 46)
        Me.btnCompute.TabIndex = 25
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(29, 185)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(106, 16)
        Me.lblPhone.TabIndex = 60
        Me.lblPhone.Text = "PhoneNumber"
        '
        'cmbItem
        '
        Me.cmbItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Item", True))
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Items.AddRange(New Object() {"Rice", "Beans", "Maize Flour", "Wheat Flour", "Meat", "Milk", "Sugar", "Water"})
        Me.cmbItem.Location = New System.Drawing.Point(560, 86)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(121, 21)
        Me.cmbItem.TabIndex = 59
        '
        'cmbBrand
        '
        Me.cmbBrand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Brand", True))
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Items.AddRange(New Object() {"Mwea", "Yellow", "Raha", "Beef", "Mt Kenya", "Rainbow", "keringet", "Dasani", "Tranzoia", "Mumias "})
        Me.cmbBrand.Location = New System.Drawing.Point(560, 120)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbBrand.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(684, 60)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Rice, beans, sugar, meat and maize is in Kilo grams" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Water and Milk in Litres " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalCost
        '
        Me.txtTotalCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Total Cost", True))
        Me.txtTotalCost.Location = New System.Drawing.Point(560, 247)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 55
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(401, 248)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(79, 16)
        Me.lblTotalCost.TabIndex = 54
        Me.lblTotalCost.Text = "Total Cost"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Method of Payment", True))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Mpesa"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(560, 182)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaymentMethod.TabIndex = 53
        '
        'cmbOrderType
        '
        Me.cmbOrderType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Order Type", True))
        Me.cmbOrderType.FormattingEnabled = True
        Me.cmbOrderType.Items.AddRange(New Object() {"Online Order", "Instore Order", "Telephone Call"})
        Me.cmbOrderType.Location = New System.Drawing.Point(178, 216)
        Me.cmbOrderType.Name = "cmbOrderType"
        Me.cmbOrderType.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrderType.TabIndex = 52
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Customer ID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(178, 83)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 51
        '
        'txtFirstname
        '
        Me.txtFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Firstname", True))
        Me.txtFirstname.Location = New System.Drawing.Point(178, 117)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 50
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Surname", True))
        Me.txtSurname.Location = New System.Drawing.Point(178, 150)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtSurname.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Date of Order"
        '
        'DofOrder
        '
        Me.DofOrder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Date of Order", True))
        Me.DofOrder.Location = New System.Drawing.Point(178, 247)
        Me.DofOrder.Name = "DofOrder"
        Me.DofOrder.Size = New System.Drawing.Size(207, 20)
        Me.DofOrder.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Customer ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Firstname"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Surname"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Order Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(401, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 16)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Method of Payment "
        '
        'txtCost
        '
        Me.txtCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Cost per Item", True))
        Me.txtCost.Location = New System.Drawing.Point(560, 213)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 26
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(401, 212)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(99, 16)
        Me.lblCost.TabIndex = 24
        Me.lblCost.Text = "Cost per Item"
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(560, 150)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 23
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(400, 119)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(49, 16)
        Me.lblBrand.TabIndex = 15
        Me.lblBrand.Text = "Brand"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.Location = New System.Drawing.Point(401, 87)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(37, 16)
        Me.lblItem.TabIndex = 8
        Me.lblItem.Text = "Item"
        '
        'lblQuanity
        '
        Me.lblQuanity.AutoSize = True
        Me.lblQuanity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuanity.Location = New System.Drawing.Point(401, 151)
        Me.lblQuanity.Name = "lblQuanity"
        Me.lblQuanity.Size = New System.Drawing.Size(68, 16)
        Me.lblQuanity.TabIndex = 6
        Me.lblQuanity.Text = "Quantity "
        '
        'btnDecline
        '
        Me.btnDecline.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.Location = New System.Drawing.Point(259, 35)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(89, 29)
        Me.btnDecline.TabIndex = 9
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'btnApprove
        '
        Me.btnApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.Location = New System.Drawing.Point(137, 32)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(89, 32)
        Me.btnApprove.TabIndex = 8
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(22, 32)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(89, 32)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.DateOfOrderDataGridViewTextBoxColumn, Me.OrderTypeDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.MethodOfPaymentDataGridViewTextBoxColumn, Me.CostPerItemDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.PaymentApprovalStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FinanceApprovalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 354)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1325, 205)
        Me.DataGridView1.TabIndex = 11
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'DateOfOrderDataGridViewTextBoxColumn
        '
        Me.DateOfOrderDataGridViewTextBoxColumn.DataPropertyName = "Date of Order"
        Me.DateOfOrderDataGridViewTextBoxColumn.HeaderText = "Date of Order"
        Me.DateOfOrderDataGridViewTextBoxColumn.Name = "DateOfOrderDataGridViewTextBoxColumn"
        '
        'OrderTypeDataGridViewTextBoxColumn
        '
        Me.OrderTypeDataGridViewTextBoxColumn.DataPropertyName = "Order Type"
        Me.OrderTypeDataGridViewTextBoxColumn.HeaderText = "Order Type"
        Me.OrderTypeDataGridViewTextBoxColumn.Name = "OrderTypeDataGridViewTextBoxColumn"
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "Item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "Item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'MethodOfPaymentDataGridViewTextBoxColumn
        '
        Me.MethodOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "Method of Payment"
        Me.MethodOfPaymentDataGridViewTextBoxColumn.HeaderText = "Method of Payment"
        Me.MethodOfPaymentDataGridViewTextBoxColumn.Name = "MethodOfPaymentDataGridViewTextBoxColumn"
        '
        'CostPerItemDataGridViewTextBoxColumn
        '
        Me.CostPerItemDataGridViewTextBoxColumn.DataPropertyName = "Cost per Item"
        Me.CostPerItemDataGridViewTextBoxColumn.HeaderText = "Cost per Item"
        Me.CostPerItemDataGridViewTextBoxColumn.Name = "CostPerItemDataGridViewTextBoxColumn"
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total Cost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        '
        'PaymentApprovalStatusDataGridViewTextBoxColumn
        '
        Me.PaymentApprovalStatusDataGridViewTextBoxColumn.DataPropertyName = "Payment Approval Status"
        Me.PaymentApprovalStatusDataGridViewTextBoxColumn.HeaderText = "Payment Approval Status"
        Me.PaymentApprovalStatusDataGridViewTextBoxColumn.Name = "PaymentApprovalStatusDataGridViewTextBoxColumn"
        '
        'cmbPaymentStatus
        '
        Me.cmbPaymentStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinanceApprovalBindingSource, "Payment Approval Status", True))
        Me.cmbPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentStatus.FormattingEnabled = True
        Me.cmbPaymentStatus.Items.AddRange(New Object() {"Approved ", "Declined ", "Pending"})
        Me.cmbPaymentStatus.Location = New System.Drawing.Point(225, 133)
        Me.cmbPaymentStatus.Name = "cmbPaymentStatus"
        Me.cmbPaymentStatus.Size = New System.Drawing.Size(121, 28)
        Me.cmbPaymentStatus.TabIndex = 64
        '
        'lblPaymentrApprovalStatus
        '
        Me.lblPaymentrApprovalStatus.AutoSize = True
        Me.lblPaymentrApprovalStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentrApprovalStatus.Location = New System.Drawing.Point(-1, 133)
        Me.lblPaymentrApprovalStatus.Name = "lblPaymentrApprovalStatus"
        Me.lblPaymentrApprovalStatus.Size = New System.Drawing.Size(211, 20)
        Me.lblPaymentrApprovalStatus.TabIndex = 63
        Me.lblPaymentrApprovalStatus.Text = "Payment Approval Status"
        '
        'btnSubmitResults
        '
        Me.btnSubmitResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitResults.Location = New System.Drawing.Point(40, 211)
        Me.btnSubmitResults.Name = "btnSubmitResults"
        Me.btnSubmitResults.Size = New System.Drawing.Size(99, 34)
        Me.btnSubmitResults.TabIndex = 65
        Me.btnSubmitResults.Text = "Submit Results"
        Me.btnSubmitResults.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1145, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 36)
        Me.btnExit.TabIndex = 81
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1145, 259)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 36)
        Me.btnSave.TabIndex = 80
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1145, 201)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 39)
        Me.btnDelete.TabIndex = 79
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(1145, 143)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 36)
        Me.btnNext.TabIndex = 78
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(1145, 76)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(112, 39)
        Me.btnPrevious.TabIndex = 77
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'Finance_ApprovalTableAdapter
        '
        Me.Finance_ApprovalTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1145, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 37)
        Me.btnAdd.TabIndex = 82
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'FinanceApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 661)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnSubmitResults)
        Me.Controls.Add(Me.cmbPaymentStatus)
        Me.Controls.Add(Me.lblPaymentrApprovalStatus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpMakeOrder)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnView)
        Me.Name = "FinanceApproval"
        Me.Text = "Finance Approval"
        Me.grpMakeOrder.ResumeLayout(False)
        Me.grpMakeOrder.PerformLayout()
        CType(Me.FinanceApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Procurement_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMakeOrder As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentMethod As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrderType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DofOrder As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQuanity As System.Windows.Forms.Label
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents btnApprove As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPaymentStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblPaymentrApprovalStatus As System.Windows.Forms.Label
    Friend WithEvents btnSubmitResults As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents Procurement_System_DatabaseDataSet As Hotel_Procurement_System.Procurement_System_DatabaseDataSet
    Friend WithEvents FinanceApprovalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Finance_ApprovalTableAdapter As Hotel_Procurement_System.Procurement_System_DatabaseDataSetTableAdapters.Finance_ApprovalTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MethodOfPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostPerItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentApprovalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
