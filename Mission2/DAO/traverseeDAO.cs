using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mission2.classes;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connecte.DAO
{
    public class TraverseeDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "slines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static void modiftraverse(traversee e, string date, string heure)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update traverse set DATETRAVERSE= '" + date + "', HEURE= '"+ heure +"' where ID_TRAVERSE = " + e.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        public static void deltraverse(traversee e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE from traverse WHERE ID_TRAVERSE= " + e.Id + " ;");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        public static void inserttraverse(int id_liaison, int id_traverse, int id_bateau, string Datetraverse, string heure)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO traverse VALUES(" + id_liaison + "," + id_traverse + "," + id_bateau + ",'" + Datetraverse + "','" + heure + "' );");

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        // Récupération de la liste
        public static List<traversee> getTraversee()
        {

            List<traversee> lc = new List<traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT liaison.ID_LIAISON AS liaison, liaison.ID_SECTEUR, liaison.DUREE," +
                    " liaison.id_port_depart, liaison.id_port_arrivee, traverse.ID_TRAVERSE, bateau.ID_BATEAU AS bateau," +
                    " bateau.NOM, bateau.LARGEUR, bateau.LONGUEUR, bateau.VITESSE, traverse.DATETRAVERSE, traverse.HEURE," +
                    " secteur.ID_SECTEUR, secteur.LIBELLE, depart.ID_PORT AS depart_ID_PORT, depart.NOM AS depart_NOM," +
                    " arrive.ID_PORT AS arrive_ID_PORT, arrive.NOM AS arrive_NOM " +
                    "FROM traverse JOIN liaison ON liaison.ID_LIAISON = traverse.ID_LIAISON " +
                    "JOIN secteur ON liaison.ID_SECTEUR = secteur.ID_SECTEUR " +
                    "JOIN port AS depart ON liaison.id_port_depart = depart.ID_PORT " +
                    "JOIN port AS arrive ON liaison.id_port_arrivee = arrive.ID_PORT " +
                    "JOIN bateau ON bateau.ID_BATEAU = traverse.ID_BATEAU;");
                MySqlDataReader reader = Ocom.ExecuteReader();
                traversee e;
                while (reader.Read())
                {
                    int id_liaison = (int)reader.GetValue(0);
                    int id_secteurl = (int)reader.GetValue(1);
                    decimal dureel = (decimal)reader.GetValue(2);
                    int idportd = (int)reader.GetValue(3);
                    int idporta = (int)reader.GetValue(4);

                    int idtraverse = (int)reader.GetValue(5);
                    int idbateau = (int)reader.GetValue(6);
                    string nombateau = (string)reader.GetValue(7);
                    decimal largbateau = (decimal)reader.GetValue(8);
                    decimal longbateau = (decimal)reader.GetValue(9);
                    decimal vitbateau = (decimal)reader.GetValue(10);

                    // Convertir la date (traverse.DATETRAVERSE) en DateTime
                    DateTime datet = (DateTime)reader.GetValue(11);

                    // Convertir l'heure (traverse.HEURE) en TimeSpan
                    TimeSpan heuret = (TimeSpan)reader.GetValue(12);

                    int idsecteur = (int)reader.GetValue(13);
                    string libelle = (string)reader.GetValue(14);

                    int depart_ID_PORT = (int)reader.GetValue(15);
                    string depart_NOM = (string)reader.GetValue(16);

                    int arrive_ID_PORT = (int)reader.GetValue(17);
                    string arrive_NOM = (string)reader.GetValue(18);

                    //Instanciation des classes
                    port portd = new port(depart_ID_PORT, depart_NOM);
                    port porta = new port(arrive_ID_PORT, arrive_NOM);
                    secteur secteur = new secteur(idsecteur, libelle);
                    liaison liaison = new liaison(id_liaison, secteur, dureel, portd, porta);
                    bateau bateau = new bateau(idbateau, nombateau, largbateau, longbateau, vitbateau);

                    e = new traversee(idtraverse, liaison, bateau, datet, heuret);

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
        public static List<traversee> getTraverseeId(int id)
        {
            List<traversee> lc = new List<traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT " +
               "liaison.ID_LIAISON AS liaison, liaison.ID_SECTEUR, liaison.DUREE, " +
               "liaison.id_port_depart, liaison.id_port_arrivee, traverse.ID_TRAVERSE, " +
               "bateau.ID_BATEAU AS bateau, bateau.NOM, bateau.LARGEUR, bateau.LONGUEUR, " +
               "bateau.VITESSE, traverse.DATETRAVERSE, traverse.HEURE, secteur.ID_SECTEUR, " +
               "secteur.LIBELLE, depart.ID_PORT AS depart_ID_PORT, depart.NOM AS depart_NOM, " +
               "arrive.ID_PORT AS arrive_ID_PORT, arrive.NOM AS arrive_NOM " +
               "FROM traverse " +
               "JOIN liaison ON liaison.ID_LIAISON = traverse.ID_LIAISON " +
               "JOIN secteur ON liaison.ID_SECTEUR = secteur.ID_SECTEUR " +
               "JOIN port AS depart ON liaison.id_port_depart = depart.ID_PORT " +
               "JOIN port AS arrive ON liaison.id_port_arrivee = arrive.ID_PORT " +
               "JOIN bateau ON bateau.ID_BATEAU = traverse.ID_BATEAU " +
               "WHERE traverse.ID_LIAISON = "+id+ ";");
                MySqlDataReader reader = Ocom.ExecuteReader();
                traversee e;
                while (reader.Read())
                {
                    int id_liaison = (int)reader.GetValue(0);
                    int id_secteurl = (int)reader.GetValue(1);
                    decimal dureel = (decimal)reader.GetValue(2);
                    int idportd = (int)reader.GetValue(3);
                    int idporta = (int)reader.GetValue(4);

                    int idtraverse = (int)reader.GetValue(5);
                    int idbateau = (int)reader.GetValue(6);
                    string nombateau = (string)reader.GetValue(7);
                    decimal largbateau = (decimal)reader.GetValue(8);
                    decimal longbateau = (decimal)reader.GetValue(9);
                    decimal vitbateau = (decimal)reader.GetValue(10);

                    // Convertir la date (traverse.DATETRAVERSE) en DateTime
                    DateTime datet = (DateTime)reader.GetValue(11);

                    // Convertir l'heure (traverse.HEURE) en TimeSpan
                    TimeSpan heuret = (TimeSpan)reader.GetValue(12);

                    int idsecteur = (int)reader.GetValue(13);
                    string libelle = (string)reader.GetValue(14);

                    int depart_ID_PORT = (int)reader.GetValue(15);
                    string depart_NOM = (string)reader.GetValue(16);

                    int arrive_ID_PORT = (int)reader.GetValue(17);
                    string arrive_NOM = (string)reader.GetValue(18);

                    //Instanciation des classes
                    port portd = new port(depart_ID_PORT, depart_NOM);
                    port porta = new port(arrive_ID_PORT, arrive_NOM);
                    secteur secteur = new secteur(idsecteur, libelle);
                    liaison liaison = new liaison(id_liaison, secteur, dureel, portd, porta);
                    bateau bateau = new bateau(idbateau, nombateau, largbateau, longbateau, vitbateau);

                    e = new traversee(idtraverse, liaison, bateau, datet, heuret);

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







