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
            this.qtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.editQtyButton = new System.Windows.Forms.Button();
            this.editPriceButton = new System.Windows.Forms.Button();
            this.searchSkuButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.maintenanceDataSet = new GSEP.MaintenanceDataSet();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter = new GSEP.MaintenanceDataSetTableAdapters.MaintenanceTableAdapter();
            this.tableAdapterManager = new GSEP.MaintenanceDataSetTableAdapters.TableAdapterManager();
            this.maintenanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).BeginInit();
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
            lastNameLabel.Location = new System.Drawing.Point(65, 259);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 32);
            lastNameLabel.TabIndex = 79;
            lastNameLabel.Text = "Price:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(35, 298);
            departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(91, 32);
            departmentLabel.TabIndex = 80;
            departmentLabel.Text = "Quantity:";
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
            // qtyNumericUpDown
            // 
            this.qtyNumericUpDown.Location = new System.Drawing.Point(130, 310);
            this.qtyNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.qtyNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyNumericUpDown.Name = "qtyNumericUpDown";
            this.qtyNumericUpDown.Size = new System.Drawing.Size(232, 20);
            this.qtyNumericUpDown.TabIndex = 84;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(130, 271);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(232, 20);
            this.priceTextBox.TabIndex = 83;
            // 
            // descTextBox
            // 
            this.descTextBox.AcceptsReturn = true;
            this.descTextBox.Location = new System.Drawing.Point(130, 142);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(232, 121);
            this.descTextBox.TabIndex = 82;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(130, 111);
            this.skuTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(232, 20);
            this.skuTextBox.TabIndex = 81;
            // 
            // editQtyButton
            // 
            this.editQtyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.editQtyButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQtyButton.Location = new System.Drawing.Point(156, 345);
            this.editQtyButton.Margin = new System.Windows.Forms.Padding(2);
            this.editQtyButton.Name = "editQtyButton";
            this.editQtyButton.Size = new System.Drawing.Size(98, 56);
            this.editQtyButton.TabIndex = 76;
            this.editQtyButton.Text = "Add Maintenance Schedule";
            this.editQtyButton.UseVisualStyleBackColor = false;
            // 
            // editPriceButton
            // 
            this.editPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.editPriceButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceButton.Location = new System.Drawing.Point(267, 345);
            this.editPriceButton.Margin = new System.Windows.Forms.Padding(2);
            this.editPriceButton.Name = "editPriceButton";
            this.editPriceButton.Size = new System.Drawing.Size(95, 56);
            this.editPriceButton.TabIndex = 75;
            this.editPriceButton.Text = "Modify Maintenance Schedule";
            this.editPriceButton.UseVisualStyleBackColor = false;
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
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.addProductButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(44, 406);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(319, 35);
            this.addProductButton.TabIndex = 73;
            this.addProductButton.Text = "Delete Maintenance Schedule";
            this.addProductButton.UseVisualStyleBackColor = false;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.maintenanceDataGridView.DataSource = this.maintenanceBindingSource;
            this.maintenanceDataGridView.Location = new System.Drawing.Point(382, 111);
            this.maintenanceDataGridView.Name = "maintenanceDataGridView";
            this.maintenanceDataGridView.Size = new System.Drawing.Size(324, 330);
            this.maintenanceDataGridView.TabIndex = 86;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaintenanceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaintenanceID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.ClientSize = new System.Drawing.Size(727, 460);
            this.Controls.Add(this.maintenanceDataGridView);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.qtyNumericUpDown);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.skuTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.editQtyButton);
            this.Controls.Add(this.editPriceButton);
            this.Controls.Add(this.searchSkuButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "ViewMaintenance";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.NumericUpDown qtyNumericUpDown;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Button editQtyButton;
        private System.Windows.Forms.Button editPriceButton;
        private System.Windows.Forms.Button searchSkuButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label titleLabel;
        private MaintenanceDataSet maintenanceDataSet;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private MaintenanceDataSetTableAdapters.MaintenanceTableAdapter maintenanceTableAdapter;
        private MaintenanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView maintenanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}