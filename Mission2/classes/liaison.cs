using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    public class liaison
    {
        private int id;
        private secteur id_secteur;
        private decimal duree;
        private port id_port_depart;
        private port id_port_arrivee;

        public liaison(int id, secteur id_secteur, decimal duree, port id_port_depart, port id_port_arrivee)
        {
            this.id = id;
            this.id_secteur = id_secteur;
            this.duree = duree;
            this.id_port_depart = id_port_depart;
            this.id_port_arrivee = id_port_arrivee;
        }

        public int getId() { return id; }
        public string DescriptionL
        {
            get => "Liaison:" + id + " secteur:" + id_secteur.DescriptionS +" durée:" + duree + " port depart:" + id_port_depart.DescriptionP + " port arrivee:" + id_port_arrivee.DescriptionP;
        }
    }
}
