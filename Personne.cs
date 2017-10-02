using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPersonne
{
    class Personne
    {
        public string Nom { set; get; }
        public string Prenom { set; get; }

        public Personne(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }

        public Personne()
        {
            this.Nom = "Ho";
            this.Prenom = "Hi";
        }

        public override string ToString()
        {
            return Nom + Prenom;
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Moncul()
        {
            return true;
        }

    }
}
