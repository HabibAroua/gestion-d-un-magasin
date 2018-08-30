using System;
using System.Windows.Forms;
using Magasin.DA;

namespace Magasin
{
    public partial class index : Form
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

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
            AjoutMateriel a = new AjoutMateriel();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterCasier ajouterCasier = new AjouterCasier();
            ajouterCasier.Show();
            ajouterCasier.setNomBloc(dataGridBloc.CurrentRow.Cells[0].Value.ToString());
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quittezToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("voulez vous quittez ?", "quittez l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Boolean test = blocDA.Ajouter(new Model.Bloc(txtBloc.Text));
            if(test==true)
            {
                MessageBox.Show("L'ajout du bloc est effectué avec succes","L'ajout",MessageBoxButtons.OK,MessageBoxIcon.Information);
                load();
            }
            else
            {
                MessageBox.Show("Erreur au niveau de l'ajout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}