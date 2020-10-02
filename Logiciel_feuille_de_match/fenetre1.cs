using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel; //INTEROP

namespace Logiciel_fdm
{
    public partial class fenetre1 : Form
    {
        public fenetre1()
        {
            InitializeComponent();
            Program.Excel = new GestionExcel();
            Program.Excel.OuvrirFichierExistant(chemin.championnats); //Ouvre championnats.xlsx
        }

        #region Informations d'avant-match

        //Calendrier permettant de choisir la date 
        private void calendrier_date_DateChanged(object sender, DateRangeEventArgs e)
        {
            label_date.Text = calendrier_date.SelectionRange.Start.ToShortDateString(); //On récupère la date dans le label prévu à cet effet
        }

        //Contrôle à la saisie sur les TextBox (éviter caractères spéciaux, chiffres etc)
        private void Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)) //Permission de saisie uniquement : lettres, caractères de contrôle (effacer par ex) et barre d'espace
            {
                e.Handled = true; //On considère l'événement géré et donc l'écriture du caractère dans la box n'est pas effectuée
            }
        }

        //Retourne la civilité à partir de deux CheckBox M et Mme
        public string GetCivilite(RadioButton r1, RadioButton r2)
        {
            string civilite;
            if (r1.Checked)
                civilite = r1.Text;
            else
                civilite = r2.Text;
            return civilite;
        }

        #endregion 
        
        #region Sélection des équipes 

        private void champ_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipe_locaux.Items.Clear();
            equipe_visiteurs.Items.Clear();

            Program.Excel.ChangerDeFeuilleActive(champ.Text); //Va sur la feuille du championnat sélectionné
            string equipe = null;
            bool fin = false;
            UInt16 i = 1;
            while (!fin)
            {
                equipe = Program.Excel.LireCellule(i, 1);
                equipe_locaux.Items.Add(equipe);
                equipe_visiteurs.Items.Add(equipe);
                if (Program.Excel.LireCellule(i + 1, 1) == null)
                    fin = true;
                i++;
            }
        }

        private void equipe_visiteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (equipe_visiteurs.Text == equipe_locaux.Text) MessageBox.Show("Selectionnez des équipes différentes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void equipe_locaux_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (equipe_visiteurs.Text == equipe_locaux.Text) MessageBox.Show("Selectionnez des équipes différentes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion 

        #region Confirmation des informations et écriture des premières infos dans la feuille de match
        //CONFIRMATION   

        private bool Verif(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h)
        {
            bool Empt;
            Empt = (a || b) && (c || d) && (e || f) && (g || h); //Faux si aucune des cases n'est cochée pour l'un des formulaires de civilité
            return Empt;
        }



        private void Confirm_Click(object sender, EventArgs e)
        {
            bool vrf; //Vrai si cases toutes cochées

            vrf = Verif(mme_arbitre_touche_1.Checked, m_arb_touche_1.Checked, mme_arbitre_touche_2.Checked, m_arbitre_touche_2.Checked, mme_arb_princ.Checked, m_arb_princ.Checked, mme_arb_remp.Checked, m_arb_remp.Checked);

            if (string.IsNullOrEmpty(stade.Text) || string.IsNullOrEmpty(dispositif_locaux.Text) || string.IsNullOrEmpty(dispositif_visiteurs.Text) || string.IsNullOrEmpty(equipe_locaux.Text) || string.IsNullOrEmpty(equipe_visiteurs.Text) || string.IsNullOrEmpty(nom_arbitre_prinicpal.Text) || string.IsNullOrEmpty(nom_arbitre_remplaçant.Text) || string.IsNullOrEmpty(nom_arbitre_touche_1.Text) || string.IsNullOrEmpty(nom_arbitre_touche_2.Text) || vrf == false || equipe_locaux.Text == equipe_visiteurs.Text)
            {
                MessageBox.Show("Erreur, vérifiez vos saisies", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Program.Excel.FermerWoorkBook(false); //Fermeture du fichier "championnats.xlsx"
                fenetre2 f2 = new fenetre2(equipe_locaux.Text, equipe_visiteurs.Text, dispositif_locaux.Text, dispositif_visiteurs.Text);
                f2.Show();
                this.Hide();
                //On commence à récupérer les premières infos pour la feuille de match
                string arb_princ = GetCivilite(m_arb_princ, mme_arb_princ) + ". " + nom_arbitre_prinicpal.Text;
                string arb_remp = GetCivilite(m_arb_remp, mme_arb_remp) + ". " + nom_arbitre_remplaçant.Text;
                string arb_touche1 = GetCivilite(m_arb_touche_1, mme_arbitre_touche_1) + ". " + nom_arbitre_touche_1.Text;
                string arb_touche2 = GetCivilite(m_arbitre_touche_2, mme_arbitre_touche_2) + ". " + nom_arbitre_touche_2.Text;
                DateTime date = calendrier_date.SelectionStart;
                Program.fdm = new FeuilleDeMatch(stade.Text, arb_princ, arb_remp, arb_touche1, arb_touche2, date, champ.Text); //Enregistrement des premières infos pour la feuille de match
            }

        }
        #endregion 

        //Bouton d'aide
        private void help_Click(object sender, EventArgs e)
        {
            string aide_présentation = "Cette fenêtre vous permet de saisir différentes informations sur le match :\r\n";
            string aide_liste = "- Le championnat \r\n- Les deux équipes \r\n- Les noms des arbitres et leur civilité \r\n- Le stade \r\n- Le dispositif pour chaque équipe\r\n\n";
            string aide_complement = "Vous devez renseigner tous les éléments avant de passer à la fenêtre suivante.";
            string aide = aide_présentation + aide_liste + aide_complement;
            MessageBox.Show(aide, "Aide");
        }

        private void fenetre1_Load(object sender, EventArgs e)
        {

        }
    }
}