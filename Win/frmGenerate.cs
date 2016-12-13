using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using StaticGeneratorCommon;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json;

namespace StaticGenerator
{
    public partial class frmGenerate : Form
    {
        public frmGenerate()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            fbdDropFolder.ShowDialog();
            if (string.IsNullOrEmpty(fbdDropFolder.SelectedPath) == false)
            {
                txtFolder.Text = fbdDropFolder.SelectedPath;
            }
        }

        private void frmGenerate_Load(object sender, EventArgs e)
        {
            // Load previous settings
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastDropFolder))
            {
                this.txtFolder.Text = Properties.Settings.Default.LastDropFolder;
            }

            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastConnectionString))
            {
                this.connectionStringComboBox.Text = Properties.Settings.Default.LastConnectionString;
            }

            this.chkCreateIndex.Checked = Properties.Settings.Default.LastIndexChoice;

            this.connectionStringComboBox.Items.AddRange(GetPreviousConnectionStrings().ToArray());
        }

        private void frmGenerate_Closing(Object sender, FormClosingEventArgs e)
        {
            // Save settings
            
            Properties.Settings.Default.LastDropFolder = this.txtFolder.Text;
            Properties.Settings.Default.LastIndexChoice = this.chkCreateIndex.Checked;
            Properties.Settings.Default.Save();
        }

        private void LoadTableList(string strConnectionString)
        {
            try
            {
                Globals.ConnectionString = strConnectionString;

                DataTable dtTableList = new DataTable("Tables");
                SqlCommand cdTableList = Globals.Connection.CreateCommand();
                cdTableList.CommandText = "SELECT TABLE_NAME, TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
                dtTableList.Load(cdTableList.ExecuteReader(CommandBehavior.CloseConnection));

                clbTables.Items.Clear();

                foreach (DataRow drTableName in dtTableList.Rows)
                {
                    clbTables.Items.Add(string.Format("[{0}].[{1}]", drTableName[1].ToString(), drTableName[0].ToString()));
                }

                clbTables.Sorted = true;
                SavePreviousConnectionString(strConnectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("An error occured while attempting to open the table list. Have you specified a connection string in the settings file?" +
                    Environment.NewLine + Environment.NewLine + "Error text: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while attempting to open the table list." +
                    Environment.NewLine + Environment.NewLine + "Error text: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerateScripts_Click(object sender, EventArgs e)
        {
            // Make sure they have selected a folder
            if (string.IsNullOrEmpty(txtFolder.Text) == true)
            {
                MessageBox.Show("Please select a folder to drop the generated script(s) into", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Make sure the folder exists
            if (!System.IO.Directory.Exists(this.txtFolder.Text))
            {
                MessageBox.Show("The selected folder does not exist. Pleas select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Make sure they have selected at least one table
            if (clbTables.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one table to generate scripts for", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Make sure the template exists
            if (File.Exists("DefaultTemplate.sql") == false)
            {
                MessageBox.Show("Template file DefaultTemplate.sql not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Load the template
            StreamReader srTemplate = new StreamReader("DefaultTemplate.sql");
            string strTemplate = srTemplate.ReadToEnd();
            srTemplate.Close();

            foreach (string strTableName in clbTables.CheckedItems)
            {
                // Replace the tablename placeholder in the template
                string strNewTemplate = strTemplate.Replace("<TABLENAME>", strTableName);

                // Create the file
                StreamWriter swOutFile = new StreamWriter(Path.Combine(txtFolder.Text, StripBrackets(strTableName)) + ".staticdata.sql", false);
                swOutFile.Write(Globals.CreateStaticDataManager(strTableName, strNewTemplate));
                swOutFile.Close();
            }

            if (chkCreateIndex.Checked == true)
            {
                // Create index file
                StreamWriter swIndex = new StreamWriter(Path.Combine(txtFolder.Text, "index.txt"), false);
                foreach (string strTableName in clbTables.CheckedItems)
                {
                    swIndex.WriteLine(":r .\\StaticData\\" + StripBrackets(strTableName) + ".staticdata.sql");
                }
                swIndex.Close();
            }

            MessageBox.Show("Done!!", "Static Data Script Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Quick hack function to remove the square brackets
        /// from the table name for use with filenames
        /// </summary>
        /// <param name="pText">The text to strip square brackets from</param>
        /// <returns></returns>
        private string StripBrackets(string pText)
        {
            return pText.Replace("[", "").Replace("]", "");
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = selectAllCheckBox.CheckState;

            for(int i=0; i < clbTables.Items.Count; i++)
                clbTables.SetItemCheckState(i, state);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionStringComboBox.Text))
            {
                MessageBox.Show("Please provide a connection string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LoadTableList(connectionStringComboBox.Text);
        }

        private void openDropFolderButton_Click(object sender, EventArgs e)
        {
            // Make sure the folder exists
            if (!System.IO.Directory.Exists(this.txtFolder.Text))
            {
                MessageBox.Show("The selected folder does not exist. Pleas select a valid directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Process.Start(txtFolder.Text);
        }

        private void SavePreviousConnectionString(string previousConnectionString)
        {
            Properties.Settings.Default.LastConnectionString = this.connectionStringComboBox.Text;

            var connections = GetPreviousConnectionStrings();
            if (connections.Any(conn => string.Equals(conn, previousConnectionString)))
            {
                return;
            }

            connections.Add(previousConnectionString);
            connectionStringComboBox.Items.Add(previousConnectionString);
            Properties.Settings.Default.PreviousConnectionStrings = JsonConvert.SerializeObject(connections);
        }

        private List<string> GetPreviousConnectionStrings()
        {
            return JsonConvert.DeserializeObject<List<string>>(Properties.Settings.Default.PreviousConnectionStrings);
        }
    }
}