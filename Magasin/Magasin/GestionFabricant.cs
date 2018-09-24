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
    }
}
