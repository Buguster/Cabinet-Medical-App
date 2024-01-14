using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ordonance ordonance = new Ordonance();
            ordonance.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            paiement paiement = new paiement();
            paiement.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login connect = new Login();
            connect.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            Ordonance ord = new Ordonance();
            ord.Show();
            this.Hide();
        }

        private void stagiare_Click(object sender, EventArgs e)
        {
            Stagiaire stagiaire = new Stagiaire();
            stagiaire.Show();
            this.Hide();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void paiement_Click(object sender, EventArgs e)
        {
            paiement paiement = new paiement();
            paiement.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            if (BaseClass.type == "S")
            {
                ordonnace.Visible = false;
            }
            else if (BaseClass.type == "M")
            {
                Acceuil acceuil = new Acceuil();
                acceuil.Show();
                this.Hide();
            }
        }

        private void Rendez_vous_Click(object sender, EventArgs e)
        {
            RDV rdv = new RDV();
            rdv.Show();
            this.Hide();
        }
    }
}
