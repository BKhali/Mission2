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


                Ocom = maConnexionSql.reqExec("Select ID_LIAISON, ID_SECTEUR, DUREE, id_port_depart, id_port_arrivee " +
                                            "from liaison join secteur on liaison.ID_SECTEUR = secteur.ID_SECTEUR " +
                                            "join port as id_port_depart on liaison.id_port_depart = port.ID_PORT " +
                                            "join port as arrivee on liaison.arrivee = port.ID_PORT");

                //Select ID_LIAISON, secteur.ID_SECTEUR, DUREE, id_port_depart, id_port_arrivee, 
                 //                           from liaison join secteur on liaison.ID_SECTEUR = secteur.ID_SECTEUR
                 //                join port as depart on liaison.id_port_depart = depart.ID_PORT
                  //                         join port as arrivee on liaison.id_port_arrivee = arrivee.ID_PORT
                  //                         join port as nomd on liaison.id_port_depart = nomd.ID_PORT





                MySqlDataReader reader = Ocom.ExecuteReader();

                liaison e;




                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    secteur id_secteur = (secteur)reader.GetValue(1);
                    float duree = (float)reader.GetValue(2);
                    port id_port_depart = (port)reader.GetValue(3);
                    port id_port_arivee = (port)reader.GetValue(4);

                    //Instanciation d'un Emplye
                    e = new liaison(id, id_secteur, duree, id_port_depart, id_port_arivee);

                    // Ajout de cet employe à la liste 
                    lc.Add(e);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }
    }
}
