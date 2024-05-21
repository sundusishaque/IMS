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
    public partial class customer_menu : Form
    {
        BLL_Customer customer = new BLL_Customer();
        string present = "";
        string sortByPrice = "min";
        string sortByName = "asc";

     
        public customer_menu()
        {
            InitializeComponent();
            pnlFilter.Visible = false;
            picSortName.Visible = false;
            PnlDetails.Visible = false;
            pnlOrder.Visible = false;


         
        }

        private void bttnInventory_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = true;
            picFilter.Visible = true;
            PnlDetails.Visible = false;
            pnlOrder.Visible = false;
            picSortName.Visible = true;
            customer.ViewInventoryById(0, dataGridView);
            present = "inventory";
            cmbFilter.SelectedItem = null;
            cmbFilter.Text = null;
            txtSearch.Clear();
          
            sortByPrice = "min";
            sortByName = "asc";
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (present == "inventory")
            {
                try
                {
                    customer.ViewInventoryById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch
                {
                    customer.ViewInventoryByName(txtSearch.Text, dataGridView);
                }
            }


            if (present == "order")
            {
                try
                {
                    customer.ViewOrdersHistoryById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch (Exception ex)
                {
                    string loggedInTitle = "Error";
                    string message = ex.Message;
                    MessageBox.Show(message, loggedInTitle);
                }
            }
        }

        private void picSortName_Click(object sender, EventArgs e)
        {
            if (present == "inventory")
            {
                customer.SortInventoryByName(sortByName, dataGridView);
                if (sortByName == "asc")
                    sortByName = "desc";
                else
                    sortByName = "asc";
            }
        }

        private void picFilter_Click(object sender, EventArgs e)
        {

            if (sortByPrice == "min")
            {
                customer.SortInventoryByPrice(sortByPrice, dataGridView);
                sortByPrice = "max";
            }
            else
            {
                customer.SortInventoryByPrice(sortByPrice, dataGridView);
                sortByPrice = "min";
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (present == "inventory")
                customer.ViewInventoryByCategory(Convert.ToString(cmbFilter.SelectedItem), dataGridView);
        }

        private void bttnAccount_Click(object sender, EventArgs e)
        {
            Form customerAccount = new customer_account();
            customerAccount.Show();
            this.Hide();
        }

        private void bttnLogOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            string title = "Logging Out...";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form mainMenu = new welcome_form();
                mainMenu.Show();
            }
        }

        private void bttnPlaceOrder_Click(object sender, EventArgs e)
        {
            PnlDetails.Visible = false;
            pnlFilter.Visible = true;
            picFilter.Visible = true;
            picSortName.Visible = true;
            pnlOrder.Visible = true;
            customer.ViewInventoryById(0, dataGridView);
            present = "inventory";
            cmbFilter.SelectedItem = null;
            cmbFilter.Text = null;
            txtSearch.Clear();
            sortByPrice = "min";
            sortByName = "asc";



          


        }

        private void bttnOrderHistory_Click(object sender, EventArgs e)
        {
            pnlFilter.Visible = false;
            picSortName.Visible = false;
            picFilter.Visible = false;
            PnlDetails.Visible = true;
            pnlOrder.Visible = false;
            present = "order";
            customer.ViewOrdersHistoryById(0, dataGridView);

            cmbFilter.SelectedItem = null;
            cmbFilter.Text = null;
            txtSearch.Clear();
            sortByPrice = "min";
            sortByName = "asc";






           
        }

        private void customer_menu_Load(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }

        private void bttnViewCart_Click(object sender, EventArgs e)
        {
            Form customerCart = new customer_cart();
            customerCart.Show();
            this.Hide();
        }

        private void bttnAddtoCart_Click(object sender, EventArgs e)
        {
            if (OrderIdNum.Value == 0 || OrderQtyNum.Value == 0)
                MessageBox.Show("Please enter information correctly.", "Information Incomplete");
            else
                customer.AddToCart(Convert.ToInt32(OrderIdNum.Value), Convert.ToInt32(OrderQtyNum.Value));
            OrderIdNum.Value = 0;
            OrderQtyNum.Value = 0;
            cmbFilter.Items.Clear();
            cmbFilter.Text = null;
            txtSearch.Clear();
        }

        private void bttnDetails_Click(object sender, EventArgs e)
        {
            Form customerOrderDetails = new customer_order();
            customerOrderDetails.Show();
        }
    }
}
