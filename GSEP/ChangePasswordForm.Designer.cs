namespace GSEP
{
    partial class ChangePasswordForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(86)))));
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Sitka Banner", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(571, 1);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(95, 31);
            this.menuButton.TabIndex = 73;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 182);
            this.label5.TabIndex = 72;
            this.label5.Text = "\r\nPassword Requirements: \r\n\r\nMust Contain:\r\nCapital and Lowercase letters,\r\nAt le" +
    "ast 1 number and 1 symbol\r\n\r\nCannot Contain:\r\n- the text \"defaultPass\"\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(65, 255);
            this.showPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(112, 24);
            this.showPasswordCheckBox.TabIndex = 71;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.Click += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.errorLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(71, 350);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 70;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(184)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(139, 295);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(392, 41);
            this.confirmButton.TabIndex = 69;
            this.confirmButton.Text = "Confirm Change";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 68;
            this.label4.Text = "Re-enter New Password:";
            // 
            // newPassTextBox2
            // 
            this.newPassTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTextBox2.Location = new System.Drawing.Point(204, 223);
            this.newPassTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.newPassTextBox2.Multiline = true;
            this.newPassTextBox2.Name = "newPassTextBox2";
            this.newPassTextBox2.PasswordChar = '*';
            this.newPassTextBox2.Size = new System.Drawing.Size(280, 22);
            this.newPassTextBox2.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 66;
            this.label3.Text = "New Password:";
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTextBox.Location = new System.Drawing.Point(204, 159);
            this.newPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.newPassTextBox.Multiline = true;
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.PasswordChar = '*';
            this.newPassTextBox.Size = new System.Drawing.Size(280, 22);
            this.newPassTextBox.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 64;
            this.label2.Text = "Old Password:";
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPassTextBox.Location = new System.Drawing.Point(204, 102);
            this.oldPassTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldPassTextBox.Multiline = true;
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '*';
            this.oldPassTextBox.Size = new System.Drawing.Size(280, 22);
            this.oldPassTextBox.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 46);
            this.label1.TabIndex = 62;
            this.label1.Text = "Change your Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(667, 400);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPassTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPassTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newPassTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Label label1;
    }
}