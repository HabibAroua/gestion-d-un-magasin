using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Magasin.DA
{
    class BlocDA
    {
        SqlConnection cn;
        SqlCommand cmd;
        
        public BlocDA()
        {
            try
            {
                cn = new SqlConnection("Data Source=DESKTOP-UU0N3RP//SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True"); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }


    }
}
