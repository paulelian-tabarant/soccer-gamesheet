namespace Logiciel_fdm
{
    partial class capitaine
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
            this.list_joueurs = new System.Windows.Forms.ListBox();
            this.add_cpt = new System.Windows.Forms.Button();
            this.list_joueurs_ext = new System.Windows.Forms.ListBox();
            this.eq_loc = new System.Windows.Forms.Label();
            this.eq_ext = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_joueurs
            // 
            this.list_joueurs.FormattingEnabled = true;
            this.list_joueurs.Location = new System.Drawing.Point(12, 55);
            this.list_joueurs.Name = "list_joueurs";
            this.list_joueurs.Size = new System.Drawing.Size(217, 329);
            this.list_joueurs.TabIndex = 0;
            this.list_joueurs.SelectedIndexChanged += new System.EventHandler(this.list_joueurs_SelectedIndexChanged);
            // 
            // add_cpt
            // 
            this.add_cpt.Enabled = false;
            this.add_cpt.Location = new System.Drawing.Point(505, 361);
            this.add_cpt.Name = "add_cpt";
            this.add_cpt.Size = new System.Drawing.Size(75, 23);
            this.add_cpt.TabIndex = 1;
            this.add_cpt.Text = "Valider";
            this.add_cpt.UseVisualStyleBackColor = true;
            this.add_cpt.Click += new System.EventHandler(this.add_cpt_Click);
            // 
            // list_joueurs_ext
            // 
            this.list_joueurs_ext.FormattingEnabled = true;
            this.list_joueurs_ext.Location = new System.Drawing.Point(267, 55);
            this.list_joueurs_ext.Name = "list_joueurs_ext";
            this.list_joueurs_ext.Size = new System.Drawing.Size(217, 329);
            this.list_joueurs_ext.TabIndex = 2;
            this.list_joueurs_ext.SelectedIndexChanged += new System.EventHandler(this.list_joueurs_ext_SelectedIndexChanged);
            // 
            // eq_loc
            // 
            this.eq_loc.AutoSize = true;
            this.eq_loc.Location = new System.Drawing.Point(12, 39);
            this.eq_loc.Name = "eq_loc";
            this.eq_loc.Size = new System.Drawing.Size(35, 13);
            this.eq_loc.TabIndex = 3;
            this.eq_loc.Text = "label1";
            // 
            // eq_ext
            // 
            this.eq_ext.AutoSize = true;
            this.eq_ext.Location = new System.Drawing.Point(267, 39);
            this.eq_ext.Name = "eq_ext";
            this.eq_ext.Size = new System.Drawing.Size(35, 13);
            this.eq_ext.TabIndex = 4;
            this.eq_ext.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choisissez le capitaine de chaque équipe";
            // 
            // capitaine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eq_ext);
            this.Controls.Add(this.eq_loc);
            this.Controls.Add(this.list_joueurs_ext);
            this.Controls.Add(this.add_cpt);
            this.Controls.Add(this.list_joueurs);
            this.Name = "capitaine";
            this.Text = "capitaine";
            this.Load += new System.EventHandler(this.capitaine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_joueurs;
        private System.Windows.Forms.Button add_cpt;
        private System.Windows.Forms.ListBox list_joueurs_ext;
        private System.Windows.Forms.Label eq_loc;
        private System.Windows.Forms.Label eq_ext;
        private System.Windows.Forms.Label label3;
    }
}