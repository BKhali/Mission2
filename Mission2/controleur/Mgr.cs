using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAO;
using Mission2.classes;


namespace Connecte.Controleur
{
    public class Mgr
    {

        liaisonDAO laiDAO = new liaisonDAO();
        TraverseeDAO TraDAO = new TraverseeDAO();

        List<liaison> listeliaison;
        List<traversee> listetraversee;
        public Mgr()
        {
            listeliaison = new List<liaison>();
            listetraversee = new List<traversee>();
        }



        // Récupération de la liste des liaison
        public List<liaison> chargementBDL()
        {

            listeliaison = liaisonDAO.getliaison();

            return (listeliaison);
        }
        public List<traversee> chargementBDT()
        {

            listetraversee = TraverseeDAO.getTraversee();

            return (listetraversee);
        }
        public List<traversee> ChargerTraversesParLiaison(int id)
        {

            listetraversee = TraverseeDAO.getTraverseeId(id);

            return (listetraversee);
        }

        public void modiftraverse(traversee e, string date, string heure)
        {
            TraverseeDAO.modiftraverse(e, date, heure);
        }
        public void traversedel(traversee id)
        {
            TraverseeDAO.deltraverse(id);
        }
        public void traverseInsert(int id_liaison, int id_traverse, int id_bateau, string Datetraverse, string heure)
        {
            TraverseeDAO.inserttraverse(id_liaison, id_traverse, id_bateau, Datetraverse, heure);
        }
    }
}

