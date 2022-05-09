namespace LeafoliaInventory
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.employeesDataSet = new LeafoliaInventory.EmployeesDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new LeafoliaInventory.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new LeafoliaInventory.EmployeesDataSetTableAdapters.TableAdapterManager();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDataSet = new LeafoliaInventory.MaintenanceDataSet();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceTableAdapter = new LeafoliaInventory.MaintenanceDataSetTableAdapters.MaintenanceTableAdapter();
            this.tableAdapterManager1 = new LeafoliaInventory.MaintenanceDataSetTableAdapters.TableAdapterManager();
            this.maintenanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataSet = new LeafoliaInventory.ProductsDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new LeafoliaInventory.ProductsDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager2 = new LeafoliaInventory.ProductsDataSetTableAdapters.TableAdapterManager();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDataSet
            // 
            this.employeesDataSet.DataSetName = "EmployeesDataSet";
            this.employeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.UpdateOrder = LeafoliaInventory.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(12, 146);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(776, 220);
            this.employeesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Permissions";
            this.dataGridViewTextBoxColumn6.HeaderText = "Permissions";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MaintenanceTableAdapter = this.maintenanceTableAdapter;
            this.tableAdapterManager1.UpdateOrder = LeafoliaInventory.MaintenanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maintenanceDataGridView
            // 
            this.maintenanceDataGridView.AutoGenerateColumns = false;
            this.maintenanceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.maintenanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.maintenanceDataGridView.DataSource = this.maintenanceBindingSource;
            this.maintenanceDataGridView.Location = new System.Drawing.Point(12, 411);
            this.maintenanceDataGridView.Name = "maintenanceDataGridView";
            this.maintenanceDataGridView.Size = new System.Drawing.Size(776, 220);
            this.maintenanceDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MaintenanceID";
            this.dataGridViewTextBoxColumn7.HeaderText = "MaintenanceID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductSKU";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProductSKU";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Strategy";
            this.dataGridViewTextBoxColumn9.HeaderText = "Strategy";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "InitialDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "InitialDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Interval";
            this.dataGridViewTextBoxColumn11.HeaderText = "Interval";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager2.UpdateOrder = LeafoliaInventory.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(12, 676);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(776, 220);
            this.productsDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProductSKU";
            this.dataGridViewTextBoxColumn12.HeaderText = "ProductSKU";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn13.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn14.HeaderText = "Price";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn15.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(704, 2);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(95, 31);
            this.menuButton.TabIndex = 61;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(29)))));
            this.printButton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(12, 911);
            this.printButton.Margin = new System.Windows.Forms.Padding(2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(776, 71);
            this.printButton.TabIndex = 62;
            this.printButton.Text = "Print Database Contents";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 81);
            this.label1.TabIndex = 63;
            this.label1.Text = "All Database Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(800, 992);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.maintenanceDataGridView);
            this.Controls.Add(this.employeesDataGridView);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LeafoliaInventory.EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private LeafoliaInventory.EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private LeafoliaInventory.EmployeesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private LeafoliaInventory.MaintenanceDataSet maintenanceDataSet;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private LeafoliaInventory.MaintenanceDataSetTableAdapters.MaintenanceTableAdapter maintenanceTableAdapter;
        private LeafoliaInventory.MaintenanceDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView maintenanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private LeafoliaInventory.ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private LeafoliaInventory.ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private LeafoliaInventory.ProductsDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}