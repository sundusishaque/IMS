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
    public partial class admin_inventory : Form
    {
        int productId = 0;
        BLL_Admin admin = new BLL_Admin();
        public admin_inventory()
        {
            InitializeComponent();
        }

        private void admin_inventory_Load(object sender, EventArgs e)
        {
            //read all records from the employee table
            admin.ViewInventoryById(0, inventoryDataGridView);
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) | string.IsNullOrEmpty(txtQuantity.Text) | string.IsNullOrEmpty(txtPrice.Text) | string.IsNullOrEmpty(cmbCategory.Text))
                MessageBox.Show("Please fill the required details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                admin.AddInventory(txtName.Text, Convert.ToInt32(txtQuantity.Text), float.Parse(txtPrice.Text), Convert.ToString(cmbCategory.SelectedItem));
            productId = 0;
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedItem = null;            

            txtName.Focus();
            admin.ViewInventoryById(0, inventoryDataGridView);
        }

        private void inventoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //storing invetnory's id for operation
            productId = Convert.ToInt32(inventoryDataGridView.SelectedRows[0].Cells[0].Value);

            //setting textbox values from data grid view
            txtName.Text = inventoryDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtQuantity.Text = inventoryDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = inventoryDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            cmbCategory.Text = inventoryDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            //meaning a row is selected
            if (productId > 0)
                admin.UpdateInventory(productId, txtName.Text, Convert.ToInt32(txtQuantity.Text), float.Parse(txtPrice.Text), Convert.ToString(cmbCategory.SelectedItem));
            else
                MessageBox.Show("Select a row of details to update employee information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            productId = 0;
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedItem = null;

            txtName.Focus();
            admin.ViewInventoryById(0, inventoryDataGridView);

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            //meaning a row is selected
            if (productId > 0)
                admin.DeleteInventory(productId);
            else
                MessageBox.Show("Select a row of details to delete employee information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            productId = 0;
            txtName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedItem = null;

            txtName.Focus();
            admin.ViewInventoryById(0, inventoryDataGridView);
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new admin_menu();
            goBack.Show();
            this.Hide();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
