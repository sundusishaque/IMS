using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public abstract class LoginReadAndUpdation
    {
        static internal int IDofUser;
        static internal string NameofUser= "";
        static internal int StoreIDofUser;

        static internal int IDofOrder;

        abstract public bool CheckIfExists(int id, string query);
        abstract public void UpdatePassword(string old_password, string new_password);
    }
}
