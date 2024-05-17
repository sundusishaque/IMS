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
    public partial class welcome_form : Form
    {
        public welcome_form()
        {
            InitializeComponent();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Form adminPicture = new admin_login();
            adminPicture.Show();
            this.Hide();
        }

        private void picCustomer_Click(object sender, EventArgs e)
        {
            Form customerPicture = new customer_login();
            customerPicture.Show();
            this.Hide();
        }
    }
}
