using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Magasin.Model;

namespace Magasin.DA
{
    class FabricantDA
    {
        SqlConnection cn;
        SqlCommand cmd;
        public FabricantDA()
        {
            try
            {
                //ch=Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True
                cn = new SqlConnection(Properties.Settings.Default.cn); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }


        public List<Fabricant> getAllFabricant()
        {
            try
            {
                List<Fabricant> list = new List<Fabricant>();
                string req = string.Format("select * from Fabricant");
                cn.Open();
                cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add(new Fabricant(Reader.GetString(0)));
                }
                Reader.Close();
                cn.Close();
                return list;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error :" + ex.Message);
                return null;
            }
        }
    }

}
