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
    public partial class admin_menu : Form
    {
        //First view all the information, if search text then view details of entered id 

        //using 'present' for navigation 
        //using sortByPrice to sort the price of inventory - picFilter
        //using sortByName to sort the names of employee, customer, inventory - picSortName        
        string present = "";
        string sortByPrice = "min";
        string sortByName = "asc";

        BLL_Admin admin = new BLL_Admin();

        public admin_menu()
        {
            InitializeComponent();

            bttnEdit.Visible = false;
            pnlFilter.Visible = false;
            pnlDataView.Visible = false;
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

        private void bttnEmployees_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            present = "employee";
            sortByPrice = "min";
            sortByName = "asc";

            pnlDataView.Visible = true;
            bttnEdit.Visible = true;
            pnlFilter.Visible = true;
            picSortName.Visible = true;

            //because the picture box is used to sort by price
            picFilter.Visible = false;

            cmbFilter.Items.Clear();
            cmbFilter.Text = null;
            cmbFilter.Items.Insert(0, "Clerk");
            cmbFilter.Items.Insert(1, "Manager");

            admin.ViewEmployeeById(0, dataGridView);
        }

        private void bttnCustomer_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            present = "customer";
            sortByName = "asc";
            sortByPrice = "min";

            picSortName.Visible = true;
            pnlDataView.Visible = true;

            //customer details cannot be edited and there is nothing to filter
            bttnEdit.Visible = false;
            pnlFilter.Visible = false;

            admin.ViewCustomerById(0, dataGridView);
        }

        private void bttnInventory_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            present = "inventory";
            sortByName = "asc";
            sortByPrice = "min";

            picSortName.Visible = true;
            pnlDataView.Visible = true;
            bttnEdit.Visible = true;
            pnlFilter.Visible = true;
            picFilter.Visible = true;

            cmbFilter.Items.Clear();
            cmbFilter.Text = null;
            cmbFilter.Items.Insert(0, "Home Appliances");
            cmbFilter.Items.Insert(1, "Kitchen Appliances");
            cmbFilter.Items.Insert(1, "Mobile Accessories");

            admin.ViewInventoryById(0, dataGridView);
        }

        private void bttnOrders_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            present = "order";
            sortByName = "asc";
            sortByPrice = "min";

            //order history is only read
            pnlDataView.Visible = true;

            bttnEdit.Visible = false;
            pnlFilter.Visible = false;
            picFilter.Visible = false;
            picSortName.Visible = false;

            admin.ViewOrdersHistoryById(0, dataGridView);
        }

        private void bttnAccount_Click(object sender, EventArgs e)
        {
            Form account = new admin_account();
            account.Show();
            this.Hide();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (present == "employee")
            {
                try
                {
                    admin.ViewEmployeeById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch
                {
                    admin.ViewEmployeeByName(txtSearch.Text, dataGridView);
                }
            }
            else if (present == "customer")
            {
                try
                {
                    admin.ViewCustomerById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch
                {
                    admin.ViewCustomerByName(txtSearch.Text, dataGridView);
                }
            }
            else if (present == "inventory")
            {
                try
                {
                    admin.ViewInventoryById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch
                {
                    admin.ViewInventoryByName(txtSearch.Text, dataGridView);
                }
            }
            else if (present == "order")
            {
                try
                {
                    admin.ViewOrdersHistoryById(Convert.ToInt32(txtSearch.Text), dataGridView);
                }
                catch (Exception ex)
                {
                    string loggedInTitle = "Error";
                    string message = ex.Message;
                    MessageBox.Show(message, loggedInTitle);
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (present == "employee")
                admin.ViewEmployeeByPosition(Convert.ToString(cmbFilter.SelectedItem), dataGridView);
            if (present == "inventory")
                admin.ViewInventoryByCategory(Convert.ToString(cmbFilter.SelectedItem), dataGridView);
        }

        private void picFilter_Click(object sender, EventArgs e)
        {
            if (sortByPrice == "min")
            {
                admin.SortInventoryByPrice(sortByPrice, dataGridView);
                sortByPrice = "max";
            }
            else
            {
                admin.SortInventoryByPrice(sortByPrice, dataGridView);
                sortByPrice = "min";
            }
        }

        private void picSortName_Click(object sender, EventArgs e)
        {
            if (present == "employee")
            {
                admin.SortEmployeeByName(sortByName, dataGridView);
                if (sortByName == "asc")
                    sortByName = "desc";
                else
                    sortByName = "asc";
            }
            if (present == "customer")
            {
                admin.SortCustomerByName(sortByName, dataGridView);
                if (sortByName == "asc")
                    sortByName = "desc";
                else
                    sortByName = "asc";
            }
            if (present == "inventory")
            {
                admin.SortInventoryByName(sortByName, dataGridView);
                if (sortByName == "asc")
                    sortByName = "desc";
                else
                    sortByName = "asc";
            }
        }

        private void bttnEdit_Click(object sender, EventArgs e)
        {
            if (present == "employee")
            {
                Form editMenu = new admin_employees();
                editMenu.Show();
            }
            if (present == "inventory")
            {
                Form editMenu = new admin_inventory();
                editMenu.Show();
            }
            if (present == "admin")
            {
                Form editMenu = new admin_account();
                editMenu.Show();
            }
            this.Hide();
        }
    }
}