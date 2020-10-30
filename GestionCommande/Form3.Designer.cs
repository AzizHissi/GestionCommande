namespace GestionCommande
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Prix = new System.Windows.Forms.TextBox();
            this.txt_Categorie = new System.Windows.Forms.TextBox();
            this.txt_Intitule = new System.Windows.Forms.TextBox();
            this.txt_Reference = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 177);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Prix);
            this.groupBox1.Controls.Add(this.txt_Categorie);
            this.groupBox1.Controls.Add(this.txt_Intitule);
            this.groupBox1.Controls.Add(this.txt_Reference);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(566, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txt_Prix
            // 
            this.txt_Prix.Location = new System.Drawing.Point(175, 197);
            this.txt_Prix.Name = "txt_Prix";
            this.txt_Prix.Size = new System.Drawing.Size(148, 24);
            this.txt_Prix.TabIndex = 10;
            // 
            // txt_Categorie
            // 
            this.txt_Categorie.Location = new System.Drawing.Point(175, 147);
            this.txt_Categorie.Name = "txt_Categorie";
            this.txt_Categorie.Size = new System.Drawing.Size(148, 24);
            this.txt_Categorie.TabIndex = 9;
            // 
            // txt_Intitule
            // 
            this.txt_Intitule.Location = new System.Drawing.Point(175, 97);
            this.txt_Intitule.Name = "txt_Intitule";
            this.txt_Intitule.Size = new System.Drawing.Size(148, 24);
            this.txt_Intitule.TabIndex = 8;
            // 
            // txt_Reference
            // 
            this.txt_Reference.Location = new System.Drawing.Point(175, 47);
            this.txt_Reference.Name = "txt_Reference";
            this.txt_Reference.Size = new System.Drawing.Size(148, 24);
            this.txt_Reference.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRIX VENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CATEGORIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "INTITULE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "REFERENCE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Supprimer);
            this.groupBox2.Controls.Add(this.btn_Quitter);
            this.groupBox2.Controls.Add(this.btn_Modifier);
            this.groupBox2.Controls.Add(this.btn_Ajouter);
            this.groupBox2.Controls.Add(this.btn_Rechercher);
            this.groupBox2.Controls.Add(this.btn_Nouveau);
            this.groupBox2.Location = new System.Drawing.Point(349, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(169, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(27, 179);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 26);
            this.btn_Supprimer.TabIndex = 11;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(27, 218);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(114, 26);
            this.btn_Quitter.TabIndex = 10;
            this.btn_Quitter.Text = "Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(27, 140);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(114, 26);
            this.btn_Modifier.TabIndex = 9;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(27, 101);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(114, 26);
            this.btn_Ajouter.TabIndex = 8;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(27, 62);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(114, 26);
            this.btn_Rechercher.TabIndex = 7;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(27, 23);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(114, 26);
            this.btn_Nouveau.TabIndex = 6;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produits";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Prix;
        private System.Windows.Forms.TextBox txt_Categorie;
        private System.Windows.Forms.TextBox txt_Intitule;
        private System.Windows.Forms.TextBox txt_Reference;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.Button btn_Nouveau;
    }
}