using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_Customer : LoginReadAndUpdation, BLL_IProduct
    {
      

        public bool AddCustomer(string name, string contact, string password, string location)
        {
            int storeId = 0;

            if (location == "Gulshan")
                storeId = 1;
            else if (location == "Nazimabad")
                storeId = 2;

            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();

                // Load parameters for adding customer
                string addCustomerQuery = "spAddCustomer";
                dataLayerObj.LoadSpParameters(addCustomerQuery, name, contact, password, storeId);
                int checkAddCustomer = dataLayerObj.ExecuteQuery();

                if (checkAddCustomer > 0)
                {
                    string getCustomerIdQuery = "spGetCustomerIdByNameContactPassword";
                    dataLayerObj.LoadSpParameters(getCustomerIdQuery, name, contact, password);
                    SqlDataReader reader = dataLayerObj.GetDataReader();

                    if (reader.HasRows)
                    {
                        NameofUser = name;
                        StoreIDofUser = storeId;
                        reader.Read();
                        IDofUser = Convert.ToInt32(reader["id"]);

                        string title = "Registration Complete";
                        string message = "You have been registered in our database. Your ID is: " + IDofUser;
                        MessageBox.Show(message, title);

                        dataLayerObj.CloseConnection();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve customer ID.", "Registration Incomplete");
                        dataLayerObj.CloseConnection();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Registration Incomplete");
                    dataLayerObj.CloseConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                string loggedInTitle = "Registration Incomplete";
                string message = ex.Message;
                MessageBox.Show(message, loggedInTitle);
                return false;
            }
        }










        public override bool CheckIfExists(int id, string password)
        {
            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();
                dataLayerObj.LoadSpParameters("spCheckCustomerExists", id, password);
                SqlDataReader reader = dataLayerObj.ExecuteReader();

                //the method checks if the reader has one or more rows
                if (reader.HasRows)
                {
                    //set id
                    IDofUser = id;

                    //read the first row                      
                    reader.Read();

                    //get the values of the returned columns
                    NameofUser = reader["CustomerName"].ToString();
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
        static protected DataTable ViewDataOnGrid(string spName, params object[] parameters)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters(spName, parameters);
            DataTable dataTable = dataLayerObj.GetDataTable();
            dataLayerObj.CloseConnection();
            return dataTable;
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
            gridView.DataSource = ViewDataOnGrid("spViewInventoryByName", StoreIDofUser, name);
        }
        public void ViewInventoryByCategory(string category, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewInventoryByCategory", StoreIDofUser, category);
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
                gridView.DataSource = ViewDataOnGrid("spViewInventoryAsc", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewInventoryDesc", StoreIDofUser);
        }
        public void DeleteCustomer(string password)
        {
            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();
                dataLayerObj.LoadSpParameters("spDeleteCustomer", IDofUser, password);
                dataLayerObj.ExecuteQuery();
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                throw ex;
            }
            finally
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.CloseConnection();
            }
        }





        public override void UpdatePassword(string old_password, string new_password)
        {
            DAL dataLayerObj = new DAL();
            dataLayerObj.OpenConnection();
            dataLayerObj.LoadSpParameters("spUpdateCustomerPassword", IDofUser, old_password, new_password);
            dataLayerObj.ExecuteQuery();
            dataLayerObj.UnLoadSpParameters();
            dataLayerObj.CloseConnection();
        }




        public void ViewOrderDetailsById(int id, DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewOrderDetailsById", id, StoreIDofUser, IDofUser);
        }

        public void ViewOrdersHistoryById(int id, DataGridView gridView)
        {



            if (id == 0)
                gridView.DataSource = ViewDataOnGrid("spViewOrderHistory", StoreIDofUser);
            else
                gridView.DataSource = ViewDataOnGrid("spViewOrderHistoryById", id, StoreIDofUser);

        }

        public void ViewCart(DataGridView gridView)
        {
            gridView.DataSource = ViewDataOnGrid("spViewCart", IDofOrder, StoreIDofUser, IDofUser);
        }




        public void AddToCart(int productId, int productQty)
        {
            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();

                // Retrieve product details using ExecuteReader
                string getProductDetailsQuery = "spGetProductDetails";
                dataLayerObj.LoadSpParameters(getProductDetailsQuery, productId, StoreIDofUser);
                SqlDataReader reader = dataLayerObj.ExecuteReader();

                if (reader == null || !reader.HasRows)
                {
                    throw new Exception("Product details not found.");
                }

                string productName = string.Empty;
                double productPrice = 0;

                if (reader.Read())
                {
                    productName = reader["name"].ToString();
                    productPrice = Convert.ToDouble(reader["price"]);
                }

                reader.Close();
                dataLayerObj.CloseConnection();

                if (!string.IsNullOrEmpty(productName) && productPrice > 0)
                {
                    double totalPrice = productPrice * productQty;

                    // Generate order ID if not already set
                    if (IDofOrder == 0)
                    {
                        int orderId;
                        do
                        {
                            orderId = new Random().Next(100, 10000);
                        } while (CheckOrderIdExists(orderId));

                        IDofOrder = orderId;
                    }

                    // Add product to cart
                    dataLayerObj.OpenConnection();
                    string addToCartQuery = "spAddToCart";
                    dataLayerObj.LoadSpParameters(addToCartQuery, productId, productName, productQty, totalPrice, IDofOrder, IDofUser, StoreIDofUser);
                    int rowsAffected = dataLayerObj.ExecuteQuery();
                    dataLayerObj.CloseConnection();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"The product, ID: {productId}, has been added to your cart.", "Product Added");
                    }
                    else
                    {
                        MessageBox.Show("The product could not be added to your cart. Please try again.", "Order Incomplete");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve product details. Please try again.", "Order Incomplete");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Order Incomplete");
            }
        }

        private bool CheckOrderIdExists(int orderId)
        {
            try
            {
                DAL dataLayerObj = new DAL();

                dataLayerObj.OpenConnection();
                string checkOrderIdQuery = "spCheckOrderIdExists";
                dataLayerObj.LoadSpParameters(checkOrderIdQuery, orderId);
                object result = dataLayerObj.ExecuteValue();
                dataLayerObj.CloseConnection();

                return result != null && Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return true; // Assume ID exists to avoid infinite loop
            }
        }






       

        public void PlaceOrder()
        {
            try
            {
                DAL dataLayerObj = new DAL();
                dataLayerObj.OpenConnection();

                // Get total quantity
                string getTotalQttyQuery = "spGetTotalQuantity";
                dataLayerObj.LoadSpParameters(getTotalQttyQuery, IDofOrder, IDofUser);
                object totalQtyResult = dataLayerObj.ExecuteValue();
                dataLayerObj.CloseConnection();
                if (totalQtyResult == null)
                {
                    throw new Exception("Failed to retrieve total quantity.");
                }
                int totalProducts = Convert.ToInt32(totalQtyResult);

                // Get total price
                dataLayerObj.OpenConnection();
                string getTotalPriceQuery = "spGetTotalPrice";
                dataLayerObj.LoadSpParameters(getTotalPriceQuery, IDofOrder, IDofUser);
                object totalPriceResult = dataLayerObj.ExecuteValue();
                dataLayerObj.CloseConnection();
                if (totalPriceResult == null)
                {
                    throw new Exception("Failed to retrieve total price.");
                }
                double totalAmount = Convert.ToDouble(totalPriceResult);

                // Insert order
                dataLayerObj.OpenConnection();
                string insertInOrdersQuery = "spInsertOrder";
                dataLayerObj.LoadSpParameters(insertInOrdersQuery, IDofOrder, totalProducts, totalAmount, IDofUser, StoreIDofUser);
                int checkInsertion = dataLayerObj.ExecuteQuery();
                dataLayerObj.CloseConnection();

                if (checkInsertion > 0)
                {
                    MessageBox.Show("Your order has been placed. Our representatives will be in contact with you shortly regarding the delivery.", "Order Placed");
                    // Reset the order ID after successful order placement
                    IDofOrder = 0;
                }
                else
                {
                    MessageBox.Show("The order could not be placed. Please try again.", "Order Incomplete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Incomplete");
            }
        }
    }
}

    



    

