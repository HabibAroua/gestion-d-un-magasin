using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void quittezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous quittez ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void redémarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous Redémarrez ?", "Redémarer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RechercheMateriel r = new RechercheMateriel();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjoutMateriel a = new AjoutMateriel();
            a.Show();
        }

        private void gestionDesMatérielsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercheMateriel r = new RechercheMateriel();
            r.Show();
        }
    }
}
