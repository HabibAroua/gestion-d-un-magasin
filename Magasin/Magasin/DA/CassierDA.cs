using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Magasin.Model;
using System.Data;

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

        public DataTable findCassierByBloc(string nomBloc)
        {
             SqlDataAdapter adap1;
             DataTable tab1;
             adap1 = new SqlDataAdapter("select Cassier.nom from Cassier , Bloc where Cassier.nomBloc=Bloc.nom and Bloc.nom='"+nomBloc+"'", Properties.Settings.Default.cn);
             DataSet dtst = new DataSet();
             adap1.Fill(dtst, "Cassier");
             tab1 = dtst.Tables["Cassier"];
             return tab1;
        }

        public Boolean ajout(Cassier cassier)
        {
            try
            {
                string nom = cassier.getNom();
                Bloc bloc = cassier.getB();
                string req = string.Format("insert into Cassier values ('" + nom + "','" + bloc.getNom() + "')");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public Boolean supprimer(string nom)
        {
            try
            {
                string req = string.Format("delete cassier where nom='"+nom+"'");
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = req;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
