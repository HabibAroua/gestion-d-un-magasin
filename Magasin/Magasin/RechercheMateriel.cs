using System;
using System.Windows.Forms;
using Magasin.DA;

namespace Magasin
{
    public partial class RechercheMateriel : Form
    {

        MaterielDA materielDA;
        public RechercheMateriel()
        {
            InitializeComponent();
            materielDA = new MaterielDA();
        }

        private void RechercheMateriel_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridMataeriel.DataSource = materielDA.sellectAll();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Message d'erreur :" + ex.Message);
            }
        }

        private void txtRefCherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridMataeriel.DataSource = materielDA.findByChar(txtRefCherche.Text);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Message d'erreur : " + ex.Message);
            }
        }

        private void dataGridMataeriel_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ConsultMateriel c = new ConsultMateriel();
                c.setReference(dataGridMataeriel.CurrentRow.Cells[0].Value.ToString());
                c.setDescription(dataGridMataeriel.CurrentRow.Cells[1].Value.ToString());
                c.setPrix(dataGridMataeriel.CurrentRow.Cells[2].Value.ToString());
                c.setQuantite(dataGridMataeriel.CurrentRow.Cells[3].Value.ToString());
                c.setFab(dataGridMataeriel.CurrentRow.Cells[5].Value.ToString());
                c.setCasier(dataGridMataeriel.CurrentRow.Cells[6].Value.ToString());
                c.setBloc(dataGridMataeriel.CurrentRow.Cells[7].Value.ToString());
                c.setLien(dataGridMataeriel.CurrentRow.Cells[4].Value.ToString());
                c.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur : Element non séléctionné", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("Message d'erreur :" + ex.Message);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            try
            {
                ModifierMateriel m = new ModifierMateriel();
                m.setReference(dataGridMataeriel.CurrentRow.Cells[0].Value.ToString());
                m.setDescription(dataGridMataeriel.CurrentRow.Cells[1].Value.ToString());
                m.setPrix(dataGridMataeriel.CurrentRow.Cells[2].Value.ToString());
                m.setQuantite(dataGridMataeriel.CurrentRow.Cells[3].Value.ToString());
                m.setFab(dataGridMataeriel.CurrentRow.Cells[5].Value.ToString());
                m.setCasier(dataGridMataeriel.CurrentRow.Cells[6].Value.ToString());
                m.setLien(dataGridMataeriel.CurrentRow.Cells[4].Value.ToString());
                m.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message d'erreur : Element non séléctionné", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show("Voulez vous supprimer ce materiel ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Boolean test = materielDA.Supprimer(dataGridMataeriel.CurrentRow.Cells[0].Value.ToString());
                    if (test == true)
                    {
                        MessageBox.Show("La suppression est effectué avec succés", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridMataeriel.DataSource = materielDA.sellectAll();
                    }
                    else
                    {
                        MessageBox.Show("Erreur au niveau du suppression", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message d'erreur : Element non séléctionné", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridMataeriel.DataSource = materielDA.sellectAll();
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error :" + ex.Message);
            }
        }

        private void dataGridMataeriel_Enter(object sender, EventArgs e)
        {
            try
            {
                ConsultMateriel c = new ConsultMateriel();
                c.setReference(dataGridMataeriel.CurrentRow.Cells[0].Value.ToString());
                c.setDescription(dataGridMataeriel.CurrentRow.Cells[1].Value.ToString());
                c.setPrix(dataGridMataeriel.CurrentRow.Cells[2].Value.ToString());
                c.setQuantite(dataGridMataeriel.CurrentRow.Cells[3].Value.ToString());
                c.setFab(dataGridMataeriel.CurrentRow.Cells[5].Value.ToString());
                c.setCasier(dataGridMataeriel.CurrentRow.Cells[6].Value.ToString());
                c.setBloc(dataGridMataeriel.CurrentRow.Cells[7].Value.ToString());
                c.setLien(dataGridMataeriel.CurrentRow.Cells[4].Value.ToString());
                c.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : Element non séléctionné", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
