namespace RentBicycle.View
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label citizensIdentityLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label nameLabel2;
            System.Windows.Forms.Label rentHoursLabel;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvTab2OrderDetail = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentHoursDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.fKOrdersDetOrder440B1D61BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentBicycleDataSet = new RentBicycle.Model.RentBicycleDataSet();
            this.dgvTab2OrderStatus = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ordersDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label = new System.Windows.Forms.Label();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnAddProduct = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQuantityStock = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtRentHours = new System.Windows.Forms.TextBox();
            this.panelImg = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.cbbProductName = new System.Windows.Forms.ComboBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerPhone = new DevExpress.XtraEditors.TextEdit();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtCusCtitizensIdentity = new DevExpress.XtraEditors.TextEdit();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ordersTableAdapter = new RentBicycle.Model.RentBicycleDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new RentBicycle.Model.RentBicycleDataSetTableAdapters.TableAdapterManager();
            this.ordersDetailTableAdapter = new RentBicycle.Model.RentBicycleDataSetTableAdapters.OrdersDetailTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            citizensIdentityLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            nameLabel2 = new System.Windows.Forms.Label();
            rentHoursLabel = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2OrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersDetOrder440B1D61BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBicycleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2OrderStatus)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusCtitizensIdentity.Properties)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // citizensIdentityLabel
            // 
            citizensIdentityLabel.AutoSize = true;
            citizensIdentityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            citizensIdentityLabel.Location = new System.Drawing.Point(45, 47);
            citizensIdentityLabel.Name = "citizensIdentityLabel";
            citizensIdentityLabel.Size = new System.Drawing.Size(125, 20);
            citizensIdentityLabel.TabIndex = 1;
            citizensIdentityLabel.Text = "Citizens Identity:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(45, 95);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(45, 144);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "Phone:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(21, 111);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(319, 47);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(72, 20);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // nameLabel2
            // 
            nameLabel2.AutoSize = true;
            nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel2.Location = new System.Drawing.Point(21, 50);
            nameLabel2.Name = "nameLabel2";
            nameLabel2.Size = new System.Drawing.Size(55, 20);
            nameLabel2.TabIndex = 20;
            nameLabel2.Text = "Name:";
            // 
            // rentHoursLabel
            // 
            rentHoursLabel.AutoSize = true;
            rentHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rentHoursLabel.Location = new System.Drawing.Point(318, 111);
            rentHoursLabel.Name = "rentHoursLabel";
            rentHoursLabel.Size = new System.Drawing.Size(95, 20);
            rentHoursLabel.TabIndex = 21;
            rentHoursLabel.Text = "Rent Hours:";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel1.Location = new System.Drawing.Point(319, 168);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(131, 20);
            quantityLabel1.TabIndex = 26;
            quantityLabel1.Text = "Quantity In Stock";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelX2);
            this.tabPage2.Controls.Add(this.labelX1);
            this.tabPage2.Controls.Add(this.dgvTab2OrderDetail);
            this.tabPage2.Controls.Add(this.dgvTab2OrderStatus);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1535, 846);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(884, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(645, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Order Detail";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(6, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(872, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Bicycle Rental Orders";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvTab2OrderDetail
            // 
            this.dgvTab2OrderDetail.AllowUserToDeleteRows = false;
            this.dgvTab2OrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTab2OrderDetail.AutoGenerateColumns = false;
            this.dgvTab2OrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTab2OrderDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvTab2OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab2OrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn1,
            this.productNameDataGridViewTextBoxColumn1,
            this.rentHoursDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.Edit});
            this.dgvTab2OrderDetail.DataSource = this.fKOrdersDetOrder440B1D61BindingSource3;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTab2OrderDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTab2OrderDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTab2OrderDetail.Location = new System.Drawing.Point(884, 57);
            this.dgvTab2OrderDetail.Name = "dgvTab2OrderDetail";
            this.dgvTab2OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTab2OrderDetail.Size = new System.Drawing.Size(645, 783);
            this.dgvTab2OrderDetail.TabIndex = 1;
            this.dgvTab2OrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2OrderDetail_CellContentClick);
            this.dgvTab2OrderDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2OrderDetail_CellEndEdit);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "Order Id";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn1
            // 
            this.productIdDataGridViewTextBoxColumn1.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn1.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn1.Name = "productIdDataGridViewTextBoxColumn1";
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            this.productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            // 
            // rentHoursDataGridViewTextBoxColumn1
            // 
            this.rentHoursDataGridViewTextBoxColumn1.DataPropertyName = "RentHours";
            this.rentHoursDataGridViewTextBoxColumn1.HeaderText = "Rent Hours";
            this.rentHoursDataGridViewTextBoxColumn1.Name = "rentHoursDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit Rent Hours";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // fKOrdersDetOrder440B1D61BindingSource3
            // 
            this.fKOrdersDetOrder440B1D61BindingSource3.DataMember = "FK__OrdersDet__Order__440B1D61";
            this.fKOrdersDetOrder440B1D61BindingSource3.DataSource = this.ordersBindingSource;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.rentBicycleDataSet;
            // 
            // rentBicycleDataSet
            // 
            this.rentBicycleDataSet.DataSetName = "RentBicycleDataSet";
            this.rentBicycleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTab2OrderStatus
            // 
            this.dgvTab2OrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTab2OrderStatus.AutoGenerateColumns = false;
            this.dgvTab2OrderStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTab2OrderStatus.BackgroundColor = System.Drawing.Color.White;
            this.dgvTab2OrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTab2OrderStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Done});
            this.dgvTab2OrderStatus.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTab2OrderStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTab2OrderStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTab2OrderStatus.Location = new System.Drawing.Point(6, 57);
            this.dgvTab2OrderStatus.Name = "dgvTab2OrderStatus";
            this.dgvTab2OrderStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTab2OrderStatus.Size = new System.Drawing.Size(872, 783);
            this.dgvTab2OrderStatus.TabIndex = 0;
            this.dgvTab2OrderStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2OrderStatus_CellClick);
            this.dgvTab2OrderStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTab2OrderStatus_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "Customer Phone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            this.customerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee Id";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Done
            // 
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.Text = "Done";
            this.Done.ToolTipText = "Done";
            this.Done.UseColumnTextForLinkValue = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Thistle;
            this.tabPage1.Controls.Add(this.lblOrderId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dataGridViewOrder);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.btnPayment);
            this.tabPage1.Controls.Add(this.btnAddProduct);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1535, 846);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(87, 270);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(18, 20);
            this.lblOrderId.TabIndex = 25;
            this.lblOrderId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Order Id:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 30;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1397, 245);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1376, 752);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 25);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "0";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.rentHoursDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridViewOrder.DataSource = this.ordersDetailBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 296);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(1523, 441);
            this.dataGridViewOrder.TabIndex = 21;
            this.dataGridViewOrder.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewOrder_CellBeginEdit);
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            this.dataGridViewOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellEndEdit);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Product Id";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // rentHoursDataGridViewTextBoxColumn
            // 
            this.rentHoursDataGridViewTextBoxColumn.DataPropertyName = "RentHours";
            this.rentHoursDataGridViewTextBoxColumn.HeaderText = "Rent Hours";
            this.rentHoursDataGridViewTextBoxColumn.Name = "rentHoursDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.Blue;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // ordersDetailBindingSource
            // 
            this.ordersDetailBindingSource.DataSource = typeof(RentBicycle.Model.OrdersDetail);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1281, 746);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 31);
            this.label.TabIndex = 18;
            this.label.Text = "Total:";
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.btnPayment.IconColor = System.Drawing.Color.Black;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(1364, 790);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(168, 50);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAddProduct.IconColor = System.Drawing.Color.Black;
            this.btnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProduct.IconSize = 30;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(1280, 246);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(111, 45);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(quantityLabel1);
            this.groupBox2.Controls.Add(this.lblQuantityStock);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblProductId);
            this.groupBox2.Controls.Add(rentHoursLabel);
            this.groupBox2.Controls.Add(this.txtRentHours);
            this.groupBox2.Controls.Add(nameLabel2);
            this.groupBox2.Controls.Add(this.panelImg);
            this.groupBox2.Controls.Add(this.cbbProductName);
            this.groupBox2.Controls.Add(priceLabel);
            this.groupBox2.Controls.Add(this.txtProductPrice);
            this.groupBox2.Controls.Add(quantityLabel);
            this.groupBox2.Controls.Add(this.txtProductQuantity);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(650, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 224);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // lblQuantityStock
            // 
            this.lblQuantityStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity", true));
            this.lblQuantityStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityStock.Location = new System.Drawing.Point(456, 168);
            this.lblQuantityStock.Name = "lblQuantityStock";
            this.lblQuantityStock.Size = new System.Drawing.Size(100, 23);
            this.lblQuantityStock.TabIndex = 27;
            this.lblQuantityStock.Text = "0";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(RentBicycle.Model.Product);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(832, 21);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(18, 20);
            this.lblProductId.TabIndex = 23;
            this.lblProductId.Text = "0";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRentHours
            // 
            this.txtRentHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentHours.Location = new System.Drawing.Point(418, 108);
            this.txtRentHours.Name = "txtRentHours";
            this.txtRentHours.Size = new System.Drawing.Size(180, 26);
            this.txtRentHours.TabIndex = 22;
            // 
            // panelImg
            // 
            this.panelImg.BackColor = System.Drawing.Color.White;
            this.panelImg.Controls.Add(this.picProduct);
            this.panelImg.Location = new System.Drawing.Point(618, 44);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(240, 144);
            this.panelImg.TabIndex = 11;
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(0, 3);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(240, 138);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;
            // 
            // cbbProductName
            // 
            this.cbbProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.cbbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProductName.FormattingEnabled = true;
            this.cbbProductName.Location = new System.Drawing.Point(82, 44);
            this.cbbProductName.Name = "cbbProductName";
            this.cbbProductName.Size = new System.Drawing.Size(201, 28);
            this.cbbProductName.TabIndex = 21;
            this.cbbProductName.SelectedIndexChanged += new System.EventHandler(this.cbbProductName_SelectedIndexChanged);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(82, 108);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ReadOnly = true;
            this.txtProductPrice.Size = new System.Drawing.Size(201, 26);
            this.txtProductPrice.TabIndex = 10;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQuantity.Location = new System.Drawing.Point(397, 44);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(201, 26);
            this.txtProductQuantity.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(citizensIdentityLabel);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(this.txtCusCtitizensIdentity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 203);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Phone", true));
            this.txtCustomerPhone.Location = new System.Drawing.Point(220, 141);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerPhone.Size = new System.Drawing.Size(201, 26);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(RentBicycle.Model.Customer);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Name", true));
            this.txtCustomerName.Location = new System.Drawing.Point(220, 92);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Size = new System.Drawing.Size(201, 26);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtCusCtitizensIdentity
            // 
            this.txtCusCtitizensIdentity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "CitizensIdentity", true));
            this.txtCusCtitizensIdentity.Location = new System.Drawing.Point(220, 44);
            this.txtCusCtitizensIdentity.Name = "txtCusCtitizensIdentity";
            this.txtCusCtitizensIdentity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusCtitizensIdentity.Properties.Appearance.Options.UseFont = true;
            this.txtCusCtitizensIdentity.Size = new System.Drawing.Size(201, 26);
            this.txtCusCtitizensIdentity.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1543, 879);
            this.tabControl1.TabIndex = 17;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrdersDetailTableAdapter = this.ordersDetailTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RentBicycle.Model.RentBicycleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // ordersDetailTableAdapter
            // 
            this.ordersDetailTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(RentBicycle.Model.Order);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1567, 896);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2OrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersDetOrder440B1D61BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBicycleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTab2OrderStatus)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusCtitizensIdentity.Properties)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtCustomerPhone;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtCusCtitizensIdentity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.ComboBox cbbProductName;
        private System.Windows.Forms.TextBox txtRentHours;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label lblQuantityStock;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ordersDetailBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private RentBicycle.Model.RentBicycleDataSet rentBicycleDataSet;
        private RentBicycle.Model.RentBicycleDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private RentBicycle.Model.RentBicycleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private RentBicycle.Model.RentBicycleDataSetTableAdapters.OrdersDetailTableAdapter ordersDetailTableAdapter;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTab2OrderDetail;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTab2OrderStatus;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentHoursDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource fKOrdersDetOrder440B1D61BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Done;
    }
}