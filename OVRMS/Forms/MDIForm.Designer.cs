namespace OVRMS
{
    partial class MDIForm
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.vehicleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.reportToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.invoiceStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalHystoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payslipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.employeeTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AllowDrop = true;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(84)))), ((int)(((byte)(124)))));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.customerToolStripButton,
            this.vehicleToolStripButton,
            this.employeeToolStripButton,
            this.reportToolStripButton,
            this.tableToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 33);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(84, 761);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::OVRMS.Properties.Resources.CarRentalLogo;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 25);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(79, 10);
            // 
            // customerToolStripButton
            // 
            this.customerToolStripButton.AutoSize = false;
            this.customerToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(158)))), ((int)(((byte)(57)))));
            this.customerToolStripButton.ForeColor = System.Drawing.Color.White;
            this.customerToolStripButton.Image = global::OVRMS.Properties.Resources.Customers;
            this.customerToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.customerToolStripButton.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.customerToolStripButton.Margin = new System.Windows.Forms.Padding(1);
            this.customerToolStripButton.Name = "customerToolStripButton";
            this.customerToolStripButton.Size = new System.Drawing.Size(80, 80);
            this.customerToolStripButton.Text = "Customers";
            this.customerToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customerToolStripButton.ToolTipText = "Customers";
            this.customerToolStripButton.Click += new System.EventHandler(this.customerToolStripButton_Click);
            // 
            // vehicleToolStripButton
            // 
            this.vehicleToolStripButton.AutoSize = false;
            this.vehicleToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(184)))), ((int)(((byte)(51)))));
            this.vehicleToolStripButton.ForeColor = System.Drawing.Color.White;
            this.vehicleToolStripButton.Image = global::OVRMS.Properties.Resources.Vehicles;
            this.vehicleToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.vehicleToolStripButton.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.vehicleToolStripButton.Margin = new System.Windows.Forms.Padding(1);
            this.vehicleToolStripButton.Name = "vehicleToolStripButton";
            this.vehicleToolStripButton.Size = new System.Drawing.Size(80, 80);
            this.vehicleToolStripButton.Text = "Vehicles";
            this.vehicleToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vehicleToolStripButton.ToolTipText = "Vehicles";
            // 
            // employeeToolStripButton
            // 
            this.employeeToolStripButton.AutoSize = false;
            this.employeeToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(207)))), ((int)(((byte)(58)))));
            this.employeeToolStripButton.ForeColor = System.Drawing.Color.White;
            this.employeeToolStripButton.Image = global::OVRMS.Properties.Resources.Employees;
            this.employeeToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.employeeToolStripButton.ImageTransparentColor = System.Drawing.Color.Maroon;
            this.employeeToolStripButton.Margin = new System.Windows.Forms.Padding(1);
            this.employeeToolStripButton.Name = "employeeToolStripButton";
            this.employeeToolStripButton.Size = new System.Drawing.Size(80, 80);
            this.employeeToolStripButton.Text = "Employee";
            this.employeeToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.employeeToolStripButton.ToolTipText = "Employees";
            this.employeeToolStripButton.Click += new System.EventHandler(this.employeeToolStripButton_Click);
            // 
            // reportToolStripButton
            // 
            this.reportToolStripButton.AutoSize = false;
            this.reportToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(150)))), ((int)(((byte)(118)))));
            this.reportToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceStripMenuItem,
            this.rentalHystoryToolStripMenuItem,
            this.payslipsToolStripMenuItem});
            this.reportToolStripButton.ForeColor = System.Drawing.Color.White;
            this.reportToolStripButton.Image = global::OVRMS.Properties.Resources.Reports;
            this.reportToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.reportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportToolStripButton.Margin = new System.Windows.Forms.Padding(1);
            this.reportToolStripButton.Name = "reportToolStripButton";
            this.reportToolStripButton.Size = new System.Drawing.Size(80, 80);
            this.reportToolStripButton.Text = "Reports";
            this.reportToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reportToolStripButton.ToolTipText = "Reports";
            // 
            // invoiceStripMenuItem
            // 
            this.invoiceStripMenuItem.Image = global::OVRMS.Properties.Resources.invoices40;
            this.invoiceStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.invoiceStripMenuItem.Name = "invoiceStripMenuItem";
            this.invoiceStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.invoiceStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.invoiceStripMenuItem.Text = "Invoices";
            this.invoiceStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // rentalHystoryToolStripMenuItem
            // 
            this.rentalHystoryToolStripMenuItem.Image = global::OVRMS.Properties.Resources.RentHistory40;
            this.rentalHystoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rentalHystoryToolStripMenuItem.Name = "rentalHystoryToolStripMenuItem";
            this.rentalHystoryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.rentalHystoryToolStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.rentalHystoryToolStripMenuItem.Text = "Rental Hystory";
            // 
            // payslipsToolStripMenuItem
            // 
            this.payslipsToolStripMenuItem.Image = global::OVRMS.Properties.Resources.Payroll40;
            this.payslipsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payslipsToolStripMenuItem.Name = "payslipsToolStripMenuItem";
            this.payslipsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.payslipsToolStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.payslipsToolStripMenuItem.Text = "Payslips";
            // 
            // tableToolStripButton
            // 
            this.tableToolStripButton.AutoSize = false;
            this.tableToolStripButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(181)))), ((int)(((byte)(196)))));
            this.tableToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeTypesToolStripMenuItem,
            this.employeeStatusToolStripMenuItem});
            this.tableToolStripButton.ForeColor = System.Drawing.Color.White;
            this.tableToolStripButton.Image = global::OVRMS.Properties.Resources.tables103;
            this.tableToolStripButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tableToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tableToolStripButton.Name = "tableToolStripButton";
            this.tableToolStripButton.Size = new System.Drawing.Size(80, 80);
            this.tableToolStripButton.Text = "Tables";
            this.tableToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // employeeTypesToolStripMenuItem
            // 
            this.employeeTypesToolStripMenuItem.Image = global::OVRMS.Properties.Resources.tables40;
            this.employeeTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeTypesToolStripMenuItem.Name = "employeeTypesToolStripMenuItem";
            this.employeeTypesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.employeeTypesToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.employeeTypesToolStripMenuItem.Text = "Employee Types";
            // 
            // employeeStatusToolStripMenuItem
            // 
            this.employeeStatusToolStripMenuItem.Image = global::OVRMS.Properties.Resources.tables40;
            this.employeeStatusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeStatusToolStripMenuItem.Name = "employeeStatusToolStripMenuItem";
            this.employeeStatusToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.employeeStatusToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.employeeStatusToolStripMenuItem.Text = "Employee Status";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(84, 764);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1394, 30);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.helpToolStripMenuItem.Text = "              ";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(69, 6);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.windowToolStripMenuItem.Text = "&Windows";
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 794);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIForm";
            this.Text = "MDIForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton customerToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton vehicleToolStripButton;
        private System.Windows.Forms.ToolStripButton employeeToolStripButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton reportToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem invoiceStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalHystoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payslipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tableToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem employeeTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeStatusToolStripMenuItem;
    }
}