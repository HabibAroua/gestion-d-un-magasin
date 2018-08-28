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
    public partial class ModifierMateriel : Form
    {
        public ModifierMateriel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rdAjouter.Checked==true)
            {
                MessageBox.Show("Ajouter");
            }
            else
            {
                if(rdMinimiser.Checked==true)
                {
                    MessageBox.Show("Minimiser");
                }
            }
        }
    }
}
