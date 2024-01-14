using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    public partial class Acceuil : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;
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

            }
            else if (BaseClass.type == "M")
            {
                Acceuil acceuil = new Acceuil();
                acceuil.Show();
                this.Hide();
            }

            // pour les informations sur l'acceuil 

            textBox1_TextChanged(sender, e);
            textBox2_TextChanged(sender, e);
            textBox3_TextChanged(sender, e);
            textBox4_TextChanged(sender, e);
        }

        private void Rendez_vous_Click(object sender, EventArgs e)
        {
            RDV rdv = new RDV();
            rdv.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private int total_patients()
        {
            int totalPatients = 0;

            using (SqlConnection connection = new SqlConnection(server_name))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Patient";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    totalPatients = (int)command.ExecuteScalar();
                }
            }
            return totalPatients;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int totalPatients = total_patients();
            textBox1.Text = $"{totalPatients}";
        }

        private int TotalRDV_today()
        {
            int total_RDV = 0;

            using (SqlConnection connection = new SqlConnection(server_name))
            {
                connection.Open();
                string query = "SELECT COUNT(DISTINCT id_patient) FROM RDV" +
                    " WHERE date = GETDATE()";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    total_RDV = (int)command.ExecuteScalar();
                }
            }

            return total_RDV;
        }

        private int TotalRDV()
        {
            int total_RDV = 0;

            using (SqlConnection connection = new SqlConnection(server_name))
            {
                connection.Open();
                string query = "SELECT COUNT(DISTINCT id_patient) FROM RDV";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    total_RDV = (int)command.ExecuteScalar();
                }
            }

            return total_RDV;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int total_RDV = TotalRDV_today();
            textBox2.Text = $"{total_RDV}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int total_RDV = TotalRDV();
            textBox3.Text = $"{total_RDV}";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login h = new Login();
            h.Show();
            this.Hide();
        }
    } 
}

