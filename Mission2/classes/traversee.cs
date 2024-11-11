using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.classes
{
    public class traversee
    {
        private int id;
        private liaison id_liaison;
        private bateau id_bateau;
        private string date;
        private int heure;

        public traversee(int id, liaison id_liaison, bateau id_bateau, string date, int heure)
        {
            this.id = id;
            this.id_liaison = id_liaison;
            this.id_bateau = id_bateau;
            this.date = date;
            this.heure = heure;
        }

        public int getId() { return id; }
        public liaison getid_liaison() { return id_liaison; }
    }
}
