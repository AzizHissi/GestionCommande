using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace GestionCommande
{
    public partial class Form2 : Form
    {
        
        BindingSource Source = new BindingSource();
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=CommandeDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Charger_Grid();
                
                text_CIN.DataBindings.Add("Text", Source, "CIN");
                text_Nom.DataBindings.Add("Text", Source, "Nom");
                text_Prenom.DataBindings.Add("Text", Source, "Prénom");
                text_Ville.DataBindings.Add("Text", Source, "Ville");
                text_Teleph.DataBindings.Add("Text", Source, "Téléphone");
                text_CIN.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Charger_Grid()
        {
            dataGridView1.DataSource = null;
            if (dt.Rows.Count != 0) dt.Clear();
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("List_Client", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            dt.Load(cmd.ExecuteReader());
            Source.DataSource = dt;
           
            cnx.Close();
            dataGridView1.DataSource = Source;


        }
        public bool Verifier(string cin)
        {
            bool verf;
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("verifier", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@Cin", cin);
            verf = cmd.ExecuteReader().HasRows;
            cnx.Close();
            return verf;
        }
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_CIN.Text == "" || text_Nom.Text == "" || text_Prenom.Text == "" || text_Ville.Text == "" || text_Teleph.Text == "")
                {
                    MessageBox.Show("Tous les champs sont obligatoire");
                    return;
                }
                if (!Verifier(text_CIN.Text))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Add_Client", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.AddWithValue("@Cin", text_CIN.Text);
                    cmd.Parameters.AddWithValue("@Nom", text_Nom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", text_Prenom.Text);
                    cmd.Parameters.AddWithValue("@Ville", text_Ville.Text);
                    cmd.Parameters.AddWithValue("@tel", text_Teleph.Text);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                   
                    MessageBox.Show("Ajoutee");
                    Charger_Grid();
                    text_CIN.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_CIN.Text == "" || text_Nom.Text == "" || text_Prenom.Text == "" || text_Ville.Text == "" || text_Teleph.Text == "")
                {
                    MessageBox.Show("Tous les champs sont obligatoire");
                    return;
                }
                else
                {
                    if (Verifier(text_CIN.Text))
                    {
                        if(cnx.State == ConnectionState.Open)cnx.Close();
                        cnx.Open();
                        cmd = new SqlCommand("Modfiy_Client", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.AddWithValue("@Cin", text_CIN.Text);
                        cmd.Parameters.AddWithValue("@Nom", text_Nom.Text);
                        cmd.Parameters.AddWithValue("@Prenom", text_Prenom.Text);
                        cmd.Parameters.AddWithValue("@Ville", text_Ville.Text);
                        cmd.Parameters.AddWithValue("@tel", text_Teleph.Text);
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        MessageBox.Show("Modifiee");
                        Charger_Grid();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verifier(text_CIN.Text))
                {
                    if (MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                       
                        Source.MoveFirst();
                        return;
                    }

                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Delete_Client", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cin", text_CIN.Text);

                    cmd.ExecuteNonQuery();
                        cnx.Close();
                        MessageBox.Show("Supprimee");
                        Charger_Grid();

                    
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Voulez-vous vraimant quiter", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
                  
            this.Close();
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
         
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string cin = Interaction.InputBox("CIN du client");
                if (Verifier(text_CIN.Text))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Selected = false;
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(cin))
                        {
                            Source.Position = row.Index;
                            break;
                        }
                    }

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            
            text_CIN.Enabled = true;
            Clear_Ctr(this);
        }
        public void Clear_Ctr(Control ctrl)
        {
            foreach(Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c.Controls.Count != 0) Clear_Ctr(c);
            }
        }

       

       
    }
}
