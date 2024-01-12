using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewProjet
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=SOLAB\SQLEXPRESS;Initial Catalog=APP_V1;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection(@"Data Source=SOLAB\SQLEXPRESS;Initial Catalog=APP_V1;Integrated Security=True;");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
        public SqlCommandBuilder cb;
        public SqlDataAdapter dap = new SqlDataAdapter();
        //functions

     
       
        //remplir gridview principal
        public void RemplirGrid()
        {
            SqlCommand MyCommand = con.CreateCommand();
            MyCommand.CommandText = "SELECT id, date_rdv, date_limite,id_patient from miniprojet.dbo.RDV ";
            SqlDataReader myRd = MyCommand.ExecuteReader();
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;



            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
            }
            dr.Close();

        }






        //supprimer
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer la date limite du rendez-vous sélectionné dans la colonne appropriée 

                DateTime dateLimite = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DATE_LIMITE"].Value);

                // Vérifier si la date limite est dépassée par rapport à la date d'aujourd'hui
                if (dateLimite < DateTime.Today)
                {
                    // La date limite est dépassée, supprimer la ligne
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                    MessageBox.Show("RDV supprimé  car la date limite du rendez-vous est dépassée.");
                    // Supprimer la ligne de la table RDV en utilisant ADO.NET
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM RDV WHERE ID = @id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells["ID"].Value);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    // La date limite n'est pas dépassée, afficher un message d'alerte
                    MessageBox.Show("La date limite du rendez-vous n'est pas encore dépassée.");
                }
            }

        }



        //ajouter
        private void button1_Click(object sender, EventArgs e)
        {

            // Récupérer les valeurs des textbox
            DateTime date1Value = DateTime.Parse(textBox1.Text);//date rdv
            DateTime date2Value = DateTime.Parse(textBox2.Text);//date limite
            string idpatient = textBox3.Text;

            // Créer la connexion à la base de données
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Préparer et exécuter la requête d'insertion avec AddWithValue
                string query = "INSERT INTO RDV (date_rdv, date_limite, id_patient) VALUES (@Date1, @Date2, @idpatient)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date1", date1Value);
                    command.Parameters.AddWithValue("@Date2", date2Value);
                    command.Parameters.AddWithValue("@idpatient", idpatient);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //Quitter
        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Home home = new Home();//
                //home.Show();//
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Définir la requête de sélection des rendez-vous d'aujourd'hui
                string query = "SELECT id, date_rdv, date_limite, id_patient FROM RDV WHERE CONVERT(date, date_rdv) = CONVERT(date, GETDATE())";

                // Créer la commande de sélection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ouvrir la connexion et exécuter la commande de sélection
                    connection.Open();

                    // Utiliser un DataAdapter pour remplir un DataTable avec les résultats de la requête
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Lier le DataTable au DataGridView pour afficher les rendez-vous d'aujourd'hui
                    dataGridView2.DataSource = dataTable;
                }
                //remplir gridview 1 par les donnees de la table rdv
                RemplirGrid();
            }


           

        }
        private void RechercherRendezVous(int idPatient)
        {
            // Remplacer "connectionString" par la chaîne de connexion à votre base de données
          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Ouvrir la connexion à la base de données
                connection.Open();

                // Requête SQL pour rechercher les rendez-vous par id_patient
                string query = "SELECT id, date_rdv, date_limite FROM RDV WHERE id_patient = @idPatient";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter le paramètre idPatient à la commande SQL
                    command.Parameters.AddWithValue("@idPatient", idPatient);

                    // Exécuter la commande SQL et obtenir les résultats dans un DataTable
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);

                    // Afficher les résultats dans le DataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = textBox4.Text;
            int idpatient = int.Parse(id);
            RechercherRendezVous(idpatient);
            Thread.Sleep(3000);
            RemplirGrid();
        }
    }
}
