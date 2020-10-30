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

namespace GestionCommande
{
    public partial class Form6 : Form
    {
       
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=CommandeDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Form6()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (dt.Rows.Count != 0) dt.Clear();
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("Recherche", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@num", int.Parse(textBox1.Text));
            dt.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dt;
            
            cnx.Close();

        }

       
    }
}
