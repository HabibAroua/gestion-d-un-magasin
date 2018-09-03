using System;
using System.Windows.Forms;

namespace Magasin
{
    public partial class Accueil : Form
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
