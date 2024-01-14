using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace medical_app
{
    public partial class Patient : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;
        int position = -1, id, patientID;
        bool edit_record = false;


        public Patient()
        {
            SqlConnection myconn = new SqlConnection(server_name);
            myconn.Open();
            InitializeComponent();
        }

        private bool CheckInfo()
        {
            return
                !string.IsNullOrWhiteSpace(inputNom.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputPrenom.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(dateTimePickerDateNaiss.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputVille.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputTel.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(dateTimePickerDateCreated.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputSymptome.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputEtat.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(inputSexe.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.PatientGrid.CurrentRow.Index;
            id = int.Parse(this.PatientGrid.Rows[position].Cells[0].Value.ToString());
            
            this.inputNom.Text = PatientGrid.Rows[position].Cells[0].Value.ToString(); 
            this.inputPrenom.Text = PatientGrid.Rows[position].Cells[1].Value.ToString();
            this.inputVille.Text = PatientGrid.Rows[position].Cells[3].Value.ToString(); 
            this.inputTel.Text = PatientGrid.Rows[position].Cells[4].Value.ToString(); 
            this.dateTimePickerDateNaiss.Text = PatientGrid.Rows[position].Cells[5].Value.ToString();
            this.inputSymptome.Text = PatientGrid.Rows[position].Cells[6].Value.ToString(); 
            this.inputEtat.Text = PatientGrid.Rows[position].Cells[7].Value.ToString();
            this.inputSexe.Text = PatientGrid.Rows[position].Cells[8].Value.ToString();
            edit_record = true;

            // pour le RDV 

            int patientID = int.Parse(this.PatientGrid.Rows[position].Cells[0].Value.ToString());
        }

        private void Patient_Load(object sender, EventArgs e)
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

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection myconn = new SqlConnection(server_name))
                {
                    myconn.Open();

                    string query = "INSERT INTO Patient " +
                                   "(Nom, Prenom, date_creation_dossier, ville, telephone, " +
                                   "date_naissance, symptômes, Etat, sexe) " +
                                   "VALUES " +
                                   "(@Nom, @Prenom, @datecreated, @Ville, @Tel, " +
                                   "@Datenaiss, @Symptome, @Etat, @Sexe)";

                    SqlCommand command = new SqlCommand(query, myconn);


                    command.Parameters.AddWithValue("@Nom", inputNom.Text.Trim());
                    command.Parameters.AddWithValue("@Prenom", inputPrenom.Text.Trim());
                    command.Parameters.AddWithValue("@datecreated", dateTimePickerDateCreated.Value);
                    command.Parameters.AddWithValue("@Ville", inputVille.Text.Trim());
                    command.Parameters.AddWithValue("@Tel", inputTel.Text.Trim());
                    command.Parameters.AddWithValue("@Datenaiss", dateTimePickerDateNaiss.Value);
                    command.Parameters.AddWithValue("@Symptome", inputSymptome.Text.Trim());
                    command.Parameters.AddWithValue("@Etat", inputEtat.Text.Trim());
                    command.Parameters.AddWithValue("@Sexe", inputSexe.Text.Trim());

                    int affectedRows = command.ExecuteNonQuery();
                    afficher_Click(sender, e);
                    MessageBox.Show($"{affectedRows} row(s) affected");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void afficher_Click(object sender, EventArgs e)
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

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("veuillez selectioner une ligne");
                return;
            }


            using (SqlConnection myconn = new SqlConnection(server_name))
            {
                DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce patient ?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = myconn;
                    cmd.CommandText = ("DELETE FROM Patient WHERE id = @id");
                    cmd.Parameters.AddWithValue("@id", id);

                    myconn.Open();
                    cmd.ExecuteNonQuery();

                    this.PatientGrid.Rows.RemoveAt(position);
                    MessageBox.Show("patient bien supprimé");
                    myconn.Close();
                }
                else
                {
                    return;
                }
            }
        }

        private DialogResult MessageBoxIcon(string v, MessageBoxButtons oKCancel, MessageBoxIcon question)
        {
            throw new NotImplementedException();
        }

        private void rénitialiser_Click(object sender, EventArgs e)
        {
            inputNom.Text = "";
            inputPrenom.Text = "";
            dateTimePickerDateCreated.Text = "";
            inputVille.Text = "";
            inputTel.Text = "";
            dateTimePickerDateNaiss.Text = "";
            inputSymptome.Text = "";
            inputEtat.Text = "";
            inputSexe.Text = "";
            inputNom.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (!edit_record)
                return;
                
            if (!CheckInfo())
            {
                using (SqlConnection myconn = new SqlConnection(server_name))
                {
                    DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir modifier ce patient ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        id = int.Parse(this.PatientGrid.Rows[position].Cells[0].Value.ToString());

                        String Query = "UPDATE Patient SET Nom = @Nom, Prenom = @Prenom, date_creation_dossier = @datecreated," +
                        "ville = @Ville, telephone = @Tel, date_naissance = @Datenaiss, symptômes = @Symptome," +
                        "Etat = @Etat, sexe = @Sexe WHERE id = @id;";

                        SqlCommand command = new SqlCommand(Query, myconn);
                        command.Parameters.AddWithValue("@Nom", inputNom.Text.Trim());
                        command.Parameters.AddWithValue("@Prenom", inputPrenom.Text.Trim());
                        command.Parameters.AddWithValue("@datecreated", dateTimePickerDateCreated.Value);
                        command.Parameters.AddWithValue("@Ville", inputVille.Text.Trim());
                        command.Parameters.AddWithValue("@Tel", inputTel.Text.Trim());
                        command.Parameters.AddWithValue("@Datenaiss", dateTimePickerDateNaiss.Value.ToString(""));
                        command.Parameters.AddWithValue("@Symptome", inputSymptome.Text.Trim());
                        command.Parameters.AddWithValue("@Etat", inputEtat.Text.Trim());
                        command.Parameters.AddWithValue("@Sexe", inputSexe.Text.Trim());
                        command.Parameters.AddWithValue("@id", id); // Add the id parameter

                        myconn.Open();
                        command.ExecuteNonQuery();
                        myconn.Close();
                        afficher_Click(sender, e);
                        MessageBox.Show("Patient modifié bien terminé ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("veuillez saisir tous les champs!!");
            }
        }

        private void inputsearchname_OnValueChanged(object sender, EventArgs e)
        {

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
