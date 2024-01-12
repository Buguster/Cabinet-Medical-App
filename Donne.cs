using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_app
{
    internal class Donne
    {
        public SqlConnection Con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();

        public void connecter()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.ConnectionString = @"Data Source=SOLAB\SQLEXPRESS;Initial Catalog=APP_V1;Integrated Security=True;";
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


