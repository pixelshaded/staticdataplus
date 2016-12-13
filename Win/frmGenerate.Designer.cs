namespace StaticGenerator
{
    partial class frmGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerate));
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnGenerateScripts = new System.Windows.Forms.Button();
            this.fbdDropFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkCreateIndex = new System.Windows.Forms.CheckBox();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openDropFolderButton = new System.Windows.Forms.Button();
            this.connectionStringComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // clbTables
            // 
            this.clbTables.CheckOnClick = true;
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(12, 110);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(664, 229);
            this.clbTables.TabIndex = 0;
            this.clbTables.ThreeDCheckBoxes = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select tables to script:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select drop folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(15, 394);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(629, 20);
            this.txtFolder.TabIndex = 3;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(650, 394);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(25, 19);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnGenerateScripts
            // 
            this.btnGenerateScripts.Location = new System.Drawing.Point(15, 461);
            this.btnGenerateScripts.Name = "btnGenerateScripts";
            this.btnGenerateScripts.Size = new System.Drawing.Size(121, 30);
            this.btnGenerateScripts.TabIndex = 5;
            this.btnGenerateScripts.Text = "Generate Scripts";
            this.btnGenerateScripts.UseVisualStyleBackColor = true;
            this.btnGenerateScripts.Click += new System.EventHandler(this.btnGenerateScripts_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(607, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkCreateIndex
            // 
            this.chkCreateIndex.AutoSize = true;
            this.chkCreateIndex.Location = new System.Drawing.Point(15, 432);
            this.chkCreateIndex.Name = "chkCreateIndex";
            this.chkCreateIndex.Size = new System.Drawing.Size(265, 17);
            this.chkCreateIndex.TabIndex = 7;
            this.chkCreateIndex.Text = "Create index script (to paste into post deploy script)";
            this.chkCreateIndex.UseVisualStyleBackColor = true;
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(15, 346);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(70, 17);
            this.selectAllCheckBox.TabIndex = 8;
            this.selectAllCheckBox.Text = "Select &All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(15, 60);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Connection String";
            // 
            // openDropFolderButton
            // 
            this.openDropFolderButton.Location = new System.Drawing.Point(142, 461);
            this.openDropFolderButton.Name = "openDropFolderButton";
            this.openDropFolderButton.Size = new System.Drawing.Size(121, 30);
            this.openDropFolderButton.TabIndex = 12;
            this.openDropFolderButton.Text = "Open Drop Folder";
            this.openDropFolderButton.UseVisualStyleBackColor = true;
            this.openDropFolderButton.Click += new System.EventHandler(this.openDropFolderButton_Click);
            // 
            // connectionStringComboBox
            // 
            this.connectionStringComboBox.FormattingEnabled = true;
            this.connectionStringComboBox.Location = new System.Drawing.Point(12, 33);
            this.connectionStringComboBox.Name = "connectionStringComboBox";
            this.connectionStringComboBox.Size = new System.Drawing.Size(663, 21);
            this.connectionStringComboBox.TabIndex = 13;
            // 
            // frmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 505);
            this.Controls.Add(this.connectionStringComboBox);
            this.Controls.Add(this.openDropFolderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.chkCreateIndex);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateScripts);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Static Data Management Scripts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGenerate_Closing);
            this.Load += new System.EventHandler(this.frmGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnGenerateScripts;
        private System.Windows.Forms.FolderBrowserDialog fbdDropFolder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkCreateIndex;
        private System.Windows.Forms.CheckBox selectAllCheckBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openDropFolderButton;
        private System.Windows.Forms.ComboBox connectionStringComboBox;
    }
}