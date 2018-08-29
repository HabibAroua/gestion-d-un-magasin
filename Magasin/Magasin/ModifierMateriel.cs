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
    public partial class ModifierMateriel : Form
    {
        public string reference, description, prix, quantite, lien, fab, casier, bloc;
        MaterielDA materielDA;

        public void setReference(string reference)
        {
            this.reference = reference;
        }

        public string getReference()
        {
            return this.reference;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setPrix(string prix)
        {
            this.prix = prix;
        }

        public string getPrix()
        {
            return this.prix;
        }

        public string getQuantite()
        {
            return this.quantite;
        }

        public void setQuantite(string quantite)
        {
            this.quantite = quantite;
        }

        public void setLien(string lien)
        {
            this.lien = lien;
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            Materiel m = new Materiel(txtRef.Text, txtDesc.Text, txtPrix.Text, txtQuantite.Text, txtLien.Text, new Fabricant(txtFab.Text), new Cassier(txtNomCasier.Text));
            Boolean test = materielDA.modifier(m, getReference());
            if (test== true)
            {
                MessageBox.Show("La mise à jour de matétriel est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur au niveau de mise à jour", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listFab_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFab.Text =listFab.SelectedItem.ToString();
        }

        private void listNomCasier_SelectedValueChanged(object sender, EventArgs e)
        {
            txtNomCasier.Text = listNomCasier.SelectedItem.ToString();
        }

        private void btInisiliser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getLien()
        {
            return this.lien;
        }

        public void setFab(string fab)
        {
            this.fab = fab;
        }

        public string getFab()
        {
            return this.fab;
        }

        public void setCasier(string casier)
        {
            this.casier = casier;
        }

        public string getCasier()
        {
            return this.casier;
        }

        public ModifierMateriel()
        {
            InitializeComponent();
            materielDA = new MaterielDA();
        }

        private void ModifierMateriel_Load(object sender, EventArgs e)
        {
            txtRef.Text = getReference();
            txtDesc.Text = getDescription();
            txtPrix.Text = getPrix();
            txtQuantite.Text = getQuantite();
            txtLien.Text = getLien();
            listFab.Text = getFab();
            listNomCasier.Text = getCasier();

            CassierDA cassierDA = new CassierDA();
            List<Cassier> list1 = cassierDA.getAllCassier();
            foreach (Cassier c in list1)
            {
                listNomCasier.Items.Add(c.getNom());
            }
            txtNomCasier.Text = getCasier();

            FabricantDA fabricantDA = new FabricantDA();
            List<Fabricant> list2 = fabricantDA.getAllFabricant();
            foreach (Fabricant f in list2)
            {
                listFab.Items.Add(f.getNom());
            }

            txtFab.Text = getFab();

        }

    }
}
