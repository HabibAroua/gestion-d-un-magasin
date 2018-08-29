using System;

using System.Windows.Forms;

namespace Magasin
{
    public partial class ConsultMateriel : Form
    {
        public string reference, description, prix, quantite, lien, fab, casier, bloc;

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

        public void setQuantite(string  quantite)
        {
            this.quantite = quantite;
        }

        public void setLien(string lien)
        {
            this.lien = lien;
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

        public void setBloc(string bloc)
        {
            this.bloc = bloc;
        }

        public string getBloc()
        {
            return this.bloc;
        }

        public ConsultMateriel()
        {
            InitializeComponent();
        }

        private void ConsultMateriel_Load(object sender, EventArgs e)
        {
            labelRef.Text = getReference();
            labelDesc.Text = getDescription();
            labelPrix.Text = getPrix();
            labelQuantite.Text = getQuantite();
            labelFab.Text = getFab();
            labelCasier.Text = getCasier();
            labelBloc.Text = getBloc();
            webBrowser1.Navigate (getLien());
        }
    }
}
