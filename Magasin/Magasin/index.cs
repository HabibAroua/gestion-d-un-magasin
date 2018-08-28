using System;
using System.Windows.Forms;
using Magasin.DA;

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

        private void index_Load(object sender, EventArgs e)
        {
            dataGridBloc.DataSource = blocDA.sellectAll();
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
    }
}