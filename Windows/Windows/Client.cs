using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    public class Client
    {
        public String nom;
        public String prenom;
        public String mdp;
        public String ddn;
        public String adresse;
        public String CIN;
        public String solde;
        public bool type = false;

        public Client(String nom,String prenom,String mdp,String ddn,String adresse,String CIN,String solde)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mdp = mdp;
            this.ddn = ddn;
            this.adresse = adresse;
            this.CIN = CIN;
            this.solde = solde;
        }

    }

   
}
