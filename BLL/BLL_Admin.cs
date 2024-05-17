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
            string query = "";
            if (id == 0)
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = '{0}'", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE id = '{0}' AND store_id = '{1}'", id, StoreIDofUser);

            //STORED PROCEDURES HAVE BEEN CREATED

            //query = string.Format("EXEC spViewAllEmployees");
            //query = string.Format("EXEC spViewEmployeesById");

            //IS IT RUNNING CORRECTLY???? COLMUMN NAMES ARE CIRRECR??




            gridView.DataSource = ViewDataOnGrid(query);
        }

        public void ViewEmployeeByName(string name, DataGridView gridView)
        {
            string query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = '{0}' AND name LIKE '{1}%'", StoreIDofUser, name);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void SortEmployeeByName(string sortBy, DataGridView gridView)
        {
            string query = "";
            if (sortBy == "asc")
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = '{0}' ORDER BY name ASC", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE store_id = '{0}' ORDER BY name DESC", StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void ViewEmployeeByPosition(string position, DataGridView gridView)
        {
            string query = "";
            query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact, position AS Position, salary AS Salary FROM employee WHERE position = '{0}' AND store_id = '{1}'", position, StoreIDofUser);

            gridView.DataSource = ViewDataOnGrid(query);
        }

        static protected DataTable ViewDataOnGrid(string query)
        {
            string sqlConnectionString = "Server = localhost\\SQLEXPRESS; Database = DBMS_Project; Trusted_Connection = True";
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
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

        public void UpdateEmployee(string empName, string empContact, string empPosition, float empSalary)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spUpdateEmployee", empName, empContact, empPosition, empSalary, StoreIDofUser);
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
            //if textbox has value then filter by id
            string query = "";
            if (id == 0)
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = '{0}'", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE id = '{0}' AND store_id = '{1}'", id, StoreIDofUser);

            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void ViewCustomerByName(string name, DataGridView gridView)
        {
            string query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = '{0}' AND name LIKE '{1}%'", StoreIDofUser, name);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void SortCustomerByName(string sortBy, DataGridView gridView)
        {
            string query = "";
            if (sortBy == "asc")
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = '{0}' ORDER BY name ASC", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, contact AS Contact FROM customer WHERE store_id = '{0}' ORDER BY name DESC", StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
















        public void ViewInventoryById(int id, DataGridView gridView)
        {
            //if textbox is null then view all records
            //if textbox has value then search by id
            string query = "";
            if (id == 0)
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = '{0}'", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE id = '{0}' AND store_id = '{1}'", id, StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void ViewInventoryByName(string name, DataGridView gridView)
        {
            string query = string.Format("SELECT id, name, quantity, price, category FROM inventory WHERE store_id = '{0}' AND name LIKE '{1}%'", StoreIDofUser, name);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void ViewInventoryByCategory(string category, DataGridView gridView)
        {
            string query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE category = '{0}' AND store_id = '{1}'", category, StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void SortInventoryByPrice(string sortBy, DataGridView gridView)
        {
            string query = "";
            if (sortBy == "min")
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = '{0}' ORDER BY price ASC;", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = '{0}' ORDER BY price DESC;", StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void SortInventoryByName(string sortBy, DataGridView gridView)
        {
            string query = "";
            if (sortBy == "asc")
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = '{0}' ORDER BY name ASC", StoreIDofUser);
            else
                query = string.Format("SELECT id AS ID, name AS Name, quantity AS Quantity, price AS Price, category AS Category FROM inventory WHERE store_id = '{0}' ORDER BY name DESC", StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
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





        public void ViewOrdersById(DataGridView gridView)
        {
            string query = string.Format("SELECT order_id AS [Order ID #], total_products AS [Total Products], amount AS [Total Amount], date AS Dated, customer_id AS [Customer's ID] FROM orders WHERE store_id = '{0}'", StoreIDofUser);
            gridView.DataSource = ViewDataOnGrid(query);
        }
        public void ViewOrderDetailsById(int id, DataGridView gridView)
        {
            string query = string.Format("SELECT product_id AS [Product's ID], name AS Name, quantity AS Quantity, price AS Price FROM order_details WHERE order_id = '{0}' AND store_id = '{1}'", id, StoreIDofUser); ;
            gridView.DataSource = ViewDataOnGrid(query);
        }

    }
}
