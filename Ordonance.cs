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


namespace medical_app
{

    public partial class Ordonance : Form
    {
        private string server_name = ConfigurationManager.ConnectionStrings["medical_app.Properties.Settings.CabinetConnectionString"].ConnectionString;
        public Ordonance()
        {
            InitializeComponent();
            SqlConnection myconn = new SqlConnection(server_name);
            myconn.Open();
            InitializeComponent();
            // style 
            OrdonnanceGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            OrdonnanceGrid.DefaultCellStyle.Font = new Font("Arial", 12);
            OrdonnanceGrid.DefaultCellStyle.BackColor = Color.LightGray;
            OrdonnanceGrid.DefaultCellStyle.ForeColor = Color.Blue;
            OrdonnanceGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            OrdonnanceGrid.DefaultCellStyle.SelectionForeColor = Color.Red;
        }

        private void OrdonnanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection myconn = new SqlConnection(server_name))
                {
                    myconn.Open();
                    string query = "INSERT INTO Ordonance " +
                                    "(type_médicaments, date_ordonance)" +
                                   "VALUES (@type_medicaments, @date_ordonance) ";

                    SqlCommand command = new SqlCommand(query, myconn);

                    command.Parameters.AddWithValue("@type_medicaments", typemedicaments.Text.Trim());
                    command.Parameters.AddWithValue("@date_ordonance", DateTimepickerdateordo.Value);

                    int affectedRows = command.ExecuteNonQuery();
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
            try
            {
                myconn.Open();
                if (myconn.State == ConnectionState.Open)
                {
                    string query = "SELECT * FROM Ordonance";
                    SqlCommand command = new SqlCommand(query, myconn);

                    using (SqlDataReader data = command.ExecuteReader())
                    {
                        if (data.HasRows)
                        {
                            MessageBox.Show("There is data");
                            OrdonnanceGrid.Rows.Clear();
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

        private void retour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
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
                        string query = "SELECT * FROM Ordonance";
                        SqlCommand command = new SqlCommand(query, myconn);

                        using (SqlDataReader data = command.ExecuteReader())
                        {
                            if (data.HasRows)
                            {
                                MessageBox.Show("There is data");
                                OrdonnanceGrid.Rows.Clear();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
