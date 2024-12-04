<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grbBrand = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.grpMakeOrder = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.OrderPlacementDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Procurement_System_DatabaseDataSet1 = New Hotel_Procurement_System.Procurement_System_DatabaseDataSet1()
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
        Me.btnRequestPayment = New System.Windows.Forms.Button()
        Me.grbItems = New System.Windows.Forms.GroupBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.TenderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSubmitTenderRequest = New System.Windows.Forms.Button()
        Me.ComboTenderRequest = New System.Windows.Forms.ComboBox()
        Me.ComboPaymentRequest = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Order_Placement_DetailsTableAdapter = New Hotel_Procurement_System.Procurement_System_DatabaseDataSet1TableAdapters.Order_Placement_DetailsTableAdapter()
        Me.grbBrand.SuspendLayout()
        Me.grpMakeOrder.SuspendLayout()
        CType(Me.OrderPlacementDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Procurement_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbItems.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(682, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "These are the products we deal with in our hotel"
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(1219, 129)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(89, 36)
        Me.btnEnd.TabIndex = 47
        Me.btnEnd.Text = "Exit"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1219, 67)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 39)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1066, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 37)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1066, 68)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 37)
        Me.btnAdd.TabIndex = 42
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grbBrand
        '
        Me.grbBrand.Controls.Add(Me.ListBox1)
        Me.grbBrand.Location = New System.Drawing.Point(165, 3)
        Me.grbBrand.Name = "grbBrand"
        Me.grbBrand.Size = New System.Drawing.Size(167, 257)
        Me.grbBrand.TabIndex = 0
        Me.grbBrand.TabStop = False
        Me.grbBrand.Text = "Brands "
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Mwea", "Yellow", "Raha", "Beef", "Mt Kenya", "Rainbow", "keringet", "Dasani", "Tranzoia", "Mumias "})
        Me.ListBox1.Location = New System.Drawing.Point(0, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 228)
        Me.ListBox1.TabIndex = 0
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
        Me.grpMakeOrder.Location = New System.Drawing.Point(352, 56)
        Me.grpMakeOrder.Name = "grpMakeOrder"
        Me.grpMakeOrder.Size = New System.Drawing.Size(708, 336)
        Me.grpMakeOrder.TabIndex = 2
        Me.grpMakeOrder.TabStop = False
        Me.grpMakeOrder.Text = "Make Orders "
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Phone Number", True))
        Me.txtPhone.Location = New System.Drawing.Point(178, 184)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 61
        '
        'OrderPlacementDetailsBindingSource
        '
        Me.OrderPlacementDetailsBindingSource.DataMember = "Order Placement Details"
        Me.OrderPlacementDetailsBindingSource.DataSource = Me.Procurement_System_DatabaseDataSet1
        '
        'Procurement_System_DatabaseDataSet1
        '
        Me.Procurement_System_DatabaseDataSet1.DataSetName = "Procurement_System_DatabaseDataSet1"
        Me.Procurement_System_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.cmbItem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Item", True))
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Items.AddRange(New Object() {"Rice", "Beans", "Maize Flour", "Wheat Flour", "Meat", "Milk", "Sugar", "Water"})
        Me.cmbItem.Location = New System.Drawing.Point(560, 86)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(121, 21)
        Me.cmbItem.TabIndex = 59
        '
        'cmbBrand
        '
        Me.cmbBrand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Brand", True))
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Items.AddRange(New Object() {"Mwea", "Yellow", "Raha", "Beef", "Rainbow", "keringet", "Tranzoia"})
        Me.cmbBrand.Location = New System.Drawing.Point(560, 120)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbBrand.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(684, 60)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Rice, beans, sugar, meat and maize is in Kilo grams" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Water and Milk in Litres " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtTotalCost
        '
        Me.txtTotalCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Total Cost", True))
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
        Me.cmbPaymentMethod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Method of Payment", True))
        Me.cmbPaymentMethod.FormattingEnabled = True
        Me.cmbPaymentMethod.Items.AddRange(New Object() {"Cash", "Mpesa"})
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(560, 182)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaymentMethod.TabIndex = 53
        '
        'cmbOrderType
        '
        Me.cmbOrderType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Order Type", True))
        Me.cmbOrderType.FormattingEnabled = True
        Me.cmbOrderType.Items.AddRange(New Object() {"Online Order", "Instore Order", "Telephone Call"})
        Me.cmbOrderType.Location = New System.Drawing.Point(178, 216)
        Me.cmbOrderType.Name = "cmbOrderType"
        Me.cmbOrderType.Size = New System.Drawing.Size(121, 21)
        Me.cmbOrderType.TabIndex = 52
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Customer ID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(178, 83)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 51
        '
        'txtFirstname
        '
        Me.txtFirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Firstname", True))
        Me.txtFirstname.Location = New System.Drawing.Point(178, 117)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 50
        '
        'txtSurname
        '
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Surname", True))
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
        Me.DofOrder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Date of Order", True))
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
        Me.txtCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Cost per Item", True))
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
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Quantity", True))
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
        'btnRequestPayment
        '
        Me.btnRequestPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestPayment.Location = New System.Drawing.Point(1066, 260)
        Me.btnRequestPayment.Name = "btnRequestPayment"
        Me.btnRequestPayment.Size = New System.Drawing.Size(221, 29)
        Me.btnRequestPayment.TabIndex = 56
        Me.btnRequestPayment.Text = "Request for Payment"
        Me.btnRequestPayment.UseVisualStyleBackColor = True
        '
        'grbItems
        '
        Me.grbItems.Controls.Add(Me.RadioButton8)
        Me.grbItems.Controls.Add(Me.RadioButton7)
        Me.grbItems.Controls.Add(Me.RadioButton6)
        Me.grbItems.Controls.Add(Me.RadioButton5)
        Me.grbItems.Controls.Add(Me.RadioButton4)
        Me.grbItems.Controls.Add(Me.RadioButton3)
        Me.grbItems.Controls.Add(Me.RadioButton2)
        Me.grbItems.Controls.Add(Me.RadioButton1)
        Me.grbItems.Location = New System.Drawing.Point(11, 3)
        Me.grbItems.Name = "grbItems"
        Me.grbItems.Size = New System.Drawing.Size(148, 257)
        Me.grbItems.TabIndex = 1
        Me.grbItems.TabStop = False
        Me.grbItems.Text = "Items"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(6, 100)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(109, 20)
        Me.RadioButton8.TabIndex = 8
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Wheat Flour"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(6, 227)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(67, 20)
        Me.RadioButton7.TabIndex = 7
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Water"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(6, 193)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(67, 20)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Sugar"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(6, 164)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(54, 20)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Milk"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(6, 133)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(60, 20)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Meat"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(6, 71)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(106, 20)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Maize Flour"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 20)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Beans"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 20)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Rice"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grbItems)
        Me.Panel1.Controls.Add(Me.grbBrand)
        Me.Panel1.Location = New System.Drawing.Point(2, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 262)
        Me.Panel1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.DateOfOrderDataGridViewTextBoxColumn, Me.OrderTypeDataGridViewTextBoxColumn, Me.ItemDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.MethodOfPaymentDataGridViewTextBoxColumn, Me.CostPerItemDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.TenderStatusDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderPlacementDetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 432)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1373, 166)
        Me.DataGridView1.TabIndex = 48
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
        'TenderStatusDataGridViewTextBoxColumn
        '
        Me.TenderStatusDataGridViewTextBoxColumn.DataPropertyName = "Tender Status"
        Me.TenderStatusDataGridViewTextBoxColumn.HeaderText = "Tender Status"
        Me.TenderStatusDataGridViewTextBoxColumn.Name = "TenderStatusDataGridViewTextBoxColumn"
        '
        'PaymentStatusDataGridViewTextBoxColumn
        '
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "Payment Status"
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "Payment Status"
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        '
        'btnSubmitTenderRequest
        '
        Me.btnSubmitTenderRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitTenderRequest.Location = New System.Drawing.Point(1066, 185)
        Me.btnSubmitTenderRequest.Name = "btnSubmitTenderRequest"
        Me.btnSubmitTenderRequest.Size = New System.Drawing.Size(221, 29)
        Me.btnSubmitTenderRequest.TabIndex = 57
        Me.btnSubmitTenderRequest.Text = "Submit Tender Request"
        Me.btnSubmitTenderRequest.UseVisualStyleBackColor = True
        '
        'ComboTenderRequest
        '
        Me.ComboTenderRequest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Tender Status", True))
        Me.ComboTenderRequest.FormattingEnabled = True
        Me.ComboTenderRequest.Items.AddRange(New Object() {"Approved", "Declined", "Pending"})
        Me.ComboTenderRequest.Location = New System.Drawing.Point(1252, 226)
        Me.ComboTenderRequest.Name = "ComboTenderRequest"
        Me.ComboTenderRequest.Size = New System.Drawing.Size(121, 21)
        Me.ComboTenderRequest.TabIndex = 62
        '
        'ComboPaymentRequest
        '
        Me.ComboPaymentRequest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrderPlacementDetailsBindingSource, "Payment Status", True))
        Me.ComboPaymentRequest.FormattingEnabled = True
        Me.ComboPaymentRequest.Items.AddRange(New Object() {"Approved", "Declined", "Pending"})
        Me.ComboPaymentRequest.Location = New System.Drawing.Point(1252, 304)
        Me.ComboPaymentRequest.Name = "ComboPaymentRequest"
        Me.ComboPaymentRequest.Size = New System.Drawing.Size(121, 21)
        Me.ComboPaymentRequest.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1066, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 29)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "View Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1066, 301)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 33)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "View Status"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Order_Placement_DetailsTableAdapter
        '
        Me.Order_Placement_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboTenderRequest)
        Me.Controls.Add(Me.ComboPaymentRequest)
        Me.Controls.Add(Me.btnSubmitTenderRequest)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpMakeOrder)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRequestPayment)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.grbBrand.ResumeLayout(False)
        Me.grpMakeOrder.ResumeLayout(False)
        Me.grpMakeOrder.PerformLayout()
        CType(Me.OrderPlacementDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Procurement_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbItems.ResumeLayout(False)
        Me.grbItems.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grbBrand As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents grpMakeOrder As System.Windows.Forms.GroupBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQuanity As System.Windows.Forms.Label
    Friend WithEvents grbItems As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
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
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRequestPayment As System.Windows.Forms.Button
    Friend WithEvents cmbBrand As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents btnSubmitTenderRequest As System.Windows.Forms.Button
    Friend WithEvents ComboTenderRequest As System.Windows.Forms.ComboBox
    Friend WithEvents ComboPaymentRequest As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Procurement_System_DatabaseDataSet1 As Hotel_Procurement_System.Procurement_System_DatabaseDataSet1
    Friend WithEvents OrderPlacementDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Order_Placement_DetailsTableAdapter As Hotel_Procurement_System.Procurement_System_DatabaseDataSet1TableAdapters.Order_Placement_DetailsTableAdapter
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
    Friend WithEvents TenderStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
