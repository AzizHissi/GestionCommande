namespace GestionCommande
{
    partial class Form4
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
            this.gb_commande = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Nouveau = new System.Windows.Forms.Button();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.date_commande = new System.Windows.Forms.DateTimePicker();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.txt_numC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_details = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.combobox2 = new System.Windows.Forms.ComboBox();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_Modifier1 = new System.Windows.Forms.Button();
            this.btn_Nouveau1 = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Enlever = new System.Windows.Forms.Button();
            this.btn_Terminer = new System.Windows.Forms.Button();
            this.gb_commande.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_commande
            // 
            this.gb_commande.Controls.Add(this.groupBox4);
            this.gb_commande.Controls.Add(this.groupBox3);
            this.gb_commande.Location = new System.Drawing.Point(12, 12);
            this.gb_commande.Name = "gb_commande";
            this.gb_commande.Size = new System.Drawing.Size(718, 179);
            this.gb_commande.TabIndex = 0;
            this.gb_commande.TabStop = false;
            this.gb_commande.Text = "COMMANDES";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Details);
            this.groupBox4.Controls.Add(this.btn_Supprimer);
            this.groupBox4.Controls.Add(this.btn_Nouveau);
            this.groupBox4.Controls.Add(this.btn_Rechercher);
            this.groupBox4.Controls.Add(this.btn_Modifier);
            this.groupBox4.Controls.Add(this.btn_Enregistrer);
            this.groupBox4.Location = new System.Drawing.Point(396, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 146);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(175, 104);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(114, 26);
            this.btn_Details.TabIndex = 10;
            this.btn_Details.Text = "Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(175, 63);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 26);
            this.btn_Supprimer.TabIndex = 11;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Nouveau
            // 
            this.btn_Nouveau.Location = new System.Drawing.Point(24, 22);
            this.btn_Nouveau.Name = "btn_Nouveau";
            this.btn_Nouveau.Size = new System.Drawing.Size(114, 26);
            this.btn_Nouveau.TabIndex = 6;
            this.btn_Nouveau.Text = "Nouveau";
            this.btn_Nouveau.UseVisualStyleBackColor = true;
            this.btn_Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(24, 63);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(114, 26);
            this.btn_Rechercher.TabIndex = 7;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(175, 23);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(114, 26);
            this.btn_Modifier.TabIndex = 9;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(24, 104);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(114, 26);
            this.btn_Enregistrer.TabIndex = 8;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.date_commande);
            this.groupBox3.Controls.Add(this.combobox1);
            this.groupBox3.Controls.Add(this.txt_numC);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 146);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // date_commande
            // 
            this.date_commande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_commande.Location = new System.Drawing.Point(184, 107);
            this.date_commande.Name = "date_commande";
            this.date_commande.Size = new System.Drawing.Size(133, 23);
            this.date_commande.TabIndex = 5;
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(187, 65);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(130, 24);
            this.combobox1.TabIndex = 4;
            // 
            // txt_numC
            // 
            this.txt_numC.Location = new System.Drawing.Point(187, 25);
            this.txt_numC.Name = "txt_numC";
            this.txt_numC.Size = new System.Drawing.Size(130, 23);
            this.txt_numC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE COMMANDE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CIN CLIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO";
            // 
            // gb_details
            // 
            this.gb_details.Controls.Add(this.txt_total);
            this.gb_details.Controls.Add(this.label4);
            this.gb_details.Controls.Add(this.dataGridView1);
            this.gb_details.Controls.Add(this.groupBox6);
            this.gb_details.Controls.Add(this.groupBox5);
            this.gb_details.Enabled = false;
            this.gb_details.Location = new System.Drawing.Point(12, 197);
            this.gb_details.Name = "gb_details";
            this.gb_details.Size = new System.Drawing.Size(718, 363);
            this.gb_details.TabIndex = 1;
            this.gb_details.TabStop = false;
            this.gb_details.Text = "DETAILS";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(569, 334);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(130, 23);
            this.txt_total.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PRIX TOTAL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 155);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.combobox2);
            this.groupBox6.Controls.Add(this.txt_quantite);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(353, 144);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // combobox2
            // 
            this.combobox2.FormattingEnabled = true;
            this.combobox2.Location = new System.Drawing.Point(184, 24);
            this.combobox2.Name = "combobox2";
            this.combobox2.Size = new System.Drawing.Size(130, 24);
            this.combobox2.TabIndex = 6;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(184, 65);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(130, 23);
            this.txt_quantite.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "QUANTITE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "REFERENCE";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_Modifier1);
            this.groupBox5.Controls.Add(this.btn_Nouveau1);
            this.groupBox5.Controls.Add(this.btn_Ajouter);
            this.groupBox5.Controls.Add(this.btn_Enlever);
            this.groupBox5.Controls.Add(this.btn_Terminer);
            this.groupBox5.Location = new System.Drawing.Point(396, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 144);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btn_Modifier1
            // 
            this.btn_Modifier1.Location = new System.Drawing.Point(175, 63);
            this.btn_Modifier1.Name = "btn_Modifier1";
            this.btn_Modifier1.Size = new System.Drawing.Size(114, 26);
            this.btn_Modifier1.TabIndex = 11;
            this.btn_Modifier1.Text = "Modifier";
            this.btn_Modifier1.UseVisualStyleBackColor = true;
            this.btn_Modifier1.Click += new System.EventHandler(this.btn_Modifier1_Click);
            // 
            // btn_Nouveau1
            // 
            this.btn_Nouveau1.Location = new System.Drawing.Point(24, 22);
            this.btn_Nouveau1.Name = "btn_Nouveau1";
            this.btn_Nouveau1.Size = new System.Drawing.Size(114, 26);
            this.btn_Nouveau1.TabIndex = 6;
            this.btn_Nouveau1.Text = "Nouveau";
            this.btn_Nouveau1.UseVisualStyleBackColor = true;
            this.btn_Nouveau1.Click += new System.EventHandler(this.btn_Nouveau1_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(24, 63);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(114, 26);
            this.btn_Ajouter.TabIndex = 7;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Enlever
            // 
            this.btn_Enlever.Location = new System.Drawing.Point(175, 23);
            this.btn_Enlever.Name = "btn_Enlever";
            this.btn_Enlever.Size = new System.Drawing.Size(114, 26);
            this.btn_Enlever.TabIndex = 9;
            this.btn_Enlever.Text = "Enlever";
            this.btn_Enlever.UseVisualStyleBackColor = true;
            this.btn_Enlever.Click += new System.EventHandler(this.btn_Enlever_Click);
            // 
            // btn_Terminer
            // 
            this.btn_Terminer.Location = new System.Drawing.Point(24, 104);
            this.btn_Terminer.Name = "btn_Terminer";
            this.btn_Terminer.Size = new System.Drawing.Size(265, 26);
            this.btn_Terminer.TabIndex = 8;
            this.btn_Terminer.Text = "Terminer";
            this.btn_Terminer.UseVisualStyleBackColor = true;
            this.btn_Terminer.Click += new System.EventHandler(this.btn_Terminer_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 572);
            this.Controls.Add(this.gb_details);
            this.Controls.Add(this.gb_commande);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mise a jour des commandes";
            this.Load += new System.EventHandler(this.Commandes_F_Load);
            this.gb_commande.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb_details.ResumeLayout(false);
            this.gb_details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_commande;
        private System.Windows.Forms.GroupBox gb_details;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Nouveau;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.DateTimePicker date_commande;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.TextBox txt_numC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox combobox2;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_Modifier1;
        private System.Windows.Forms.Button btn_Nouveau1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Enlever;
        private System.Windows.Forms.Button btn_Terminer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
    }
}