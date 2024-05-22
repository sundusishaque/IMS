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
    public partial class admin_employees : Form
    {
        int employeeId = 0;
        BLL_Admin admin = new BLL_Admin();
        public admin_employees()
        {
            InitializeComponent();
        }

        private void admin_employees_Load(object sender, EventArgs e)
        {
            //read all records from the employee table
            admin.ViewEmployeeById(0, employeeDataGridView);
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) | string.IsNullOrEmpty(txtContact.Text) | string.IsNullOrEmpty(cmbPosition.Text) | string.IsNullOrEmpty(txtSalary.Text))
                MessageBox.Show("Please fill the required details.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                admin.AddEmployee(txtName.Text, txtContact.Text, Convert.ToString(cmbPosition.SelectedItem), float.Parse(txtSalary.Text));

            employeeId = 0;
            txtName.Clear();
            txtContact.Clear();
            cmbPosition.SelectedItem = null;
            txtSalary.Clear();

            txtName.Focus();
            admin.ViewEmployeeById(0, employeeDataGridView);
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            //storing employee id for operation
            employeeId = Convert.ToInt32(employeeDataGridView.SelectedRows[0].Cells[0].Value);

            //setting textbox values from data grid view
            txtName.Text = employeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtContact.Text = employeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            cmbPosition.Text = employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtSalary.Text = employeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            //meaning a row is selected
            if (employeeId > 0)
                admin.UpdateEmployee(employeeId,txtName.Text, txtContact.Text, Convert.ToString(cmbPosition.SelectedItem), float.Parse(txtSalary.Text));
            else
                MessageBox.Show("Select a row of details to update employee information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            employeeId = 0;
            txtName.Clear();
            txtContact.Clear();
            cmbPosition.SelectedItem = null;
            txtSalary.Clear();

            txtName.Focus();
            admin.ViewEmployeeById(0, employeeDataGridView);
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            //meaning a row is selected
            if (employeeId > 0)
                admin.DeleteEmployee(employeeId);
            else
                MessageBox.Show("Select a row of details to delete employee information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            employeeId = 0;
            txtName.Clear();
            txtContact.Clear();
            cmbPosition.SelectedItem = null;
            txtSalary.Clear();

            txtName.Focus();
            admin.ViewEmployeeById(0, employeeDataGridView);
        }

        private void bttnGoBack_Click(object sender, EventArgs e)
        {
            Form goBack = new admin_menu();
            goBack.Show();
            this.Hide();
        }
    }
}
