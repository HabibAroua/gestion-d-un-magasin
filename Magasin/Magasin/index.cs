using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Magasin.DA;
using Magasin.Model;

namespace Magasin
{
    public partial class index : Form
    {
        BlocDA blocDA;
        public index()
        {
            InitializeComponent();
            blocDA = new BlocDA();
        }

        private void index_Load(object sender, EventArgs e)
        {
            dataGridBloc.DataSource = blocDA.sellectAll();
        }
    }
}