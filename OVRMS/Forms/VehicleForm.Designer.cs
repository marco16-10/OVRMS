namespace OVRMS.Forms
{
    partial class VehicleForm
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
            System.Windows.Forms.Label idVehicleLabel;
            System.Windows.Forms.Label idCategoryLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label registrationNoLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label odometerLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label imageFilePathLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label idCategoryLabel1;
            this.VehicleDetailGroupBox = new System.Windows.Forms.GroupBox();
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.imageFilePathTextBox = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ovrmsDataSet = new OVRMS.OVRMSDataSet();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.odometerTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.registrationNoTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.idCategoryTextBox = new System.Windows.Forms.TextBox();
            this.idVehicleTextBox = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.vehicleGroupBox = new System.Windows.Forms.GroupBox();
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.vVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tableAdapterManager = new OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager();
            this.vehicleTableAdapter = new OVRMS.OVRMSDataSetTableAdapters.VehicleTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.idCategoryComboBox = new System.Windows.Forms.ComboBox();
            idVehicleLabel = new System.Windows.Forms.Label();
            idCategoryLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            registrationNoLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            odometerLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            imageFilePathLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            idCategoryLabel1 = new System.Windows.Forms.Label();
            this.VehicleDetailGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovrmsDataSet)).BeginInit();
            this.vehicleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiclesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idVehicleLabel
            // 
            idVehicleLabel.AutoSize = true;
            idVehicleLabel.Location = new System.Drawing.Point(25, 47);
            idVehicleLabel.Name = "idVehicleLabel";
            idVehicleLabel.Size = new System.Drawing.Size(83, 20);
            idVehicleLabel.TabIndex = 0;
            idVehicleLabel.Text = "Id Vehicle:";
            // 
            // idCategoryLabel
            // 
            idCategoryLabel.AutoSize = true;
            idCategoryLabel.Location = new System.Drawing.Point(25, 88);
            idCategoryLabel.Name = "idCategoryLabel";
            idCategoryLabel.Size = new System.Drawing.Size(95, 20);
            idCategoryLabel.TabIndex = 2;
            idCategoryLabel.Text = "Id Category:";
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(25, 127);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(108, 20);
            manufacturerLabel.TabIndex = 4;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(25, 167);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "Model:";
            // 
            // registrationNoLabel
            // 
            registrationNoLabel.AutoSize = true;
            registrationNoLabel.Location = new System.Drawing.Point(25, 207);
            registrationNoLabel.Name = "registrationNoLabel";
            registrationNoLabel.Size = new System.Drawing.Size(123, 20);
            registrationNoLabel.TabIndex = 8;
            registrationNoLabel.Text = "Registration No:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(410, 87);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(50, 20);
            colorLabel.TabIndex = 12;
            colorLabel.Text = "Color:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(410, 127);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // odometerLabel
            // 
            odometerLabel.AutoSize = true;
            odometerLabel.Location = new System.Drawing.Point(410, 167);
            odometerLabel.Name = "odometerLabel";
            odometerLabel.Size = new System.Drawing.Size(84, 20);
            odometerLabel.TabIndex = 16;
            odometerLabel.Text = "Odometer:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(410, 207);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(47, 20);
            yearLabel.TabIndex = 18;
            yearLabel.Text = "Year:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(25, 247);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(55, 20);
            notesLabel.TabIndex = 20;
            notesLabel.Text = "Notes:";
            // 
            // imageFilePathLabel
            // 
            imageFilePathLabel.AutoSize = true;
            imageFilePathLabel.Location = new System.Drawing.Point(707, 47);
            imageFilePathLabel.Name = "imageFilePathLabel";
            imageFilePathLabel.Size = new System.Drawing.Size(124, 20);
            imageFilePathLabel.TabIndex = 23;
            imageFilePathLabel.Text = "Image File Path:";
            // 
            // VehicleDetailGroupBox
            // 
            this.VehicleDetailGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VehicleDetailGroupBox.Controls.Add(idCategoryLabel1);
            this.VehicleDetailGroupBox.Controls.Add(this.idCategoryComboBox);
            this.VehicleDetailGroupBox.Controls.Add(statusLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.statusComboBox);
            this.VehicleDetailGroupBox.Controls.Add(this.vehiclePictureBox);
            this.VehicleDetailGroupBox.Controls.Add(imageFilePathLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.imageFilePathTextBox);
            this.VehicleDetailGroupBox.Controls.Add(this.loadImageButton);
            this.VehicleDetailGroupBox.Controls.Add(notesLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.notesTextBox);
            this.VehicleDetailGroupBox.Controls.Add(yearLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.yearTextBox);
            this.VehicleDetailGroupBox.Controls.Add(odometerLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.odometerTextBox);
            this.VehicleDetailGroupBox.Controls.Add(descriptionLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.descriptionTextBox);
            this.VehicleDetailGroupBox.Controls.Add(colorLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.colorTextBox);
            this.VehicleDetailGroupBox.Controls.Add(registrationNoLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.registrationNoTextBox);
            this.VehicleDetailGroupBox.Controls.Add(modelLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.modelTextBox);
            this.VehicleDetailGroupBox.Controls.Add(manufacturerLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.manufacturerTextBox);
            this.VehicleDetailGroupBox.Controls.Add(idCategoryLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.idCategoryTextBox);
            this.VehicleDetailGroupBox.Controls.Add(idVehicleLabel);
            this.VehicleDetailGroupBox.Controls.Add(this.idVehicleTextBox);
            this.VehicleDetailGroupBox.ForeColor = System.Drawing.Color.White;
            this.VehicleDetailGroupBox.Location = new System.Drawing.Point(28, 110);
            this.VehicleDetailGroupBox.Name = "VehicleDetailGroupBox";
            this.VehicleDetailGroupBox.Size = new System.Drawing.Size(1728, 341);
            this.VehicleDetailGroupBox.TabIndex = 31;
            this.VehicleDetailGroupBox.TabStop = false;
            this.VehicleDetailGroupBox.Text = "Vehicle Details";
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vehiclePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vehiclePictureBox.Image = global::OVRMS.Properties.Resources.CarRentalLogo;
            this.vehiclePictureBox.Location = new System.Drawing.Point(1131, 44);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(572, 268);
            this.vehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.vehiclePictureBox.TabIndex = 25;
            this.vehiclePictureBox.TabStop = false;
            // 
            // imageFilePathTextBox
            // 
            this.imageFilePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "ImageFilePath", true));
            this.imageFilePathTextBox.Location = new System.Drawing.Point(837, 44);
            this.imageFilePathTextBox.Name = "imageFilePathTextBox";
            this.imageFilePathTextBox.Size = new System.Drawing.Size(288, 26);
            this.imageFilePathTextBox.TabIndex = 24;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.ovrmsDataSet;
            // 
            // ovrmsDataSet
            // 
            this.ovrmsDataSet.DataSetName = "OVRMSDataSet";
            this.ovrmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadImageButton
            // 
            this.loadImageButton.ForeColor = System.Drawing.Color.Black;
            this.loadImageButton.Location = new System.Drawing.Point(1030, 164);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(95, 60);
            this.loadImageButton.TabIndex = 22;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(164, 244);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(535, 68);
            this.notesTextBox.TabIndex = 21;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(539, 204);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(160, 26);
            this.yearTextBox.TabIndex = 19;
            // 
            // odometerTextBox
            // 
            this.odometerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Odometer", true));
            this.odometerTextBox.Location = new System.Drawing.Point(539, 164);
            this.odometerTextBox.Name = "odometerTextBox";
            this.odometerTextBox.Size = new System.Drawing.Size(160, 26);
            this.odometerTextBox.TabIndex = 17;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(539, 124);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(160, 26);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(539, 84);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(160, 26);
            this.colorTextBox.TabIndex = 13;
            // 
            // registrationNoTextBox
            // 
            this.registrationNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "RegistrationNo", true));
            this.registrationNoTextBox.Location = new System.Drawing.Point(164, 204);
            this.registrationNoTextBox.Name = "registrationNoTextBox";
            this.registrationNoTextBox.Size = new System.Drawing.Size(160, 26);
            this.registrationNoTextBox.TabIndex = 9;
            this.registrationNoTextBox.Tag = "mandatory";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(164, 164);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(160, 26);
            this.modelTextBox.TabIndex = 7;
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(164, 124);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(160, 26);
            this.manufacturerTextBox.TabIndex = 5;
            // 
            // idCategoryTextBox
            // 
            this.idCategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "IdCategory", true));
            this.idCategoryTextBox.Location = new System.Drawing.Point(164, 84);
            this.idCategoryTextBox.Name = "idCategoryTextBox";
            this.idCategoryTextBox.Size = new System.Drawing.Size(160, 26);
            this.idCategoryTextBox.TabIndex = 3;
            this.idCategoryTextBox.Tag = "mandatory";
            // 
            // idVehicleTextBox
            // 
            this.idVehicleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "IdVehicle", true));
            this.idVehicleTextBox.Enabled = false;
            this.idVehicleTextBox.Location = new System.Drawing.Point(164, 44);
            this.idVehicleTextBox.Name = "idVehicleTextBox";
            this.idVehicleTextBox.Size = new System.Drawing.Size(160, 26);
            this.idVehicleTextBox.TabIndex = 1;
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
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Vehicles";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehicleGroupBox
            // 
            this.vehicleGroupBox.Controls.Add(this.vehicleDataGridView);
            this.vehicleGroupBox.ForeColor = System.Drawing.Color.White;
            this.vehicleGroupBox.Location = new System.Drawing.Point(28, 468);
            this.vehicleGroupBox.Name = "vehicleGroupBox";
            this.vehicleGroupBox.Size = new System.Drawing.Size(1728, 319);
            this.vehicleGroupBox.TabIndex = 33;
            this.vehicleGroupBox.TabStop = false;
            this.vehicleGroupBox.Text = "Vehicle List";
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.CategoryName,
            this.CategoryDescription,
            this.DailyRate,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.vehicleDataGridView.DataSource = this.vVehiclesBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(29, 38);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.vehicleDataGridView.RowTemplate.Height = 28;
            this.vehicleDataGridView.Size = new System.Drawing.Size(1674, 266);
            this.vehicleDataGridView.TabIndex = 0;
            this.vehicleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.defaultDataGridView_CellClick);
            this.vehicleDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.defaultDataGridView_RowHeaderMouseClick);
            // 
            // vVehiclesBindingSource
            // 
            this.vVehiclesBindingSource.DataMember = "v_Vehicles";
            this.vVehiclesBindingSource.DataSource = this.ovrmsDataSet;
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
            this.toolStrip1.TabIndex = 34;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.PayrollTableAdapter = null;
            this.tableAdapterManager.RentalTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OVRMS.OVRMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleCategoryTableAdapter = null;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVehicle";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Vehicle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCategory";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id Category";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 55;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Manufacturer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Manufacturer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Color";
            this.dataGridViewTextBoxColumn7.HeaderText = "Color";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RegistrationNo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Registr. No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Width = 80;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "CategoryDescription";
            this.CategoryDescription.HeaderText = "Cat. Description";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.Width = 130;
            // 
            // DailyRate
            // 
            this.DailyRate.DataPropertyName = "DailyRate";
            this.DailyRate.HeaderText = "Daily Rate ($)";
            this.DailyRate.Name = "DailyRate";
            this.DailyRate.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Odometer";
            this.dataGridViewTextBoxColumn9.HeaderText = "Odometer";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn10.HeaderText = "Year";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(410, 47);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(60, 20);
            statusLabel.TabIndex = 25;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Servicing"});
            this.statusComboBox.Location = new System.Drawing.Point(539, 44);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(160, 28);
            this.statusComboBox.TabIndex = 26;
            // 
            // idCategoryLabel1
            // 
            idCategoryLabel1.AutoSize = true;
            idCategoryLabel1.Location = new System.Drawing.Point(736, 102);
            idCategoryLabel1.Name = "idCategoryLabel1";
            idCategoryLabel1.Size = new System.Drawing.Size(95, 20);
            idCategoryLabel1.TabIndex = 26;
            idCategoryLabel1.Text = "Id Category:";
            // 
            // idCategoryComboBox
            // 
            this.idCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "IdCategory", true));
            this.idCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehicleBindingSource, "IdCategory", true));
            this.idCategoryComboBox.DataSource = this.vVehiclesBindingSource;
            this.idCategoryComboBox.DisplayMember = "CategoryName";
            this.idCategoryComboBox.FormattingEnabled = true;
            this.idCategoryComboBox.Location = new System.Drawing.Point(837, 99);
            this.idCategoryComboBox.Name = "idCategoryComboBox";
            this.idCategoryComboBox.Size = new System.Drawing.Size(288, 28);
            this.idCategoryComboBox.TabIndex = 27;
            this.idCategoryComboBox.ValueMember = "IdCategory";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1778, 802);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.vehicleGroupBox);
            this.Controls.Add(this.VehicleDetailGroupBox);
            this.Controls.Add(this.lblTitle);
            this.Name = "VehicleForm";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.VehicleForm_Load);
            this.VehicleDetailGroupBox.ResumeLayout(false);
            this.VehicleDetailGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ovrmsDataSet)).EndInit();
            this.vehicleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiclesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox VehicleDetailGroupBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox odometerTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox registrationNoTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox idCategoryTextBox;
        private System.Windows.Forms.TextBox idVehicleTextBox;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.TextBox imageFilePathTextBox;
        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private System.Windows.Forms.GroupBox vehicleGroupBox;
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
        private OVRMSDataSet ovrmsDataSet;
        private OVRMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private OVRMSDataSetTableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.BindingSource vVehiclesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox idCategoryComboBox;
    }
}