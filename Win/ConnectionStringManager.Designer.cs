namespace StaticGenerator
{
    partial class ConnectionStringManager
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
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authenticationComboBox = new System.Windows.Forms.ComboBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.databaseNameComboBox = new System.Windows.Forms.ComboBox();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(127, 22);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(240, 20);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(22, 25);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(72, 13);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Server Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Authentication:";
            // 
            // authenticationComboBox
            // 
            this.authenticationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authenticationComboBox.FormattingEnabled = true;
            this.authenticationComboBox.Location = new System.Drawing.Point(127, 61);
            this.authenticationComboBox.Name = "authenticationComboBox";
            this.authenticationComboBox.Size = new System.Drawing.Size(240, 21);
            this.authenticationComboBox.TabIndex = 4;
            this.authenticationComboBox.SelectedIndexChanged += new System.EventHandler(this.authenticationComboBox_SelectedIndexChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(22, 106);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(127, 103);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(240, 20);
            this.userNameTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(22, 144);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(127, 141);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // databaseNameComboBox
            // 
            this.databaseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseNameComboBox.FormattingEnabled = true;
            this.databaseNameComboBox.Location = new System.Drawing.Point(127, 181);
            this.databaseNameComboBox.Name = "databaseNameComboBox";
            this.databaseNameComboBox.Size = new System.Drawing.Size(240, 21);
            this.databaseNameComboBox.TabIndex = 9;
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(22, 184);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(87, 13);
            this.databaseNameLabel.TabIndex = 10;
            this.databaseNameLabel.Text = "Database Name:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(211, 219);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(292, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ConnectionStringManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 254);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.databaseNameLabel);
            this.Controls.Add(this.databaseNameComboBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.authenticationComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.serverNameTextBox);
            this.Name = "ConnectionStringManager";
            this.Text = "Connection String Manager";
            this.Load += new System.EventHandler(this.ConnectionStringManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox authenticationComboBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox databaseNameComboBox;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}