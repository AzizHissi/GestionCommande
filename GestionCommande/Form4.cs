using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande
{
    public partial class Form4 : Form
    {
        
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=CommandeDB;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void Commandes_F_Load(object sender, EventArgs e)
        {
            try
            {

                Charger_Combo();
                txt_numC.Enabled = false;

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

     

        private void Charger_Combo()
        {
          
            if (dt.Rows.Count != 0) dt.Clear();
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("List_Client", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            dt.Load(cmd.ExecuteReader());
            combobox1.DataSource = dt;
            combobox1.DisplayMember = "CIN";
            combobox1.ValueMember = "CIN";
            cnx.Close();
            /******************************************************************************************************/
            DataTable dat = new DataTable();
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("List_Produit", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            dat.Load(cmd.ExecuteReader());
            combobox2.DataSource = dat;
            combobox2.DisplayMember = "Refproduit";
            combobox2.ValueMember = "Refproduit";
            combobox2.SelectedIndex = 0;
            cnx.Close();

            
        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            txt_numC.Enabled = true;
            Clear_Ctr(gb_commande);
        }
        public void Clear_Ctr(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                if (c.Controls.Count != 0) Clear_Ctr(c);
            }
        }
        public bool Verifier(string Ref)
        {
            bool verf;
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("verif_Commande", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@num", int.Parse(Ref));
            verf = cmd.ExecuteReader().HasRows;
            cnx.Close();
            return verf;
        }
        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            try
            {


                int num;
                int.TryParse(Interaction.InputBox("Numero du Commande"), out num);
               
                if (Verifier(num+""))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    DataTable ds = new DataTable();
                    cmd = new SqlCommand("verif_Commande", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", num);
                    ds.Load(cmd.ExecuteReader());
                    
                    txt_numC.Text = ds.Rows[0]["Num_cmd"].ToString();
                combobox1.SelectedValue = ds.Rows[0]["CIN"].ToString();
                    date_commande.Value = (DateTime)ds.Rows[0]["Datecmd"];
                    cnx.Close();
                   
                }
                else MessageBox.Show("Numero n'existe pas");
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numC.Text == "" && combobox1.Text == "" && date_commande.Text == "")
                {
                    MessageBox.Show("Tous les champs obliatoires");
                    return;
                }
                if (!Verifier(txt_numC.Text))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Add_Commande", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@cin", combobox1.SelectedValue + "");
                    cmd.Parameters.AddWithValue("@date", date_commande.Value);
                    

                    cmd.ExecuteNonQuery();
                    cnx.Close();
                   
                    MessageBox.Show("Ajouter");

                    txt_numC.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numC.Text == "" && combobox1.Text == "" && date_commande.Text == "")
                {
                    MessageBox.Show("Tous les champs obligatoire");
                    return;
                }


                
                if (Verifier(txt_numC.Text))
                {
                    if (MessageBox.Show("Voulez-vous vraimant modifier", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        MessageBox.Show("annulee");
                        return;
                    }
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Modf_Commande", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@cin", combobox1.SelectedValue + "");
                    cmd.Parameters.AddWithValue("@date", date_commande.Value);


                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("Modifiee");

                    txt_numC.Enabled = false;
                    txt_numC.Clear();

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
                if (Verifier(txt_numC.Text))
                {
                    if (MessageBox.Show("Voulez-vous vraimant supprimer", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        MessageBox.Show("annulee");
                        return;
                    }
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Del_Proc", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    MessageBox.Show("Supprimee");
                    txt_numC.Enabled = false;
                    txt_numC.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
         
            int refer = int.Parse(combobox2.SelectedValue + "");
            
            if (Verifier(txt_numC.Text))
            {
                gb_commande.Enabled = false;
                gb_details.Enabled = true;
                Charger_DataGrid();

            }
            else MessageBox.Show("Aucune commande trouvee");
        }

        private void Charger_DataGrid()
        {
            int num_Cmd= int.Parse(txt_numC.Text);
            int reference = int.Parse(combobox2.SelectedValue + "");
            dataGridView1.DataSource = null;
            DataTable table = new DataTable(); 
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("liste_Pro", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@num", num_Cmd);
            
            table.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = table;
            cnx.Close();

            
           
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("Total", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
            txt_total.Text = cmd.ExecuteScalar().ToString();
            
            cnx.Close();
        }
        private void btn_Terminer_Click(object sender, EventArgs e)
        {
            gb_commande.Enabled = true;
            gb_details.Enabled = false;
            dataGridView1.DataSource = null;
        }

        private void btn_Nouveau1_Click(object sender, EventArgs e)
        {
            Clear_Ctr(gb_details);
        }
        public bool Verifier(string num,string Ref)
        {
            bool verf;
            int refer = int.Parse(Ref);
            if (cnx.State == ConnectionState.Open) cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("verif_d", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@num", int.Parse(num));
            cmd.Parameters.AddWithValue("@ref", refer);
            verf = cmd.ExecuteReader().HasRows;
            cnx.Close();
            return verf;
        }
        private void btn_Enlever_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verifier(txt_numC.Text, combobox2.Text))
                {
                    if (MessageBox.Show("Voulez-vous vraimant supprimer", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        MessageBox.Show("annulee");
                        return;
                    }

                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("verif_d", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@ref", int.Parse(combobox2.Text));
                     cmd.ExecuteNonQuery();
                    cnx.Close();
                    Charger_DataGrid();
                    MessageBox.Show("Supprimee");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_numC.Text == "" && combobox1.Text == "" && date_commande.Text == "")
                {
                    MessageBox.Show("Tous les champs obligatoire");
                    return;
                }
               

                if (!Verifier(txt_numC.Text, combobox2.SelectedValue+""))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Add_Details", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@ref", int.Parse(combobox2.Text));
                    cmd.Parameters.AddWithValue("@qnt", int.Parse(txt_quantite.Text));
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    Charger_DataGrid();
                    MessageBox.Show("Ajoutee");

                }
                else
                {

                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Modf_Details", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@ref", int.Parse(combobox2.Text));
                    cmd.Parameters.AddWithValue("@qnt", int.Parse(txt_quantite.Text));
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    Charger_DataGrid();
                    MessageBox.Show("Ajoutee");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_Modifier1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verifier(txt_numC.Text, combobox2.Text))
                {
                    if (cnx.State == ConnectionState.Open) cnx.Close();
                    cnx.Open();
                    cmd = new SqlCommand("Modf_Details2", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num", int.Parse(txt_numC.Text));
                    cmd.Parameters.AddWithValue("@ref", int.Parse(combobox2.Text));
                    cmd.Parameters.AddWithValue("@qnt", int.Parse(txt_quantite.Text));
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    Charger_DataGrid();
                    MessageBox.Show("Modifiee");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
