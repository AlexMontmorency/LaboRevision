using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionExam1
{
    class Produit
    {
        private static int nbProduits = 0;
        private String nom {  get; set; }
        private decimal prix { get; set; }
        public static int NbProduits { get; internal set; }

        public Produit() {
            nom = null;


            prix = 0;


        }

        public Produit(String pNom, decimal pPrix)
        {
            nom = pNom;
           prix = pPrix;
        }


        public override string ToString()
        {
           
            return nom + ", " + prix;
        }

    }
}
