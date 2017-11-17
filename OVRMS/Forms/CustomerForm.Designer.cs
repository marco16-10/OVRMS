namespace OVRMS
{
    partial class CustomerForm
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
            System.Windows.Forms.Label idCustomerLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label licenceNumberLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label notesLabel;
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oVRMSDataSet = new OVRMS.OVRMSDataSet();
            this.idCustomerTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.licenceNumberTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CustomerDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBoxRentals = new System.Windows.Forms.GroupBox();
            this.customerTableAdapter = new OVRMS.OVRMSDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager();
            this.v_RentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_RentalsTableAdapter = new OVRMS.OVRMSDataSetTableAdapters.v_RentalsTableAdapter();
            this.v_RentalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            idCustomerLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            licenceNumberLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVRMSDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.CustomerDetailGroupBox.SuspendLayout();
            this.CustomerListGroupBox.SuspendLayout();
            this.groupBoxRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_RentalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_RentalsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idCustomerLabel
            // 
            idCustomerLabel.AutoSize = true;
            idCustomerLabel.BackColor = System.Drawing.Color.Transparent;
            idCustomerLabel.ForeColor = System.Drawing.Color.White;
            idCustomerLabel.Location = new System.Drawing.Point(16, 49);
            idCustomerLabel.Name = "idCustomerLabel";
            idCustomerLabel.Size = new System.Drawing.Size(100, 20);
            idCustomerLabel.TabIndex = 7;
            idCustomerLabel.Text = "Id Customer:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(16, 85);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(16, 122);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Last Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = System.Drawing.Color.Transparent;
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(16, 159);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address:";
            // 
            // licenceNumberLabel
            // 
            licenceNumberLabel.AutoSize = true;
            licenceNumberLabel.BackColor = System.Drawing.Color.Transparent;
            licenceNumberLabel.ForeColor = System.Drawing.Color.White;
            licenceNumberLabel.Location = new System.Drawing.Point(16, 196);
            licenceNumberLabel.Name = "licenceNumberLabel";
            licenceNumberLabel.Size = new System.Drawing.Size(96, 20);
            licenceNumberLabel.TabIndex = 11;
            licenceNumberLabel.Text = "Licence No.:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            dateOfBirthLabel.ForeColor = System.Drawing.Color.White;
            dateOfBirthLabel.Location = new System.Drawing.Point(292, 49);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(103, 20);
            dateOfBirthLabel.TabIndex = 12;
            dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = System.Drawing.Color.Transparent;
            statusLabel.ForeColor = System.Drawing.Color.White;
            statusLabel.Location = new System.Drawing.Point(292, 85);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "Status:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(292, 122);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.BackColor = System.Drawing.Color.Transparent;
            mobileLabel.ForeColor = System.Drawing.Color.White;
            mobileLabel.Location = new System.Drawing.Point(292, 159);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(59, 20);
            mobileLabel.TabIndex = 18;
            mobileLabel.Text = "Mobile:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.BackColor = System.Drawing.Color.Transparent;
            notesLabel.ForeColor = System.Drawing.Color.White;
            notesLabel.Location = new System.Drawing.Point(16, 248);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(55, 20);
            notesLabel.TabIndex = 20;
            notesLabel.Text = "Notes:";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(20, 42);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 20;
            this.customerDataGridView.RowTemplate.ReadOnly = true;
            this.customerDataGridView.Size = new System.Drawing.Size(1123, 257);
            this.customerDataGridView.TabIndex = 7;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellClick);
            this.customerDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCustomer";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Customer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn10.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.oVRMSDataSet;
            // 
            // oVRMSDataSet
            // 
            this.oVRMSDataSet.DataSetName = "OVRMSDataSet";
            this.oVRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idCustomerTextBox
            // 
            this.idCustomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "IdCustomer", true));
            this.idCustomerTextBox.Enabled = false;
            this.idCustomerTextBox.Location = new System.Drawing.Point(120, 42);
            this.idCustomerTextBox.Name = "idCustomerTextBox";
            this.idCustomerTextBox.Size = new System.Drawing.Size(154, 26);
            this.idCustomerTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(120, 79);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.firstNameTextBox.TabIndex = 9;
            this.firstNameTextBox.Tag = "mandatory";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(120, 116);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.lastNameTextBox.TabIndex = 10;
            this.lastNameTextBox.Tag = "mandatory";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(120, 153);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(154, 26);
            this.addressTextBox.TabIndex = 11;
            // 
            // licenceNumberTextBox
            // 
            this.licenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LicenceNumber", true));
            this.licenceNumberTextBox.Location = new System.Drawing.Point(120, 190);
            this.licenceNumberTextBox.Name = "licenceNumberTextBox";
            this.licenceNumberTextBox.Size = new System.Drawing.Size(154, 26);
            this.licenceNumberTextBox.TabIndex = 12;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(404, 42);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(158, 26);
            this.dateOfBirthDateTimePicker.TabIndex = 13;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(404, 79);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(158, 26);
            this.statusTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(404, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(158, 26);
            this.emailTextBox.TabIndex = 17;
            this.emailTextBox.Tag = "mandatory";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(404, 153);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(158, 26);
            this.mobileTextBox.TabIndex = 19;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(120, 228);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(442, 77);
            this.notesTextBox.TabIndex = 21;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearch,
            this.toolStripReset,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripSaveAsNew,
            this.toolStripDelete,
            this.toolStripSeparator2,
            this.toolStripClose,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1778, 32);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // CustomerDetailGroupBox
            // 
            this.CustomerDetailGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerDetailGroupBox.Controls.Add(this.idCustomerTextBox);
            this.CustomerDetailGroupBox.Controls.Add(idCustomerLabel);
            this.CustomerDetailGroupBox.Controls.Add(notesLabel);
            this.CustomerDetailGroupBox.Controls.Add(this.firstNameTextBox);
            this.CustomerDetailGroupBox.Controls.Add(this.notesTextBox);
            this.CustomerDetailGroupBox.Controls.Add(firstNameLabel);
            this.CustomerDetailGroupBox.Controls.Add(mobileLabel);
            this.CustomerDetailGroupBox.Controls.Add(this.lastNameTextBox);
            this.CustomerDetailGroupBox.Controls.Add(this.mobileTextBox);
            this.CustomerDetailGroupBox.Controls.Add(lastNameLabel);
            this.CustomerDetailGroupBox.Controls.Add(emailLabel);
            this.CustomerDetailGroupBox.Controls.Add(this.addressTextBox);
            this.CustomerDetailGroupBox.Controls.Add(this.emailTextBox);
            this.CustomerDetailGroupBox.Controls.Add(addressLabel);
            this.CustomerDetailGroupBox.Controls.Add(statusLabel);
            this.CustomerDetailGroupBox.Controls.Add(this.licenceNumberTextBox);
            this.CustomerDetailGroupBox.Controls.Add(this.statusTextBox);
            this.CustomerDetailGroupBox.Controls.Add(licenceNumberLabel);
            this.CustomerDetailGroupBox.Controls.Add(dateOfBirthLabel);
            this.CustomerDetailGroupBox.Controls.Add(this.dateOfBirthDateTimePicker);
            this.CustomerDetailGroupBox.ForeColor = System.Drawing.Color.White;
            this.CustomerDetailGroupBox.Location = new System.Drawing.Point(12, 59);
            this.CustomerDetailGroupBox.Name = "CustomerDetailGroupBox";
            this.CustomerDetailGroupBox.Size = new System.Drawing.Size(587, 311);
            this.CustomerDetailGroupBox.TabIndex = 23;
            this.CustomerDetailGroupBox.TabStop = false;
            this.CustomerDetailGroupBox.Text = "Customer Details";
            // 
            // CustomerListGroupBox
            // 
            this.CustomerListGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerListGroupBox.Controls.Add(this.customerDataGridView);
            this.CustomerListGroupBox.ForeColor = System.Drawing.Color.White;
            this.CustomerListGroupBox.Location = new System.Drawing.Point(605, 59);
            this.CustomerListGroupBox.Name = "CustomerListGroupBox";
            this.CustomerListGroupBox.Size = new System.Drawing.Size(1153, 311);
            this.CustomerListGroupBox.TabIndex = 24;
            this.CustomerListGroupBox.TabStop = false;
            this.CustomerListGroupBox.Text = "Customer List";
            // 
            // groupBoxRentals
            // 
            this.groupBoxRentals.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRentals.Controls.Add(this.v_RentalsDataGridView);
            this.groupBoxRentals.ForeColor = System.Drawing.Color.White;
            this.groupBoxRentals.Location = new System.Drawing.Point(12, 382);
            this.groupBoxRentals.Name = "groupBoxRentals";
            this.groupBoxRentals.Size = new System.Drawing.Size(1746, 339);
            this.groupBoxRentals.TabIndex = 25;
            this.groupBoxRentals.TabStop = false;
            this.groupBoxRentals.Text = "Customer Rentals";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleCategoryTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // v_RentalsBindingSource
            // 
            this.v_RentalsBindingSource.DataMember = "v_Rentals";
            this.v_RentalsBindingSource.DataSource = this.oVRMSDataSet;
            // 
            // v_RentalsTableAdapter
            // 
            this.v_RentalsTableAdapter.ClearBeforeFill = true;
            // 
            // v_RentalsDataGridView
            // 
            this.v_RentalsDataGridView.AutoGenerateColumns = false;
            this.v_RentalsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.v_RentalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.v_RentalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.v_RentalsDataGridView.DataSource = this.v_RentalsBindingSource;
            this.v_RentalsDataGridView.Location = new System.Drawing.Point(20, 32);
            this.v_RentalsDataGridView.Name = "v_RentalsDataGridView";
            this.v_RentalsDataGridView.RowTemplate.Height = 28;
            this.v_RentalsDataGridView.Size = new System.Drawing.Size(1716, 297);
            this.v_RentalsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdRental";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdRental";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdCustomer";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdCustomer";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ModelManufacturer";
            this.dataGridViewTextBoxColumn22.HeaderText = "Vehicle";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn23.HeaderText = "Category";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "DailyRate";
            this.dataGridViewTextBoxColumn24.HeaderText = "DailyRate";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdVehicle";
            this.dataGridViewTextBoxColumn9.HeaderText = "IdVehicle";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RentalExpStartDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "Exp Start Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RentalExpEndtDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "Exp End Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RentalActStartDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "Act Start Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RentalActEndDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "Act End Date";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DamagesPenalty";
            this.dataGridViewTextBoxColumn15.HeaderText = "Damages";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "LowFuelPenalty";
            this.dataGridViewTextBoxColumn16.HeaderText = "Low Fuel";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "RoadOffencePenalty";
            this.dataGridViewTextBoxColumn17.HeaderText = "Road Offence";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "LateReturnPenalty";
            this.dataGridViewTextBoxColumn18.HeaderText = "Return Penalty";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "NumberOfKm";
            this.dataGridViewTextBoxColumn19.HeaderText = "Km";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "NumberOfDays";
            this.dataGridViewTextBoxColumn20.HeaderText = "Days";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn21.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Image = global::OVRMS.Properties.Resources.search;
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(92, 29);
            this.toolStripSearch.Text = "Search";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripSearch_Click);
            // 
            // toolStripReset
            // 
            this.toolStripReset.Image = global::OVRMS.Properties.Resources.reset;
            this.toolStripReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReset.Name = "toolStripReset";
            this.toolStripReset.Size = new System.Drawing.Size(82, 29);
            this.toolStripReset.Text = "Reset";
            this.toolStripReset.Click += new System.EventHandler(this.toolStripReset_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = global::OVRMS.Properties.Resources.Save1_24;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(77, 29);
            this.toolStripSave.Text = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSaveAsNew
            // 
            this.toolStripSaveAsNew.Image = global::OVRMS.Properties.Resources.Save_as1_24;
            this.toolStripSaveAsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAsNew.Name = "toolStripSaveAsNew";
            this.toolStripSaveAsNew.Size = new System.Drawing.Size(142, 29);
            this.toolStripSaveAsNew.Text = "Save As New";
            this.toolStripSaveAsNew.Click += new System.EventHandler(this.toolStripSaveAsNew_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = global::OVRMS.Properties.Resources.Delete;
            this.toolStripDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(90, 29);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripClose
            // 
            this.toolStripClose.Image = global::OVRMS.Properties.Resources.Close;
            this.toolStripClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClose.Name = "toolStripClose";
            this.toolStripClose.Size = new System.Drawing.Size(83, 29);
            this.toolStripClose.Text = "Close";
            this.toolStripClose.Click += new System.EventHandler(this.toolStripClose_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::OVRMS.Properties.Resources.Exit;
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(67, 29);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1778, 777);
            this.Controls.Add(this.groupBoxRentals);
            this.Controls.Add(this.CustomerListGroupBox);
            this.Controls.Add(this.CustomerDetailGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVRMSDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CustomerDetailGroupBox.ResumeLayout(false);
            this.CustomerDetailGroupBox.PerformLayout();
            this.CustomerListGroupBox.ResumeLayout(false);
            this.groupBoxRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.v_RentalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_RentalsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OVRMSDataSet oVRMSDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private OVRMSDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private OVRMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox idCustomerTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox licenceNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripButton toolStripClose;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.GroupBox CustomerDetailGroupBox;
        private System.Windows.Forms.GroupBox CustomerListGroupBox;
        private System.Windows.Forms.ToolStripButton toolStripSaveAsNew;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBoxRentals;
        private System.Windows.Forms.BindingSource v_RentalsBindingSource;
        private OVRMSDataSetTableAdapters.v_RentalsTableAdapter v_RentalsTableAdapter;
        private System.Windows.Forms.DataGridView v_RentalsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}