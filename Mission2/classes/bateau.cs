using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    public class bateau
    {
        private int id;
        private string nom;
        private decimal longueur;
        private decimal largeur;
        private decimal vitesse;

        public bateau(int id, string nom, decimal longueur, decimal largeur, decimal vitesse)
        {
            this.id = id;
            this.nom = nom;
            this.longueur = longueur;
            this.largeur = largeur;
            this.vitesse = vitesse;
        }
    }
}
