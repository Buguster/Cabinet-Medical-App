using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace medical_app
{
    public partial class Login : Form
    {
        BaseClass db = new BaseClass();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void choice_login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void secretary_login(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.Con.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_type_login", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@uname", txt_Nom_utilisateur.Text);
                        command.Parameters.AddWithValue("@upass", txt_passwd.Text);

                        using (SqlDataReader myrd = command.ExecuteReader())
                        {
                            if (myrd.HasRows)
                            {
                                myrd.Read();
                                if (myrd[3].ToString() == "Sécrétaire")
                                    BaseClass.type = "S";
                                Home acceuil = new Home();
                                acceuil.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error!! Login Secretary");
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Acceuil_Load()
        {
            throw new NotImplementedException();
        }

        public void medecin_login(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.Con.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_login_medecin", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@uname", txt_Nom_utilisateur.Text);
                        command.Parameters.AddWithValue("@upass", txt_passwd.Text);

                        using (SqlDataReader myrd = command.ExecuteReader())
                        {
                            if (myrd.HasRows)
                            {
                                myrd.Read();
                                if (myrd[6].ToString() == "Médecin")
                                    BaseClass.type = "M";
                                MedecinAcceuil acceuil = new MedecinAcceuil();
                                acceuil.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error!! Login medecin");
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.Con.ConnectionString))
                {
                    connection.Open();

                    if (choice_login.SelectedIndex == 0)
                    {
                        medecin_login(sender, e);
                    }
                    else if (choice_login.SelectedIndex == 1)
                    {
                        secretary_login(sender, e);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_passwd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Rendez_vous_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }