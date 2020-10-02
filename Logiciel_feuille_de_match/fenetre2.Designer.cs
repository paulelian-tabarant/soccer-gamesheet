namespace Logiciel_fdm
{
    partial class fenetre2
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
            this.Joueurs_equipe_locaux = new System.Windows.Forms.ListBox();
            this.remp_loc = new System.Windows.Forms.CheckedListBox();
            this.logo_loc = new System.Windows.Forms.PictureBox();
            this.pictureBox_Dispo_Loc = new System.Windows.Forms.PictureBox();
            this.add_joueurs_loc = new System.Windows.Forms.Button();
            this.Val_remp_loc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Joueurs_equipe_ext = new System.Windows.Forms.ListBox();
            this.logo_ext = new System.Windows.Forms.PictureBox();
            this.remp_ext = new System.Windows.Forms.CheckedListBox();
            this.pictureBox_Dispo_Ext = new System.Windows.Forms.PictureBox();
            this.add_joueurs_ext = new System.Windows.Forms.Button();
            this.Val_remp_ext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poste = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Nom_exterieur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Poste_exterieur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Confirmer = new System.Windows.Forms.Button();
            this.labelPostesEq1 = new System.Windows.Forms.Label();
            this.labelPostesEq2 = new System.Windows.Forms.Label();
            this.BoutonAnnulerEq1 = new System.Windows.Forms.Button();
            this.BoutonAnnulerEq2 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dispo_Loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dispo_Ext)).BeginInit();
            this.SuspendLayout();
            // 
            // Joueurs_equipe_locaux
            // 
            this.Joueurs_equipe_locaux.FormattingEnabled = true;
            this.Joueurs_equipe_locaux.Location = new System.Drawing.Point(9, 27);
            this.Joueurs_equipe_locaux.Margin = new System.Windows.Forms.Padding(2);
            this.Joueurs_equipe_locaux.Name = "Joueurs_equipe_locaux";
            this.Joueurs_equipe_locaux.Size = new System.Drawing.Size(162, 264);
            this.Joueurs_equipe_locaux.TabIndex = 0;
            // 
            // remp_loc
            // 
            this.remp_loc.CheckOnClick = true;
            this.remp_loc.FormattingEnabled = true;
            this.remp_loc.Location = new System.Drawing.Point(9, 359);
            this.remp_loc.Margin = new System.Windows.Forms.Padding(2);
            this.remp_loc.Name = "remp_loc";
            this.remp_loc.Size = new System.Drawing.Size(162, 109);
            this.remp_loc.TabIndex = 4;
            // 
            // logo_loc
            // 
            this.logo_loc.Location = new System.Drawing.Point(365, 26);
            this.logo_loc.Margin = new System.Windows.Forms.Padding(2);
            this.logo_loc.Name = "logo_loc";
            this.logo_loc.Size = new System.Drawing.Size(124, 130);
            this.logo_loc.TabIndex = 5;
            this.logo_loc.TabStop = false;
            // 
            // pictureBox_Dispo_Loc
            // 
            this.pictureBox_Dispo_Loc.Location = new System.Drawing.Point(243, 298);
            this.pictureBox_Dispo_Loc.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Dispo_Loc.Name = "pictureBox_Dispo_Loc";
            this.pictureBox_Dispo_Loc.Size = new System.Drawing.Size(230, 222);
            this.pictureBox_Dispo_Loc.TabIndex = 6;
            this.pictureBox_Dispo_Loc.TabStop = false;
            // 
            // add_joueurs_loc
            // 
            this.add_joueurs_loc.Location = new System.Drawing.Point(9, 298);
            this.add_joueurs_loc.Margin = new System.Windows.Forms.Padding(2);
            this.add_joueurs_loc.Name = "add_joueurs_loc";
            this.add_joueurs_loc.Size = new System.Drawing.Size(56, 25);
            this.add_joueurs_loc.TabIndex = 7;
            this.add_joueurs_loc.Text = "Ajouter";
            this.add_joueurs_loc.UseVisualStyleBackColor = true;
            this.add_joueurs_loc.Click += new System.EventHandler(this.add_joueurs_loc_Click);
            // 
            // Val_remp_loc
            // 
            this.Val_remp_loc.Location = new System.Drawing.Point(9, 497);
            this.Val_remp_loc.Margin = new System.Windows.Forms.Padding(2);
            this.Val_remp_loc.Name = "Val_remp_loc";
            this.Val_remp_loc.Size = new System.Drawing.Size(56, 23);
            this.Val_remp_loc.TabIndex = 8;
            this.Val_remp_loc.Text = "Valider";
            this.Val_remp_loc.UseVisualStyleBackColor = true;
            this.Val_remp_loc.Click += new System.EventHandler(this.Validation_domicile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Joueurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sélectionner joueur \r\npour le poste :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remplaçants";
            // 
            // Joueurs_equipe_ext
            // 
            this.Joueurs_equipe_ext.FormattingEnabled = true;
            this.Joueurs_equipe_ext.Location = new System.Drawing.Point(602, 27);
            this.Joueurs_equipe_ext.Margin = new System.Windows.Forms.Padding(2);
            this.Joueurs_equipe_ext.Name = "Joueurs_equipe_ext";
            this.Joueurs_equipe_ext.Size = new System.Drawing.Size(163, 264);
            this.Joueurs_equipe_ext.TabIndex = 12;
            // 
            // logo_ext
            // 
            this.logo_ext.Location = new System.Drawing.Point(959, 26);
            this.logo_ext.Margin = new System.Windows.Forms.Padding(2);
            this.logo_ext.Name = "logo_ext";
            this.logo_ext.Size = new System.Drawing.Size(125, 130);
            this.logo_ext.TabIndex = 15;
            this.logo_ext.TabStop = false;
            // 
            // remp_ext
            // 
            this.remp_ext.CheckOnClick = true;
            this.remp_ext.FormattingEnabled = true;
            this.remp_ext.Location = new System.Drawing.Point(602, 359);
            this.remp_ext.Margin = new System.Windows.Forms.Padding(2);
            this.remp_ext.Name = "remp_ext";
            this.remp_ext.Size = new System.Drawing.Size(162, 109);
            this.remp_ext.TabIndex = 16;
            // 
            // pictureBox_Dispo_Ext
            // 
            this.pictureBox_Dispo_Ext.Location = new System.Drawing.Point(838, 300);
            this.pictureBox_Dispo_Ext.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Dispo_Ext.Name = "pictureBox_Dispo_Ext";
            this.pictureBox_Dispo_Ext.Size = new System.Drawing.Size(230, 222);
            this.pictureBox_Dispo_Ext.TabIndex = 17;
            this.pictureBox_Dispo_Ext.TabStop = false;
            // 
            // add_joueurs_ext
            // 
            this.add_joueurs_ext.Location = new System.Drawing.Point(602, 300);
            this.add_joueurs_ext.Margin = new System.Windows.Forms.Padding(2);
            this.add_joueurs_ext.Name = "add_joueurs_ext";
            this.add_joueurs_ext.Size = new System.Drawing.Size(56, 23);
            this.add_joueurs_ext.TabIndex = 18;
            this.add_joueurs_ext.Text = "Ajouter";
            this.add_joueurs_ext.UseVisualStyleBackColor = true;
            this.add_joueurs_ext.Click += new System.EventHandler(this.add_joueurs_ext_Click);
            // 
            // Val_remp_ext
            // 
            this.Val_remp_ext.Location = new System.Drawing.Point(602, 497);
            this.Val_remp_ext.Margin = new System.Windows.Forms.Padding(2);
            this.Val_remp_ext.Name = "Val_remp_ext";
            this.Val_remp_ext.Size = new System.Drawing.Size(56, 23);
            this.Val_remp_ext.TabIndex = 19;
            this.Val_remp_ext.Text = "Valider";
            this.Val_remp_ext.UseVisualStyleBackColor = true;
            this.Val_remp_ext.Click += new System.EventHandler(this.Validation_exterieur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Remplaçants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(599, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Joueurs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(813, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sélectionnez joueur\r\n pour ce poste :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Poste});
            this.listView1.Location = new System.Drawing.Point(221, 162);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(268, 128);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 120;
            // 
            // Poste
            // 
            this.Poste.Text = "Poste";
            this.Poste.Width = 50;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom_exterieur,
            this.Poste_exterieur});
            this.listView2.Location = new System.Drawing.Point(816, 162);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(268, 129);
            this.listView2.TabIndex = 24;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Nom_exterieur
            // 
            this.Nom_exterieur.Text = "Poste";
            this.Nom_exterieur.Width = 152;
            // 
            // Poste_exterieur
            // 
            this.Poste_exterieur.Text = "Poste";
            // 
            // Confirmer
            // 
            this.Confirmer.Enabled = false;
            this.Confirmer.Location = new System.Drawing.Point(1098, 497);
            this.Confirmer.Margin = new System.Windows.Forms.Padding(2);
            this.Confirmer.Name = "Confirmer";
            this.Confirmer.Size = new System.Drawing.Size(75, 23);
            this.Confirmer.TabIndex = 25;
            this.Confirmer.Text = "Confirmer";
            this.Confirmer.UseVisualStyleBackColor = true;
            this.Confirmer.Click += new System.EventHandler(this.Confirmer_Click);
            // 
            // labelPostesEq1
            // 
            this.labelPostesEq1.AutoSize = true;
            this.labelPostesEq1.Font = new System.Drawing.Font("Franklin Gothic Book", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostesEq1.Location = new System.Drawing.Point(207, 64);
            this.labelPostesEq1.Name = "labelPostesEq1";
            this.labelPostesEq1.Size = new System.Drawing.Size(83, 81);
            this.labelPostesEq1.TabIndex = 26;
            this.labelPostesEq1.Text = "...";
            // 
            // labelPostesEq2
            // 
            this.labelPostesEq2.AutoSize = true;
            this.labelPostesEq2.Font = new System.Drawing.Font("Franklin Gothic Book", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostesEq2.Location = new System.Drawing.Point(802, 64);
            this.labelPostesEq2.Name = "labelPostesEq2";
            this.labelPostesEq2.Size = new System.Drawing.Size(83, 81);
            this.labelPostesEq2.TabIndex = 27;
            this.labelPostesEq2.Text = "...";
            // 
            // BoutonAnnulerEq1
            // 
            this.BoutonAnnulerEq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonAnnulerEq1.ForeColor = System.Drawing.Color.Red;
            this.BoutonAnnulerEq1.Location = new System.Drawing.Point(70, 298);
            this.BoutonAnnulerEq1.Name = "BoutonAnnulerEq1";
            this.BoutonAnnulerEq1.Size = new System.Drawing.Size(29, 25);
            this.BoutonAnnulerEq1.TabIndex = 28;
            this.BoutonAnnulerEq1.Text = "X";
            this.BoutonAnnulerEq1.UseVisualStyleBackColor = true;
            this.BoutonAnnulerEq1.Click += new System.EventHandler(this.BoutonAnnulerEq1_Click);
            // 
            // BoutonAnnulerEq2
            // 
            this.BoutonAnnulerEq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonAnnulerEq2.ForeColor = System.Drawing.Color.Red;
            this.BoutonAnnulerEq2.Location = new System.Drawing.Point(663, 300);
            this.BoutonAnnulerEq2.Name = "BoutonAnnulerEq2";
            this.BoutonAnnulerEq2.Size = new System.Drawing.Size(29, 23);
            this.BoutonAnnulerEq2.TabIndex = 29;
            this.BoutonAnnulerEq2.Text = "X";
            this.BoutonAnnulerEq2.UseVisualStyleBackColor = true;
            this.BoutonAnnulerEq2.Click += new System.EventHandler(this.BoutonAnnulerEq2_Click);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(1098, 445);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 30;
            this.help.Text = "Aide";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // fenetre2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1199, 533);
            this.Controls.Add(this.help);
            this.Controls.Add(this.BoutonAnnulerEq2);
            this.Controls.Add(this.BoutonAnnulerEq1);
            this.Controls.Add(this.labelPostesEq2);
            this.Controls.Add(this.labelPostesEq1);
            this.Controls.Add(this.Confirmer);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Val_remp_ext);
            this.Controls.Add(this.add_joueurs_ext);
            this.Controls.Add(this.pictureBox_Dispo_Ext);
            this.Controls.Add(this.remp_ext);
            this.Controls.Add(this.logo_ext);
            this.Controls.Add(this.Joueurs_equipe_ext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Val_remp_loc);
            this.Controls.Add(this.add_joueurs_loc);
            this.Controls.Add(this.pictureBox_Dispo_Loc);
            this.Controls.Add(this.logo_loc);
            this.Controls.Add(this.remp_loc);
            this.Controls.Add(this.Joueurs_equipe_locaux);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fenetre2";
            this.Text = "Sélection - Titulaires et remplaçants";
            this.Load += new System.EventHandler(this.fenetre2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dispo_Loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Dispo_Ext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Joueurs_equipe_locaux;
        private System.Windows.Forms.CheckedListBox remp_loc;
        private System.Windows.Forms.PictureBox logo_loc;
        private System.Windows.Forms.PictureBox pictureBox_Dispo_Loc;
        private System.Windows.Forms.Button add_joueurs_loc;
        private System.Windows.Forms.Button Val_remp_loc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Joueurs_equipe_ext;
        private System.Windows.Forms.PictureBox logo_ext;
        private System.Windows.Forms.CheckedListBox remp_ext;
        private System.Windows.Forms.PictureBox pictureBox_Dispo_Ext;
        private System.Windows.Forms.Button add_joueurs_ext;
        private System.Windows.Forms.Button Val_remp_ext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button Confirmer;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Poste;
        private System.Windows.Forms.ColumnHeader Nom_exterieur;
        private System.Windows.Forms.ColumnHeader Poste_exterieur;
        private System.Windows.Forms.Label labelPostesEq1;
        private System.Windows.Forms.Label labelPostesEq2;
        private System.Windows.Forms.Button BoutonAnnulerEq1;
        private System.Windows.Forms.Button BoutonAnnulerEq2;
        private System.Windows.Forms.Button help;
    }
}