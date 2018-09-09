using System;
using System.Data.SqlClient;
using Magasin.Model;
using System.Data;
using System.Collections.Generic;

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
                //ch=Data Source=DESKTOP-UU0N3RP\\SQLEXPRESS;Initial Catalog=Magasin_M4;Integrated Security=True
                cn = new SqlConnection(Properties.Settings.Default.cn); //Source= nom de serveur , Catalog= nom de la base de donnee
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
                string reference = m.getReference();
                string des = m.getDescription();
                string prix = m.getPrix();
                string quantite = m.getQuantite();
                string lien = m.getLien();
                Fabricant fab = m.getFabricant();
                Cassier c = m.getCassier();
                string req = string.Format("insert into Materiel values ('" + reference + "','" + des + "','" + prix + "','" + quantite + "','" + lien + "','" + fab.getNom() + "','" + c.getNom() + "')");
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

        public DataTable sellectAll()
        {
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select  Materiel.ref , Materiel.description , Materiel.prix , Materiel.quantite , Materiel.lien , Fabricant.nom As Fabricant , Cassier.nom As Casier ,Bloc.nom As Bloc from Materiel , Fabricant , Cassier , Bloc where Materiel.nomFab = Fabricant.nom and Cassier.nom = Materiel.nomCasier and Bloc.nom = Cassier.nomBloc order by Bloc.nom", Properties.Settings.Default.cn);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Materiel");
                tab1 = dtst.Tables["Materiel"];
                return tab1;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return null;
            }
        }

        public DataTable findByChar(string ch)
        {
            try
            {
                SqlDataAdapter adap1;
                DataTable tab1;
                adap1 = new SqlDataAdapter("select  Materiel.ref , Materiel.description , Materiel.prix , Materiel.quantite , Materiel.lien , Fabricant.nom As Fabricant , Cassier.nom As Casier ,Bloc.nom As Bloc from Materiel , Fabricant , Cassier , Bloc where((Materiel.nomFab = Fabricant.nom) and(Cassier.nom = Materiel.nomCasier) and(Bloc.nom = Cassier.nomBloc) and (Materiel.ref like '" + ch + "%'))", Properties.Settings.Default.cn);
                DataSet dtst = new DataSet();
                adap1.Fill(dtst, "Materiel");
                tab1 = dtst.Tables["Materiel"];
                return tab1;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return null;
            }
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

        public Boolean AjouterP(Materiel m)
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
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Materiel values (@reference,@des,@prix,@quantite,@lien,@fab,@casier)";
                cmd.Parameters.Add(new SqlParameter("@reference",reference));
                cmd.Parameters.Add(new SqlParameter("@des", des));
                cmd.Parameters.Add(new SqlParameter("@prix", prix));
                cmd.Parameters.Add(new SqlParameter("@quantite", quantite));
                cmd.Parameters.Add(new SqlParameter("@lien", lien));
                cmd.Parameters.Add(new SqlParameter("@fab", fab.getNom()));
                cmd.Parameters.Add(new SqlParameter("@casier", c.getNom()));
                cmd.ExecuteNonQuery();  
                return true;
            }
            catch(SqlException ex)
            {
                Console.WriteLine("error :" + ex);
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public Boolean ModifierPa(Materiel m , string refe)
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
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "update Materiel set ref= @reference, description = @des, prix = @prix, quantite = @quantite, lien = @lien, nomFab = @nomFab, nomCasier=@nomCasier  where ref=@refe";
                cmd.Parameters.Add(new SqlParameter("@reference", reference));
                cmd.Parameters.Add(new SqlParameter("@des", des));
                cmd.Parameters.Add(new SqlParameter("@prix", prix));
                cmd.Parameters.Add(new SqlParameter("@quantite", quantite));
                cmd.Parameters.Add(new SqlParameter("@lien", lien));
                cmd.Parameters.Add(new SqlParameter("@nomFab", fab.getNom()));
                cmd.Parameters.Add(new SqlParameter("@nomCasier", c.getNom()));
                cmd.Parameters.Add(new SqlParameter("@refe", refe));
                cmd.ExecuteNonQuery();
                return true;
                
            }
            catch (SqlException ex)
            {
                 Console.WriteLine("error :" + ex);
                 return false;
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Materiel> getAllMateriel()
        {
            try
            {
                List<Materiel> list = new List<Materiel>();
                string req = string.Format("select * from Materiel");
                cn.Open();
                cmd = new SqlCommand(req, cn);
                SqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    list.Add(new Materiel(Reader.GetString(0)));
                }
                Reader.Close();
                cn.Close();
                return list;
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("error :" + ex.Message);
                return null;
            }
        }

        public Boolean refExist(List<Materiel> list , string refe)
        {
            Boolean test = false;
            foreach(Materiel m in list)
            {
                if(m.getReference().Equals(refe))
                {
                    test = true;
                    break;
                }
            }
            return test;
        }

    }
}
