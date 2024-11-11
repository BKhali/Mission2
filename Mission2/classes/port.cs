using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    public class port
    {
        private int id;
        private string nom;

        public port(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public string DescriptionP
        {
            get => "Secteur: " + id + " nom: " + nom;
        }

        public int getId() { return id; }
        public string getNom() { return nom; }
    }

}
