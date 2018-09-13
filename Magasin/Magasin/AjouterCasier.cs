using System;
using System.Windows.Forms;
using Magasin.DA;
using Magasin.Model;

namespace Magasin
{
    public partial class AjouterCasier : Form
    {
        public string nomBloc;
        CassierDA cassierDA;

        public string getNomBloc()
        {
            return this.nomBloc;
        }

        public void setNomBloc(string nom)
        {
            this.nomBloc = nom;
        }

        public AjouterCasier()
        {
            InitializeComponent();
            cassierDA = new CassierDA();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if(txtNom.Text.Equals(""))
            {
                MessageBox.Show("Champ vide", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean test = cassierDA.ajout(new Cassier(txtNom.Text, new Bloc(getNomBloc())));
                if (test == true)
                {
                    MessageBox.Show("L'ajout de casier est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur au niveau de l'ajout", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
