namespace GSEP
{
    partial class ViewProducts
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.editQtyButton = new System.Windows.Forms.Button();
            this.editPriceButton = new System.Windows.Forms.Button();
            this.searchSkuButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.qtyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuButton = new System.Windows.Forms.Button();
            this.productsDataSet = new GSEP.ProductsDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GSEP.ProductsDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new GSEP.ProductsDataSetTableAdapters.TableAdapterManager();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(12, 102);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(122, 32);
            employeeIDLabel.TabIndex = 62;
            employeeIDLabel.Text = "Product Sku:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(18, 132);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(114, 32);
            firstNameLabel.TabIndex = 63;
            firstNameLabel.Text = "Description:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(68, 163);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 32);
            lastNameLabel.TabIndex = 64;
            lastNameLabel.Text = "Price:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(38, 191);
            departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(91, 32);
            departmentLabel.TabIndex = 65;
            departmentLabel.Text = "Quantity:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Underline);
            this.titleLabel.Location = new System.Drawing.Point(90, 27);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(541, 64);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "View/Manage Products";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(134, 175);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(180, 20);
            this.priceTextBox.TabIndex = 68;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(134, 144);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(180, 20);
            this.descTextBox.TabIndex = 67;
            // 
            // skuTextBox
            // 
            this.skuTextBox.Location = new System.Drawing.Point(134, 113);
            this.skuTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(180, 20);
            this.skuTextBox.TabIndex = 66;
            // 
            // editQtyButton
            // 
            this.editQtyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.editQtyButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQtyButton.Location = new System.Drawing.Point(116, 236);
            this.editQtyButton.Margin = new System.Windows.Forms.Padding(2);
            this.editQtyButton.Name = "editQtyButton";
            this.editQtyButton.Size = new System.Drawing.Size(98, 56);
            this.editQtyButton.TabIndex = 61;
            this.editQtyButton.Text = "Modify Quantity";
            this.editQtyButton.UseVisualStyleBackColor = false;
            this.editQtyButton.Click += new System.EventHandler(this.editQtyButton_Click);
            // 
            // editPriceButton
            // 
            this.editPriceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.editPriceButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPriceButton.Location = new System.Drawing.Point(218, 236);
            this.editPriceButton.Margin = new System.Windows.Forms.Padding(2);
            this.editPriceButton.Name = "editPriceButton";
            this.editPriceButton.Size = new System.Drawing.Size(95, 56);
            this.editPriceButton.TabIndex = 60;
            this.editPriceButton.Text = "Modify Price";
            this.editPriceButton.UseVisualStyleBackColor = false;
            this.editPriceButton.Click += new System.EventHandler(this.editPriceButton_Click);
            // 
            // searchSkuButton
            // 
            this.searchSkuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.searchSkuButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSkuButton.Location = new System.Drawing.Point(15, 236);
            this.searchSkuButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchSkuButton.Name = "searchSkuButton";
            this.searchSkuButton.Size = new System.Drawing.Size(96, 56);
            this.searchSkuButton.TabIndex = 59;
            this.searchSkuButton.Text = "Search by Sku";
            this.searchSkuButton.UseVisualStyleBackColor = false;
            this.searchSkuButton.Click += new System.EventHandler(this.searchSkuButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.addProductButton.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(16, 297);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(298, 35);
            this.addProductButton.TabIndex = 58;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // qtyNumericUpDown
            // 
            this.qtyNumericUpDown.Location = new System.Drawing.Point(134, 205);
            this.qtyNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.qtyNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.qtyNumericUpDown.Name = "qtyNumericUpDown";
            this.qtyNumericUpDown.Size = new System.Drawing.Size(179, 20);
            this.qtyNumericUpDown.TabIndex = 69;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(611, 3);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(95, 31);
            this.menuButton.TabIndex = 70;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = GSEP.ProductsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(331, 113);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(356, 220);
            this.productsDataGridView.TabIndex = 71;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSKU";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductSKU";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "DateAdded";
            this.dataGridViewImageColumn1.HeaderText = "DateAdded";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(709, 353);
            this.Controls.Add(this.productsDataGridView);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewProducts";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.Button editQtyButton;
        private System.Windows.Forms.Button editPriceButton;
        private System.Windows.Forms.Button searchSkuButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.NumericUpDown qtyNumericUpDown;
        private System.Windows.Forms.Button menuButton;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private ProductsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}