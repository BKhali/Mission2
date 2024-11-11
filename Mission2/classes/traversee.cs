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
        private DateTime date;
        private TimeSpan heure;

        public traversee(int id, liaison id_liaison, bateau id_bateau, DateTime date, TimeSpan heure)
        {
            this.id = id;
            this.id_liaison = id_liaison;
            this.id_bateau = id_bateau;
            this.date = date;
            this.heure = heure;
        }
        public int Id { get => id; set => id = value; }
        public liaison Liaison { get => id_liaison; set => id_liaison = value; }
        public bateau Bateau { get => id_bateau; set => id_bateau = value; }
        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Heure { get => heure; set => heure = value; }

        public string DescriptionT
        {
            get => "Traversée:" + Id + " Liaison:" + Liaison.DescriptionL + " Bateau:" + Bateau + " Date:" + Date
                + " Heure:" + Heure;
        }
    }
}
