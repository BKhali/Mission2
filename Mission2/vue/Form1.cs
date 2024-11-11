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
        public void chargerTraverse()
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
        private void listBoxliaison_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            chargerTraverse();
        }

        private void Supr_traverse_Click(object sender, EventArgs e)
        {
            if (listBoxliaison.SelectedItem != null)
            {
                // Récupérer la liaison sélectionnée
                traversee selectedTraverse = listBoxtraverse.SelectedItem as traversee;

                if (selectedTraverse != null)
                {
                    try
                    {
                        // Afficher les traversées dans listBoxTraverse
                        Matraverse.traversedel(selectedTraverse);
                        chargerTraverse();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de la traversé : " + ex.Message);
                    }
                }
            }
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            int idliaison = Convert.ToInt32(Ajout_id_liaison.Text);
            int idtraverse = Convert.ToInt32(Ajout_id_traverse.Text);
            int idbateau = Convert.ToInt32(Ajout_id_bateau.Text);
            string date = Ajout_date.Text;
            string heure = Ajout_heure.Text;
            Matraverse.traverseInsert(idliaison,idtraverse,idbateau,date,heure);
            chargerTraverse();
        }

        private void Modif_traverse_Click(object sender, EventArgs e)
        {

            if (listBoxliaison.SelectedItem != null)
            {
                // Récupérer la liaison sélectionnée
                traversee selectedTraverse = listBoxtraverse.SelectedItem as traversee;

                if (selectedTraverse != null)
                {
                    try
                    {
                        // Afficher les traversées dans listBoxTraverse
                        string date = Modif_Date.Text;
                        string heure = Modif_Heure.Text;
                        Matraverse.modiftraverse(selectedTraverse, date, heure);
                        chargerTraverse();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la modification de la traversé : " + ex.Message);
                    }
                }
            }

        }
    }
}
