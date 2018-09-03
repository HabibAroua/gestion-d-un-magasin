namespace Magasin.Model
{
    class Materiel
    { 
        private string reference;
        private string description;
        private string prix;
        private string quantite;
        private string lien;
        private Fabricant f;
        private Cassier cas;

        public Materiel (string r , string d, string p,string q, string l , Fabricant fab , Cassier c)
        {
            reference = r;
            description = d;
            prix = p;
            quantite = q;
            lien = l;
            f = fab;
            cas = c;
        }

        public Materiel(string reference)
        {
            this.reference = reference;
        }

        public string getReference()
        {
            return this.reference;
        }

        public string getDescription()
        {
            return this.description;
        }

        public string getPrix()
        {
            return this.prix;
        }

        public string getQuantite()
        {
            return this.quantite;
        }

        public string getLien()
        {
            return this.lien;
        }

        public Fabricant getFabricant()
        {
            return this.f;
        }

        public Cassier getCassier()
        {
            return this.cas;
        }
    }
}
