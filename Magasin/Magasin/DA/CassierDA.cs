using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Magasin.Model;

namespace Magasin.DA
{
    class CassierDA
    {
        SqlConnection cn;
        SqlCommand cmd;

        public CassierDA()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True"); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        public List<Cassier> getAllCassier()
        {
            List<Cassier> list = new List<Cassier>();
            string req = string.Format("select * from Cassier");
            cn.Open();
            cmd = new SqlCommand(req, cn);
            SqlDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                list.Add(new Cassier(Reader.GetString(0),new Bloc(Reader.GetString(1))));
            }
            Reader.Close();
            cn.Close();
            return list;
        }
    }
}
