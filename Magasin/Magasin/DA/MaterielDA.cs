using System;
using System.Data.SqlClient;
using Magasin.Model;
using System.Data;

namespace Magasin.DA
{
    class MaterielDA
    {
        SqlConnection cn;
        SqlCommand cmd;

        public MaterielDA()
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

        public Boolean Ajout(Materiel m)
        {
           try
           {
                string reference= m.getReference();
                string des = m.getDescription();
                string prix = m.getPrix();
                string quantite = m.getQuantite();
                string lien = m.getLien();
                Fabricant fab = m.getFabricant();
                Cassier c = m.getCassier();
                string req = string.Format("insert into Materiel values ('"+reference+"','"+des+"','"+prix+"','"+quantite+"','"+lien+"','"+fab.getNom()+"','"+c.getNom() +"')");
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

        public DataTable sellectAll()
        {
            SqlDataAdapter adap1;
            DataTable tab1;
            adap1 = new SqlDataAdapter("select  Materiel.ref , Materiel.description , Materiel.prix , Materiel.quantite , Materiel.lien , Fabricant.nom , Cassier.nom ,Bloc.nom   from Materiel , Fabricant , Cassier , Bloc where Materiel.nomFab = Fabricant.nom and Cassier.nom = Materiel.nomCasier and Bloc.nom = Cassier.nomBloc order by Bloc.nom", Properties.Settings.Default.cn);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Materiel");
            tab1 = dtst.Tables["Materiel"];
            return tab1;
        }

        public DataTable findByChar(string ch)
        {
            SqlDataAdapter adap1;
            DataTable tab1;
            adap1 = new SqlDataAdapter("select  Materiel.ref , Materiel.description , Materiel.prix , Materiel.quantite , Materiel.lien , Fabricant.nom , Cassier.nom ,Bloc.nom   from Materiel , Fabricant , Cassier , Bloc where((Materiel.nomFab = Fabricant.nom) and(Cassier.nom = Materiel.nomCasier) and(Bloc.nom = Cassier.nomBloc) and (Materiel.ref like '"+ch+"%'))", Properties.Settings.Default.cn);
            DataSet dtst = new DataSet();
            adap1.Fill(dtst, "Materiel");
            tab1 = dtst.Tables["Materiel"];
            return tab1;
        }

        public Boolean modifier(Materiel m , string refe)
        {
            try
            {
                string reference = m.getReference();
                string des = m.getDescription();
                string prix = m.getPrix();
                string quantite = m.getQuantite();
                string lien = m.getLien();
                Fabricant fab = m.getFabricant();
                Cassier c = m.getCassier();
                string req = string.Format("update Materiel set ref='" + reference+"', description='"+des+"' , prix='"+prix+"' , quantite='"+quantite+"' , lien='"+lien+"' , nomFab='"+fab.getNom()+"' , nomCasier='"+c.getNom()+"' where ref='"+refe+"'");
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

        public Boolean Supprimer  (string refe)
        {
            try
            {
                string req = string.Format("delete Materiel where ref='"+refe+"'");
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
