using System;
using System.Collections.Generic;
using Magasin.DA;
using Magasin.Model;
using System.Windows.Forms;

namespace Magasin
{
    public partial class AjoutMateriel2 : Form
    {
        public string nomCasier;
        MaterielDA materielDA;

        public AjoutMateriel2()
        {
            InitializeComponent();
            materielDA = new MaterielDA();
        }

        public string getCasier()
        {
            return this.nomCasier;
        }

        public void setCasier(string nomCasier)
        {
            this.nomCasier = nomCasier;
        }

        private void btInisiliser_Click(object sender, EventArgs e)
        {
            txtRef.Clear();
            txtDesc.Clear();
            txtLien.Clear();
            txtPrix.Clear();
            txtQuantite.Clear();
        }

        private void AjoutMateriel2_Load(object sender, EventArgs e)
        {
            FabricantDA fabricantDA = new FabricantDA();
            List<Fabricant> list2 = fabricantDA.getAllFabricant();
            foreach (Fabricant f in list2)
            {
                listFab.Items.Add(f.getNom());
            }
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtRef.Text.Equals("") || (txtDesc.Text.Equals("")) || (txtPrix.Text.Equals("") || (txtQuantite.Equals("")) || (txtLien.Text.Equals("") || listFab.SelectedItem.ToString() == null))))
                {
                    MessageBox.Show("Il y a au mois un champ vide ", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (materielDA.refExist(materielDA.getAllMateriel(), txtRef.Text))
                    {
                        MessageBox.Show("Ce matériel est déjà Existe", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Materiel m = new Materiel(txtRef.Text, txtDesc.Text, txtPrix.Text, txtQuantite.Text, txtLien.Text, new Fabricant(listFab.SelectedItem.ToString()), new Cassier(getCasier()));
                        Boolean test = materielDA.AjouterP(m);
                        if (test == true)
                        {
                            MessageBox.Show("L'ajout de matériel est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Vérifiez les valeurs", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Il faut choisir un Fabricant", "Message d'erreur :"+ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
