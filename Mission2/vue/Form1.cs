using Connecte.Controleur;
using Mission2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission2
{
    public partial class Form1 : Form
    {
        Mgr Maliaison;
        Mgr Matraverse;
        List<liaison> lEmp = new List<liaison>();
        List<traversee> lEmpt = new List<traversee>();
        public Form1()
        {
            InitializeComponent();

            Maliaison = new Mgr();
            Matraverse = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lEmp = Maliaison.chargementBDL();
            lEmpt = Matraverse.chargementBDT();

            afficheL();
            //afficheT();
        }

        public void afficheL()
        {
            try
            {
                listBoxliaison.DataSource = null;
                listBoxliaison.DataSource = lEmp;
                listBoxliaison.DisplayMember = "DescriptionL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void afficheT()
        {
            try
            {
                listBoxtraverse.DataSource = null;
                listBoxtraverse.DataSource = lEmpt;
                listBoxtraverse.DisplayMember = "DescriptionT";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Événement pour gérer la sélection dans listBoxLiaison

        private void listBoxliaison_SelectedIndexChanged_1(object sender, EventArgs e)

        {
            // Vérifier si un élément est sélectionné
            if (listBoxliaison.SelectedItem != null)
            {
                // Récupérer la liaison sélectionnée
                liaison selectedLiaison = listBoxliaison.SelectedItem as liaison;

                if (selectedLiaison != null)
                {
                    try
                    {
                        // Charger les traversées associées à la liaison sélectionnée
                        List<traversee> traverses = Matraverse.ChargerTraversesParLiaison(selectedLiaison.Id);

                        // Afficher les traversées dans listBoxTraverse
                        listBoxtraverse.DataSource = null;
                        listBoxtraverse.DataSource = traverses;
                        listBoxtraverse.DisplayMember = "DescriptionT";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors du chargement des traversées : " + ex.Message);
                    }
                }
            }
        }
    }
}
