namespace StaticGenerator
{
    partial class ConnectionStringCreator
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
            this.getDatabasesButton = new System.Windows.Forms.Button();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.connectionStringOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverNameTextBox.Location = new System.Drawing.Point(169, 27);
            this.serverNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(319, 22);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(29, 31);
            this.serverNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(91, 16);
            this.serverNameLabel.TabIndex = 1;
            this.serverNameLabel.Text = "Server Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Authentication:";
            // 
            // authenticationComboBox
            // 
            this.authenticationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authenticationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authenticationComboBox.FormattingEnabled = true;
            this.authenticationComboBox.Location = new System.Drawing.Point(169, 75);
            this.authenticationComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authenticationComboBox.Name = "authenticationComboBox";
            this.authenticationComboBox.Size = new System.Drawing.Size(319, 24);
            this.authenticationComboBox.TabIndex = 4;
            this.authenticationComboBox.SelectedIndexChanged += new System.EventHandler(this.authenticationComboBox_SelectedIndexChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(29, 130);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(80, 16);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Location = new System.Drawing.Point(169, 127);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(319, 22);
            this.userNameTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(29, 177);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 16);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Location = new System.Drawing.Point(169, 174);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(319, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // databaseNameComboBox
            // 
            this.databaseNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseNameComboBox.FormattingEnabled = true;
            this.databaseNameComboBox.Location = new System.Drawing.Point(169, 263);
            this.databaseNameComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.databaseNameComboBox.Name = "databaseNameComboBox";
            this.databaseNameComboBox.Size = new System.Drawing.Size(319, 24);
            this.databaseNameComboBox.TabIndex = 9;
            this.databaseNameComboBox.SelectedIndexChanged += new System.EventHandler(this.databaseNameComboBox_SelectedIndexChanged);
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.Location = new System.Drawing.Point(29, 267);
            this.databaseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(111, 16);
            this.databaseNameLabel.TabIndex = 10;
            this.databaseNameLabel.Text = "Database Name:";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(281, 364);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Add";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(389, 364);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // getDatabasesButton
            // 
            this.getDatabasesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getDatabasesButton.Location = new System.Drawing.Point(363, 217);
            this.getDatabasesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDatabasesButton.Name = "getDatabasesButton";
            this.getDatabasesButton.Size = new System.Drawing.Size(127, 28);
            this.getDatabasesButton.TabIndex = 13;
            this.getDatabasesButton.Text = "Get Databases";
            this.getDatabasesButton.UseVisualStyleBackColor = true;
            this.getDatabasesButton.Click += new System.EventHandler(this.getDatabasesButton_Click);
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.AutoSize = true;
            this.connectionStringLabel.Location = new System.Drawing.Point(29, 315);
            this.connectionStringLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(115, 16);
            this.connectionStringLabel.TabIndex = 15;
            this.connectionStringLabel.Text = "Connection String:";
            // 
            // connectionStringOutputLabel
            // 
            this.connectionStringOutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionStringOutputLabel.AutoEllipsis = true;
            this.connectionStringOutputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionStringOutputLabel.Location = new System.Drawing.Point(165, 315);
            this.connectionStringOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectionStringOutputLabel.Name = "connectionStringOutputLabel";
            this.connectionStringOutputLabel.Size = new System.Drawing.Size(324, 16);
            this.connectionStringOutputLabel.TabIndex = 16;
            this.connectionStringOutputLabel.Text = "Connection String Output";
            // 
            // ConnectionStringCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 417);
            this.Controls.Add(this.connectionStringOutputLabel);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.getDatabasesButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectionStringCreator";
            this.Text = "Add Connection String";
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
        private System.Windows.Forms.Button getDatabasesButton;
        private System.Windows.Forms.Label connectionStringLabel;
        private System.Windows.Forms.Label connectionStringOutputLabel;
    }
}