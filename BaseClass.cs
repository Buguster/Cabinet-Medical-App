using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace medical_app
{
    internal class BaseClass
    {
        public SqlConnection Con;
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        private static string connectionString = ConfigurationManager.ConnectionStrings["server_me"].ConnectionString;

        public static string type;


        public BaseClass()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["server_me"].ConnectionString);
        }

        public void connecter()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.ConnectionString = connectionString;
                Con.Open();
            }

        }
        public void deconnecter()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
        public void RemplirGrid(String table, DataGridView dg)
        {
            connecter();
            cmd.Connection = Con;
            cmd.CommandText = "SELECT * FROM" + table;
            da.SelectCommand = cmd;
            da.Fill(ds, "DT" + table);
            dg.DataSource = ds.Tables["DT" + table];
            deconnecter();
        }
    }
}


