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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if((login=="user") && (password=="asteel"))
            {
                Accueil a = new Accueil();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect", "Message erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
