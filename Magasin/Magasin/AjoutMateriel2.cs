using System;
using System.Collections.Generic;
using Magasin.DA;
using Magasin.Model;
using System.Windows.Forms;

namespace Magasin
{
    public partial class AjoutMateriel2 : Form
    {
        public AjoutMateriel2()
        {
            InitializeComponent();
        }

        private void btInisiliser_Click(object sender, EventArgs e)
        {

        }

        private void AjoutMateriel2_Load(object sender, EventArgs e)
        {/*
            CassierDA cassierDA = new CassierDA();
            List<Cassier> list1 = cassierDA.getAllCassier();
            foreach (Cassier c in list1)
            {
                listNomCasier.Items.Add(c.getNom());
            }

            FabricantDA fabricantDA = new FabricantDA();
            List<Fabricant> list2 = fabricantDA.getAllFabricant();
            foreach (Fabricant f in list2)
            {
                listFab.Items.Add(f.getNom());
            }
            */

        }

        private void btAjout_Click(object sender, EventArgs e)
        {

        }
    }
}
