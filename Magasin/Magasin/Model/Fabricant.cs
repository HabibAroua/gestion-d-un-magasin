using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.Model
{
    class Fabricant
    {
        private string nom;

        public string getNom()
        {
            return this.nom;
        }

        public Fabricant(string nom)
        {
            this.nom = nom;
        }
    }
}
