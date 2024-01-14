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
                BaseClass d = new BaseClass();
                d.RemplirGrid(" facture ", dgvpaiment);


            // style 
            dgvpaiment.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dgvpaiment.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvpaiment.DefaultCellStyle.BackColor = Color.LightGray;
            dgvpaiment.DefaultCellStyle.ForeColor = Color.Blue;
            dgvpaiment.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvpaiment.DefaultCellStyle.SelectionForeColor = Color.Red;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            BaseClass d = new BaseClass();
            d.connecter();
            d.cmd.Connection = d.Con;
            try
            {
                d.cmd.CommandText = "INSERT INTO facture (Num_facture, date_paiment, montant, type_medicament, id_patient) VALUES (@param1, @param2, @param3, @param4, @param5)";
                d.cmd.Parameters.AddWithValue("@param1", int.Parse(textBox1.Text));
                d.cmd.Parameters.AddWithValue("@param2", DateTime.Parse(textBox7.Text));
                d.cmd.Parameters.AddWithValue("@param3", decimal.TryParse(textBox3.Text, out decimal montantxt));
                d.cmd.Parameters.AddWithValue("@param4", textBox6.Text);
                d.cmd.Parameters.AddWithValue("@param5", int.Parse(textBox2.Text));
                d.cmd.ExecuteNonQuery();
                MessageBox.Show("Montant valide");
                d.cmd.Parameters.Clear();
                d.cmd.CommandText = "SELECT * FROM facture";

                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(d.cmd))
                {
                    adapter.Fill(dataTable);
                }

                dgvpaiment.DataSource = dataTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseClass G = new BaseClass();
            G.connecter();
            G.cmd.Connection = G.Con;

            try
            {
                G.cmd.CommandText = "SELECT * FROM Stagiaire";
                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(G.cmd))
                {
                    adapter.Fill(dataTable);
                }
                dgvpaiment.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du chargement des données : "
                    + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                G.Con.Close();
            }

        }
    }
}
