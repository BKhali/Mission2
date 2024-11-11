using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mission2.classes;
using System.Windows.Forms;

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

        public static void deltraverse(traversee e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE from traverse WHERE ID_TRAVERSE= '" + Convert.ToString(e.getId));


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }

        public static void inserttraverse(int id_liaison, int id_traverse, int id_bateau, string Datetraverse,int heure)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO traverse VALUES(" + id_liaison + ","+ id_traverse +","+ id_bateau + "," + Datetraverse + "," + heure);

                int i = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);
            }
        }
        // Mise à jour d'une traversée
        /**
        public static void updateTraversee(traversee e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update employe set login= '" + e.Login + "' where id = " + e.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        **/
        // Récupération de la liste
        public static List<traversee> getTraversee()
        {

            List<traversee> lc = new List<traversee>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT l.ID_LIAISON AS liaison, t.ID_TRAVERSE, b.ID_BATEAU AS bateau, t.DATETRAVERSE, t.HEURE " +
                    "FROM traverse t" +
                    "JOIN liaison l ON l.ID_LIAISON = t.ID_LIAISON" +
                    "JOIN bateau b ON b.ID_BATEAU = t.ID_BATEAU; ");


                MySqlDataReader reader = Ocom.ExecuteReader();

                traversee e;




                while (reader.Read())
                {

                    liaison id_liaison = (liaison)reader.GetValue(0);
                    int id = (int)reader.GetValue(1);
                    bateau id_bateau = (bateau)reader.GetValue(2);
                    string date = (string)reader.GetValue(3);
                    int heure = (int)reader.GetValue(4);

                    //Instanciation
                    e = new traversee(id, id_liaison, id_bateau, date, heure);

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
        /**
        public static void supprEmploye(Employe e)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("DELETE FROM employe WHERE id=" + e.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }
        public static void insertEmploye(int id, string login)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("INSERT INTO employe VALUES (" + id + ",'','','" + login + "',0)");


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }**/
    }

}






