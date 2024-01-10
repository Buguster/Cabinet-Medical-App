using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace medical_app
{
    public partial class Login : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=SOLAB\SQLEXPRESS;Initial Catalog=testing;");
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

        private void login_button_Click_1(object sender, EventArgs e)
        {

            try
            {
                string username = txt_Nom_utilisateur.Text;
                string password = txt_passwd.Text;


                if (string.Equals(username, "Admin", StringComparison.OrdinalIgnoreCase) &&
     string.Equals(password, "12345678", StringComparison.Ordinal))
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("informations erronés");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
