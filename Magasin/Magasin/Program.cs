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
            Application.Run(new Authentification());
        }
    }
}
