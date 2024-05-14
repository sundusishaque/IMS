using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace IMS
{
    class RegistryManager
    {
        public void WriteRegistry(string serverName, string databaseName, string id, string password)
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\OOAD\IMS");
            key.SetValue("ServerName", serverName);
            key.SetValue("DatabaseName", databaseName);
            key.SetValue("ID", id);
            key.SetValue("Password", password);
            key.Close();
        }

        public (string, string, string, string) ReadRegistry()
        {
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\OOAD\IMS");
            string serverName = key?.GetValue("ServerName")?.ToString();
            string databaseName = key?.GetValue("DatabaseName")?.ToString();
            string id = key?.GetValue("ID")?.ToString();
            string password = key?.GetValue("Password")?.ToString();
            return (serverName, databaseName, id, password);
        }
    }
}
