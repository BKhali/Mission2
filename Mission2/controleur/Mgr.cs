using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAO;
using Mission2.classes;


namespace Connecte.Controleur
{
  public  class Mgr
    {

        liaisonDAO laiDAO = new liaisonDAO();

        List<liaison> listeliaison;
        List<traversee> listetraversee;
        public Mgr()
        {
            listeliaison = new List<liaison>();
            listetraversee = new List<traversee>();
        }



        // Récupération de la liste des liaison
        public List<liaison> chargementBD()
        {

            listeliaison = liaisonDAO.getliaison();

            return (listeliaison);
        }

    }
}
