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
    public partial class customer_cart : Form
    {
        
        public customer_cart()
        {
         
            InitializeComponent();
            BLL_Customer customer = new BLL_Customer();
            OrderIdLabel.Text = Convert.ToString(customer.getorderId());
           
            customer.ViewCart(dataGridViewOrders);
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form customerMenu = new customer_menu();
            customerMenu.Show();
            this.Hide();
        }

        private void bttnPlaceOrder_Click(object sender, EventArgs e)
        {
            BLL_Customer customer = new BLL_Customer();
            customer.PlaceOrder();
            this.Hide();
            Form customerMenu = new customer_menu();
            customerMenu.Show();

        }

        private void pnlOrderId_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
