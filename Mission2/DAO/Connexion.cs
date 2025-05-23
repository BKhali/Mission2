﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms ;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Mission2.classes;

namespace Connecte {

    /**
     * Classe de connexion à une base de données
     */
    public class ConnexionSql
    {
        private static ConnexionSql connection = null;

        private MySqlConnection mysqlCn;

        private static readonly object mylock = new object();

        private string connString;


        public ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    mysqlCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                   throw(emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { // Premier appel
                        connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                        
                    }

                }
                catch (Exception emp)
                {
                    throw (emp);


                }
                return connection;

            }
        }





        /**
         * Ouverture de la connexion
         */
        public void openConnection()
        {
            try
            {
                if (mysqlCn.State == System.Data.ConnectionState.Closed)
                    mysqlCn.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        /**
         * Fermeture de la connexion
         */
        public void closeConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close();
        }

        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn);
            return (mysqlCom);
        }


    }

}