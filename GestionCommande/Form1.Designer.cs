namespace GestionCommande
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier,
            this.gestion,
            this.quiter});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichier
            // 
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexion,
            this.deconnexion});
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(62, 24);
            this.fichier.Text = "fichier";
            // 
            // connexion
            // 
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(180, 24);
            this.connexion.Text = "connexion ";
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // deconnexion
            // 
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(180, 24);
            this.deconnexion.Text = "deconnexion ";
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // gestion
            // 
            this.gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesProduitsToolStripMenuItem,
            this.gestionDesCommandesToolStripMenuItem,
            this.consultationToolStripMenuItem});
            this.gestion.Name = "gestion";
            this.gestion.Size = new System.Drawing.Size(70, 24);
            this.gestion.Text = "gestion";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.gestionDesClientsToolStripMenuItem.Text = "gestion des clients";
            this.gestionDesClientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesClientsToolStripMenuItem_Click);
            // 
            // gestionDesProduitsToolStripMenuItem
            // 
            this.gestionDesProduitsToolStripMenuItem.Name = "gestionDesProduitsToolStripMenuItem";
            this.gestionDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.gestionDesProduitsToolStripMenuItem.Text = "gestion des produits";
            this.gestionDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesProduitsToolStripMenuItem_Click);
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.gestionDesCommandesToolStripMenuItem.Text = "gestion des commandes";
            this.gestionDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesCommandesToolStripMenuItem_Click);
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.consultationToolStripMenuItem.Text = "consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // quiter
            // 
            this.quiter.Name = "quiter";
            this.quiter.Size = new System.Drawing.Size(60, 24);
            this.quiter.Text = "quiter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem connexion;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fichier;
        public System.Windows.Forms.ToolStripMenuItem gestion;
        public System.Windows.Forms.ToolStripMenuItem quiter;
        public System.Windows.Forms.ToolStripMenuItem deconnexion;
    }
}

