using System;
using System.Windows.Forms;
using Magasin.DA;
using Magasin.Regular_Expression;

namespace Magasin
{
    public partial class index : Form
    {
        BlocDA blocDA;
        CassierDA cassierDA;

        public index()
        {
            InitializeComponent();
            blocDA = new BlocDA();
            cassierDA = new CassierDA();
        }

        private void load()
        {
            dataGridBloc.DataSource = blocDA.sellectAll();
            dataGridBloc.RowHeadersWidth = 61;
            for (int i = 0; i < dataGridCasier.Columns.Count; i++)
            {
                dataGridCasier.Columns[i].Width = 151;
            }
        }

        private void index_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridBloc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridCasier.DataSource = cassierDA.findCassierByBloc(dataGridBloc.CurrentRow.Cells[0].Value.ToString());
                labelBloc.Text = dataGridBloc.CurrentRow.Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btAjout_Click(object sender, EventArgs e)
        {
            try
            {
                AjoutMateriel2 a = new AjoutMateriel2();
                a.setCasier(dataGridCasier.CurrentRow.Cells[0].Value.ToString());
                a.Show();
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Impossible d'ajouter une nouvelle casier", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridBloc.CurrentRow.Cells[0].Value.ToString() == null)
                {
                    MessageBox.Show("Impossible d'ajouter une nouvelle casier", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AjouterCasier ajouterCasier = new AjouterCasier();
                    ajouterCasier.Show();
                    ajouterCasier.setNomBloc(dataGridBloc.CurrentRow.Cells[0].Value.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Impossible d'ajouter une nouvelle casier", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quittezToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous quittez ?", "quittez l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a== DialogResult.Yes)
            {
                Application.Exit();
          
            }
        }

        private void redémarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void actualiséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridBloc.DataSource = blocDA.sellectAll();
        }

        private void gestionDesMatérielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercheMateriel r = new RechercheMateriel();
            r.Show();
        }

        private void ajouterMaterielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMateriel aj = new AjoutMateriel();
            aj.Show();
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Regular r=new Regular();
            if(txtBloc.Text.Equals(""))
            {
                MessageBox.Show("Champs vide", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(blocDA.Exist(blocDA.getAll(),new Model.Bloc(txtBloc.Text)))
                {
                    MessageBox.Show("Ce bloc est déja existe", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (r.CommencerParBloc(txtBloc.Text))
                    {
                        Boolean test = blocDA.Ajouter(new Model.Bloc(txtBloc.Text));
                        if (test == true)
                        {
                            MessageBox.Show("L'ajout du bloc est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Erreur au niveau de l'ajout", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le nom doit commencer par Bloc", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show("Voulez vous supprimez ce casier", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Boolean test = cassierDA.supprimer(dataGridCasier.CurrentRow.Cells[0].Value.ToString());
                    if (test == true)
                    {
                        MessageBox.Show("Suppresion de ce casier est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Ce casier n'est pas vide", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Suppression Annulé", "Suppression annulé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Message d'erreur : Element non séléctionné", ex.Message, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show("Voulez vous supprimez ce bloc", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    Boolean test = blocDA.Supprimer(dataGridBloc.CurrentRow.Cells[0].Value.ToString());
                    if (test == true)
                    {
                        MessageBox.Show("Suppresion de ce bloc est effectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Ce bloc n'est pas vide", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Suppression Annulé", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("Error : Element non séléctionné", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}