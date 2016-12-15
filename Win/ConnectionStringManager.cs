using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace StaticGenerator
{
    public enum AuthenticationType
    {
        WindowsAuthentication,
        SqlServerAuthentication
    }

    public partial class ConnectionStringManager : Form
    {
        private readonly Dictionary<AuthenticationType, string> _authenticationTitleMap = new Dictionary<AuthenticationType, string>
        {
            { AuthenticationType.WindowsAuthentication, "Windows Authentication" },
            { AuthenticationType.SqlServerAuthentication, "Sql Server Authentication" }
        };

        private readonly AuthenticationType InitialAuthenticationType = AuthenticationType.WindowsAuthentication;
        private const string DatabaseNameQuery = "SELECT name FROM master.sys.databases ORDER BY name";

        public ConnectionStringManager()
        {
            InitializeComponent();

            var authenticationTypes = Enum.GetValues(typeof(AuthenticationType)).Cast<AuthenticationType>();
            foreach (var authType in authenticationTypes)
            {
                authenticationComboBox.Items.Add(_authenticationTitleMap[authType]);
            }
            authenticationComboBox.SelectedIndex = (int) InitialAuthenticationType;
            testConnectionButton.Enabled = false;
        }

        private void ConnectionStringManager_Load(object sender, EventArgs e)
        {
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
            // Generate connection string, persist it, etc
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getDatabasesButton_Click(object sender, EventArgs e)
        {
            var connString = string.Format("Server={0};Integrated Security=SSPI", serverNameTextBox.Text);
            var databases = new List<string>();
            databaseNameComboBox.Items.Clear();

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

            if (databases.Count > 0)
            {
                databaseNameComboBox.Items.AddRange(databases.ToArray());
                databaseNameComboBox.SelectedIndex = 0;
            }

            testConnectionButton.Enabled = databaseNameComboBox.Items.Count > 0;
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
