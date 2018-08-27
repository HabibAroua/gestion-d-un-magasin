using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magasin.Model
{
    class Bloc
    {
        
        private String nom;

        public Bloc(String nom)
        {
            this.nom = nom;
        }

        public String getNom()
        {
            return this.nom;
        }
    }
}
