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
using System.Configuration;

namespace medical_app
{
    public partial class RDV : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;
        public RDV()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlConnection myconn = new SqlConnection(server_name))
                    {
                        myconn.Open();

                        
                        string query_1 = "SELECT COUNT(*) FROM Patient WHERE id = @id";
                        SqlCommand cmd = myconn.CreateCommand();
                        cmd.Parameters.AddWithValue("@id", int.Parse(patient_ID.Text));
                    
                        cmd.CommandText = query_1;
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            string query_2 = "INSERT INTO RDV (date, id_patient) VALUES (@RDVDate, @PatientID)";
                            SqlCommand command = new SqlCommand(query_2, myconn);

                            command.Parameters.AddWithValue("@RDVDate", DateTimepickerdateRDV.Value);
                            command.Parameters.AddWithValue("@PatientID", int.Parse(patient_ID.Text));

                            int affectedRows = command.ExecuteNonQuery();

                            MessageBox.Show($"{affectedRows} row(s) affected");
                        }
                        else
                        {
                            MessageBox.Show("Patient Introuvable");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            RDVGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            RDVGrid.DefaultCellStyle.Font = new Font("Arial", 12);
            RDVGrid.DefaultCellStyle.BackColor = Color.LightGray;
            RDVGrid.DefaultCellStyle.ForeColor = Color.Blue;
            RDVGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            RDVGrid.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void afficher_Click(object sender, EventArgs e)
        {

        }

        private void RDVGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void select_rdv_based_times(object sender, EventArgs e)
        {
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            if (selected_time.SelectedIndex == 0)
            {
                using (SqlConnection myconn = new SqlConnection(server_name))
                {
                    try
                    {
                        myconn.Open();

                        if (myconn.State == ConnectionState.Open)
                        {
                            string query = "SELECT Nom, Prenom, telephone, date FROM Patient AS P " +
                                           "JOIN RDV AS R " +
                                           "ON P.id = R.id_patient " +
                                           "WHERE date = @aujourd_hui";

                            SqlCommand command = new SqlCommand(query, myconn);

                            command.Parameters.AddWithValue("@aujourd_hui", DateTime.Today);

                            using (SqlDataReader data = command.ExecuteReader())
                            {
                                if (data.HasRows)
                                {
                                    Grid_Filter_RDV.Rows.Clear();
                                    while (data.Read())
                                    {
                                        Grid_Filter_RDV.Rows.Add(data["Nom"], data["Prenom"], data["telephone"], data["date"]);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No data for the current date");
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

        }

        private void Grid_Filter_RDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Grid_Filter_RDV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            Grid_Filter_RDV.DefaultCellStyle.Font = new Font("Arial", 12);
            Grid_Filter_RDV.DefaultCellStyle.BackColor = Color.LightGray;
            Grid_Filter_RDV.DefaultCellStyle.ForeColor = Color.Blue;
            Grid_Filter_RDV.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            Grid_Filter_RDV.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_patient_Click(object sender, EventArgs e)
        {
            using (SqlConnection myconn = new SqlConnection(server_name))
            {
                try
                {
                    myconn.Open();
                    if (myconn.State == ConnectionState.Open)
                    {
                        string query = "SELECT * FROM RDV";
                        SqlCommand command = new SqlCommand(query, myconn);

                        RDVGrid.Rows.Clear();
                        using (SqlDataReader data = command.ExecuteReader())
                        {
                            if (data.HasRows)
                            {
                                while (data.Read())
                                {
                                    RDVGrid.Rows.Add(data[0], data[1], data[2]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("table est vide");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("veuillez connecter");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
    }
