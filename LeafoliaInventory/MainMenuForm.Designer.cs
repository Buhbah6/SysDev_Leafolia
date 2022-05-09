namespace LeafoliaInventory
{
    partial class MainMenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.createUsersButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.manageMaintenanceButton = new System.Windows.Forms.Button();
            this.manageUsersButton = new System.Windows.Forms.Button();
            this.manageProductsButton = new System.Windows.Forms.Button();
            this.manageSuppliesButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(219)))), ((int)(((byte)(132)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createUsersButton
            // 
            this.createUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.createUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createUsersButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUsersButton.ForeColor = System.Drawing.Color.Black;
            this.createUsersButton.Location = new System.Drawing.Point(46, 130);
            this.createUsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.createUsersButton.Name = "createUsersButton";
            this.createUsersButton.Size = new System.Drawing.Size(215, 93);
            this.createUsersButton.TabIndex = 2;
            this.createUsersButton.Text = "Create Users";
            this.createUsersButton.UseVisualStyleBackColor = false;
            this.createUsersButton.Click += new System.EventHandler(this.createUsersButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePasswordButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.Black;
            this.changePasswordButton.Location = new System.Drawing.Point(322, 130);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(215, 93);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // manageMaintenanceButton
            // 
            this.manageMaintenanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.manageMaintenanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageMaintenanceButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageMaintenanceButton.ForeColor = System.Drawing.Color.Black;
            this.manageMaintenanceButton.Location = new System.Drawing.Point(322, 261);
            this.manageMaintenanceButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageMaintenanceButton.Name = "manageMaintenanceButton";
            this.manageMaintenanceButton.Size = new System.Drawing.Size(215, 93);
            this.manageMaintenanceButton.TabIndex = 4;
            this.manageMaintenanceButton.Text = "Manage Plant Maintenance";
            this.manageMaintenanceButton.UseVisualStyleBackColor = false;
            this.manageMaintenanceButton.Click += new System.EventHandler(this.manageMaintenanceButton_Click);
            // 
            // manageUsersButton
            // 
            this.manageUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.manageUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageUsersButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersButton.ForeColor = System.Drawing.Color.Black;
            this.manageUsersButton.Location = new System.Drawing.Point(46, 261);
            this.manageUsersButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageUsersButton.Name = "manageUsersButton";
            this.manageUsersButton.Size = new System.Drawing.Size(215, 93);
            this.manageUsersButton.TabIndex = 5;
            this.manageUsersButton.Text = "Manage Users";
            this.manageUsersButton.UseVisualStyleBackColor = false;
            this.manageUsersButton.Click += new System.EventHandler(this.manageUsersButton_Click);
            // 
            // manageProductsButton
            // 
            this.manageProductsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.manageProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageProductsButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageProductsButton.ForeColor = System.Drawing.Color.Black;
            this.manageProductsButton.Location = new System.Drawing.Point(46, 391);
            this.manageProductsButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageProductsButton.Name = "manageProductsButton";
            this.manageProductsButton.Size = new System.Drawing.Size(215, 93);
            this.manageProductsButton.TabIndex = 6;
            this.manageProductsButton.Text = "View/Manage Products";
            this.manageProductsButton.UseVisualStyleBackColor = false;
            this.manageProductsButton.Click += new System.EventHandler(this.manageProductsButton_Click);
            // 
            // manageSuppliesButton
            // 
            this.manageSuppliesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.manageSuppliesButton.Enabled = false;
            this.manageSuppliesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageSuppliesButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSuppliesButton.ForeColor = System.Drawing.Color.Black;
            this.manageSuppliesButton.Location = new System.Drawing.Point(322, 391);
            this.manageSuppliesButton.Margin = new System.Windows.Forms.Padding(2);
            this.manageSuppliesButton.Name = "manageSuppliesButton";
            this.manageSuppliesButton.Size = new System.Drawing.Size(215, 93);
            this.manageSuppliesButton.TabIndex = 7;
            this.manageSuppliesButton.Text = "View/Manage Supplies";
            this.manageSuppliesButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(46, 569);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(491, 54);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(112)))), ((int)(((byte)(29)))));
            this.calendarButton.Enabled = false;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calendarButton.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.Color.White;
            this.calendarButton.Location = new System.Drawing.Point(46, 500);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(491, 54);
            this.calendarButton.TabIndex = 9;
            this.calendarButton.Text = "View Calendar";
            this.calendarButton.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(584, 645);
            this.Controls.Add(this.calendarButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.manageSuppliesButton);
            this.Controls.Add(this.manageProductsButton);
            this.Controls.Add(this.manageUsersButton);
            this.Controls.Add(this.manageMaintenanceButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.createUsersButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUsersButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button manageMaintenanceButton;
        private System.Windows.Forms.Button manageUsersButton;
        private System.Windows.Forms.Button manageProductsButton;
        private System.Windows.Forms.Button manageSuppliesButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button calendarButton;
    }
}