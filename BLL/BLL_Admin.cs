using DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BLL
{
    //abstract class inherited as almost same working for admin, customer class
    public class BLL_Admin : LoginReadAndUpdation, BLL_IProduct
    {
        public override bool CheckIfExists(int id, string password)
        {
            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();
                dataLayerObj.LoadSpParameters("spCheckAdminExists", id, password);
                SqlDataReader reader = dataLayerObj.ExecuteReader();

                //the method checks if the reader has one or more rows
                if (reader.HasRows)
                {
                    //set id
                    IDofUser = id;

                    //read the first row                      
                    reader.Read();

                    //get the values of the returned columns
                    NameofUser = reader["AdminName"].ToString();
                    StoreIDofUser = Convert.ToInt32(reader["StoreID"]);

                    string loggedInTitle = "Login";
                    string message = $"You have successfully logged in as {NameofUser}.";
                    MessageBox.Show(message, loggedInTitle);

                    return true;
                }
                else
                {
                    string loggedInTitle = "Login Incomplete";
                    string message = "Your login credentials are incorrect.";
                    MessageBox.Show(message, loggedInTitle);
                }
                dataLayerObj.UnLoadSpParameters();
                dataLayerObj.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public override void UpdatePassword(string old_password, string new_password)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spUpdateAdminPassword", IDofUser, old_password, new_password);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }



        public void ViewEmployeeById(int id, DataGridView gridView)
        {
            //if textbox is null then view all records
            //if textbox has value then search by id
            if (id == 0)
                gridView.DataSource = ViewDataOnGrid("spViewAllEmployees", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewEmployeesById", id, StoreIDofUser);
        }

        public void ViewEmployeeByName(string name, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewEmployeesByName",name, StoreIDofUser);
        }
        public void SortEmployeeByName(string sortBy, DataGridView gridView)
        {
            if (sortBy == "asc")
                gridView.DataSource = ViewDataOnGrid("spViewEmployeesAsc", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewEmployeesDesc", StoreIDofUser);
        }
        public void ViewEmployeeByPosition(string position, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewEmployeesByPosition", position,StoreIDofUser);
        }

        public void AddEmployee(string empName, string empContact, string empPosition, float empSalary)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spInsertEmployee", empName, empContact, empPosition, empSalary, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }

        public void UpdateEmployee(int empId,string empName, string empContact, string empPosition, float empSalary)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spUpdateEmployee",empId, empName, empContact, empPosition, empSalary, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }

        public void DeleteEmployee(int employeeId)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spDeleteEmployee", employeeId, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }













        public void ViewCustomerById(int id, DataGridView gridView)
        {
            //if textbox is null then view all records
            //if textbox has value then search by id
            if (id == 0)
                gridView.DataSource = ViewDataOnGrid("spViewAllCustomers", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewCustomersById", id, StoreIDofUser);
        }
        public void ViewCustomerByName(string name, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewCustomersByName", name,StoreIDofUser);
        }
        public void SortCustomerByName(string sortBy, DataGridView gridView)
        {
            if (sortBy == "asc")
                gridView.DataSource = ViewDataOnGrid("spViewCustomersAsc", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewCustomersDesc", StoreIDofUser);
        }
















        public void ViewInventoryById(int id, DataGridView gridView)
        {
            //if textbox is null then view all records
            //if textbox has value then search by id
            if (id == 0)
                gridView.DataSource = ViewDataOnGrid("spViewAllInventory", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewInventoryById", id, StoreIDofUser);
        }
        public void ViewInventoryByName(string name, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewInventoryByName",name, StoreIDofUser);
        }
        public void ViewInventoryByCategory(string category, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewInventoryByCategory", category, StoreIDofUser);
        }
        public void SortInventoryByPrice(string sortBy, DataGridView gridView)
        {
            if (sortBy == "min")
                gridView.DataSource = ViewDataOnGrid(" spViewInventoryByPriceAsc", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid(" spViewInventoryByPriceDesc", StoreIDofUser);

        }
        public void SortInventoryByName(string sortBy, DataGridView gridView)
        {

            if (sortBy == "asc")
                gridView.DataSource = ViewDataOnGrid("spViewInventoryByNameAsc", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewInventoryByNameDesc", StoreIDofUser);
        }
        public void AddInventory(string productName, int productQuantity, float productPrice, string productCategory)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spInsertInventory", productName, productQuantity, productPrice, productCategory, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
            
        }

        public void UpdateInventory(int productId, string productName, int productQuantity, float productPrice, string productCategory)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spUpdateInventory", productId, productName, productQuantity, productPrice, productCategory, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }
        public void DeleteInventory(int productId)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spDeleteInventory", productId, StoreIDofUser);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }


        public void ViewOrdersHistoryById(int id, DataGridView gridView)
        {
            if (id == 0)
                gridView.DataSource = ViewDataOnGrid("spViewOrderHistory", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewOrderHistoryById", id, StoreIDofUser);
        }

    }
}