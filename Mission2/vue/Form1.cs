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
        List<liaison> lEmp = new List<liaison>();
        public Form1()
        {
            InitializeComponent();

            Maliaison = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lEmp = Maliaison.chargementBD();

            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxliaison.DataSource = null;
                listBoxliaison.DataSource = lEmp;
                listBoxliaison.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
