using System;
using System.Data.SqlClient;
using System.Data;
using Magasin.Model;
using System.Collections.Generic;

namespace Magasin.DA
{
    class BlocDA
    {
        SqlConnection cn;
        SqlCommand cmd;

        public BlocDA()
        {
            try
            { // ch=Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True
                cn = new SqlConnection(Properties.Settings.Default.cn); //Source= nom de serveur , Catalog= nom de la base de donnee
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
        
        public DataTable sellectAll()
        {
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select * from Bloc", Properties.Settings.Default.cn);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Bloc");
                tab1 = dtst.Tables["Bloc"];
                return tab1;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return null;
            }
        }

        public Boolean Ajouter(Bloc b)
        {
            try
            {
                string nom = b.getNom();
                string req = string.Format("insert into Bloc values('"+nom+"')");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
              Console.WriteLine("error :" + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public Boolean Supprimer(string nom)
        {
            try
            {
                string req = string.Format("delete Bloc where nom='"+nom+"'");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("error :" + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Bloc> getAll()
        {
            try
            {
                List<Bloc> list = new List<Bloc>();
                string req = string.Format("select * from Bloc");
                cn.Open();
                cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add(new Bloc(Reader.GetString(0)));
                }
                Reader.Close();
                cn.Close();
                return list;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Message d'erreur :" + ex.Message);
                return null;
            }
        }

        public Boolean Exist(List<Bloc> list , Bloc bloc)
        {
            Boolean test = false;
            foreach(Bloc b in list)
            {
                if(b.getNom().Equals(bloc.getNom()))
                {
                    test= true;
                    break;
                }
            }
            return test;
        }
    }
    
}
