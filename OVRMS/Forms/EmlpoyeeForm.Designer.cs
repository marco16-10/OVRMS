using System;

namespace OVRMS.Forms
{
    partial class EmlpoyeeForm
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
            System.Windows.Forms.Label idEmpLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label idRoleLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label dateofHireLabel;
            System.Windows.Forms.Label employmentTypeLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hourlyWageLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label qualificationLabel;
            System.Windows.Forms.Label taxCodeLabel;
            System.Windows.Forms.Label isKiwiSaverLabel;
            System.Windows.Forms.Label kiwiSaverContrRateLabel;
            System.Windows.Forms.Label employerContrRateLabel;
            System.Windows.Forms.Label notesLabel;
            this.lblTitle = new System.Windows.Forms.Label();
            this.EmployeeDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oVRMSDataSet = new OVRMS.OVRMSDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.idRoleTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.idEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.payslipDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.employerContrRateTextBox = new System.Windows.Forms.TextBox();
            this.kiwiSaverContrRateTextBox = new System.Windows.Forms.TextBox();
            this.isKiwiSaverTextBox = new System.Windows.Forms.TextBox();
            this.taxCodeTextBox = new System.Windows.Forms.TextBox();
            this.qualificationTextBox = new System.Windows.Forms.TextBox();
            this.hourlyWageTextBox = new System.Windows.Forms.TextBox();
            this.employmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.dateofHireDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeTableAdapter = new OVRMS.OVRMSDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager();
            this.EmployeeListGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idEmpLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            idRoleLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            dateofHireLabel = new System.Windows.Forms.Label();
            employmentTypeLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hourlyWageLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            qualificationLabel = new System.Windows.Forms.Label();
            taxCodeLabel = new System.Windows.Forms.Label();
            isKiwiSaverLabel = new System.Windows.Forms.Label();
            kiwiSaverContrRateLabel = new System.Windows.Forms.Label();
            employerContrRateLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVRMSDataSet)).BeginInit();
            this.payslipDetailGroupBox.SuspendLayout();
            this.EmployeeListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idEmpLabel
            // 
            idEmpLabel.AutoSize = true;
            idEmpLabel.Location = new System.Drawing.Point(13, 37);
            idEmpLabel.Name = "idEmpLabel";
            idEmpLabel.Size = new System.Drawing.Size(64, 20);
            idEmpLabel.TabIndex = 0;
            idEmpLabel.Text = "Id Emp:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(13, 77);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(13, 117);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name:";
            // 
            // idRoleLabel
            // 
            idRoleLabel.AutoSize = true;
            idRoleLabel.Location = new System.Drawing.Point(314, 117);
            idRoleLabel.Name = "idRoleLabel";
            idRoleLabel.Size = new System.Drawing.Size(64, 20);
            idRoleLabel.TabIndex = 6;
            idRoleLabel.Text = "Id Role:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(13, 157);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // dateofHireLabel
            // 
            dateofHireLabel.AutoSize = true;
            dateofHireLabel.Location = new System.Drawing.Point(13, 46);
            dateofHireLabel.Name = "dateofHireLabel";
            dateofHireLabel.Size = new System.Drawing.Size(99, 20);
            dateofHireLabel.TabIndex = 10;
            dateofHireLabel.Text = "Date of Hire:";
            // 
            // employmentTypeLabel
            // 
            employmentTypeLabel.AutoSize = true;
            employmentTypeLabel.Location = new System.Drawing.Point(13, 86);
            employmentTypeLabel.Name = "employmentTypeLabel";
            employmentTypeLabel.Size = new System.Drawing.Size(87, 20);
            employmentTypeLabel.TabIndex = 11;
            employmentTypeLabel.Text = "Empl.Type:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(314, 83);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender:";
            // 
            // hourlyWageLabel
            // 
            hourlyWageLabel.AutoSize = true;
            hourlyWageLabel.Location = new System.Drawing.Point(314, 46);
            hourlyWageLabel.Name = "hourlyWageLabel";
            hourlyWageLabel.Size = new System.Drawing.Size(104, 20);
            hourlyWageLabel.TabIndex = 12;
            hourlyWageLabel.Text = "Hourly Wage:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(314, 37);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(82, 20);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password:";
            // 
            // qualificationLabel
            // 
            qualificationLabel.AutoSize = true;
            qualificationLabel.Location = new System.Drawing.Point(314, 86);
            qualificationLabel.Name = "qualificationLabel";
            qualificationLabel.Size = new System.Drawing.Size(100, 20);
            qualificationLabel.TabIndex = 13;
            qualificationLabel.Text = "Qualification:";
            // 
            // taxCodeLabel
            // 
            taxCodeLabel.AutoSize = true;
            taxCodeLabel.Location = new System.Drawing.Point(13, 126);
            taxCodeLabel.Name = "taxCodeLabel";
            taxCodeLabel.Size = new System.Drawing.Size(80, 20);
            taxCodeLabel.TabIndex = 14;
            taxCodeLabel.Text = "Tax Code:";
            // 
            // isKiwiSaverLabel
            // 
            isKiwiSaverLabel.AutoSize = true;
            isKiwiSaverLabel.Location = new System.Drawing.Point(315, 124);
            isKiwiSaverLabel.Name = "isKiwiSaverLabel";
            isKiwiSaverLabel.Size = new System.Drawing.Size(102, 20);
            isKiwiSaverLabel.TabIndex = 15;
            isKiwiSaverLabel.Text = "Is Kiwi Saver:";
            // 
            // kiwiSaverContrRateLabel
            // 
            kiwiSaverContrRateLabel.AutoSize = true;
            kiwiSaverContrRateLabel.Location = new System.Drawing.Point(13, 166);
            kiwiSaverContrRateLabel.Name = "kiwiSaverContrRateLabel";
            kiwiSaverContrRateLabel.Size = new System.Drawing.Size(167, 20);
            kiwiSaverContrRateLabel.TabIndex = 16;
            kiwiSaverContrRateLabel.Text = "Kiwi Saver Contr Rate:";
            // 
            // employerContrRateLabel
            // 
            employerContrRateLabel.AutoSize = true;
            employerContrRateLabel.Location = new System.Drawing.Point(314, 166);
            employerContrRateLabel.Name = "employerContrRateLabel";
            employerContrRateLabel.Size = new System.Drawing.Size(161, 20);
            employerContrRateLabel.TabIndex = 17;
            employerContrRateLabel.Text = "Employer Contr Rate:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(13, 197);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(55, 20);
            notesLabel.TabIndex = 18;
            notesLabel.Text = "Notes:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(28, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1728, 35);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Employees";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeDetailGroupBox
            // 
            this.EmployeeDetailGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeDetailGroupBox.Controls.Add(notesLabel);
            this.EmployeeDetailGroupBox.Controls.Add(passwordLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.notesTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(this.passwordTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(genderLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.genderTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(addressLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.addressTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(idRoleLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.idRoleTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(lastNameLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.lastNameTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(firstNameLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.firstNameTextBox);
            this.EmployeeDetailGroupBox.Controls.Add(idEmpLabel);
            this.EmployeeDetailGroupBox.Controls.Add(this.idEmployeeTextBox);
            this.EmployeeDetailGroupBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeDetailGroupBox.Location = new System.Drawing.Point(28, 110);
            this.EmployeeDetailGroupBox.Name = "EmployeeDetailGroupBox";
            this.EmployeeDetailGroupBox.Size = new System.Drawing.Size(633, 279);
            this.EmployeeDetailGroupBox.TabIndex = 29;
            this.EmployeeDetailGroupBox.TabStop = false;
            this.EmployeeDetailGroupBox.Text = "Employee Details";
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(114, 194);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(463, 59);
            this.notesTextBox.TabIndex = 19;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.oVRMSDataSet;
            // 
            // oVRMSDataSet
            // 
            this.oVRMSDataSet.DataSetName = "OVRMSDataSet";
            this.oVRMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(423, 34);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 26);
            this.passwordTextBox.TabIndex = 13;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(423, 74);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(154, 26);
            this.genderTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(114, 154);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(463, 26);
            this.addressTextBox.TabIndex = 9;
            // 
            // idRoleTextBox
            // 
            this.idRoleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "IdRole", true));
            this.idRoleTextBox.Location = new System.Drawing.Point(423, 114);
            this.idRoleTextBox.Name = "idRoleTextBox";
            this.idRoleTextBox.Size = new System.Drawing.Size(154, 26);
            this.idRoleTextBox.TabIndex = 7;
            this.idRoleTextBox.Tag = "mandatory";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(114, 114);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.Tag = "mandatory";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(114, 74);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(154, 26);
            this.firstNameTextBox.TabIndex = 3;
            this.firstNameTextBox.Tag = "mandatory";
            // 
            // idEmployeeTextBox
            // 
            this.idEmployeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "IdEmp", true));
            this.idEmployeeTextBox.Enabled = false;
            this.idEmployeeTextBox.Location = new System.Drawing.Point(114, 34);
            this.idEmployeeTextBox.Name = "idEmployeeTextBox";
            this.idEmployeeTextBox.Size = new System.Drawing.Size(154, 26);
            this.idEmployeeTextBox.TabIndex = 1;
            // 
            // payslipDetailGroupBox
            // 
            this.payslipDetailGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.payslipDetailGroupBox.Controls.Add(employerContrRateLabel);
            this.payslipDetailGroupBox.Controls.Add(this.employerContrRateTextBox);
            this.payslipDetailGroupBox.Controls.Add(kiwiSaverContrRateLabel);
            this.payslipDetailGroupBox.Controls.Add(this.kiwiSaverContrRateTextBox);
            this.payslipDetailGroupBox.Controls.Add(isKiwiSaverLabel);
            this.payslipDetailGroupBox.Controls.Add(this.isKiwiSaverTextBox);
            this.payslipDetailGroupBox.Controls.Add(taxCodeLabel);
            this.payslipDetailGroupBox.Controls.Add(this.taxCodeTextBox);
            this.payslipDetailGroupBox.Controls.Add(qualificationLabel);
            this.payslipDetailGroupBox.Controls.Add(this.qualificationTextBox);
            this.payslipDetailGroupBox.Controls.Add(hourlyWageLabel);
            this.payslipDetailGroupBox.Controls.Add(this.hourlyWageTextBox);
            this.payslipDetailGroupBox.Controls.Add(employmentTypeLabel);
            this.payslipDetailGroupBox.Controls.Add(this.employmentTypeTextBox);
            this.payslipDetailGroupBox.Controls.Add(dateofHireLabel);
            this.payslipDetailGroupBox.Controls.Add(this.dateofHireDateTimePicker);
            this.payslipDetailGroupBox.ForeColor = System.Drawing.Color.White;
            this.payslipDetailGroupBox.Location = new System.Drawing.Point(28, 405);
            this.payslipDetailGroupBox.Name = "payslipDetailGroupBox";
            this.payslipDetailGroupBox.Size = new System.Drawing.Size(633, 226);
            this.payslipDetailGroupBox.TabIndex = 30;
            this.payslipDetailGroupBox.TabStop = false;
            this.payslipDetailGroupBox.Text = "Payslip Details";
            // 
            // employerContrRateTextBox
            // 
            this.employerContrRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmployerContrRate", true));
            this.employerContrRateTextBox.Location = new System.Drawing.Point(481, 163);
            this.employerContrRateTextBox.Name = "employerContrRateTextBox";
            this.employerContrRateTextBox.Size = new System.Drawing.Size(96, 26);
            this.employerContrRateTextBox.TabIndex = 18;
            // 
            // kiwiSaverContrRateTextBox
            // 
            this.kiwiSaverContrRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "KiwiSaverContrRate", true));
            this.kiwiSaverContrRateTextBox.Location = new System.Drawing.Point(186, 163);
            this.kiwiSaverContrRateTextBox.Name = "kiwiSaverContrRateTextBox";
            this.kiwiSaverContrRateTextBox.Size = new System.Drawing.Size(82, 26);
            this.kiwiSaverContrRateTextBox.TabIndex = 17;
            // 
            // isKiwiSaverTextBox
            // 
            this.isKiwiSaverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "IsKiwiSaver", true));
            this.isKiwiSaverTextBox.Location = new System.Drawing.Point(423, 123);
            this.isKiwiSaverTextBox.Name = "isKiwiSaverTextBox";
            this.isKiwiSaverTextBox.Size = new System.Drawing.Size(154, 26);
            this.isKiwiSaverTextBox.TabIndex = 16;
            // 
            // taxCodeTextBox
            // 
            this.taxCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "TaxCode", true));
            this.taxCodeTextBox.Location = new System.Drawing.Point(114, 123);
            this.taxCodeTextBox.Name = "taxCodeTextBox";
            this.taxCodeTextBox.Size = new System.Drawing.Size(154, 26);
            this.taxCodeTextBox.TabIndex = 15;
            // 
            // qualificationTextBox
            // 
            this.qualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Qualification", true));
            this.qualificationTextBox.Location = new System.Drawing.Point(423, 83);
            this.qualificationTextBox.Name = "qualificationTextBox";
            this.qualificationTextBox.Size = new System.Drawing.Size(154, 26);
            this.qualificationTextBox.TabIndex = 14;
            // 
            // hourlyWageTextBox
            // 
            this.hourlyWageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HourlyWage", true));
            this.hourlyWageTextBox.Location = new System.Drawing.Point(423, 43);
            this.hourlyWageTextBox.Name = "hourlyWageTextBox";
            this.hourlyWageTextBox.Size = new System.Drawing.Size(154, 26);
            this.hourlyWageTextBox.TabIndex = 13;
            // 
            // employmentTypeTextBox
            // 
            this.employmentTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "EmploymentType", true));
            this.employmentTypeTextBox.Location = new System.Drawing.Point(114, 83);
            this.employmentTypeTextBox.Name = "employmentTypeTextBox";
            this.employmentTypeTextBox.Size = new System.Drawing.Size(154, 26);
            this.employmentTypeTextBox.TabIndex = 12;
            // 
            // dateofHireDateTimePicker
            // 
            this.dateofHireDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "DateofHire", true));
            this.dateofHireDateTimePicker.Location = new System.Drawing.Point(114, 43);
            this.dateofHireDateTimePicker.Name = "dateofHireDateTimePicker";
            this.dateofHireDateTimePicker.Size = new System.Drawing.Size(154, 26);
            this.dateofHireDateTimePicker.TabIndex = 11;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleCategoryTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // EmployeeListGroupBox
            // 
            this.EmployeeListGroupBox.Controls.Add(this.employeeDataGridView);
            this.EmployeeListGroupBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeListGroupBox.Location = new System.Drawing.Point(682, 113);
            this.EmployeeListGroupBox.Name = "EmployeeListGroupBox";
            this.EmployeeListGroupBox.Size = new System.Drawing.Size(1074, 518);
            this.EmployeeListGroupBox.TabIndex = 32;
            this.EmployeeListGroupBox.TabStop = false;
            this.EmployeeListGroupBox.Text = "Employee List";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(16, 30);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.employeeDataGridView.RowTemplate.Height = 20;
            this.employeeDataGridView.Size = new System.Drawing.Size(1031, 451);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultDataGridView_CellClick);
            this.employeeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.defaultDataGridView_RowHeaderMouseClick);
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
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1778, 32);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmp";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdRole";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id Role";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmploymentType";
            this.dataGridViewTextBoxColumn7.HeaderText = "Employment Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Qualification";
            this.dataGridViewTextBoxColumn11.HeaderText = "Qualification";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TaxCode";
            this.dataGridViewTextBoxColumn12.HeaderText = "Tax Code";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 40;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IsKiwiSaver";
            this.dataGridViewTextBoxColumn13.HeaderText = "Is Kiwi Saver";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 65;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "KiwiSaverContrRate";
            this.dataGridViewTextBoxColumn14.HeaderText = "Kiwi Saver ContrRate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 65;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "EmployerContrRate";
            this.dataGridViewTextBoxColumn15.HeaderText = "Employer Contr Rate";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 65;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn16.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // EmlpoyeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1778, 802);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EmployeeListGroupBox);
            this.Controls.Add(this.payslipDetailGroupBox);
            this.Controls.Add(this.EmployeeDetailGroupBox);
            this.Controls.Add(this.lblTitle);
            this.Name = "EmlpoyeeForm";
            this.Text = "Emlpoyee";
            this.Load += new System.EventHandler(this.Form_Load);
            this.EmployeeDetailGroupBox.ResumeLayout(false);
            this.EmployeeDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oVRMSDataSet)).EndInit();
            this.payslipDetailGroupBox.ResumeLayout(false);
            this.payslipDetailGroupBox.PerformLayout();
            this.EmployeeListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox EmployeeDetailGroupBox;
        private System.Windows.Forms.GroupBox payslipDetailGroupBox;
        private OVRMSDataSet oVRMSDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private OVRMSDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private OVRMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox idEmployeeTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox idRoleTextBox;
        private System.Windows.Forms.TextBox employerContrRateTextBox;
        private System.Windows.Forms.TextBox kiwiSaverContrRateTextBox;
        private System.Windows.Forms.TextBox isKiwiSaverTextBox;
        private System.Windows.Forms.TextBox taxCodeTextBox;
        private System.Windows.Forms.TextBox qualificationTextBox;
        private System.Windows.Forms.TextBox hourlyWageTextBox;
        private System.Windows.Forms.TextBox employmentTypeTextBox;
        private System.Windows.Forms.DateTimePicker dateofHireDateTimePicker;
        private System.Windows.Forms.GroupBox EmployeeListGroupBox;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSearch;
        private System.Windows.Forms.ToolStripButton toolStripReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripSaveAsNew;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripClose;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}