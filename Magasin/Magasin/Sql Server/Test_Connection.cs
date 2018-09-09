using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace Magasin.Sql_Server
{
    class Test_Connection
    {
        public Boolean testConnection()
        {
            try
            {
                SqlConnection cn;
                SqlCommand cmd; //Properties.Settings.Default.cn
                cn = new SqlConnection(getConnectionCh()); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean testConnection(string ch)
        {
            try
            {
                SqlConnection cn;
                SqlCommand cmd; //Properties.Settings.Default.cn
                cn = new SqlConnection(ch); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return false;
            }
        }

        private string getConnectionCh()
        {
            return "Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True";
        }

        public Boolean testServer()
        {
            try
            {
                SqlConnection cn=new SqlConnection(getConnectionCh());
                SqlCommand cmd = new SqlCommand();
                List<string> list = new List<string>();
                String req = string.Format("select * from Cassier");
                cn.Open();
                cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add(Reader.GetString(0));
                }
                Reader.Close();
                cn.Close();
                return true;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error :" + ex.Message);
                return false;
            }
        }
    }
}
