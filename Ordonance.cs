using System;
using System.Collections;
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

    public partial class Ordonance : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;
        
        public Ordonance()
        {
            InitializeComponent();
            SqlConnection myconn = new SqlConnection(server_name);
            myconn.Open();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            OrdonnanceGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            OrdonnanceGrid.DefaultCellStyle.Font = new Font("Arial", 12);
            OrdonnanceGrid.DefaultCellStyle.BackColor = Color.LightGray;
            OrdonnanceGrid.DefaultCellStyle.ForeColor = Color.Blue;
            OrdonnanceGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            OrdonnanceGrid.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void type_medicaments_Click(object sender, EventArgs e)
        {

        }
        private void retour_Click(object sender, EventArgs e)
        {
            Medecin acceuil = new Medecin();
            acceuil.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
            {
                using (SqlConnection myconn = new SqlConnection(server_name))
                {
                    try
                    {
                        myconn.Open();
                        if (myconn.State == ConnectionState.Open)
                        {
                            string query = "SELECT * FROM Ordonance";
                            SqlCommand command = new SqlCommand(query, myconn);

                            OrdonnanceGrid.Rows.Clear();

                            using (SqlDataReader data = command.ExecuteReader())
                            {
                                if (data.HasRows)
                                {
                                    while (data.Read())
                                    {
                                        OrdonnanceGrid.Rows.Add(data[0], data[1], data[2]);
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

        private void button2_Click(object sender, EventArgs e)
            {
                BaseClass d = new BaseClass();
                d.connecter();
                d.cmd.Connection = d.Con;

                try
                {
                    d.cmd.CommandText = "INSERT INTO Ordonance " +
                                        "(type_médicaments, date_ordonance)" +
                                       "VALUES (@param1, @param2) ";

                    d.cmd.Parameters.AddWithValue("@param1", type_medicaments.Text);
                    d.cmd.Parameters.AddWithValue("@param2", DateTimepickerdateordo.Value);

                    d.cmd.ExecuteNonQuery();
                    MessageBox.Show("Ordonance enregistré");
                    d.cmd.Parameters.Clear();
                    button1_Click_1(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
            }

        // pour la fonctionalité de print l'ordonance 

        private void OrdonnanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == OrdonnanceGrid.Columns["Print"].Index)
            {
                string ordonnanceId = OrdonnanceGrid.Rows[e.RowIndex].Cells["ID_Ordonnance"].Value.ToString();
                string typeMedicaments = OrdonnanceGrid.Rows[e.RowIndex].Cells["type_medi"].Value.ToString();
                DateTime dateOrdonnance = Convert.ToDateTime(OrdonnanceGrid.Rows[e.RowIndex].Cells["date_ordonnance"].Value);
                PrintOrdonnance(ordonnanceId, typeMedicaments, dateOrdonnance);
            }
        }
        private void PrintOrdonnance(string ordonnanceId, string typeMedicaments, DateTime dateOrdonnance)
        {
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += (sender, e) =>
            {
                string content = $"Ordonnance ID: {ordonnanceId}\n\n\n\nType Médicaments:\n\n {typeMedicaments}\n\n\n\nDate Ordonnance: {dateOrdonnance}\n\n";
                Font font = new Font("Arial", 16);
                RectangleF layoutRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
                StringFormat format = new StringFormat();
                e.Graphics.DrawString(content, font, Brushes.Black, layoutRect, format);
            };

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }
    }

}
