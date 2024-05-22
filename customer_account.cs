using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace IMS
{
    public partial class customer_account : Form
    {
        public customer_account()
        {
            InitializeComponent();
           
        }

        private void bttnCustUpdate_Click(object sender, EventArgs e)
        {
            PnlUpdateCustomer.Visible = true;
            PnlDeleteCustomer.Visible = false;
            txtOldPassword.Clear();
            txtOldPassword.Clear();
        }

        private void bttnCustDelete_Click(object sender, EventArgs e)
        {
            PnlUpdateCustomer.Visible = false;
            PnlDeleteCustomer.Visible = true;
            txtCustPassword.Clear();
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new customer_menu();
            goBack.Show();
            this.Hide();
        }

        private void bttDeleteCustomer_Click(object sender, EventArgs e)
        {
            BLL_Customer customer = new BLL_Customer();
            if (String.IsNullOrEmpty(txtCustPassword.Text))
                MessageBox.Show("Please enter information correctly.", "Information Incomplete");
            else
            {
                customer.DeleteCustomer(txtCustPassword.Text);
                string title = "Deletion Complete.";
                string message = "Your account, ID has been deleted.";
                MessageBox.Show(message, title);
                this.Hide();
                Form goBack = new welcome_form();
                goBack.Show();
            }
            txtCustPassword.Clear();

        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            BLL_Customer customer = new BLL_Customer();

            if (string.IsNullOrEmpty(txtOldPassword.Text) | string.IsNullOrEmpty(txtNewPassword.Text))
                MessageBox.Show("Please fill the required details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                customer.UpdatePassword(txtOldPassword.Text, txtNewPassword.Text);
                //updation successful so shoe message and take back to main menu
                string title = "Updation Complete.";
                string message = "Your Password has been updated.";
                MessageBox.Show(message, title);
                this.Hide();
                Form goBack = new customer_menu();
                goBack.Show();
            }

            txtOldPassword.Clear();
            txtNewPassword.Clear();
        }

        private void customer_account_Load(object sender, EventArgs e)
        {
            PnlUpdateCustomer.Visible = false;
            PnlDeleteCustomer.Visible = false;
        }
    }
}
