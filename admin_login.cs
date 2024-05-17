using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using BLL;

namespace IMS
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new welcome_form();
            goBack.Show();
            this.Hide();
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
                txtUserPassword.UseSystemPasswordChar = false;
            else if (!checkPassword.Checked)
                txtUserPassword.UseSystemPasswordChar = true;
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text) | string.IsNullOrEmpty(txtUserPassword.Text))
                MessageBox.Show("Please fill the required details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                BLL_Admin admin = new BLL_Admin();
                if(admin.CheckIfExists(Convert.ToInt32(txtUserId.Text), txtUserPassword.Text))
                {
                    Form adminMenu = new admin_menu();
                    adminMenu.Show();
                    this.Hide();
                }
            }
            txtUserId.Clear();
            txtUserPassword.Clear();
            txtUserId.Focus();
        }
    }
}
