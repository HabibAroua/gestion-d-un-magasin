using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Magasin.DA;
using Magasin.Model;

namespace Magasin
{
    public partial class index : Form
    {

        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            CassierDA cassierDA = new CassierDA();
            List<Cassier> list = cassierDA.getAllCassier();
            foreach(Cassier c in list)
            {
                MessageBox.Show(c.getNom()+" "+c.getB().getNom(),"Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}