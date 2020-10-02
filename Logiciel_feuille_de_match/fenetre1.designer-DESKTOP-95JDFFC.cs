namespace Logiciel_fdm
{
    partial class fenetre1
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
            this.stade = new System.Windows.Forms.TextBox();
            this.nom_arbitre_prinicpal = new System.Windows.Forms.TextBox();
            this.nom_arbitre_remplaçant = new System.Windows.Forms.TextBox();
            this.nom_arbitre_touche_2 = new System.Windows.Forms.TextBox();
            this.nom_arbitre_touche_1 = new System.Windows.Forms.TextBox();
            this.dispositif_locaux = new System.Windows.Forms.ListBox();
            this.dispositif_visiteurs = new System.Windows.Forms.ListBox();
            this.equipe_locaux = new System.Windows.Forms.ComboBox();
            this.equipe_visiteurs = new System.Windows.Forms.ComboBox();
            this.label_select_loc = new System.Windows.Forms.Label();
            this.label_select_ext = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label_stade = new System.Windows.Forms.Label();
            this.label_arbitre_p = new System.Windows.Forms.Label();
            this.label_arb_r = new System.Windows.Forms.Label();
            this.label_arb_t = new System.Windows.Forms.Label();
            this.m_arb_princ = new System.Windows.Forms.RadioButton();
            this.mme_arb_princ = new System.Windows.Forms.RadioButton();
            this.m_arb_remp = new System.Windows.Forms.RadioButton();
            this.mme_arb_remp = new System.Windows.Forms.RadioButton();
            this.m_arb_touche_1 = new System.Windows.Forms.RadioButton();
            this.mme_arbitre_touche_1 = new System.Windows.Forms.RadioButton();
            this.m_arbitre_touche_2 = new System.Windows.Forms.RadioButton();
            this.mme_arbitre_touche_2 = new System.Windows.Forms.RadioButton();
            this.Confirm = new System.Windows.Forms.Button();
            this.labeal_dispo_locaux = new System.Windows.Forms.Label();
            this.label_dispo_ext = new System.Windows.Forms.Label();
            this.champ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calendrier_date = new System.Windows.Forms.MonthCalendar();
            this.help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // stade
            // 
            this.stade.Location = new System.Drawing.Point(12, 47);
            this.stade.Margin = new System.Windows.Forms.Padding(2);
            this.stade.Name = "stade";
            this.stade.Size = new System.Drawing.Size(117, 20);
            this.stade.TabIndex = 1;
            this.stade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // nom_arbitre_prinicpal
            // 
            this.nom_arbitre_prinicpal.Location = new System.Drawing.Point(187, 108);
            this.nom_arbitre_prinicpal.Margin = new System.Windows.Forms.Padding(2);
            this.nom_arbitre_prinicpal.Name = "nom_arbitre_prinicpal";
            this.nom_arbitre_prinicpal.Size = new System.Drawing.Size(138, 20);
            this.nom_arbitre_prinicpal.TabIndex = 2;
            this.nom_arbitre_prinicpal.TextChanged += new System.EventHandler(this.nom_arbitre_prinicpal_TextChanged);
            this.nom_arbitre_prinicpal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // nom_arbitre_remplaçant
            // 
            this.nom_arbitre_remplaçant.Location = new System.Drawing.Point(188, 157);
            this.nom_arbitre_remplaçant.Margin = new System.Windows.Forms.Padding(2);
            this.nom_arbitre_remplaçant.Name = "nom_arbitre_remplaçant";
            this.nom_arbitre_remplaçant.Size = new System.Drawing.Size(137, 20);
            this.nom_arbitre_remplaçant.TabIndex = 3;
            this.nom_arbitre_remplaçant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // nom_arbitre_touche_2
            // 
            this.nom_arbitre_touche_2.Location = new System.Drawing.Point(187, 279);
            this.nom_arbitre_touche_2.Margin = new System.Windows.Forms.Padding(2);
            this.nom_arbitre_touche_2.Name = "nom_arbitre_touche_2";
            this.nom_arbitre_touche_2.Size = new System.Drawing.Size(138, 20);
            this.nom_arbitre_touche_2.TabIndex = 5;
            this.nom_arbitre_touche_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // nom_arbitre_touche_1
            // 
            this.nom_arbitre_touche_1.Location = new System.Drawing.Point(187, 230);
            this.nom_arbitre_touche_1.Margin = new System.Windows.Forms.Padding(2);
            this.nom_arbitre_touche_1.Name = "nom_arbitre_touche_1";
            this.nom_arbitre_touche_1.Size = new System.Drawing.Size(138, 20);
            this.nom_arbitre_touche_1.TabIndex = 6;
            this.nom_arbitre_touche_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_KeyPress);
            // 
            // dispositif_locaux
            // 
            this.dispositif_locaux.FormattingEnabled = true;
            this.dispositif_locaux.Items.AddRange(new object[] {
            "4, 4, 2",
            "4, 3, 3",
            "5, 3, 2",
            "3, 5, 2",
            "4, 5, 1",
            "4, 2, 3, 1"});
            this.dispositif_locaux.Location = new System.Drawing.Point(364, 101);
            this.dispositif_locaux.Margin = new System.Windows.Forms.Padding(2);
            this.dispositif_locaux.Name = "dispositif_locaux";
            this.dispositif_locaux.Size = new System.Drawing.Size(79, 134);
            this.dispositif_locaux.TabIndex = 7;
            // 
            // dispositif_visiteurs
            // 
            this.dispositif_visiteurs.FormattingEnabled = true;
            this.dispositif_visiteurs.Items.AddRange(new object[] {
            "4, 4, 2",
            "4, 3, 3",
            "5, 3, 2",
            "3, 5, 2",
            "4, 5, 1",
            "4, 2, 3, 1"});
            this.dispositif_visiteurs.Location = new System.Drawing.Point(532, 101);
            this.dispositif_visiteurs.Margin = new System.Windows.Forms.Padding(2);
            this.dispositif_visiteurs.Name = "dispositif_visiteurs";
            this.dispositif_visiteurs.Size = new System.Drawing.Size(79, 134);
            this.dispositif_visiteurs.TabIndex = 8;
            // 
            // equipe_locaux
            // 
            this.equipe_locaux.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipe_locaux.FormattingEnabled = true;
            this.equipe_locaux.Location = new System.Drawing.Point(364, 47);
            this.equipe_locaux.Margin = new System.Windows.Forms.Padding(2);
            this.equipe_locaux.Name = "equipe_locaux";
            this.equipe_locaux.Size = new System.Drawing.Size(105, 21);
            this.equipe_locaux.TabIndex = 9;
            this.equipe_locaux.SelectedIndexChanged += new System.EventHandler(this.equipe_locaux_SelectedIndexChanged);
            // 
            // equipe_visiteurs
            // 
            this.equipe_visiteurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipe_visiteurs.FormattingEnabled = true;
            this.equipe_visiteurs.Location = new System.Drawing.Point(532, 47);
            this.equipe_visiteurs.Margin = new System.Windows.Forms.Padding(2);
            this.equipe_visiteurs.Name = "equipe_visiteurs";
            this.equipe_visiteurs.Size = new System.Drawing.Size(109, 21);
            this.equipe_visiteurs.TabIndex = 10;
            this.equipe_visiteurs.SelectedIndexChanged += new System.EventHandler(this.equipe_visiteurs_SelectedIndexChanged);
            // 
            // label_select_loc
            // 
            this.label_select_loc.AutoSize = true;
            this.label_select_loc.Location = new System.Drawing.Point(364, 28);
            this.label_select_loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_select_loc.Name = "label_select_loc";
            this.label_select_loc.Size = new System.Drawing.Size(42, 13);
            this.label_select_loc.TabIndex = 11;
            this.label_select_loc.Text = "Locaux";
            // 
            // label_select_ext
            // 
            this.label_select_ext.AutoSize = true;
            this.label_select_ext.Location = new System.Drawing.Point(532, 28);
            this.label_select_ext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_select_ext.Name = "label_select_ext";
            this.label_select_ext.Size = new System.Drawing.Size(46, 13);
            this.label_select_ext.TabIndex = 12;
            this.label_select_ext.Text = "Visiteurs";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(676, 42);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(33, 13);
            this.label_date.TabIndex = 13;
            this.label_date.Text = "Date ";
            // 
            // label_stade
            // 
            this.label_stade.AutoSize = true;
            this.label_stade.Location = new System.Drawing.Point(12, 30);
            this.label_stade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stade.Name = "label_stade";
            this.label_stade.Size = new System.Drawing.Size(35, 13);
            this.label_stade.TabIndex = 14;
            this.label_stade.Text = "Stade";
            // 
            // label_arbitre_p
            // 
            this.label_arbitre_p.AutoSize = true;
            this.label_arbitre_p.Location = new System.Drawing.Point(12, 82);
            this.label_arbitre_p.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_arbitre_p.Name = "label_arbitre_p";
            this.label_arbitre_p.Size = new System.Drawing.Size(79, 13);
            this.label_arbitre_p.TabIndex = 15;
            this.label_arbitre_p.Text = "Arbitre principal";
            // 
            // label_arb_r
            // 
            this.label_arb_r.AutoSize = true;
            this.label_arb_r.Location = new System.Drawing.Point(13, 132);
            this.label_arb_r.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_arb_r.Name = "label_arb_r";
            this.label_arb_r.Size = new System.Drawing.Size(64, 13);
            this.label_arb_r.TabIndex = 16;
            this.label_arb_r.Text = "Remplaçant";
            // 
            // label_arb_t
            // 
            this.label_arb_t.AutoSize = true;
            this.label_arb_t.Location = new System.Drawing.Point(13, 207);
            this.label_arb_t.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_arb_t.Name = "label_arb_t";
            this.label_arb_t.Size = new System.Drawing.Size(93, 13);
            this.label_arb_t.TabIndex = 17;
            this.label_arb_t.Text = "Arbitres de touche";
            // 
            // m_arb_princ
            // 
            this.m_arb_princ.AutoSize = true;
            this.m_arb_princ.Location = new System.Drawing.Point(68, 11);
            this.m_arb_princ.Margin = new System.Windows.Forms.Padding(2);
            this.m_arb_princ.Name = "m_arb_princ";
            this.m_arb_princ.Size = new System.Drawing.Size(34, 17);
            this.m_arb_princ.TabIndex = 18;
            this.m_arb_princ.TabStop = true;
            this.m_arb_princ.Text = "M";
            this.m_arb_princ.UseVisualStyleBackColor = true;
            // 
            // mme_arb_princ
            // 
            this.mme_arb_princ.AutoSize = true;
            this.mme_arb_princ.Location = new System.Drawing.Point(126, 11);
            this.mme_arb_princ.Margin = new System.Windows.Forms.Padding(2);
            this.mme_arb_princ.Name = "mme_arb_princ";
            this.mme_arb_princ.Size = new System.Drawing.Size(48, 17);
            this.mme_arb_princ.TabIndex = 19;
            this.mme_arb_princ.TabStop = true;
            this.mme_arb_princ.Text = "Mme";
            this.mme_arb_princ.UseVisualStyleBackColor = true;
            // 
            // m_arb_remp
            // 
            this.m_arb_remp.AutoSize = true;
            this.m_arb_remp.Location = new System.Drawing.Point(62, 9);
            this.m_arb_remp.Margin = new System.Windows.Forms.Padding(2);
            this.m_arb_remp.Name = "m_arb_remp";
            this.m_arb_remp.Size = new System.Drawing.Size(34, 17);
            this.m_arb_remp.TabIndex = 20;
            this.m_arb_remp.TabStop = true;
            this.m_arb_remp.Text = "M";
            this.m_arb_remp.UseVisualStyleBackColor = true;
            // 
            // mme_arb_remp
            // 
            this.mme_arb_remp.AutoSize = true;
            this.mme_arb_remp.Location = new System.Drawing.Point(126, 9);
            this.mme_arb_remp.Margin = new System.Windows.Forms.Padding(2);
            this.mme_arb_remp.Name = "mme_arb_remp";
            this.mme_arb_remp.Size = new System.Drawing.Size(48, 17);
            this.mme_arb_remp.TabIndex = 21;
            this.mme_arb_remp.TabStop = true;
            this.mme_arb_remp.Text = "Mme";
            this.mme_arb_remp.UseVisualStyleBackColor = true;
            // 
            // m_arb_touche_1
            // 
            this.m_arb_touche_1.AutoSize = true;
            this.m_arb_touche_1.Location = new System.Drawing.Point(62, 10);
            this.m_arb_touche_1.Margin = new System.Windows.Forms.Padding(2);
            this.m_arb_touche_1.Name = "m_arb_touche_1";
            this.m_arb_touche_1.Size = new System.Drawing.Size(34, 17);
            this.m_arb_touche_1.TabIndex = 22;
            this.m_arb_touche_1.TabStop = true;
            this.m_arb_touche_1.Text = "M";
            this.m_arb_touche_1.UseVisualStyleBackColor = true;
            // 
            // mme_arbitre_touche_1
            // 
            this.mme_arbitre_touche_1.AutoSize = true;
            this.mme_arbitre_touche_1.Location = new System.Drawing.Point(126, 11);
            this.mme_arbitre_touche_1.Margin = new System.Windows.Forms.Padding(2);
            this.mme_arbitre_touche_1.Name = "mme_arbitre_touche_1";
            this.mme_arbitre_touche_1.Size = new System.Drawing.Size(48, 17);
            this.mme_arbitre_touche_1.TabIndex = 23;
            this.mme_arbitre_touche_1.TabStop = true;
            this.mme_arbitre_touche_1.Text = "Mme";
            this.mme_arbitre_touche_1.UseVisualStyleBackColor = true;
            // 
            // m_arbitre_touche_2
            // 
            this.m_arbitre_touche_2.AutoSize = true;
            this.m_arbitre_touche_2.Location = new System.Drawing.Point(62, 10);
            this.m_arbitre_touche_2.Margin = new System.Windows.Forms.Padding(2);
            this.m_arbitre_touche_2.Name = "m_arbitre_touche_2";
            this.m_arbitre_touche_2.Size = new System.Drawing.Size(34, 17);
            this.m_arbitre_touche_2.TabIndex = 24;
            this.m_arbitre_touche_2.TabStop = true;
            this.m_arbitre_touche_2.Text = "M";
            this.m_arbitre_touche_2.UseVisualStyleBackColor = true;
            // 
            // mme_arbitre_touche_2
            // 
            this.mme_arbitre_touche_2.AutoSize = true;
            this.mme_arbitre_touche_2.Location = new System.Drawing.Point(126, 9);
            this.mme_arbitre_touche_2.Margin = new System.Windows.Forms.Padding(2);
            this.mme_arbitre_touche_2.Name = "mme_arbitre_touche_2";
            this.mme_arbitre_touche_2.Size = new System.Drawing.Size(48, 17);
            this.mme_arbitre_touche_2.TabIndex = 25;
            this.mme_arbitre_touche_2.TabStop = true;
            this.mme_arbitre_touche_2.Text = "Mme";
            this.mme_arbitre_touche_2.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(840, 275);
            this.Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(73, 33);
            this.Confirm.TabIndex = 26;
            this.Confirm.Text = "Confirmer";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // labeal_dispo_locaux
            // 
            this.labeal_dispo_locaux.AutoSize = true;
            this.labeal_dispo_locaux.Location = new System.Drawing.Point(361, 86);
            this.labeal_dispo_locaux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeal_dispo_locaux.Name = "labeal_dispo_locaux";
            this.labeal_dispo_locaux.Size = new System.Drawing.Size(49, 13);
            this.labeal_dispo_locaux.TabIndex = 27;
            this.labeal_dispo_locaux.Text = "Dispositif";
            // 
            // label_dispo_ext
            // 
            this.label_dispo_ext.AutoSize = true;
            this.label_dispo_ext.Location = new System.Drawing.Point(529, 86);
            this.label_dispo_ext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dispo_ext.Name = "label_dispo_ext";
            this.label_dispo_ext.Size = new System.Drawing.Size(49, 13);
            this.label_dispo_ext.TabIndex = 28;
            this.label_dispo_ext.Text = "Dispositif";
            // 
            // champ
            // 
            this.champ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.champ.FormattingEnabled = true;
            this.champ.Items.AddRange(new object[] {
            "Ligue 1",
            "Premier League",
            "Bundesliga",
            "BBVA espagnole"});
            this.champ.Location = new System.Drawing.Point(145, 46);
            this.champ.Margin = new System.Windows.Forms.Padding(2);
            this.champ.Name = "champ";
            this.champ.Size = new System.Drawing.Size(109, 21);
            this.champ.TabIndex = 29;
            this.champ.SelectedIndexChanged += new System.EventHandler(this.champ_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Championnat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mme_arb_princ);
            this.groupBox1.Controls.Add(this.m_arb_princ);
            this.groupBox1.Location = new System.Drawing.Point(7, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 32);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civilité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mme_arb_remp);
            this.groupBox2.Controls.Add(this.m_arb_remp);
            this.groupBox2.Location = new System.Drawing.Point(8, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(175, 32);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Civilité";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mme_arbitre_touche_1);
            this.groupBox3.Controls.Add(this.m_arb_touche_1);
            this.groupBox3.Location = new System.Drawing.Point(6, 222);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(175, 33);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Civilité";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mme_arbitre_touche_2);
            this.groupBox4.Controls.Add(this.m_arbitre_touche_2);
            this.groupBox4.Location = new System.Drawing.Point(7, 271);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(175, 33);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Civilité";
            // 
            // calendrier_date
            // 
            this.calendrier_date.Location = new System.Drawing.Point(679, 58);
            this.calendrier_date.Name = "calendrier_date";
            this.calendrier_date.TabIndex = 35;
            this.calendrier_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_date_DateChanged);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(831, 12);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 36;
            this.help.Text = "Aide";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // fenetre1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 319);
            this.Controls.Add(this.help);
            this.Controls.Add(this.calendrier_date);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.champ);
            this.Controls.Add(this.label_dispo_ext);
            this.Controls.Add(this.labeal_dispo_locaux);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label_arb_t);
            this.Controls.Add(this.label_arb_r);
            this.Controls.Add(this.label_arbitre_p);
            this.Controls.Add(this.label_stade);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_select_ext);
            this.Controls.Add(this.label_select_loc);
            this.Controls.Add(this.equipe_visiteurs);
            this.Controls.Add(this.equipe_locaux);
            this.Controls.Add(this.dispositif_visiteurs);
            this.Controls.Add(this.dispositif_locaux);
            this.Controls.Add(this.nom_arbitre_touche_1);
            this.Controls.Add(this.nom_arbitre_touche_2);
            this.Controls.Add(this.nom_arbitre_remplaçant);
            this.Controls.Add(this.nom_arbitre_prinicpal);
            this.Controls.Add(this.stade);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fenetre1";
            this.Text = "Informations à remplir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stade;
        private System.Windows.Forms.TextBox nom_arbitre_prinicpal;
        private System.Windows.Forms.TextBox nom_arbitre_remplaçant;
        private System.Windows.Forms.TextBox nom_arbitre_touche_2;
        private System.Windows.Forms.TextBox nom_arbitre_touche_1;
        private System.Windows.Forms.ListBox dispositif_locaux;
        private System.Windows.Forms.ListBox dispositif_visiteurs;
        private System.Windows.Forms.ComboBox equipe_locaux;
        private System.Windows.Forms.ComboBox equipe_visiteurs;
        private System.Windows.Forms.Label label_select_loc;
        private System.Windows.Forms.Label label_select_ext;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_stade;
        private System.Windows.Forms.Label label_arbitre_p;
        private System.Windows.Forms.Label label_arb_r;
        private System.Windows.Forms.Label label_arb_t;
        private System.Windows.Forms.RadioButton m_arb_princ;
        private System.Windows.Forms.RadioButton mme_arb_princ;
        private System.Windows.Forms.RadioButton m_arb_remp;
        private System.Windows.Forms.RadioButton mme_arb_remp;
        private System.Windows.Forms.RadioButton m_arb_touche_1;
        private System.Windows.Forms.RadioButton mme_arbitre_touche_1;
        private System.Windows.Forms.RadioButton m_arbitre_touche_2;
        private System.Windows.Forms.RadioButton mme_arbitre_touche_2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label labeal_dispo_locaux;
        private System.Windows.Forms.Label label_dispo_ext;
        private System.Windows.Forms.ComboBox champ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MonthCalendar calendrier_date;
        private System.Windows.Forms.Button help;
    }
}

