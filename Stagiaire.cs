using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace medical_app
{
    public partial class Stagiaire : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;
        
        public Stagiaire()
        {
            InitializeComponent();
        }

        private void Stagiaire_Load(object sender, EventArgs e)
        {
            BaseClass G = new BaseClass();
            G.RemplirGrid(" stagiaire ", dgvstagiaire);

            // style 
            dgvstagiaire.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            dgvstagiaire.DefaultCellStyle.Font = new Font("Arial", 12);
            dgvstagiaire.DefaultCellStyle.BackColor = Color.LightGray;
            dgvstagiaire.DefaultCellStyle.ForeColor = Color.Blue;
            dgvstagiaire.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvstagiaire.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void BTRNOUVEAU_Click(object sender, EventArgs e)
        {
            textnm.Text = "";
            textpre.Text = "";
            textspe.Text = "";
            textBox3tacher.Text = "";
            tbxdeb.Text = "";
            tbxfin.Text = "";
            textIDMR.Text = "";
        }

        private void btnnoveau_Click_1(object sender, EventArgs e)
        {
            BaseClass d = new BaseClass();
            d.connecter();
            d.cmd.Connection = d.Con;

            try
            {
                d.cmd.CommandText = "INSERT INTO stagiaire (Nom_Stagiaire, Prenom_Stagiaire, " +
                    "Spécialité_Etude, Tâches, date_debut, date_fin, id_Medecin) " +
                    "VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7)";

                d.cmd.Parameters.AddWithValue("@param1", textBoxnm.Text);
                d.cmd.Parameters.AddWithValue("@param2", textBoxpr.Text);
                d.cmd.Parameters.AddWithValue("@param3", textBox2sp.Text);
                d.cmd.Parameters.AddWithValue("@param4", textBox3tacher.Text);
                d.cmd.Parameters.AddWithValue("@param5", DateTime.Parse(textBox1deb.Text));
                d.cmd.Parameters.AddWithValue("@param6", DateTime.Parse(textBox2fin.Text));

                d.cmd.Parameters.AddWithValue("@param7", int.Parse(textIDM.Text));

                d.cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout avec succès");

                d.cmd.Parameters.Clear();

                d.cmd.CommandText = "SELECT * FROM stagiaire";

                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(d.cmd))
                {
                    adapter.Fill(dataTable);
                }

                dgvstagiaire.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                d.Con.Close();
            }
        }

        private void butnmodifier_Click_1(object sender, EventArgs e)
        {
            tabCstagiaire.SelectedTab = tabPmiseajour;
            if (dgvstagiaire.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvstagiaire.SelectedRows[0];

                if (selectedRow != null)
                {
                    textnm.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    textpre.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    textspe.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    textBox3tacher.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    tbxdeb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    tbxfin.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
                    textIDMR.Text = selectedRow.Cells[7].Value?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("La ligne sélectionnée est nulle.");
                }
            }
            else
            {
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
           

        }

        private void butnrechercher_Click_1(object sender, EventArgs e)
        {
            BaseClass d = new BaseClass();
            d.connecter();
            d.cmd.Connection = d.Con;

            if (inputsearchsta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez saisir un nom pour la recherche.");
                return;
            }

            try
            {
                d.cmd.CommandText = "SELECT * FROM stagiaire WHERE Nom_Stagiaire = @nom";
                d.cmd.Parameters.AddWithValue("@nom", inputsearchsta.Text.Trim());

                DataTable dataTable = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(d.cmd))
                {
                    adapter.Fill(dataTable);
                }

                dgvstagiaire.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Aucun stagiaire trouvé avec le nom spécifié.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
            finally
            {
                d.Con.Close();
            }
        }

        private void ChargerDonnees()
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
                dgvstagiaire.DataSource = dataTable;
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

        private void BTNMODIFIER_Click_1(object sender, EventArgs e)
        {
            try
            {
                BaseClass G = new BaseClass();
                G.connecter();
                G.cmd.Connection = G.Con;

                int stagiaireID = Convert.ToInt32(dgvstagiaire.CurrentRow.Cells["Stagiaire_ID"].Value);
                string nouveauNom = textnm.Text;
                string nouveauPrenom = textpre.Text;
                string nouvelleSpecialite = textspe.Text;
                string nouvellesTaches = textBox3tacher.Text; 
                DateTime nouvelleDateDebut = DateTime.Parse(tbxdeb.Text);
                DateTime nouvelleDateFin = DateTime.Parse(tbxfin.Text);
                int nouveauIdMedecin = 1;

                G.cmd.CommandText = "UPDATE Stagiaire SET Nom_Stagiaire = @Nom, Prenom_Stagiaire = @Prenom, " +
                    "Spécialité_Etude = @Specialite, Tâches = @Taches, date_debut = @DateDebut, date_fin = " +
                    "@DateFin, id_Medecin = @IdMedecin WHERE Stagiaire_ID = @StagiaireID";

                G.cmd.Parameters.AddWithValue("@StagiaireID", stagiaireID);
                G.cmd.Parameters.AddWithValue("@Nom", nouveauNom);
                G.cmd.Parameters.AddWithValue("@Prenom", nouveauPrenom);
                G.cmd.Parameters.AddWithValue("@Specialite", nouvelleSpecialite);
                G.cmd.Parameters.AddWithValue("@Taches", nouvellesTaches);
                G.cmd.Parameters.AddWithValue("@DateDebut", nouvelleDateDebut);
                G.cmd.Parameters.AddWithValue("@DateFin", nouvelleDateFin);
                G.cmd.Parameters.AddWithValue("@IdMedecin", nouveauIdMedecin);

                G.cmd.ExecuteNonQuery();
                G.cmd.Parameters.Clear();
                dgvstagiaire.Refresh();
                ChargerDonnees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNSUPPRIMER_Click_1(object sender, EventArgs e)
        {
            try
            {
                BaseClass G = new BaseClass();
                G.connecter();
                G.cmd.Connection = G.Con;

                int stagiaireID = Convert.ToInt32(dgvstagiaire.CurrentRow.Cells["Stagiaire_ID"].Value);

                G.cmd.CommandText = "DELETE FROM Stagiaire WHERE Stagiaire_ID = @StagiaireID";

                G.cmd.Parameters.AddWithValue("@StagiaireID", stagiaireID);

                G.cmd.ExecuteNonQuery();

                dgvstagiaire.Rows.Remove(dgvstagiaire.CurrentRow);

                MessageBox.Show("La ligne a été supprimée avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNQUITTER_Click_1(object sender, EventArgs e)
        {
            tabCstagiaire.SelectedTab = tabPrecherche;
            Medecin med = new Medecin();
            med.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection myconn = new SqlConnection(server_name))
            {
                try
                {
                    myconn.Open();

                    if (myconn.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connected successfully");
                        string query = "SELECT * FROM Stagiaire ORDER BY Stagiaire_ID";
                        SqlCommand command = new SqlCommand(query, myconn);

                        using (SqlDataReader data = command.ExecuteReader())
                        {
                            if (data.HasRows)
                            {
                                dgvstagiaire.Rows.Clear();
                                while (data.Read())
                                {
                                    dgvstagiaire.Rows.Add(data[0], data[1], data[2], data[3], data[4], data[5],
                                                          data[6], data[7]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Table est vide");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("n'est pas connecté");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvstagiaire_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butnquitter_Click_1(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }
    }
}