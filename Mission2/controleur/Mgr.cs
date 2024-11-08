using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Connecte.Modele;
using Mission2.classes;


namespace Connecte.Controleur
{
  public  class Mgr
    {

        ConnexionSql empDAO = new ConnexionSql("localhost", "slines", "root","");

        List<bateau> listebateau;
        List<liaison> listeliaison;
        List<port> listeport;
        List<secteur> listesecteur;
        List<traversee> listetraversee;



        // Récupération de la liste des liaison
        public List<liaison> chargementEmpBD()
        {

            maListeliaison = ConnexionSql.getEmployes();

            return (maListeEmploye);
        }


        // Mise à jour d'un employé  dans la DAL
        public void updateEmploye(Employe e)
        {

            EmployeDAO.updateEmploye(e);

        }

        public void delEmployer(Employe e)
        {

            EmployeDAO.delEmploye(e);

        }

        public void insertEmploye(int id, string login)
        {

            EmployeDAO.insertEmploye(id, login);

        }

    }
}
