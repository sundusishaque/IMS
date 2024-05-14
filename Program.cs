using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool countone = false;
            using (Mutex mtex = new Mutex(true, "MyRunningApp", out countone))
            {
                if (countone)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());

                }
                else
                {
                    MessageBox.Show("Application is already running.");

                }
            }
            
        }
    }
}
