namespace GSEP
{
    partial class ManageUsersForm
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.editNameButton = new System.Windows.Forms.Button();
            this.changeDeptButton = new System.Windows.Forms.Button();
            this.resetPassButton = new System.Windows.Forms.Button();
            this.updatePermsButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.depTextBox = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.permsGroupBox = new System.Windows.Forms.GroupBox();
            this.changeSuppliesCheckBox = new System.Windows.Forms.CheckBox();
            this.changeProductsCheckBox = new System.Windows.Forms.CheckBox();
            this.manageMaintenanceCheckBox = new System.Windows.Forms.CheckBox();
            this.viewEmployeesCheckBox = new System.Windows.Forms.CheckBox();
            this.createUsersCheckBox = new System.Windows.Forms.CheckBox();
            this.generatePasswordsCheckBox = new System.Windows.Forms.CheckBox();
            this.employeesDataSet = new GSEP.EmployeesDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new GSEP.EmployeesDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new GSEP.EmployeesDataSetTableAdapters.TableAdapterManager();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            employeeIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            this.permsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            employeeIDLabel.Location = new System.Drawing.Point(18, 117);
            employeeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(126, 32);
            employeeIDLabel.TabIndex = 42;
            employeeIDLabel.Text = "Employee ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(30, 149);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(112, 32);
            firstNameLabel.TabIndex = 46;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(33, 180);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(108, 32);
            lastNameLabel.TabIndex = 48;
            lastNameLabel.Text = "Last Name:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentLabel.Location = new System.Drawing.Point(22, 209);
            departmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(119, 32);
            departmentLabel.TabIndex = 50;
            departmentLabel.Text = "Department:";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(21, 87);
            this.instructionsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(500, 26);
            this.instructionsLabel.TabIndex = 42;
            this.instructionsLabel.Text = "Please enter an employee ID along with the information you want changed then pres" +
    "s the corresponding button.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editNameButton
            // 
            this.editNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.editNameButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.editNameButton.Location = new System.Drawing.Point(122, 252);
            this.editNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(98, 56);
            this.editNameButton.TabIndex = 41;
            this.editNameButton.Text = "Edit Name";
            this.editNameButton.UseVisualStyleBackColor = false;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            // 
            // changeDeptButton
            // 
            this.changeDeptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.changeDeptButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.changeDeptButton.Location = new System.Drawing.Point(224, 252);
            this.changeDeptButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeDeptButton.Name = "changeDeptButton";
            this.changeDeptButton.Size = new System.Drawing.Size(95, 56);
            this.changeDeptButton.TabIndex = 40;
            this.changeDeptButton.Text = "Change Department";
            this.changeDeptButton.UseVisualStyleBackColor = false;
            this.changeDeptButton.Click += new System.EventHandler(this.changeDeptButton_Click);
            // 
            // resetPassButton
            // 
            this.resetPassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.resetPassButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.resetPassButton.Location = new System.Drawing.Point(21, 252);
            this.resetPassButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetPassButton.Name = "resetPassButton";
            this.resetPassButton.Size = new System.Drawing.Size(96, 56);
            this.resetPassButton.TabIndex = 39;
            this.resetPassButton.Text = "Reset Password";
            this.resetPassButton.UseVisualStyleBackColor = false;
            this.resetPassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // updatePermsButton
            // 
            this.updatePermsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.updatePermsButton.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePermsButton.Location = new System.Drawing.Point(341, 313);
            this.updatePermsButton.Margin = new System.Windows.Forms.Padding(2);
            this.updatePermsButton.Name = "updatePermsButton";
            this.updatePermsButton.Size = new System.Drawing.Size(180, 35);
            this.updatePermsButton.TabIndex = 38;
            this.updatePermsButton.Text = "Update Permissions";
            this.updatePermsButton.UseVisualStyleBackColor = false;
            this.updatePermsButton.Click += new System.EventHandler(this.changePermsButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.deleteUserButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(22, 313);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(298, 35);
            this.deleteUserButton.TabIndex = 37;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.titleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 38F, System.Drawing.FontStyle.Underline);
            this.titleLabel.Location = new System.Drawing.Point(251, 7);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(345, 64);
            this.titleLabel.TabIndex = 22;
            this.titleLabel.Text = "Manage Users";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(140, 129);
            this.empIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(180, 20);
            this.empIDTextBox.TabIndex = 53;
            this.empIDTextBox.TextChanged += new System.EventHandler(this.empIDTextBox_TextChanged);
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(140, 160);
            this.fNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.fNameTextBox.TabIndex = 55;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(140, 191);
            this.lNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(180, 20);
            this.lNameTextBox.TabIndex = 56;
            // 
            // depTextBox
            // 
            this.depTextBox.Location = new System.Drawing.Point(140, 221);
            this.depTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.depTextBox.Name = "depTextBox";
            this.depTextBox.Size = new System.Drawing.Size(180, 20);
            this.depTextBox.TabIndex = 57;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(753, 7);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(95, 31);
            this.menuButton.TabIndex = 60;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // permsGroupBox
            // 
            this.permsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.permsGroupBox.Controls.Add(this.changeSuppliesCheckBox);
            this.permsGroupBox.Controls.Add(this.changeProductsCheckBox);
            this.permsGroupBox.Controls.Add(this.manageMaintenanceCheckBox);
            this.permsGroupBox.Controls.Add(this.viewEmployeesCheckBox);
            this.permsGroupBox.Controls.Add(this.createUsersCheckBox);
            this.permsGroupBox.Controls.Add(this.generatePasswordsCheckBox);
            this.permsGroupBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permsGroupBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.permsGroupBox.Location = new System.Drawing.Point(342, 129);
            this.permsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.permsGroupBox.Name = "permsGroupBox";
            this.permsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.permsGroupBox.Size = new System.Drawing.Size(179, 179);
            this.permsGroupBox.TabIndex = 61;
            this.permsGroupBox.TabStop = false;
            this.permsGroupBox.Text = "Permissions";
            // 
            // changeSuppliesCheckBox
            // 
            this.changeSuppliesCheckBox.AutoSize = true;
            this.changeSuppliesCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSuppliesCheckBox.Location = new System.Drawing.Point(4, 123);
            this.changeSuppliesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.changeSuppliesCheckBox.Name = "changeSuppliesCheckBox";
            this.changeSuppliesCheckBox.Size = new System.Drawing.Size(166, 27);
            this.changeSuppliesCheckBox.TabIndex = 5;
            this.changeSuppliesCheckBox.Text = "Add/Remove Supplies";
            this.changeSuppliesCheckBox.UseVisualStyleBackColor = true;
            // 
            // changeProductsCheckBox
            // 
            this.changeProductsCheckBox.AutoSize = true;
            this.changeProductsCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeProductsCheckBox.Location = new System.Drawing.Point(4, 17);
            this.changeProductsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.changeProductsCheckBox.Name = "changeProductsCheckBox";
            this.changeProductsCheckBox.Size = new System.Drawing.Size(167, 27);
            this.changeProductsCheckBox.TabIndex = 0;
            this.changeProductsCheckBox.Text = "Add/Remove Products";
            this.changeProductsCheckBox.UseVisualStyleBackColor = true;
            // 
            // manageMaintenanceCheckBox
            // 
            this.manageMaintenanceCheckBox.AutoSize = true;
            this.manageMaintenanceCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMaintenanceCheckBox.Location = new System.Drawing.Point(4, 38);
            this.manageMaintenanceCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.manageMaintenanceCheckBox.Name = "manageMaintenanceCheckBox";
            this.manageMaintenanceCheckBox.Size = new System.Drawing.Size(160, 27);
            this.manageMaintenanceCheckBox.TabIndex = 1;
            this.manageMaintenanceCheckBox.Text = "Manage Maintenance";
            this.manageMaintenanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // viewEmployeesCheckBox
            // 
            this.viewEmployeesCheckBox.AutoSize = true;
            this.viewEmployeesCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmployeesCheckBox.Location = new System.Drawing.Point(4, 102);
            this.viewEmployeesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.viewEmployeesCheckBox.Name = "viewEmployeesCheckBox";
            this.viewEmployeesCheckBox.Size = new System.Drawing.Size(130, 27);
            this.viewEmployeesCheckBox.TabIndex = 4;
            this.viewEmployeesCheckBox.Text = "View Employees";
            this.viewEmployeesCheckBox.UseVisualStyleBackColor = true;
            // 
            // createUsersCheckBox
            // 
            this.createUsersCheckBox.AutoSize = true;
            this.createUsersCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUsersCheckBox.Location = new System.Drawing.Point(4, 59);
            this.createUsersCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.createUsersCheckBox.Name = "createUsersCheckBox";
            this.createUsersCheckBox.Size = new System.Drawing.Size(109, 27);
            this.createUsersCheckBox.TabIndex = 2;
            this.createUsersCheckBox.Text = "Create Users";
            this.createUsersCheckBox.UseVisualStyleBackColor = true;
            // 
            // generatePasswordsCheckBox
            // 
            this.generatePasswordsCheckBox.AutoSize = true;
            this.generatePasswordsCheckBox.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePasswordsCheckBox.Location = new System.Drawing.Point(4, 80);
            this.generatePasswordsCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.generatePasswordsCheckBox.Name = "generatePasswordsCheckBox";
            this.generatePasswordsCheckBox.Size = new System.Drawing.Size(155, 27);
            this.generatePasswordsCheckBox.TabIndex = 3;
            this.generatePasswordsCheckBox.Text = "Generate Passwords";
            this.generatePasswordsCheckBox.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.UpdateOrder = GSEP.EmployeesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AutoGenerateColumns = false;
            this.employeesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employeesDataGridView.DataSource = this.employeesBindingSource;
            this.employeesDataGridView.Location = new System.Drawing.Point(539, 87);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(289, 262);
            this.employeesDataGridView.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(853, 364);
            this.Controls.Add(this.employeesDataGridView);
            this.Controls.Add(this.permsGroupBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.depTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.updatePermsButton);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.editNameButton);
            this.Controls.Add(this.changeDeptButton);
            this.Controls.Add(this.resetPassButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.permsGroupBox.ResumeLayout(false);
            this.permsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button editNameButton;
        private System.Windows.Forms.Button changeDeptButton;
        private System.Windows.Forms.Button resetPassButton;
        private System.Windows.Forms.Button updatePermsButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox depTextBox;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.GroupBox permsGroupBox;
        private System.Windows.Forms.CheckBox changeSuppliesCheckBox;
        private System.Windows.Forms.CheckBox changeProductsCheckBox;
        private System.Windows.Forms.CheckBox manageMaintenanceCheckBox;
        private System.Windows.Forms.CheckBox viewEmployeesCheckBox;
        private System.Windows.Forms.CheckBox createUsersCheckBox;
        private System.Windows.Forms.CheckBox generatePasswordsCheckBox;
        private EmployeesDataSet employeesDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private EmployeesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}