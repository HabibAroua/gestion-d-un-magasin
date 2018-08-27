using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Magasin.Model;
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
    }
}
