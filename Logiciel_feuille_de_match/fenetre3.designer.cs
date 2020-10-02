namespace Logiciel_fdm
{
    partial class fenetre3
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
            this.components = new System.ComponentModel.Container();
            this.logo_loc = new System.Windows.Forms.PictureBox();
            this.logo_ext = new System.Windows.Forms.PictureBox();
            this.equipe_loc = new System.Windows.Forms.Label();
            this.equipe_ext = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Button();
            this.effectif_loc = new System.Windows.Forms.ListBox();
            this.list_remp_loc = new System.Windows.Forms.ListBox();
            this.score_loc = new System.Windows.Forms.Label();
            this.score_ext = new System.Windows.Forms.Label();
            this.effectif_ext = new System.Windows.Forms.ListBox();
            this.list_remp_ext = new System.Windows.Forms.ListBox();
            this.but_ext = new System.Windows.Forms.Button();
            this.cart_r_ext = new System.Windows.Forms.Button();
            this.cart_j_ext = new System.Windows.Forms.Button();
            this.peno_ext = new System.Windows.Forms.Button();
            this.coup_franc_ext = new System.Windows.Forms.Button();
            this.HJ_ext = new System.Windows.Forms.Button();
            this.remp_ext = new System.Windows.Forms.Button();
            this.faute_ext = new System.Windows.Forms.Button();
            this.corner_ext = new System.Windows.Forms.Button();
            this.add_action_ext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.evts = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.mi_temps = new System.Windows.Forms.Button();
            this.reprise = new System.Windows.Forms.Button();
            this.indic_add = new System.Windows.Forms.Label();
            this.Actions = new System.Windows.Forms.ListView();
            this.Minute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Joueur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_min_add = new System.Windows.Forms.Label();
            this.label_sec_add = new System.Windows.Forms.Label();
            this.annuler_action_ext = new System.Windows.Forms.Button();
            this.chgt_ext_clic = new System.Windows.Forms.PictureBox();
            this.chgt_loc_clic = new System.Windows.Forms.PictureBox();
            this.buttonFin = new System.Windows.Forms.Button();
            this.folderBrowserSave_fdm = new System.Windows.Forms.FolderBrowserDialog();
            this.help = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_loc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ext)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chgt_ext_clic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chgt_loc_clic)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_loc
            // 
            this.logo_loc.Location = new System.Drawing.Point(393, 12);
            this.logo_loc.Name = "logo_loc";
            this.logo_loc.Size = new System.Drawing.Size(113, 105);
            this.logo_loc.TabIndex = 0;
            this.logo_loc.TabStop = false;
            // 
            // logo_ext
            // 
            this.logo_ext.Location = new System.Drawing.Point(660, 12);
            this.logo_ext.Name = "logo_ext";
            this.logo_ext.Size = new System.Drawing.Size(113, 105);
            this.logo_ext.TabIndex = 1;
            this.logo_ext.TabStop = false;
            // 
            // equipe_loc
            // 
            this.equipe_loc.AutoSize = true;
            this.equipe_loc.Location = new System.Drawing.Point(285, 162);
            this.equipe_loc.Name = "equipe_loc";
            this.equipe_loc.Size = new System.Drawing.Size(35, 13);
            this.equipe_loc.TabIndex = 2;
            this.equipe_loc.Text = "label1";
            // 
            // equipe_ext
            // 
            this.equipe_ext.AutoSize = true;
            this.equipe_ext.Location = new System.Drawing.Point(817, 162);
            this.equipe_ext.Name = "equipe_ext";
            this.equipe_ext.Size = new System.Drawing.Size(35, 13);
            this.equipe_ext.TabIndex = 3;
            this.equipe_ext.Text = "label2";
            // 
            // end
            // 
            this.end.Enabled = false;
            this.end.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(929, 488);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(225, 74);
            this.end.TabIndex = 5;
            this.end.Text = "Générer la feuille de match";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.Generer_Click);
            // 
            // effectif_loc
            // 
            this.effectif_loc.FormattingEnabled = true;
            this.effectif_loc.Location = new System.Drawing.Point(12, 12);
            this.effectif_loc.Name = "effectif_loc";
            this.effectif_loc.Size = new System.Drawing.Size(144, 342);
            this.effectif_loc.TabIndex = 6;
            this.effectif_loc.SelectedIndexChanged += new System.EventHandler(this.effectif_loc_SelectedIndexChanged);
            // 
            // list_remp_loc
            // 
            this.list_remp_loc.FormattingEnabled = true;
            this.list_remp_loc.Location = new System.Drawing.Point(243, 12);
            this.list_remp_loc.Name = "list_remp_loc";
            this.list_remp_loc.Size = new System.Drawing.Size(144, 147);
            this.list_remp_loc.TabIndex = 7;
            // 
            // score_loc
            // 
            this.score_loc.AutoSize = true;
            this.score_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_loc.Location = new System.Drawing.Point(512, 62);
            this.score_loc.Name = "score_loc";
            this.score_loc.Size = new System.Drawing.Size(70, 25);
            this.score_loc.TabIndex = 9;
            this.score_loc.Text = "label3";
            // 
            // score_ext
            // 
            this.score_ext.AutoSize = true;
            this.score_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_ext.Location = new System.Drawing.Point(606, 62);
            this.score_ext.Name = "score_ext";
            this.score_ext.Size = new System.Drawing.Size(70, 25);
            this.score_ext.TabIndex = 10;
            this.score_ext.Text = "label4";
            // 
            // effectif_ext
            // 
            this.effectif_ext.FormattingEnabled = true;
            this.effectif_ext.Location = new System.Drawing.Point(1010, 12);
            this.effectif_ext.Name = "effectif_ext";
            this.effectif_ext.Size = new System.Drawing.Size(144, 342);
            this.effectif_ext.TabIndex = 23;
            this.effectif_ext.SelectedIndexChanged += new System.EventHandler(this.effectif_ext_SelectedIndexChanged);
            // 
            // list_remp_ext
            // 
            this.list_remp_ext.FormattingEnabled = true;
            this.list_remp_ext.Location = new System.Drawing.Point(779, 12);
            this.list_remp_ext.Name = "list_remp_ext";
            this.list_remp_ext.Size = new System.Drawing.Size(144, 147);
            this.list_remp_ext.TabIndex = 25;
            // 
            // but_ext
            // 
            this.but_ext.Location = new System.Drawing.Point(762, 322);
            this.but_ext.Name = "but_ext";
            this.but_ext.Size = new System.Drawing.Size(80, 23);
            this.but_ext.TabIndex = 26;
            this.but_ext.Text = "But";
            this.but_ext.UseVisualStyleBackColor = true;
            this.but_ext.Click += new System.EventHandler(this.but_Click);
            // 
            // cart_r_ext
            // 
            this.cart_r_ext.Location = new System.Drawing.Point(660, 322);
            this.cart_r_ext.Name = "cart_r_ext";
            this.cart_r_ext.Size = new System.Drawing.Size(80, 23);
            this.cart_r_ext.TabIndex = 27;
            this.cart_r_ext.Text = "Carton rouge";
            this.cart_r_ext.UseVisualStyleBackColor = true;
            this.cart_r_ext.Click += new System.EventHandler(this.cart_r_Click);
            // 
            // cart_j_ext
            // 
            this.cart_j_ext.Location = new System.Drawing.Point(562, 322);
            this.cart_j_ext.Name = "cart_j_ext";
            this.cart_j_ext.Size = new System.Drawing.Size(75, 23);
            this.cart_j_ext.TabIndex = 28;
            this.cart_j_ext.Text = "Carton jaune";
            this.cart_j_ext.UseVisualStyleBackColor = true;
            this.cart_j_ext.Click += new System.EventHandler(this.cart_j_Click);
            // 
            // peno_ext
            // 
            this.peno_ext.Location = new System.Drawing.Point(562, 415);
            this.peno_ext.Name = "peno_ext";
            this.peno_ext.Size = new System.Drawing.Size(75, 23);
            this.peno_ext.TabIndex = 29;
            this.peno_ext.Text = "Penalty";
            this.peno_ext.UseVisualStyleBackColor = true;
            this.peno_ext.Click += new System.EventHandler(this.peno_Click);
            // 
            // coup_franc_ext
            // 
            this.coup_franc_ext.Location = new System.Drawing.Point(660, 369);
            this.coup_franc_ext.Name = "coup_franc_ext";
            this.coup_franc_ext.Size = new System.Drawing.Size(80, 23);
            this.coup_franc_ext.TabIndex = 30;
            this.coup_franc_ext.Text = "Coup franc";
            this.coup_franc_ext.UseVisualStyleBackColor = true;
            this.coup_franc_ext.Click += new System.EventHandler(this.coup_franc_Click);
            // 
            // HJ_ext
            // 
            this.HJ_ext.Location = new System.Drawing.Point(562, 369);
            this.HJ_ext.Name = "HJ_ext";
            this.HJ_ext.Size = new System.Drawing.Size(75, 23);
            this.HJ_ext.TabIndex = 31;
            this.HJ_ext.Text = "Hors jeu";
            this.HJ_ext.UseVisualStyleBackColor = true;
            this.HJ_ext.Click += new System.EventHandler(this.HJ_Click);
            // 
            // remp_ext
            // 
            this.remp_ext.Location = new System.Drawing.Point(762, 415);
            this.remp_ext.Name = "remp_ext";
            this.remp_ext.Size = new System.Drawing.Size(80, 23);
            this.remp_ext.TabIndex = 32;
            this.remp_ext.Text = "Changement";
            this.remp_ext.UseVisualStyleBackColor = true;
            this.remp_ext.Click += new System.EventHandler(this.remp_Click);
            // 
            // faute_ext
            // 
            this.faute_ext.Location = new System.Drawing.Point(762, 369);
            this.faute_ext.Name = "faute_ext";
            this.faute_ext.Size = new System.Drawing.Size(80, 23);
            this.faute_ext.TabIndex = 33;
            this.faute_ext.Text = "Faute";
            this.faute_ext.UseVisualStyleBackColor = true;
            this.faute_ext.Click += new System.EventHandler(this.faute_Click);
            // 
            // corner_ext
            // 
            this.corner_ext.Location = new System.Drawing.Point(660, 415);
            this.corner_ext.Name = "corner_ext";
            this.corner_ext.Size = new System.Drawing.Size(80, 23);
            this.corner_ext.TabIndex = 34;
            this.corner_ext.Text = "Corner";
            this.corner_ext.UseVisualStyleBackColor = true;
            this.corner_ext.Click += new System.EventHandler(this.corner_Click);
            // 
            // add_action_ext
            // 
            this.add_action_ext.Location = new System.Drawing.Point(660, 539);
            this.add_action_ext.Name = "add_action_ext";
            this.add_action_ext.Size = new System.Drawing.Size(75, 23);
            this.add_action_ext.TabIndex = 35;
            this.add_action_ext.Text = "Valider";
            this.add_action_ext.UseVisualStyleBackColor = true;
            this.add_action_ext.Click += new System.EventHandler(this.valider_action_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ajouter l\'action";
            // 
            // evts
            // 
            this.evts.AutoSize = true;
            this.evts.Location = new System.Drawing.Point(318, 235);
            this.evts.Name = "evts";
            this.evts.Size = new System.Drawing.Size(89, 13);
            this.evts.TabIndex = 37;
            this.evts.Text = "Actions du match";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.Location = new System.Drawing.Point(610, 162);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(66, 24);
            this.sec.TabIndex = 39;
            this.sec.Text = "label1";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(559, 166);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 17);
            this.label.TabIndex = 40;
            this.label.Text = "min";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(517, 162);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(66, 24);
            this.minutes.TabIndex = 41;
            this.minutes.Text = "label2";
            // 
            // mi_temps
            // 
            this.mi_temps.Location = new System.Drawing.Point(848, 251);
            this.mi_temps.Name = "mi_temps";
            this.mi_temps.Size = new System.Drawing.Size(75, 23);
            this.mi_temps.TabIndex = 51;
            this.mi_temps.Text = "Mi-temps";
            this.mi_temps.UseVisualStyleBackColor = true;
            this.mi_temps.Visible = false;
            this.mi_temps.Click += new System.EventHandler(this.mi_temps_Click);
            // 
            // reprise
            // 
            this.reprise.Location = new System.Drawing.Point(767, 251);
            this.reprise.Name = "reprise";
            this.reprise.Size = new System.Drawing.Size(75, 23);
            this.reprise.TabIndex = 52;
            this.reprise.Text = "Reprise";
            this.reprise.UseVisualStyleBackColor = true;
            this.reprise.Visible = false;
            this.reprise.Click += new System.EventHandler(this.reprise_Click);
            // 
            // indic_add
            // 
            this.indic_add.AutoSize = true;
            this.indic_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indic_add.Location = new System.Drawing.Point(670, 170);
            this.indic_add.Name = "indic_add";
            this.indic_add.Size = new System.Drawing.Size(37, 13);
            this.indic_add.TabIndex = 53;
            this.indic_add.Text = "(Add)";
            this.indic_add.Visible = false;
            // 
            // Actions
            // 
            this.Actions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Minute,
            this.Joueur,
            this.Action});
            this.Actions.ContextMenuStrip = this.contextMenuStrip1;
            this.Actions.FullRowSelect = true;
            this.Actions.Location = new System.Drawing.Point(207, 251);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(324, 321);
            this.Actions.TabIndex = 54;
            this.Actions.UseCompatibleStateImageBehavior = false;
            this.Actions.View = System.Windows.Forms.View.Details;
            // 
            // Minute
            // 
            this.Minute.Text = "Minute";
            this.Minute.Width = 64;
            // 
            // Joueur
            // 
            this.Joueur.Text = "Joueur";
            this.Joueur.Width = 148;
            // 
            // Action
            // 
            this.Action.Text = "Action";
            this.Action.Width = 203;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // label_min_add
            // 
            this.label_min_add.AutoSize = true;
            this.label_min_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_min_add.Location = new System.Drawing.Point(722, 170);
            this.label_min_add.Name = "label_min_add";
            this.label_min_add.Size = new System.Drawing.Size(41, 13);
            this.label_min_add.TabIndex = 56;
            this.label_min_add.Text = "label1";
            this.label_min_add.Visible = false;
            // 
            // label_sec_add
            // 
            this.label_sec_add.AutoSize = true;
            this.label_sec_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sec_add.Location = new System.Drawing.Point(741, 170);
            this.label_sec_add.Name = "label_sec_add";
            this.label_sec_add.Size = new System.Drawing.Size(41, 13);
            this.label_sec_add.TabIndex = 57;
            this.label_sec_add.Text = "label2";
            this.label_sec_add.Visible = false;
            // 
            // annuler_action_ext
            // 
            this.annuler_action_ext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler_action_ext.ForeColor = System.Drawing.Color.Red;
            this.annuler_action_ext.Location = new System.Drawing.Point(746, 539);
            this.annuler_action_ext.Name = "annuler_action_ext";
            this.annuler_action_ext.Size = new System.Drawing.Size(27, 23);
            this.annuler_action_ext.TabIndex = 58;
            this.annuler_action_ext.Text = "X";
            this.annuler_action_ext.UseVisualStyleBackColor = true;
            this.annuler_action_ext.Click += new System.EventHandler(this.annuler_action_Click);
            // 
            // chgt_ext_clic
            // 
            this.chgt_ext_clic.Location = new System.Drawing.Point(929, 37);
            this.chgt_ext_clic.Name = "chgt_ext_clic";
            this.chgt_ext_clic.Size = new System.Drawing.Size(77, 67);
            this.chgt_ext_clic.TabIndex = 60;
            this.chgt_ext_clic.TabStop = false;
            this.chgt_ext_clic.Click += new System.EventHandler(this.chgt_ext_Click);
            // 
            // chgt_loc_clic
            // 
            this.chgt_loc_clic.Location = new System.Drawing.Point(160, 37);
            this.chgt_loc_clic.Name = "chgt_loc_clic";
            this.chgt_loc_clic.Size = new System.Drawing.Size(77, 67);
            this.chgt_loc_clic.TabIndex = 61;
            this.chgt_loc_clic.TabStop = false;
            this.chgt_loc_clic.Click += new System.EventHandler(this.chgt_loc_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(542, 189);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(75, 23);
            this.buttonFin.TabIndex = 62;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Visible = false;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // folderBrowserSave_fdm
            // 
            this.folderBrowserSave_fdm.Description = "Chemin d\'enregistrement de la feuille de match";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(12, 539);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 63;
            this.help.Text = "Aide";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click_1);
            // 
            // fenetre3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1169, 583);
            this.Controls.Add(this.help);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.chgt_loc_clic);
            this.Controls.Add(this.chgt_ext_clic);
            this.Controls.Add(this.annuler_action_ext);
            this.Controls.Add(this.label_sec_add);
            this.Controls.Add(this.label_min_add);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.indic_add);
            this.Controls.Add(this.reprise);
            this.Controls.Add(this.mi_temps);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.evts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add_action_ext);
            this.Controls.Add(this.corner_ext);
            this.Controls.Add(this.faute_ext);
            this.Controls.Add(this.remp_ext);
            this.Controls.Add(this.HJ_ext);
            this.Controls.Add(this.coup_franc_ext);
            this.Controls.Add(this.peno_ext);
            this.Controls.Add(this.cart_j_ext);
            this.Controls.Add(this.cart_r_ext);
            this.Controls.Add(this.but_ext);
            this.Controls.Add(this.list_remp_ext);
            this.Controls.Add(this.effectif_ext);
            this.Controls.Add(this.score_ext);
            this.Controls.Add(this.score_loc);
            this.Controls.Add(this.list_remp_loc);
            this.Controls.Add(this.effectif_loc);
            this.Controls.Add(this.end);
            this.Controls.Add(this.equipe_ext);
            this.Controls.Add(this.equipe_loc);
            this.Controls.Add(this.logo_ext);
            this.Controls.Add(this.logo_loc);
            this.Name = "fenetre3";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.fenetre3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_loc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_ext)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chgt_ext_clic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chgt_loc_clic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_loc;
        private System.Windows.Forms.PictureBox logo_ext;
        private System.Windows.Forms.Label equipe_loc;
        private System.Windows.Forms.Label equipe_ext;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.ListBox effectif_loc;
        private System.Windows.Forms.ListBox list_remp_loc;
        private System.Windows.Forms.Label score_loc;
        private System.Windows.Forms.Label score_ext;
        private System.Windows.Forms.ListBox effectif_ext;
        private System.Windows.Forms.ListBox list_remp_ext;
        private System.Windows.Forms.Button but_ext;
        private System.Windows.Forms.Button cart_r_ext;
        private System.Windows.Forms.Button cart_j_ext;
        private System.Windows.Forms.Button peno_ext;
        private System.Windows.Forms.Button coup_franc_ext;
        private System.Windows.Forms.Button HJ_ext;
        private System.Windows.Forms.Button remp_ext;
        private System.Windows.Forms.Button faute_ext;
        private System.Windows.Forms.Button corner_ext;
        private System.Windows.Forms.Button add_action_ext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label evts;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Button mi_temps;
        private System.Windows.Forms.Button reprise;
        private System.Windows.Forms.Label indic_add;
        private System.Windows.Forms.ListView Actions;
        private System.Windows.Forms.ColumnHeader Minute;
        private System.Windows.Forms.ColumnHeader Joueur;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.Label label_min_add;
        private System.Windows.Forms.Label label_sec_add;
        private System.Windows.Forms.Button annuler_action_ext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.PictureBox chgt_ext_clic;
        private System.Windows.Forms.PictureBox chgt_loc_clic;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSave_fdm;
        private System.Windows.Forms.Button help;
    }
}