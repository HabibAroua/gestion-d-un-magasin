using System;
using System.Windows.Forms;
using Magasin.Sql_Server;
namespace Magasin
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Test_Connection.testConnection())
            {
                Application.Run(new Authentification());
            }
            else
            {
                MessageBox.Show("Le serveur est désactiveé", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
