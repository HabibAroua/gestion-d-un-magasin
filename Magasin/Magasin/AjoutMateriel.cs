using System;
using System.Collections.Generic;
using Magasin.DA;
using Magasin.Model;
using System.Windows.Forms;

namespace Magasin
{
    public partial class AjoutMateriel : Form
    {
        MaterielDA materielDA ;
        public AjoutMateriel()
        {
            InitializeComponent();
            materielDA = new MaterielDA();
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
            try
            {
                if (materielDA.refExist(materielDA.getAllMateriel(), txtRef.Text))
                {
                    MessageBox.Show("Ce réféerence est déjà existe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Materiel m = new Materiel(txtRef.Text, txtDesc.Text, txtPrix.Text, txtQuantite.Text, txtLien.Text, new Fabricant(listFab.SelectedItem.ToString()), new Cassier(listNomCasier.SelectedItem.ToString()));
                    Boolean test = materielDA.AjouterP(m);
                    if (test == true)
                    {
                        MessageBox.Show("L'ajout de matériel est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Les choix de fabricant ou casier sont nulle", "error :" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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