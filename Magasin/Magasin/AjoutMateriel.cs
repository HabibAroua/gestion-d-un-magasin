using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magasin.DA;
using Magasin.Model;
using System.Windows.Forms;

namespace Magasin
{
    public partial class AjoutMateriel : Form
    {
        public AjoutMateriel()
        {
            InitializeComponent();
        }

        private void AjoutMateriel_Load(object sender, EventArgs e)
        {
            CassierDA cassierDA = new CassierDA();
            List<Cassier> list1 = cassierDA.getAllCassier();
            foreach (Cassier c in list1)
            {
                listNomCasier.Items.Add(c.getNom());
            }

            FabricantDA fabricantDA = new FabricantDA();
            List<Fabricant> list2 = fabricantDA.getAllFabricant() ;
            foreach (Fabricant f in list2)
            {
                listFab.Items.Add(f.getNom());
            }
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            Materiel m = new Materiel(txtRef.Text, txtDesc.Text, txtPrix.Text,txtQuantite.Text, txtLien.Text,new Fabricant(listFab.SelectedItem.ToString()),new Cassier(listNomCasier.SelectedItem.ToString()));
            MaterielDA materielDA = new MaterielDA();
            Boolean test = materielDA.Ajout(m);
            if(test==true)
            {
                MessageBox.Show("L'ajout de matériel est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btInisiliser_Click(object sender, EventArgs e)
        {
            txtRef.Clear();
            txtDesc.Clear();
            txtLien.Clear();
            txtPrix.Clear();
            txtQuantite.Clear();
        }
    }
}
