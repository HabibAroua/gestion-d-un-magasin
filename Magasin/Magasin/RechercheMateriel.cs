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
            dataGridMataeriel.DataSource = materielDA.sellectAll();
        }

        private void txtRefCherche_TextChanged(object sender, EventArgs e)
        {
            dataGridMataeriel.DataSource = materielDA.findByChar(txtRefCherche.Text);
        }
    }
}
