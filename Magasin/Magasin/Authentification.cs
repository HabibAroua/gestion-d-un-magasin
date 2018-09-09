using System;
using System.Windows.Forms;
using Magasin.Sql_Server;

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

        private void Authentification_Load(object sender, EventArgs e)
        {
            Test_Connection t = new Test_Connection();
            if(t.testServer()==false)
            {
                MessageBox.Show("Votre application n'est pas connecté avec la base de donnée ou bien le serveur est desactivé", "Impossible d'ouvrir l'application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Bien");
            }
        }
    }
}
