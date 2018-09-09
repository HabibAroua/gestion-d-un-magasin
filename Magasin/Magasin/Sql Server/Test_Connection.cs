using System;
using System.Data.SqlClient;

namespace Magasin.Sql_Server
{
    class Test_Connection
    {
        public static Boolean testConnection()
        {
            try
            {
                SqlConnection cn;
                SqlCommand cmd;
                cn = new SqlConnection("Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True"); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
