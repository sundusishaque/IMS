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
    public partial class customer_registration : Form
    {
        public customer_registration()
        {
            InitializeComponent();
        }

        private void bttnRegister_Click(object sender, EventArgs e)
        {

            BLL_Customer customer = new BLL_Customer();
            var isSuccessful = customer.AddCustomer(txtCustName.Text, txtContact.Text, txtPassword.Text, cmbLocation.SelectedItem.ToString());

            if (isSuccessful)
            {
                MessageBox.Show("Registration Complete", "Success");

                Form customerMenu = new customer_menu();
                customerMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to register. Please try again.", "Registration Incomplete");

                Form customerReg = new customer_registration();
                customerReg.Show();
                this.Hide();
            }

            txtCustName.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            cmbLocation.SelectedIndex = -1;
        }








        


        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new customer_login();
            goBack.Show();
            this.Hide();
        }
    }
}
