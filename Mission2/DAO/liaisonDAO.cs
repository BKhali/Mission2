using Connecte;
using Mission2.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.DAO
{
    public class liaisonDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "slines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static List<liaison> getliaison()
        {

            List<liaison> lc = new List<liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT ID_LIAISON, secteur.ID_SECTEUR, DUREE, depart.ID_PORT AS ID_PORT_DEPART, depart.NOM AS NOM_PORT_DEPART, arrivee.ID_PORT AS ID_PORT_ARRIVEE, arrivee.NOM AS NOM_PORT_ARRIVEE, secteur.libelle AS LIBELLE_SECTEUR FROM liaison JOIN secteur ON liaison.ID_SECTEUR = secteur.ID_SECTEUR JOIN port AS depart ON liaison.id_port_depart = depart.ID_PORT JOIN port AS arrivee ON liaison.id_port_arrivee = arrivee.ID_PORT");


                MySqlDataReader reader = Ocom.ExecuteReader();

                liaison e;



                while (reader.Read())
                {

                    int id = Convert.ToInt32((int)reader.GetValue(0));
                    int id_secteur = Convert.ToInt32((int)reader.GetValue(1));
                    decimal duree = Convert.ToDecimal((decimal)reader.GetValue(2));
                    int id_port_depart = Convert.ToInt32((int)reader.GetValue(3));
                    string nom_port_depart = (string)reader.GetValue(4);
                    int id_port_arivee = Convert.ToInt32((int)reader.GetValue(5));
                    string nom_port_arrivee = (string)reader.GetValue(6);
                    string nom_secteur = (string)reader.GetValue(7);

                    secteur secteur = new secteur(id_secteur, nom_secteur);

                    port port_arriver = new port(id_port_arivee, nom_port_arrivee);
                    port port_depart = new port(id_port_depart, nom_port_depart);

                    //Instanciation d'une liaison
                    e = new liaison(id, secteur, duree, port_arriver, port_depart);

                    // Ajout à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }
    }
}
