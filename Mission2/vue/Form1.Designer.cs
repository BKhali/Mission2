namespace Mission2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxliaison = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ajout_heure = new System.Windows.Forms.TextBox();
            this.Ajout_date = new System.Windows.Forms.TextBox();
            this.Ajout_id_bateau = new System.Windows.Forms.TextBox();
            this.Ajout_id_traverse = new System.Windows.Forms.TextBox();
            this.btnInser = new System.Windows.Forms.Button();
            this.Ajout_id_liaison = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Supr_traverse = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Modif_traverse = new System.Windows.Forms.Button();
            this.Modif_Heure = new System.Windows.Forms.Label();
            this.Modif_Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxtraverse = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxliaison
            // 
            this.listBoxliaison.FormattingEnabled = true;
            this.listBoxliaison.ItemHeight = 25;
            this.listBoxliaison.Location = new System.Drawing.Point(48, 83);
            this.listBoxliaison.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxliaison.Name = "listBoxliaison";
            this.listBoxliaison.Size = new System.Drawing.Size(650, 304);
            this.listBoxliaison.TabIndex = 24;
            this.listBoxliaison.SelectedIndexChanged += new System.EventHandler(this.listBoxliaison_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Ajout_heure);
            this.groupBox1.Controls.Add(this.Ajout_date);
            this.groupBox1.Controls.Add(this.Ajout_id_bateau);
            this.groupBox1.Controls.Add(this.Ajout_id_traverse);
            this.groupBox1.Controls.Add(this.btnInser);
            this.groupBox1.Controls.Add(this.Ajout_id_liaison);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 419);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(454, 259);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle traversée";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 25);
            this.label11.TabIndex = 19;
            this.label11.Text = "Heure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Id_bateau";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id_traversee";
            // 
            // Ajout_heure
            // 
            this.Ajout_heure.Location = new System.Drawing.Point(238, 202);
            this.Ajout_heure.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ajout_heure.Name = "Ajout_heure";
            this.Ajout_heure.Size = new System.Drawing.Size(196, 31);
            this.Ajout_heure.TabIndex = 15;
            // 
            // Ajout_date
            // 
            this.Ajout_date.Location = new System.Drawing.Point(238, 158);
            this.Ajout_date.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ajout_date.Name = "Ajout_date";
            this.Ajout_date.Size = new System.Drawing.Size(196, 31);
            this.Ajout_date.TabIndex = 14;
            // 
            // Ajout_id_bateau
            // 
            this.Ajout_id_bateau.Location = new System.Drawing.Point(238, 116);
            this.Ajout_id_bateau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ajout_id_bateau.Name = "Ajout_id_bateau";
            this.Ajout_id_bateau.Size = new System.Drawing.Size(196, 31);
            this.Ajout_id_bateau.TabIndex = 13;
            // 
            // Ajout_id_traverse
            // 
            this.Ajout_id_traverse.Location = new System.Drawing.Point(238, 72);
            this.Ajout_id_traverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ajout_id_traverse.Name = "Ajout_id_traverse";
            this.Ajout_id_traverse.Size = new System.Drawing.Size(196, 31);
            this.Ajout_id_traverse.TabIndex = 12;
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(0, 194);
            this.btnInser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(150, 44);
            this.btnInser.TabIndex = 7;
            this.btnInser.Text = "Insérer";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // Ajout_id_liaison
            // 
            this.Ajout_id_liaison.Location = new System.Drawing.Point(238, 31);
            this.Ajout_id_liaison.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Ajout_id_liaison.Name = "Ajout_id_liaison";
            this.Ajout_id_liaison.Size = new System.Drawing.Size(196, 31);
            this.Ajout_id_liaison.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Id_liaison";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Supr_traverse);
            this.groupBox2.Location = new System.Drawing.Point(530, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(338, 259);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suppression";
            // 
            // Supr_traverse
            // 
            this.Supr_traverse.Location = new System.Drawing.Point(94, 80);
            this.Supr_traverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Supr_traverse.Name = "Supr_traverse";
            this.Supr_traverse.Size = new System.Drawing.Size(150, 94);
            this.Supr_traverse.TabIndex = 12;
            this.Supr_traverse.Text = "Supprimer la traversée";
            this.Supr_traverse.UseVisualStyleBackColor = true;
            this.Supr_traverse.Click += new System.EventHandler(this.Supr_traverse_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.Modif_traverse);
            this.groupBox3.Controls.Add(this.Modif_Heure);
            this.groupBox3.Controls.Add(this.Modif_Date);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(906, 419);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox3.Size = new System.Drawing.Size(400, 259);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 31);
            this.textBox1.TabIndex = 20;
            // 
            // Modif_traverse
            // 
            this.Modif_traverse.Location = new System.Drawing.Point(128, 20);
            this.Modif_traverse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Modif_traverse.Name = "Modif_traverse";
            this.Modif_traverse.Size = new System.Drawing.Size(150, 44);
            this.Modif_traverse.TabIndex = 15;
            this.Modif_traverse.Text = "Modifier";
            this.Modif_traverse.UseVisualStyleBackColor = true;
            this.Modif_traverse.Click += new System.EventHandler(this.Modif_traverse_Click);
            // 
            // Modif_Heure
            // 
            this.Modif_Heure.AutoSize = true;
            this.Modif_Heure.Location = new System.Drawing.Point(236, 116);
            this.Modif_Heure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Modif_Heure.Name = "Modif_Heure";
            this.Modif_Heure.Size = new System.Drawing.Size(160, 25);
            this.Modif_Heure.TabIndex = 19;
            this.Modif_Heure.Text = "Heure_traverse";
            // 
            // Modif_Date
            // 
            this.Modif_Date.Location = new System.Drawing.Point(39, 72);
            this.Modif_Date.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Modif_Date.Name = "Modif_Date";
            this.Modif_Date.Size = new System.Drawing.Size(196, 31);
            this.Modif_Date.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date_traverse";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxtraverse
            // 
            this.listBoxtraverse.FormattingEnabled = true;
            this.listBoxtraverse.ItemHeight = 25;
            this.listBoxtraverse.Location = new System.Drawing.Point(728, 83);
            this.listBoxtraverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxtraverse.Name = "listBoxtraverse";
            this.listBoxtraverse.Size = new System.Drawing.Size(578, 304);
            this.listBoxtraverse.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Liaisons";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Traverse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 720);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxtraverse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxliaison);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxliaison;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.TextBox Ajout_id_liaison;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Supr_traverse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Modif_traverse;
        private System.Windows.Forms.Label Modif_Heure;
        private System.Windows.Forms.TextBox Modif_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxtraverse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Ajout_heure;
        private System.Windows.Forms.TextBox Ajout_date;
        private System.Windows.Forms.TextBox Ajout_id_bateau;
        private System.Windows.Forms.TextBox Ajout_id_traverse;
    }
}

