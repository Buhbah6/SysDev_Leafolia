namespace GSEP
{
    partial class ViewMaintenance
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
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label departmentLabel;
            this.menuButton = new System.Windows.Forms.Button();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.strategyTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.addScheduleButton = new System.Windows.Forms.Button();
            this.modifyScheduleButton = new System.Windows.Forms.Button();
            this.searchSkuButton = new System.Windows.Forms.Button();
            this.deleteScheduleButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.maintenanceDataSet = new GSEP.MaintenanceDataSet();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter = new GSEP.MaintenanceDataSetTableAdapters.MaintenanceTableAdapter();
            this.tableAdapterManager = new GSEP.MaintenanceDataSetTableAdapters.TableAdapterManager();
            this.maintenanceDataGridView = new System.Windows.Forms.DataGridView();
            this.initialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(8, 100);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(122, 32);
            employeeIDLabel.TabIndex = 77;
            employeeIDLabel.Text = "Product Sku:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(38, 132);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(88, 32);
            firstNameLabel.TabIndex = 78;
            firstNameLabel.Text = "Strategy:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(26, 260);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(104, 32);
            lastNameLabel.TabIndex = 79;
            lastNameLabel.Text = "InitialDate:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(0, 298);
            departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(130, 32);
            departmentLabel.TabIndex = 80;
            departmentLabel.Text = "Daily Interval:";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(627, 6);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(95, 31);
            this.menuButton.TabIndex = 85;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Location = new System.Drawing.Point(130, 310);
            this.intervalNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(232, 20);
            this.intervalNumericUpDown.TabIndex = 84;
            // 
            // strategyTextBox
            // 
            this.strategyTextBox.AcceptsReturn = true;
            this.strategyTextBox.Location = new System.Drawing.Point(130, 142);
            this.strategyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.strategyTextBox.Multiline = true;
            this.strategyTextBox.Name = "strategyTextBox";
            this.strategyTextBox.Size = new System.Drawing.Size(232, 121);
            this.strategyTextBox.TabIndex = 82;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(130, 111);
            this.skuTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(232, 20);
            this.skuTextBox.TabIndex = 81;
            // 
            // addScheduleButton
            // 
            this.addScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.addScheduleButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScheduleButton.Location = new System.Drawing.Point(156, 345);
            this.addScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addScheduleButton.Name = "addScheduleButton";
            this.addScheduleButton.Size = new System.Drawing.Size(98, 56);
            this.addScheduleButton.TabIndex = 76;
            this.addScheduleButton.Text = "Add Maintenance Schedule";
            this.addScheduleButton.UseVisualStyleBackColor = false;
            this.addScheduleButton.Click += new System.EventHandler(this.addScheduleButton_Click);
            // 
            // modifyScheduleButton
            // 
            this.modifyScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.modifyScheduleButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyScheduleButton.Location = new System.Drawing.Point(267, 345);
            this.modifyScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.modifyScheduleButton.Name = "modifyScheduleButton";
            this.modifyScheduleButton.Size = new System.Drawing.Size(95, 56);
            this.modifyScheduleButton.TabIndex = 75;
            this.modifyScheduleButton.Text = "Modify Maintenance Schedule";
            this.modifyScheduleButton.UseVisualStyleBackColor = false;
            this.modifyScheduleButton.Click += new System.EventHandler(this.modifyScheduleButton_Click);
            // 
            // searchSkuButton
            // 
            this.searchSkuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.searchSkuButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSkuButton.Location = new System.Drawing.Point(44, 345);
            this.searchSkuButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchSkuButton.Name = "searchSkuButton";
            this.searchSkuButton.Size = new System.Drawing.Size(96, 56);
            this.searchSkuButton.TabIndex = 74;
            this.searchSkuButton.Text = "Search by Sku";
            this.searchSkuButton.UseVisualStyleBackColor = false;
            this.searchSkuButton.Click += new System.EventHandler(this.searchSkuButton_Click);
            // 
            // deleteScheduleButton
            // 
            this.deleteScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.deleteScheduleButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteScheduleButton.Location = new System.Drawing.Point(44, 406);
            this.deleteScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteScheduleButton.Name = "deleteScheduleButton";
            this.deleteScheduleButton.Size = new System.Drawing.Size(319, 35);
            this.deleteScheduleButton.TabIndex = 73;
            this.deleteScheduleButton.Text = "Delete Maintenance Schedule";
            this.deleteScheduleButton.UseVisualStyleBackColor = false;
            this.deleteScheduleButton.Click += new System.EventHandler(this.deleteScheduleButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Underline);
            this.titleLabel.Location = new System.Drawing.Point(41, 22);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(631, 64);
            this.titleLabel.TabIndex = 72;
            this.titleLabel.Text = "View/Manage Maintenance";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maintenanceDataSet
            // 
            this.maintenanceDataSet.DataSetName = "MaintenanceDataSet";
            this.maintenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataMember = "Maintenance";
            this.maintenanceBindingSource.DataSource = this.maintenanceDataSet;
            // 
            // maintenanceTableAdapter
            // 
            this.maintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaintenanceTableAdapter = this.maintenanceTableAdapter;
            this.tableAdapterManager.UpdateOrder = GSEP.MaintenanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maintenanceDataGridView
            // 
            this.maintenanceDataGridView.AutoGenerateColumns = false;
            this.maintenanceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.maintenanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.maintenanceDataGridView.DataSource = this.maintenanceBindingSource;
            this.maintenanceDataGridView.Location = new System.Drawing.Point(382, 111);
            this.maintenanceDataGridView.Name = "maintenanceDataGridView";
            this.maintenanceDataGridView.Size = new System.Drawing.Size(312, 330);
            this.maintenanceDataGridView.TabIndex = 86;
            // 
            // initialDateTimePicker
            // 
            this.initialDateTimePicker.Location = new System.Drawing.Point(130, 271);
            this.initialDateTimePicker.Name = "initialDateTimePicker";
            this.initialDateTimePicker.Size = new System.Drawing.Size(232, 20);
            this.initialDateTimePicker.TabIndex = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductSKU";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductSKU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Strategy";
            this.dataGridViewTextBoxColumn3.HeaderText = "Strategy";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InitialDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "InitialDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Interval";
            this.dataGridViewTextBoxColumn5.HeaderText = "Interval";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ViewMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(726, 461);
            this.Controls.Add(this.initialDateTimePicker);
            this.Controls.Add(this.maintenanceDataGridView);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.intervalNumericUpDown);
            this.Controls.Add(this.strategyTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.addScheduleButton);
            this.Controls.Add(this.modifyScheduleButton);
            this.Controls.Add(this.searchSkuButton);
            this.Controls.Add(this.deleteScheduleButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ViewMaintenance";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.TextBox strategyTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Button addScheduleButton;
        private System.Windows.Forms.Button modifyScheduleButton;
        private System.Windows.Forms.Button searchSkuButton;
        private System.Windows.Forms.Button deleteScheduleButton;
        private System.Windows.Forms.Label titleLabel;
        private MaintenanceDataSet maintenanceDataSet;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private MaintenanceDataSetTableAdapters.MaintenanceTableAdapter maintenanceTableAdapter;
        private MaintenanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView maintenanceDataGridView;
        private System.Windows.Forms.DateTimePicker initialDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}