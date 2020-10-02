using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Pour utiliser la méthode GetParent

namespace Logiciel_fdm
{
    public partial class fenetre2 : Form
    {
        //Variables statiques pour repérer combien de postes sur les 11 ont été affectés
        static UInt16 i_domicile = 1;
        static UInt16 i_ext = 1;
       
        //Constructeur
        public fenetre2(string equipe_loc, string equipe_ext, string dispo_loc, string dispo_ext)
        {
            InitializeComponent();

            Program.eq_domicile = new Equipe(equipe_loc, dispo_loc); //Objet équipe domicile créé
            Program.eq_exterieur = new Equipe(equipe_ext, dispo_ext); //Objet équipe extérieur créé

            //CHARGEMENT DES EFFECTIFS ET INITIALISATION DES 2 OBJETS REPRESENTANT LES 2 EQUIPES
            Program.Excel.OuvrirFichierExistant(chemin.effectifs, Program.eq_domicile.GetName(false));

            //Chargement des effectifs
            //Domicile
            bool fin = false;
            UInt16 i = 1;
            string nomjoueur;
            UInt16 numjoueur;
            while (!fin)
            {
                nomjoueur = Program.Excel.LireCellule(i, 2);
                numjoueur = UInt16.Parse(Program.Excel.LireCellule(i, 1));
                Joueurs_equipe_locaux.Items.Add(nomjoueur);
                remp_loc.Items.Add(nomjoueur);
                Program.eq_domicile.AddEffectif(nomjoueur, numjoueur); //Ajout du joueur dans l'effectif de l'équipe
                if (Program.Excel.LireCellule(i + 1, 2) == null)
                    fin = true;
                i++;
            }
            Program.eq_domicile.SetCoach(); //Entraîneur équipe domicile enregistré
  
            //Extérieur
            Program.Excel.ChangerDeFeuilleActive(Program.eq_exterieur.GetName(false));

            fin = false;
            i = 1;
            while (!fin)
            {
                nomjoueur = Program.Excel.LireCellule(i, 2);
                numjoueur = UInt16.Parse(Program.Excel.LireCellule(i, 1));
                Joueurs_equipe_ext.Items.Add(nomjoueur);
                remp_ext.Items.Add(nomjoueur);
                Program.eq_exterieur.AddEffectif(nomjoueur, numjoueur); //Ajout du joueur dans l'effectif de l'équipe
                if (Program.Excel.LireCellule(i + 1, 2) == null)
                    fin = true;
                i++;
            }
            Program.eq_exterieur.SetCoach(); //Entraîneur équipe extérieur enregistré

            //FERMETURE DE L'EXCEL DES EFFECTIFS
            Program.Excel.FermerWoorkBook();

            //CHARGEMENT DES LOGOS
            logo_loc.Image = System.Drawing.Image.FromFile(chemin.logos + Program.eq_domicile.GetName(false) + ".jpg");
            logo_ext.Image = System.Drawing.Image.FromFile(chemin.logos + Program.eq_exterieur.GetName(false) + ".jpg");
            logo_loc.SizeMode = PictureBoxSizeMode.Zoom; //Ajustement de l'image
            logo_ext.SizeMode = PictureBoxSizeMode.Zoom;

            //CHARGEMENT DES DISPOSITIFS
            pictureBox_Dispo_Loc.Image = System.Drawing.Image.FromFile(chemin.images_dispositifs + Program.eq_domicile.GetDisp(false) + ".jpg");
            pictureBox_Dispo_Ext.Image = System.Drawing.Image.FromFile(chemin.images_dispositifs + Program.eq_exterieur.GetDisp(false) + ".jpg");
            pictureBox_Dispo_Loc.SizeMode = PictureBoxSizeMode.Zoom; //Ajustement de l'image 
            pictureBox_Dispo_Ext.SizeMode = PictureBoxSizeMode.Zoom;

            //Ouverture de l'Excel contenant les postes pour chaque dispositif + initialisation des 2 labels (texte du poste)

            //Domicile
            Program.Excel.OuvrirFichierExistant(chemin.dispositifs, Program.eq_domicile.GetDisp(false));
            labelPostesEq1.Text = Program.Excel.LireCellule(1, 1); //1er poste à affecter

            //Extérieur
            Program.Excel.ChangerDeFeuilleActive(Program.eq_exterieur.GetDisp(false));
            labelPostesEq2.Text = Program.Excel.LireCellule(1, 1);
        }

        #region Saisie des titulaires

        //Ajout d'un joueur dans la ListBox des titulaires (équipe domicile)
        private void add_joueurs_loc_Click(object sender, EventArgs e)
        {
            Program.Excel.ChangerDeFeuilleActive(Program.eq_domicile.GetDisp(false)); //Passage sur la feuille Excel du dispositif de l'équipe concernée
            if (string.IsNullOrEmpty(Joueurs_equipe_locaux.Text) || i_domicile>11) //Obligation de sélection d'un joueur et sélection d'un total de 11 joueurs
            {
                MessageBox.Show("Un joueur doit être sélectionné, et vous ne pouvez pas sélectionner plus de 11 titulaires.", "Ajout joueur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remp_loc.Items.Remove(Joueurs_equipe_locaux.Text);
                ListViewItem joueur_loc = new ListViewItem(Joueurs_equipe_locaux.Text);
                joueur_loc.SubItems.Add(labelPostesEq1.Text);
                listView1.Items.Add(joueur_loc);
                Joueurs_equipe_locaux.Items.Remove(Joueurs_equipe_locaux.Text);
                i_domicile++;
                labelPostesEq1.Text = Program.Excel.LireCellule(i_domicile, 1); //On lit le poste suivant dans le fichier Excel des dispositifs pour le mettre dans le label correspondant
            }   
        }

        //Ajout d'un joueur dans la ListBox des titulaires (équipe extérieur)
        private void add_joueurs_ext_Click(object sender, EventArgs e)
        {
            Program.Excel.ChangerDeFeuilleActive(Program.eq_exterieur.GetDisp(false)); //Passage sur la feuille Excel de l'équipe concernée
            if (string.IsNullOrEmpty(Joueurs_equipe_ext.Text) || i_ext >11) //Obligation de sélection d'un joueur et sélection d'un total de 11 joueurs
            {
                MessageBox.Show("Un joueur doit être sélectionné, et vous ne pouvez pas sélectionner plus de 11 titulaires.", "Ajout joueur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                remp_ext.Items.Remove(Joueurs_equipe_ext.Text);
                ListViewItem joueur_ext = new ListViewItem(Joueurs_equipe_ext.Text);
                joueur_ext.SubItems.Add(labelPostesEq2.Text);
                listView2.Items.Add(joueur_ext);
                Joueurs_equipe_ext.Items.Remove(Joueurs_equipe_ext.Text);
                i_ext++;
                labelPostesEq2.Text = Program.Excel.LireCellule(i_ext, 1);
            }   
        }

        //Annulation de la dernière affectation de poste à un joueur (équipe domicile)
        private void BoutonAnnulerEq1_Click(object sender, EventArgs e)
        {
            if (i_domicile > 1) //Au moins 1 joueur entré
            {
                Program.Excel.ChangerDeFeuilleActive(Program.eq_domicile.GetDisp(false)); //On se met sur la feuille du dispositif de l'équipe à domicile
                i_domicile--; //On revient au poste précédent dans le tableau
                labelPostesEq1.Text = Program.Excel.LireCellule(i_domicile, 1);
                Joueurs_equipe_locaux.Items.Add(listView1.Items[i_domicile - 1].SubItems[0].Text); //On remet dans la listbox le dernier joueur entré 
                remp_loc.Items.Add(listView1.Items[i_domicile - 1].SubItems[0].Text);
                listView1.Items.RemoveAt(i_domicile - 1);
            }
        }

        //Annulation de la dernière affectation de poste à un joueur (équipe extérieur)
        private void BoutonAnnulerEq2_Click(object sender, EventArgs e)
        {
            if (i_ext > 1)
            {
                Program.Excel.ChangerDeFeuilleActive(Program.eq_exterieur.GetDisp(false)); //Même raisonnement que pour domicile
                i_ext--;
                labelPostesEq2.Text = Program.Excel.LireCellule(i_ext, 1);
                Joueurs_equipe_ext.Items.Add(listView2.Items[i_ext - 1].SubItems[0].Text);
                remp_ext.Items.Add(listView2.Items[i_ext - 1].SubItems[0].Text);
                listView2.Items.RemoveAt(i_ext - 1);
            }
        }

        #endregion 

        #region Vérifications et confirmation des éléments

        //Vérification saisie cohérente des joueurs de l'équipe locale
        private bool verif_saisies_loc()
        {
            bool all_right;

            int nb_joueur = listView1.Items.Count;
            int nb_remp = remp_loc.CheckedItems.Count;

            if (nb_joueur == 11 && nb_remp == 7) all_right = true;//Si la listView1 contient 11 éléments (i.e 11 joueurs ont été ajoutés) et remp_loc contient 7 éléments (i.e 7 remplaçants ajoutés) alors la saisie est correcte
            else all_right = false;//Sinon la saisie est incorrecte                

            return all_right;                  
        }

        //Vérification saisie cohérente des joueurs de l'équipe extérieur
        private bool verif_saisies_ext()
        {
            bool all_right;

            int nb_joueur = listView2.Items.Count;
            int nb_remp = remp_ext.CheckedItems.Count;

            if (nb_joueur == 11 && nb_remp == 7) all_right = true;
            else all_right = false;

            return all_right;
        }

        //Lorsque la personne valide ses saisies pour l'équipe domicile
        private void Validation_domicile_Click(object sender, EventArgs e)
        {
            bool dispo_check = verif_saisies_loc();//Appel à la fonction de vérification de saisie de l'équipe locale 

            if (dispo_check)//Si le booléen est vrai (i.e paramètres renseignés correctes), alors on désactive les controles pour éviter des modifications inexactes
            {
                MessageBox.Show("La saisie des paramètres de l'équipe locale a bien été faite", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_joueurs_loc.Enabled = false;
                BoutonAnnulerEq1.Enabled = false;
                remp_loc.Enabled = false;
                bool local, exterieur;
                local = verif_saisies_loc();
                exterieur = verif_saisies_ext();
                if (local == true && exterieur == true && remp_ext.Enabled == false) Confirmer.Enabled = true;//Si et seulement si les deux effectifs ont été correctement renseignés, on active le bouton pour passer à la fenetre suivante
                else Confirmer.Enabled = false;
            }
            else MessageBox.Show("Vérifiez votre saisie (11 joueurs ajoutés et 7 remplaçants séléctionnés)", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Lorsque la personne valide ses saisies pour l'équipe extérieur
        private void Validation_exterieur_Click(object sender, EventArgs e)
        {
            bool dispo_check = verif_saisies_ext();

            if (dispo_check)
            {
                MessageBox.Show("La saisie des paramètres de l'équipe locale a bien été faite", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                add_joueurs_ext.Enabled = false;
                BoutonAnnulerEq2.Enabled = false;
                remp_ext.Enabled = false;
                bool local, exterieur;
                local = verif_saisies_loc();
                exterieur = verif_saisies_ext();
                if (local == true && exterieur == true && remp_loc.Enabled == false) Confirmer.Enabled = true;
                else Confirmer.Enabled = false;
            }
            else MessageBox.Show("Vérifiez votre saisie (11 joueurs ajoutés et 7 remplaçants séléctionnés)", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Confirmation de l'ensemble des saisies faites sur la fenêtre et enregistrement en mémoire des informations
        private void Confirmer_Click(object sender, EventArgs e)
        {
            //Equipe domicile

            //Titulaires
            UInt16 i = 0;
            foreach (ListViewItem joueur in listView1.Items) //Pour chaque joueur ajouté dans la listView de l'équipe domicile
            {
                Program.eq_domicile.MettreTitulaire(joueur.SubItems[0].Text, i, joueur.SubItems[1].Text); //SubItems0 : nom, SubItems1 : poste
                i++;
            }

            //Remplaçants
            i = 0;
            CheckedListBox.CheckedItemCollection remplaçants = remp_loc.CheckedItems; //Pour chaque joueur ajouté dans la listView de l'équipe domicile
            foreach(object itemChecked in remp_loc.CheckedItems)
            {
                Program.eq_domicile.AjouterRemplaçant(itemChecked.ToString(), i);
                i++;
            }

            

            //Equipe extérieur

            //Titulaires
            i = 0;
            foreach (ListViewItem joueur in listView2.Items) //Pour chaque joueur ajouté dans la listView de l'équipe extérieur
            {
                Program.eq_exterieur.MettreTitulaire(joueur.SubItems[0].Text, i, joueur.SubItems[1].Text); //SubItems0 : nom, SubItems1 : poste
                i++;
            }

            //Remplaçants
            i = 0;
            remplaçants = remp_ext.CheckedItems;
            foreach (object itemChecked in remp_ext.CheckedItems)
            {
                Program.eq_exterieur.AjouterRemplaçant(itemChecked.ToString(), i);
                i++;
            }
            capitaine ch_cap_loc = new capitaine();
            ch_cap_loc.Show();

            Program.Excel.FermerWoorkBook(false); //On ferme le fichier Excel des dispositifs
            Program.Excel.QuitterXl(false); 

            this.Hide();
            this.Close();
        }

        #endregion 

        private void help_Click(object sender, EventArgs e)
        {
            //Elements apportés par le bouton d'aide
            string aide_présentation = "Cette fenêtre vous permet de saisir les informations sur la composition des équipes. Pour chaque équipe vous devez choisir :\r\n";
            string aide_liste = "- Les remplaçants en cochant les noms correspondant \r\n- Les titulaires. Pour ce faire, vous devez selectionner le joueur correspondant au poste qui s'affiche à coté du logo de l'équipe (cf. dispositif affiché sur le terrain).\r\n\n";
            string aide_add = "Vous devez valider votre saisie pour chaque équipe en cliquant sur ''Valider''.\r\n\n";
            string aide_del = "En cas d'erreur de saisie d'un titulaire, vous avez la possibilité d'annuler la saisie précédent en cliquant sur le bouton d'annulation (croix rouge).\r\n";
            string aide = aide_présentation + aide_liste + aide_add + aide_del;
            MessageBox.Show(aide, "Aide");
        }

        private void fenetre2_Load(object sender, EventArgs e)
        {

        }
    }
}
