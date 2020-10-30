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
    public delegate void ShowFrm();
    public partial class Form5 : Form
    {
        
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=CommandeDB;Integrated Security=True");
        SqlCommand cmd;
        public static bool login = false;
        public event ShowFrm evt;
        public Form5()
        {
            InitializeComponent();
        }
        public bool Verifier(string log,string pass)
        {
            bool verf;
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("verifi_log", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@login", log);
            cmd.Parameters.AddWithValue("@pass", pass);
            verf = cmd.ExecuteReader().HasRows;
            cnx.Close();
            return verf;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Verifier(textBox1.Text, textBox2.Text))
            {

                if (evt != null)
                {
                    evt();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Erreur Entrer login et pasword correct");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
