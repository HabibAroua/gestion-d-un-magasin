using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magasin.DA;

namespace Magasin
{
    public partial class GestionFabricant : Form
    {
        FabricantDA fabricantDa;
        public GestionFabricant()
        {
            fabricantDa = new FabricantDA();
            InitializeComponent();
        }

        private void GestionFabricant_Load(object sender, EventArgs e)
        {
            dataGridFab.DataSource = fabricantDa.sellectAll();
            for (int i = 0; i < dataGridFab.Columns.Count; i++)
            {
                dataGridFab.Columns[i].Width = 151;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(fabricantDa.numberFabExist(dataGridFab.CurrentRow.Cells[0].Value.ToString())+" ");
        }

        private void dataGridFab_SelectionChanged(object sender, EventArgs e)
        {
            if(fabricantDa.numberFabExist(dataGridFab.CurrentRow.Cells[0].Value.ToString())>0)
            {
                btSupprimer.Enabled = false;
            }
            else
            {
                btSupprimer.Enabled = true;
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Boolean test = fabricantDa.ajouter(new Model.Fabricant(txtNomFab.Text));
            if(test==true)
            {
                MessageBox.Show("L'ajoout du fabricant efectué avec succes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erreur au niveau de l'ajout", ""Message d'erreur"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
