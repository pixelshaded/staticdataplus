using System;
using System.Collections.Generic;
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

        private AuthenticationType InitialAuthenticationType = AuthenticationType.WindowsAuthentication;

        public ConnectionStringManager()
        {
            InitializeComponent();

            var authenticationTypes = Enum.GetValues(typeof(AuthenticationType)).Cast<AuthenticationType>();
            foreach (var authType in authenticationTypes)
            {
                authenticationComboBox.Items.Add(_authenticationTitleMap[authType]);
            }
            authenticationComboBox.SelectedIndex = (int) InitialAuthenticationType;
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
    }
}
