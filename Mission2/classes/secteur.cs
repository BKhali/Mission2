using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    public class secteur
    {
        private int id;
        private string libelle;

        public secteur(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int getId() { return id; }
        public string getLibelle() {  return libelle; }


    }
}
