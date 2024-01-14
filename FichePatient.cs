using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    public partial class FichePatient : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;

        public FichePatient()
        {
            InitializeComponent();
            PatientGrid.CellFormatting += PatientGrid_CellFormatting;
        }

        private void PatientGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == PatientGrid.Columns["Afficher"].Index && e.RowIndex >= 0)
            {
                e.Value = "Afficher";
            }
        }

        private void FichePatient_Load(object sender, EventArgs e)
        {
            this.PatientGrid.ReadOnly = true;
            this.PatientGrid.AllowUserToAddRows = false;

            // style 
            PatientGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            PatientGrid.DefaultCellStyle.Font = new Font("Arial", 12);
            PatientGrid.DefaultCellStyle.BackColor = Color.LightGray;
            PatientGrid.DefaultCellStyle.ForeColor = Color.Blue;
            PatientGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            PatientGrid.DefaultCellStyle.SelectionForeColor = Color.Red;
        }
        private void PatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == PatientGrid.Columns["Afficher"].Index)
            {
                int ID_patient = Convert.ToInt32(PatientGrid.Rows[e.RowIndex].Cells["Id_Patient"].Value);
                string Nom = PatientGrid.Rows[e.RowIndex].Cells["Nom_patient"].Value.ToString();
                string Prenom = PatientGrid.Rows[e.RowIndex].Cells["Prenom_Patient"].Value.ToString();
                DateTime dossier_creation = Convert.ToDateTime(PatientGrid.Rows[e.RowIndex].Cells["Date_création"].Value);
                string Ville = PatientGrid.Rows[e.RowIndex].Cells["Ville"].Value.ToString();
                string Tel = PatientGrid.Rows[e.RowIndex].Cells["Téléphone"].Value.ToString();
                DateTime date_naiss = Convert.ToDateTime(PatientGrid.Rows[e.RowIndex].Cells["Date_naissance"].Value);
                string Symptomes = PatientGrid.Rows[e.RowIndex].Cells["symptomes"].Value.ToString();
                string etat = PatientGrid.Rows[e.RowIndex].Cells["Etat"].Value.ToString();
                string genre = PatientGrid.Rows[e.RowIndex].Cells["Sexe"].Value.ToString();
                Print_Patient(ID_patient, Nom, Prenom,dossier_creation, Ville, Tel, date_naiss, 
                    Symptomes, etat, genre);
            }
        }

        private void Print_Patient(int ID_patient, string Nom, string Prenom, 
            DateTime dossier_creation, string Ville, string Tel, DateTime date_naiss, string Symptomes,
            string etat, string genre)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                string content = $"Patient ID: {ID_patient}\n\n\n\nNom: {Nom}\n\nPrenom: {Prenom}\n\n\n\n" +
                                 $"Date de création du dossier: {dossier_creation}\n\nVille: {Ville}\n\n" +
                                 $"Téléphone: {Tel}\n\nDate de naissance: {date_naiss}\n\n" +
                                 $"Symptômes: {Symptomes}\n\nÉtat: {etat}\n\nGenre: {genre}\n\n";
                Font font = new Font("Arial", 16);
                RectangleF layoutRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
                StringFormat format = new StringFormat();
                e.Graphics.DrawString(content, font, Brushes.Black, layoutRect, format);
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection myconn = new SqlConnection(server_name))
            {
                    try
                    {
                        myconn.Open();

                        if (myconn.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Connected successfully");
                            string query = "SELECT * FROM Patient ORDER BY id";
                            SqlCommand command = new SqlCommand(query, myconn);

                            using (SqlDataReader data = command.ExecuteReader())
                            {
                                if (data.HasRows)
                                {
                                    MessageBox.Show("There is data");
                                    PatientGrid.Rows.Clear();
                                    while (data.Read())
                                    {
                                        PatientGrid.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5],
                                                              data[6], data[7], data[8], data[9]);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Table is empty");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not connected");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        private void rechercher_Click(object sender, EventArgs e)
        {
            if (inputsearchname.Text.Trim() == string.Empty)
            {
                MessageBox.Show("SVP veuillez saisir un nom ");
                return;
            }

            using (SqlConnection myconn = new SqlConnection(server_name))
            {
                string query = "SELECT COUNT(*) FROM Patient WHERE Nom = @nom";
                SqlCommand command = new SqlCommand(query, myconn);
                command.Parameters.AddWithValue("@nom", inputsearchname.Text.Trim());

                myconn.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                myconn.Close();

                if (count > 0)
                {
                    MessageBox.Show("Patient déja client du cabinet");
                }
                else
                {
                    MessageBox.Show("n'existe pas veuillez l'ajouter");
                }
            }
        }
    }
    }
