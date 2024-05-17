using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    internal interface BLL_IProduct
    {
        void ViewInventoryById(int id, DataGridView gridView);
        void ViewInventoryByName(string name, DataGridView gridView);
        void ViewInventoryByCategory(string category, DataGridView gridView);
        void SortInventoryByPrice(string sortBy, DataGridView gridView);
        void SortInventoryByName(string sortBy, DataGridView gridView);
    }
}
