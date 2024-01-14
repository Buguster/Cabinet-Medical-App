using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    public partial class Medecin : Form
    {
        public Medecin()
        {
            InitializeComponent();
        }

        private void Medecin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            FichePatient p = new FichePatient();
            p.Show();
            this.Hide();
        }

        private void ordonnace_Click(object sender, EventArgs e)
        {
            Ordonance ordonnace = new Ordonance();
            ordonnace.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
