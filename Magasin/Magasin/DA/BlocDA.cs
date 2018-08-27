using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

        }

        public DataTable sellectAll()
        {
            SqlDataAdapter adap1;
            DataTable tab1;
            adap1 = new SqlDataAdapter("select * from Bloc", Properties.Settings.Default.cn);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Bloc");
            tab1 = dtst.Tables["Bloc"];
            return tab1;
        }
    }
}
