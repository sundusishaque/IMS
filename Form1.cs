using System;

using System.Windows.Forms;


namespace IMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryManager regObj = new RegistryManager();
            (string serverName, string databaseName, string id, string password) = regObj.ReadRegistry();


            if (!string.IsNullOrEmpty(serverName) && !string.IsNullOrEmpty(databaseName) &&
                !string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(password))
            {
                txtServerName.Text = serverName;
                txtDbName.Text = databaseName;
               txtDbUserId.Text = id;
               txtDbPwd.Text = password;
            }
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            ConnectionSettings csObj = new ConnectionSettings();
            csObj.UpdateConnectionString(txtServerName.Text, txtDbName.Text, txtDbUserId.Text, txtDbPwd.Text);
            RegistryManager regObj = new RegistryManager();
            regObj.WriteRegistry(txtServerName.Text, txtDbName.Text, txtDbUserId.Text, txtDbPwd.Text);
        }
    }
}
