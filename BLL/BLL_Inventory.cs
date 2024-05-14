using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BLL
{
    public class BLL_Inventory
    {
        public void AddProduct(string _pName, int _pQuantity, float _pPrice, string p_Category)
        {
            DAL DalObj = new DAL();
            DalObj.OpenConnection();
            DalObj.LoadSpParameters("spInsertProduct", _pName, _pQuantity, _pPrice, p_Category);
            DalObj.ExecuteQuery();
            DalObj.UnLoadSpParameters();
            DalObj.CloseConnection();
        }
        public void UpdateProduct(string _pName, int _pQuantity, float _pPrice, string p_Category)
        {
            DAL DalObj = new DAL();
            DalObj.OpenConnection();
            DalObj.LoadSpParameters("spUpdateProduct", _pName, _pQuantity, _pPrice, p_Category);
            DalObj.ExecuteQuery();
            DalObj.UnLoadSpParameters();
            DalObj.CloseConnection();
        }
        public void DeleteProduct(int p_Id)
        {
            DAL DalObj = new DAL();
            DalObj.OpenConnection();
            DalObj.LoadSpParameters("spDeleteProduct", p_Id);
            DalObj.ExecuteQuery();
            DalObj.UnLoadSpParameters();
            DalObj.CloseConnection();
        }
    }
}
