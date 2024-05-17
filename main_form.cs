using System;
using System.Windows.Forms;


//if wrong details are inputted in server connection then???
//why is registry manager and connectionsetiinges here here?? - in ims
//remove commented methods from different forms
//cjeck all forms for comments
//check if admin stored procedures for viewing are okay or not

namespace IMS
{
    public partial class main_form : Form
    {
        public main_form()
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

            Form new_form = new welcome_form();
            new_form.Show();
            this.Hide();
        }
    }
}
