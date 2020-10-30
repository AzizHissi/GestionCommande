using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void connexion_Click(object sender, EventArgs e)
        {

            Form5 f = new Form5();
            f.evt += new ShowFrm(f_evt);
            f.ShowDialog();


        }
        void f_evt()
        {
            deconnexion.Enabled = true;
            gestion.Enabled = true;
            connexion.Enabled = false;
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {

            connexion.Enabled = true;
            deconnexion.Enabled = false;
            gestion.Enabled = false;
        }

        internal void Form1_Load(object sender, EventArgs e)
        {
            deconnexion.Enabled = false;
            gestion.Enabled = false;
            
           
           
            
        }

        private void gestionDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 clients_F = new Form2();
            clients_F.ShowDialog();
        }

        private void gestionDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 produits_F = new Form3();
            produits_F.ShowDialog();
        }

        private void gestionDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 commandes_F = new Form4();
            commandes_F.ShowDialog();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 consultation_F = new Form6();
            consultation_F.ShowDialog();
        }
    }
}
