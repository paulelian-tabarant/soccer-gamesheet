using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_fdm
{
    public partial class capitaine : Form
    {
        public capitaine()
        {
            InitializeComponent();

            string ext = Program.eq_exterieur.GetName(true);
            string loc = Program.eq_domicile.GetName(true);
            eq_ext.Text = ext;
            eq_loc.Text = loc;

            int i = 0;
            int k = 0;
            string titu_loc;
            while (i < 11)
            {
                titu_loc = Program.eq_domicile.titulaires[i].GetName();
                list_joueurs.Items.Add(titu_loc);
                i++;
            }
            string titu_ext;
            while (k < 11)
            {
                titu_ext = Program.eq_exterieur.titulaires[k].GetName();
                list_joueurs_ext.Items.Add(titu_ext);
                k++;
            }
            
        }

        private void list_joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(list_joueurs.Text) || string.IsNullOrEmpty(list_joueurs_ext.Text)) add_cpt.Enabled = false;
            else add_cpt.Enabled = true;
                
        }

        private void add_cpt_Click(object sender, EventArgs e)
        {
            int i = list_joueurs.SelectedIndex;
            Program.eq_domicile.titulaires[i].MettreCapitaine();

            int j = list_joueurs_ext.SelectedIndex;
            Program.eq_exterieur.titulaires[j].MettreCapitaine();

            fenetre3 pdt_match = new fenetre3();
            pdt_match.Show();
            this.Hide();
            this.Close();
        }

        private void list_joueurs_ext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(list_joueurs.Text) || string.IsNullOrEmpty(list_joueurs_ext.Text)) add_cpt.Enabled = false;
            else add_cpt.Enabled = true;
        }
        
        private void capitaine_Load(object sender, EventArgs e)
        {

        }
    }
}
