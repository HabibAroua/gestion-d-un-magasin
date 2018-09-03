using System;

namespace Magasin.Model
{
    class Cassier
    {
        private String nom;
        private Bloc b;

        public Cassier(String nom , Bloc b)
        {
            this.nom = nom;
            this.b = b;
        }

        public Cassier(String nom)
        {
            this.nom = nom;
        }

        public String getNom()
        {
            return this.nom ;
        }

        public Bloc getB()
        {
            return b;
        }
    }
}
