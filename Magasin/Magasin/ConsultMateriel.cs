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
    public partial class ConsultMateriel : Form
    {
        public ConsultMateriel()
        {
            InitializeComponent();
        }

        private void ConsultMateriel_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate ("https://media.rs-online.com/t_large/RF120810-01.jpg");
        }
    }
}
