using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IMS
{
    class ConnectionSettings
    {
        public void UpdateConnectionString(string server, string database, string userId, string password)
        {

            string connectionString = $"Server={server};Database={database};User Id={userId};Password={password};";

            // Update the configuration file
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["dbCon"].Value = connectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
