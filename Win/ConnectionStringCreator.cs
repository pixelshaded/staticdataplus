using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using StaticGenerator.Models;

namespace StaticGenerator
{
    public enum AuthenticationType
    {
        WindowsAuthentication,
        SqlServerAuthentication
    }

    public partial class ConnectionStringCreator : Form
    {
        private Dictionary<AuthenticationType, AuthenticationMetaData> AuthenticationMetaDataMap { get; set; }

        private readonly AuthenticationType InitialAuthenticationType = AuthenticationType.WindowsAuthentication;
        private const string DatabaseNameQuery = "SELECT name FROM master.sys.databases ORDER BY name";
        private const string ApplicationName = "StaticDataScriptGenerator";
        private frmGenerate ParentForm { get; set; }

        public ConnectionStringCreator(frmGenerate parentForm)
        {
            ParentForm = parentForm;
            InitializeComponent();

            AuthenticationMetaDataMap =  new Dictionary<AuthenticationType, AuthenticationMetaData>
            {
                {
                    AuthenticationType.WindowsAuthentication,
                    new AuthenticationMetaData
                    {
                        Name = "Windows Authentication",
                        GetConnectionString = () => string.Format("Data Source={0};Integrated Security=SSPI; Application Name={1};", serverNameTextBox.Text, ApplicationName)
                    }
                },
                { 
                    AuthenticationType.SqlServerAuthentication,
                    new AuthenticationMetaData
                    {
                        Name = "Sql Server Authentication",
                        GetConnectionString = () => string.Format("Data Source={0}; User Id={1}; Password={2}; Application Name={3};", serverNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, ApplicationName)
                    }
                 }
            };

            var authenticationTypes = Enum.GetValues(typeof(AuthenticationType)).Cast<AuthenticationType>();
            foreach (var authType in authenticationTypes)
            {
                authenticationComboBox.Items.Add(AuthenticationMetaDataMap[authType].Name);
            }
            authenticationComboBox.SelectedIndex = (int) InitialAuthenticationType;
            connectionStringOutputLabel.Text = "";
            okButton.Enabled = false;
        }

        private void ConnectionStringManager_Load(object sender, EventArgs e)
        {
            databaseNameComboBox.Items.Clear();
            okButton.Enabled = false;
            connectionStringOutputLabel.Text = "";
        }

        private void authenticationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authenticationComboBox.SelectedIndex == (int) AuthenticationType.WindowsAuthentication)
            {
                userNameTextBox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
                userNameTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
            }
            else if (authenticationComboBox.SelectedIndex == (int) AuthenticationType.SqlServerAuthentication)
            {
                userNameTextBox.Text = "";
                userNameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            ParentForm.AddConnectionString(connectionStringOutputLabel.Text);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getDatabasesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serverNameTextBox.Text))
            {
                MessageBox.Show("Please enter a server name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            connectionStringOutputLabel.Text = "Getting databases...";
            var authType = (AuthenticationType) authenticationComboBox.SelectedIndex;
            var connString = AuthenticationMetaDataMap[authType].GetConnectionString();

            var databases = new List<string>();
            databaseNameComboBox.Items.Clear();

            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    var command = new SqlCommand(DatabaseNameQuery, connection);
                    connection.Open();

                    var dataReader = command.ExecuteReader(CommandBehavior.Default);

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            databases.Add(dataReader.GetString(0));
                        }
                    }

                    dataReader.Close();
                }
            }
            catch (SqlException sqlException)
            {
                MessageBox.Show("An error occured while attempting to connect to server" +
                    Environment.NewLine + Environment.NewLine + "Error text: " + sqlException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                okButton.Enabled = false;
                connectionStringOutputLabel.Text = "Failed to get databases";
                return;
            }

            if (databases.Count > 0)
            {
                databaseNameComboBox.Items.AddRange(databases.ToArray());
                databaseNameComboBox.SelectedIndex = 0;
                okButton.Enabled = true;

                connectionStringOutputLabel.Text = GetFullConnectionString();
            }
        }

        private string GetFullConnectionString()
        {
            var authType = (AuthenticationType) authenticationComboBox.SelectedIndex;
            var connString =  string.Format("Initial Catalog={0};", databaseNameComboBox.SelectedItem) + AuthenticationMetaDataMap[authType].GetConnectionString();
            return connString;
        }

        private void databaseNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionStringOutputLabel.Text = GetFullConnectionString();
        }
    }
}
