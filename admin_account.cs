using BLL;
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
    public partial class admin_account : Form
    {
        public admin_account()
        {
            InitializeComponent();
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new admin_menu();
            goBack.Show();
            this.Hide();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            BLL_Admin admin = new BLL_Admin();

            if (string.IsNullOrEmpty(txtOldPassword.Text) | string.IsNullOrEmpty(txtNewPassword.Text))
                MessageBox.Show("Please fill the required details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                admin.UpdatePassword(txtOldPassword.Text, txtNewPassword.Text);
                //updation successful so shoe message and take back to main menu
                this.Hide();
                Form goBack = new admin_menu();
                goBack.Show();
            }

            txtOldPassword.Clear();
            txtNewPassword.Clear();
          
        }
    }
}
