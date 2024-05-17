using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class customer_login : Form
    {
        public customer_login()
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
                //cUSTOMER admin = new Admin();
                //admin.CheckLogin(Convert.ToInt32(txtUserId.Text), txtUserPassword.Text);
                //this.Hide();
            }
            txtUserId.Clear();
            txtUserPassword.Clear();
            txtUserId.Focus();
        }

        private void linkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form customerRegister = new customer_registration();
            customerRegister.Show();
            this.Hide();
        }
    }
}
