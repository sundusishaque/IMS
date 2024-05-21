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
    public partial class customer_order : Form
    {
        public customer_order()
        {
            InitializeComponent();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            BLL_Customer customer = new BLL_Customer();
            try
            {
                customer.ViewOrderDetailsById(Convert.ToInt32(txtSearch), dataGridViewOrders);
            }
            catch (Exception ex)
            {
                string loggedInTitle = "Error";
                string message = ex.Message;
                MessageBox.Show(message, loggedInTitle);
            }
        }
    }
}
