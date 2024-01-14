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
using static System.Net.Mime.MediaTypeNames;

namespace medical_app
{
    public partial class Stagiaire : Form
    {
        public Stagiaire()
        {
            InitializeComponent();
        }

        private void Stagiaire_Load(object sender, EventArgs e)
        {
            BaseClass G = new BaseClass();
            G.RemplirGrid(" stagiaire ", dgvstagiaire);
        }

        private void BTRNOUVEAU_Click(object sender, EventArgs e)
        {
            // Vider les TextBox
            textBox6ids.Text = "";
            textnm.Text = "";
            textpre.Text = "";
            textspe.Text = "";
            textBox3tacher.Text = "";
            tbxdeb.Text = "";
            tbxfin.Text = "";
            textIDMR.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPrecherche_Click(object sender, EventArgs e)
        {

        }


        private void butnmodifier_Click(object sender, EventArgs e)
        {
            tabCstagiaire.SelectedTab = tabPmiseajour;
            // Assurez-vous qu'il y a au moins une ligne sélectionnée
            if (dgvstagiaire.SelectedRows.Count > 0)
            {
                // Accédez à la ligne sélectionnée
                DataGridViewRow selectedRow = dgvstagiaire.SelectedRows[0];

                // Vérifiez si la ligne n'est pas nulle
                if (selectedRow != null)
                {
                    // Obtenez les valeurs des huit cellules et affectez-les aux TextBox correspondants
                    textBox6ids.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                    // Répétez ce processus pour les sept autres cellules
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
                    // Gérez le cas où la ligne sélectionnée est nulle
                    MessageBox.Show("La ligne sélectionnée est nulle.");
                }
            }
            else
            {
                // Gérez le cas où aucune ligne n'est sélectionnée
                MessageBox.Show("Aucune ligne sélectionnée.");
            }
        }

        private void BTNMODIFIER_Click(object sender, EventArgs e)
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
                string nouvellesTaches = textBox3tacher.Text; // Correction du nom de la TextBox pour les tâches
                DateTime nouvelleDateDebut = DateTime.Parse(tbxdeb.Text);
                DateTime nouvelleDateFin = DateTime.Parse(tbxfin.Text);
                int nouveauIdMedecin = 1;

                G.cmd.CommandText = "UPDATE Stagiaire SET Nom_Stagiaire = @Nom, Prenom_Stagiaire = @Prenom, Spécialité_Etude = @Specialite, Tâches = @Taches, date_debut = @DateDebut, date_fin = @DateFin, id_Medecin = @IdMedecin WHERE Stagiaire_ID = @StagiaireID";

                G.cmd.Parameters.AddWithValue("@StagiaireID", stagiaireID);
                G.cmd.Parameters.AddWithValue("@Nom", nouveauNom);
                G.cmd.Parameters.AddWithValue("@Prenom", nouveauPrenom);
                G.cmd.Parameters.AddWithValue("@Specialite", nouvelleSpecialite);
                G.cmd.Parameters.AddWithValue("@Taches", nouvellesTaches);
                G.cmd.Parameters.AddWithValue("@DateDebut", nouvelleDateDebut);
                G.cmd.Parameters.AddWithValue("@DateFin", nouvelleDateFin);
                G.cmd.Parameters.AddWithValue("@IdMedecin", nouveauIdMedecin);

                G.cmd.ExecuteNonQuery();

                // Mettre à jour la ligne dans la base de données

                // Recharger les données dans le DataGridView
                // Assurez-vous que vous avez une méthode ChargerDonnees() pour mettre à jour votre DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNSUPPRIMER_Click(object sender, EventArgs e)
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

                // Supprimer la ligne du DataGridView
                dgvstagiaire.Rows.Remove(dgvstagiaire.CurrentRow);

                MessageBox.Show("La ligne a été supprimée avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNQUITTER_Click(object sender, EventArgs e)
        {
            tabCstagiaire.SelectedTab = tabPrecherche;


        }
        private void btnnoveau_Click(object sender, EventArgs e)
        {
            BaseClass d = new BaseClass();
            d.connecter();
            d.cmd.Connection = d.Con;

            try
            {
                d.cmd.CommandText = "INSERT INTO stagiaire (Nom_Stagiaire, Prenom_Stagiaire, Spécialité_Etude, Tâches, date_debut, date_fin, id_Medecin) VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7)";

                d.cmd.Parameters.AddWithValue("@param1", textBoxnm.Text);
                d.cmd.Parameters.AddWithValue("@param2", textBoxpr.Text);
                d.cmd.Parameters.AddWithValue("@param3", textBox2sp.Text);
                d.cmd.Parameters.AddWithValue("@param4", textBox3tacher.Text);
                d.cmd.Parameters.AddWithValue("@param5", DateTime.Parse(textBox1deb.Text));
                d.cmd.Parameters.AddWithValue("@param6", DateTime.Parse(textBox2fin.Text));

                d.cmd.Parameters.AddWithValue("@param7", int.Parse(textIDM.Text));

                d.cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout avec succès");

                // Effacer les paramètres après l'exécution de la requête
                d.cmd.Parameters.Clear();

                // Sélectionner toutes les lignes de la table stagiaire pour mettre à jour le DataGridView
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
                // Fermer la connexion après l'opération
                d.Con.Close();
            }
        }

        private void butnrechercher_Click(object sender, EventArgs e)
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvstagiaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butnquitter_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }
    }
}