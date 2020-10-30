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
    public partial class Form3 : Form
    {
        
        BindingSource bs = new BindingSource();
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=CommandeDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Charger_Grid();
                dataGridView1.DataSource = bs;
                txt_Reference.DataBindings.Add("Text", bs, "Refproduit");
                txt_Intitule.DataBindings.Add("Text", bs, "Intitulé");
                txt_Categorie.DataBindings.Add("Text", bs, "Catégorie");
                txt_Prix.DataBindings.Add("Text", bs, "PrixVente");
                
                txt_Reference.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Charger_Grid()
        {
            
            if (dt.Rows.Count != 0) dt.Clear();
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("List_Produit", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            
            dt.Load(cmd.ExecuteReader());
            bs.DataSource = dt;


            cnx.Close();
           
        }
        public bool Verifier(string Ref)
        {
            bool verf;
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("verifier_p", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Ref", int.Parse(Ref));
            verf = cmd.ExecuteReader().HasRows;
            cnx.Close();
            return verf;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_Reference.Text == "" && txt_Intitule.Text == "" && txt_Categorie.Text == "" && txt_Prix.Text == "")
                {
                    MessageBox.Show("Remplir tous les champs");
                    return;
                }
                if (!Verifier(txt_Reference.Text))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Add_Produit", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ref", int.Parse(txt_Reference.Text));
                    cmd.Parameters.AddWithValue("@Intitule", txt_Intitule.Text);
                    cmd.Parameters.AddWithValue("@Cat", txt_Categorie.Text);
                    cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(txt_Prix.Text));
                    
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Ajoutee");
                    Charger_Grid();
                    txt_Reference.Enabled = false;
                }

                
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Reference.Text == "" && txt_Intitule.Text == "" && txt_Categorie.Text == "" && txt_Prix.Text == "")
                {
                    MessageBox.Show("Tous les champs obligatoire");
                    return;
                }
                if (Verifier(txt_Reference.Text))
                {
                    if (MessageBox.Show("Voulez-vous vraimant modifier", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (cnx.State == ConnectionState.Open) cnx.Close();
                        cnx.Open();
                        cmd = new SqlCommand("Modfiy_Produit", cnx);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ref", int.Parse(txt_Reference.Text));
                        cmd.Parameters.AddWithValue("@Intitule", txt_Intitule.Text);
                        cmd.Parameters.AddWithValue("@Cat", txt_Categorie.Text);
                        cmd.Parameters.AddWithValue("@Prix", Convert.ToDouble(txt_Prix.Text));
                        cmd.ExecuteNonQuery();
                        cnx.Close();

                        MessageBox.Show("Modifiee");
                        Charger_Grid();


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                
                        if (Verifier(txt_Reference.Text))
                        {
                            if (MessageBox.Show("Voulez-vous vraimant supprimer", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                        if (cnx.State == ConnectionState.Open) cnx.Close();
                            cnx.Open();
                            cmd = new SqlCommand("delete_Produit", cnx);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ref", int.Parse(txt_Reference.Text));

                            cmd.ExecuteNonQuery();
                            cnx.Close();
                            MessageBox.Show("Supprimee");
                            Charger_Grid();




                        }
                    }
                   

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                string cin = Interaction.InputBox("Reference du Produit");
                if (Verifier(txt_Reference.Text))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Selected = false;
                    }
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(cin))
                        {
                            bs.Position = row.Index;
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
            txt_Reference.Enabled = true;
            Clear_Ctr(this);
        }
        public void Clear_Ctr(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c.Controls.Count != 0) Clear_Ctr(c);
            }
        }

       
    }
}
