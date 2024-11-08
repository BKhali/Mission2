using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    internal class bateau
    {
        private int id;
        private string nom;
        private int longueur;
        private int largeur;
        private int vitesse;

        public bateau(int id, string nom, int longueur, int largeur, int vitesse)
        {
            this.id = id;
            this.nom = nom;
            this.longueur = longueur;
            this.largeur = largeur;
            this.vitesse = vitesse;
        }
    }
}
