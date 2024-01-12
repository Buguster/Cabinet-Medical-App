using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    public partial class paiement : Form
    {
            public paiement()
            {
                InitializeComponent();
            }

            private void paiement_Load(object sender, EventArgs e)
            {
                Donne d = new Donne();
                d.RemplirGrid(" facture ", dgvpaiment);
            }


        private void button1_Click(object sender, EventArgs e)
            {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }
    }
    }
