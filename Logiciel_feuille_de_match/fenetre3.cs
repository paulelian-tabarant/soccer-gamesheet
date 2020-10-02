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
    public partial class fenetre3 : Form
    {
        static int type_f = 0;//Prend 9 valeurs selon l'action   (ex : 1= carton jaune)      

        //Variables chronomètre
        static int compteur = 0;
        static int min = 0;
        static int sec_add = 0;
        static int min_add = 0;
        static bool temps_add_1mt = false;

        //Constructeur
        public fenetre3()
        {
            InitializeComponent();

            //Chargement image de changement (flèches en rotation) sur la fenêtre
            string name_picture = "chgt_clic";
            chgt_loc_clic.Image = System.Drawing.Image.FromFile(chemin.logos + name_picture + ".jpg");
            chgt_loc_clic.SizeMode = PictureBoxSizeMode.Zoom; //Ajustement de l'image)

            chgt_ext_clic.Image = System.Drawing.Image.FromFile(chemin.logos + name_picture + ".jpg");
            chgt_ext_clic.SizeMode = PictureBoxSizeMode.Zoom; //Ajustement de l'image)

            //Initialisation chronomètre
            time.Interval = 1;//Toutes les 10 ms les commandes dans la méthode time s'exécute : mettre 1s pour un déroulement réel du match
            time.Start();//Demarrage du chrono
            minutes.Text = "0";
            sec.Text = "0";

            label_sec_add.Text = ":  0";
            label_min_add.Text = "0";

            //INITIALISATION DES PARAMETRES  (actions et joueurs)             

            //LOCAUX
            
            string equipe_locale = Program.eq_domicile.GetName(false);
            //Chargement image           
            logo_loc.Image = System.Drawing.Image.FromFile(chemin.logos + equipe_locale + ".jpg");
            logo_loc.SizeMode = PictureBoxSizeMode.Zoom;


            //Affichage titulaires
            string titu_loc;
            for (UInt16 i = 0; i < 11; i++)
            {
                titu_loc = Program.eq_domicile.titulaires[i].GetName();
                effectif_loc.Items.Add(titu_loc);
            }

            //Affichage remplaçants
            string rempl_loc;
            for (UInt16 i = 0; i < 7; i++)
            {
                rempl_loc = Program.eq_domicile.remplaçants[i].GetName();
                list_remp_loc.Items.Add(rempl_loc);
            }
            
            score_loc.Text = "0";//On affiche le score (à l'ouvertue à sa valeure initiale soit 0)

            equipe_loc.Text = Program.eq_domicile.GetName(true);//On affiche le nom de l'équipe sous le logo
            //A l'ouverture de la fenetre, ces éléments ne doivent pas etre activés
            effectif_loc.Enabled = false;
            list_remp_loc.Enabled = false;
            end.Enabled = false;
            
          

            //EXTERIEUR
            string equipe_exterieur = Program.eq_exterieur.GetName(false);
            //Chargement image
            logo_ext.Image = System.Drawing.Image.FromFile(chemin.logos + equipe_exterieur + ".jpg");
            logo_ext.SizeMode = PictureBoxSizeMode.Zoom;


            //Affichage titulaires
            string titu_ext;
            for (UInt16 i = 0; i < 11; i++)
            {
                titu_ext = Program.eq_exterieur.titulaires[i].GetName();
                effectif_ext.Items.Add(titu_ext);
            }

            //Affichage remplaçants
            string rempl_ext;
            for (UInt16 i = 0; i < 7; i++)
            {
                rempl_ext = Program.eq_exterieur.remplaçants[i].GetName();
                list_remp_ext.Items.Add(rempl_ext);
            }

            score_ext.Text = "0";//On affiche le score (à l'ouvertue à sa valeure initiale soit 0)

            equipe_ext.Text = Program.eq_exterieur.GetName(true);//On affiche le nom de l'équipe sous le logo

            //A l'ouverture de la fenetre, ces éléments ne doivent pas etre activés
            effectif_ext.Enabled = false;
            list_remp_ext.Enabled = false;    
      
            add_action_ext.Enabled = false;
        }

        //FIN DE L'INITIALISATION DE LA FENETRE

        #region Boutons d'action 
        //GESTION SELECTION TYPE D'ACTIONS 
       
        private void cart_j_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;//On active la liste des joueurs pour pouvoir les séléctionner
            effectif_loc.Enabled = true;
            //Elements désactivés pour éviter que l'utilisateur ne change d'action
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 1;
        }

        private void cart_r_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_j_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 2;
        }

        private void but_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 3;
        }

        private void HJ_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 4;
        }

        private void coup_franc_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 5;
        }

        private void peno_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 6;
        }

        private void corner_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            faute_ext.Enabled = false;
            remp_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;

            type_f = 7;
        }

        private void faute_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            list_remp_ext.Enabled = false;
            list_remp_loc.Enabled = false;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            cart_j_ext.Enabled = false;
            remp_ext.Enabled = false;

            type_f = 8;
        }

        private void remp_Click(object sender, EventArgs e)
        {
            effectif_ext.Enabled = true;
            effectif_loc.Enabled = true;
            cart_r_ext.Enabled = false;
            but_ext.Enabled = false;
            HJ_ext.Enabled = false;
            coup_franc_ext.Enabled = false;
            peno_ext.Enabled = false;
            corner_ext.Enabled = false;
            faute_ext.Enabled = false;
            cart_j_ext.Enabled = false;

            type_f = 9;
        }

        //FIN GESTION SELECTION TYPE D'ACTION          
        #endregion 

        #region Sélection d'un joueur (effectif et remplaçants)

        private void effectif_loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_f != 9 && effectif_loc.Text != "")
            {
                add_action_ext.Enabled = true;
                effectif_ext.Enabled = false;
              
            }//Si l'action n'est pas un changement, on active le bouton de validation
            else//Sinon (action de changement) on active la liste des remplacants pour pouvoir les selectionner 
            {
                list_remp_loc.Enabled = true;
                effectif_loc.Enabled = false;
            }

        }

        private void effectif_ext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type_f != 9 && effectif_ext.Text != "")
            {
                add_action_ext.Enabled = true;
                effectif_loc.Enabled = false;
                                
            }//Si l'action n'est pas un changement, on active le bouton de validation
            else//Sinon (action de changement) on active la liste des remplacants pour pouvoir les selectionner 
            {
                list_remp_ext.Enabled = true;
                effectif_ext.Enabled = false;
            }
        }

        //FIN SELECTION D'UN JOUEUR (EFFECTIF ET REMPLACANTS)
        #endregion 

        #region Gestion des actions

        //Fonction gérant l'ajout d'une action à partir de l'entier associé à cette action (équipe domicile)
        private void ajout_action_domicile(int action)
        {
            bool ok = true;
            string min;
            ListViewItem liste_Action;
            if (!temps_add_1mt || label_min_add.Text == "0")//Si on n'est pas dans le temps additionnel, alors on affiche la minute de l'action
            {
                min = minutes.Text;
            }
            else 
            {
                min = "45 + " +label_min_add.Text;
              //Sinon on affiche 45 + la minute du temps additionnel
            }
            liste_Action = new ListViewItem(min);
            
            liste_Action.SubItems.Add(effectif_loc.Text);

                switch (type_f)//Selon l'action séléctionnée (valeur de type_f)
                {
                    case 1:

                        bool carton = Program.eq_domicile.ajouter_carton(effectif_loc.Text);
                        if ( carton == false)
                        {
                            MessageBox.Show("Vous avez déjà signalé un carton jaune pour ce joueur", "Erreur carton jaune", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ok = false;
                        }    
                        liste_Action.SubItems.Add("Carton jaune");
                        break;
                    case 2:
                        liste_Action.SubItems.Add("Carton rouge");
                        effectif_loc.Items.Remove(effectif_loc.Text);
                        break;
                    case 3:
                        liste_Action.SubItems.Add("But");
                        score_loc.Text = Program.eq_domicile.ajouter_but(min, effectif_loc.Text); //Ajout du but à la liste de l'équipe + actualisation du score
                        break;
                    case 4:
                        liste_Action.SubItems.Add("Hors-jeu");
                        break;
                    case 5:
                        liste_Action.SubItems.Add("Coup franc");
                        break;
                    case 6:
                        liste_Action.SubItems.Add("Penalty");
                        break;
                    case 7:
                        liste_Action.SubItems.Add("Corner");
                        break;
                    case 8:
                        liste_Action.SubItems.Add("Faute");
                        break;
                    case 9:
                        liste_Action.SubItems.Add("Remplacé par :" + list_remp_loc.Text);
                        bool succes = Program.eq_domicile.remplacement(list_remp_loc.Text, effectif_loc.Text); //On essaie de faire le remplacement
                        if (!succes) //Erreur si déjà 3 remplacements effectués
                        {
                            MessageBox.Show("Vous avez déjà signalé 3 remplacements pour cette équipe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ok = false;
                        }
                        break;

                }

            if(ok)
            {
                liste_Action.ForeColor = System.Drawing.Color.Blue;
                Actions.Items.Add(liste_Action);  
            }           
        }

        //Fonction gérant l'ajout d'une action à partir de l'entier associé à cette action (équipe extérieur)
        private void ajout_action_exterieur(int action)
        {
            bool ok = true; //Dans certains cas (remplacement alors qu'il y a déjà 3 remplacements dans l'équipe concernée), ok passe à "false" pour signifier que l'action ne peut pas être ajoutée.
            ListViewItem Action;
            string min;
            if (!temps_add_1mt || label_min_add.Text == "0")
            {
                min = minutes.Text;
            }
            else min = "45 + " + label_min_add.Text;

            Action = new ListViewItem(min);

            Action.SubItems.Add(effectif_ext.Text);

            switch (type_f)//Selon l'action séléctionnée (valeur de type_f)
            {
                case 1:
                    bool carton = Program.eq_exterieur.ajouter_carton(effectif_ext.Text);
                    if (carton == false)
                    {
                        MessageBox.Show("Vous avez déjà signalé un carton jaune pour ce joueur", "Erreur carton jaune", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ok = false;
                    }
                    Action.SubItems.Add("Carton jaune");
                    break;
                case 2:
                    Action.SubItems.Add("Carton rouge");
                    effectif_ext.Items.Remove(effectif_ext.Text);
                    break;
                case 3:
                    Action.SubItems.Add("But");
                    score_ext.Text = Program.eq_exterieur.ajouter_but(min, effectif_ext.Text);
                    break;
                case 4:
                    Action.SubItems.Add("Hors-jeu");
                    break;
                case 5:
                    Action.SubItems.Add("Coup franc");
                    break;
                case 6:
                    Action.SubItems.Add("Penalty");
                    break;
                case 7:
                    Action.SubItems.Add("Corner");
                    break;
                case 8:
                    Action.SubItems.Add("Faute");
                    break;
                case 9:
                    Action.SubItems.Add("Remplacé par :" + list_remp_ext.Text);
                    bool succes = Program.eq_exterieur.remplacement(list_remp_ext.Text, effectif_ext.Text);
                    if(!succes)
                    {
                        MessageBox.Show("Vous avez déjà signalé 3 remplacements pour cette équipe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ok = false;
                    }
                    break;

            }
            
            //Si l'on juge que l'action peut être ajoutée
            if(ok)
            {
                Action.ForeColor = System.Drawing.Color.Red;
                Actions.Items.Add(Action);
            }
        }         

        //Au clic sur le bouton de validation d'action
        private void valider_action_Click(object sender, EventArgs e)
        {
            if (effectif_ext.Text == "" && effectif_loc.Text != "")
            {
                ajout_action_domicile(type_f); //On gère l'action 
            }
            else if (effectif_loc.Text == "" && effectif_ext.Text != "")
            {
                ajout_action_exterieur(type_f);
            }

            //Pour remettre les controles permettant la saisie de la prochaine action
            effectif_loc.ClearSelected();
            effectif_ext.ClearSelected();
            effectif_loc.Enabled = false;
            list_remp_loc.Enabled = false;
            effectif_ext.Enabled = false;
            list_remp_ext.Enabled = false;
            effectif_loc.Enabled = false;
            list_remp_loc.Enabled = false;
            cart_j_ext.Enabled = true;
            cart_r_ext.Enabled = true;
            but_ext.Enabled = true;
            HJ_ext.Enabled = true;
            coup_franc_ext.Enabled = true;
            peno_ext.Enabled = true;
            corner_ext.Enabled = true;
            faute_ext.Enabled = true;
            remp_ext.Enabled = true;
            cart_r_ext.Enabled = true;
            add_action_ext.Enabled = false;
            

        }
          
        //Bouton pour annuler le choix d'une action en cours de sélection
        private void annuler_action_Click(object sender, EventArgs e)
        {
            add_action_ext.Enabled = false;
            //Tous les boutons d'actions se réaffichent
            cart_j_ext.Enabled = true;
            cart_r_ext.Enabled = true;
            but_ext.Enabled = true;
            HJ_ext.Enabled = true;
            coup_franc_ext.Enabled = true;
            peno_ext.Enabled = true;
            corner_ext.Enabled = true;
            faute_ext.Enabled = true;
            remp_ext.Enabled = true;
            cart_r_ext.Enabled = true;
            effectif_loc.Enabled = false;
            effectif_ext.Enabled = false;
        }

        //Clic sur l'image de changement (2 flèches qui tournent) - équipe domicile
        private void chgt_loc_Click(object sender, EventArgs e)
        {
            if (type_f == 9 && (string.IsNullOrEmpty(effectif_loc.Text)) || string.IsNullOrEmpty(list_remp_loc.Text))
            {
                MessageBox.Show("Selectionnez les joueur entrant et sortant");
            }
            else
            {
                
              
                cart_j_ext.Enabled = true;
                cart_r_ext.Enabled = true;
                but_ext.Enabled = true;
                HJ_ext.Enabled = true;
                coup_franc_ext.Enabled = true;
                peno_ext.Enabled = true;
                corner_ext.Enabled = true;
                faute_ext.Enabled = true;
                remp_ext.Enabled = true;
                cart_r_ext.Enabled = true;

                string sortant = effectif_loc.Text;
                string entrant = list_remp_loc.Text;

                ajout_action_domicile(type_f);
                

                //Modification des listes de joueurs
                effectif_loc.Items[effectif_loc.SelectedIndex] = entrant;
                list_remp_loc.Items.Remove(entrant);

                list_remp_loc.ClearSelected();
                effectif_loc.ClearSelected();
                add_action_ext.Enabled = false;
                effectif_loc.Enabled = false;
                list_remp_ext.Enabled = false;
                list_remp_loc.Enabled = false;
                effectif_ext.Enabled = false;
            }
        }

        //Clic sur l'image de changement (2 flèches qui tournent) - équipe extérieur
        private void chgt_ext_Click(object sender, EventArgs e)
        {
            if (type_f == 9 && (string.IsNullOrEmpty(effectif_ext.Text)) || string.IsNullOrEmpty(list_remp_ext.Text))
            {
                MessageBox.Show("Selectionnez les joueur entrant et sortant");
            }
            else
            {
                
               
                add_action_ext.Enabled = false;
                
                cart_j_ext.Enabled = true;
                cart_r_ext.Enabled = true;
                but_ext.Enabled = true;
                HJ_ext.Enabled = true;
                coup_franc_ext.Enabled = true;
                peno_ext.Enabled = true;
                corner_ext.Enabled = true;
                faute_ext.Enabled = true;
                remp_ext.Enabled = true;
                cart_r_ext.Enabled = true;

                string sortant = effectif_ext.Text;
                string entrant = list_remp_ext.Text;

                ajout_action_exterieur(type_f);
                

                //Modification des listes de joueurs
                effectif_ext.Items[effectif_ext.SelectedIndex] = entrant;
                list_remp_ext.Items.Remove(entrant);

                list_remp_ext.ClearSelected();
                effectif_ext.ClearSelected();
                effectif_ext.Enabled = false;
                list_remp_ext.Enabled = false;
                list_remp_loc.Enabled = false;
                effectif_loc.Enabled = false;
            }
        }

        //Suppression d'un action saisie dans la ListView
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)//A l'evenement clique sur "supprimer", après un clic droit sur une action
        {

            if (Actions.SelectedItems.Count != 0)//Pour vérifier qu'un élément est bien selectionné
            {
                string type_actions = Actions.SelectedItems[0].SubItems[2].Text;
                string joueur = Actions.SelectedItems[0].SubItems[1].Text;
                string minute = Actions.SelectedItems[0].SubItems[0].Text;

                if (type_actions == "But")//Si l'action est un but il faut décrémenter l'affichage du but de l'équipe concernée
                {

                    if (Actions.FocusedItem.ForeColor == Color.Blue)//Couleur de l'action séléctionnée bleu --> équipe domicile
                    {
                        score_loc.Text = Program.eq_domicile.annuler_but(minute, joueur);
                    }
                    else
                    {
                        score_ext.Text = Program.eq_exterieur.annuler_but(minute, joueur);
                    }
                }
                
                if (type_actions.Contains("Remplacé"))//Si la phrase de l'action contient "Remplaçé", alors on est dans le cas d'une suppression de changement
                {
                    if (Actions.FocusedItem.ForeColor == Color.Red)
                    {
                        string joueur_remplacé = Actions.SelectedItems[0].SubItems[1].Text;
                        string ph_joueur_entrant = Actions.SelectedItems[0].SubItems[2].Text;

                        string joueur_entrant;

                        string[] temp = ph_joueur_entrant.Split(':');    //On découpe le phrase descriptive en deux parties, séparées par le ":", dans un tableu de string.                    

                        joueur_entrant = temp[1];//Donc la partie droite de la phrase après le ":" correspond au nom du joueur (element d'indice 1 du tableau)                      

                        //On fait les modifications necessaires dans les listes de joueurs et remplaçants
                        list_remp_ext.Items.Add(joueur_entrant);
                        effectif_ext.Items.Add(joueur_remplacé);
                        effectif_ext.Items.Remove(joueur_entrant);
                        Program.eq_exterieur.annuler_remp(joueur_remplacé);
                    }
                    else
                    {
                        string joueur_remplacé = Actions.SelectedItems[0].SubItems[1].Text;
                        string ph_joueur_entrant = Actions.SelectedItems[0].SubItems[2].Text;

                        string joueur_entrant;

                        string[] temp = ph_joueur_entrant.Split(':');

                        joueur_entrant = temp[1];

                        list_remp_loc.Items.Add(joueur_entrant);
                        effectif_loc.Items.Add(joueur_remplacé);
                        effectif_loc.Items.Remove(joueur_entrant);
                        Program.eq_domicile.annuler_remp(joueur_remplacé);
                    }


                }
                
                if (type_actions == "Carton rouge")
                {
                    if (Actions.FocusedItem.ForeColor == Color.Red)
                    {
                        string joueur_a_remettre = Actions.SelectedItems[0].SubItems[1].Text;
                        effectif_ext.Items.Add(joueur_a_remettre);

                    }
                    else
                    {
                        string joueur_a_remettre = Actions.SelectedItems[0].SubItems[1].Text;
                        effectif_loc.Items.Add(joueur_a_remettre);
                    }
                }
                if (type_actions == "Carton jaune")
                {
                    if (Actions.FocusedItem.ForeColor == Color.Red)
                    {
                        Program.eq_exterieur.annuler_carton(Actions.SelectedItems[0].SubItems[1].Text);
                    }
                    else
                    {
                        Program.eq_domicile.annuler_carton(Actions.SelectedItems[0].SubItems[1].Text);
                    }
                }


                Actions.SelectedItems[0].Remove();
            }

        }
        #endregion 
        
        #region Chronomètre

        //Méthode lancée toutes les secondes (gestion du chrono du match)
        private void time_Tick(object sender, EventArgs e)
        {
            if (temps_add_1mt)//Si on est dans le temps additionnel de la 1ère mi-temps
            {
                if (sec_add == 59)
                {
                    if (minutes.Text == "45")   minutes.Text = "45";
                    else minutes.Text = "90";
                    sec.Text = "00";
                    sec_add = 0;
                    min_add++;
                    label_sec_add.Text = ":  " + sec_add.ToString() ;
                    label_min_add.Text = min_add.ToString() ;
                }

                else
                {
                    sec_add++;

                    label_sec_add.Text = ":  " + sec_add.ToString();
                }
            }
            else //Si on est dans le temps réglementaire 
            {
                if (compteur == 59)
                {
                    compteur = 0;
                    min++;
                    sec.Text = compteur.ToString();
                    minutes.Text = min.ToString();
                    
                    if (min == 90)
                    {
                        buttonFin.Visible = true;
                    }

                    if (min == 45)
                    {
                        temps_add_1mt = true;


                        label_min_add.Visible = true;
                        label_sec_add.Visible = true;
                        temps_add_1mt = true;
                        


                        reprise.Visible = true;
                        indic_add.Visible = true;
                        reprise.Enabled = false;
                        mi_temps.Enabled = true;
                        mi_temps.Visible = true;
                        label_min_add.Visible = true;
                        label_sec_add.Visible = true;                 
                        

                    }

                }
                else
                {
                    compteur++;
                    sec.Text = compteur.ToString();
                }
            }
            
            
        }
              


        private void reprise_Click(object sender, EventArgs e)
        {
            //A la reprise, on enlève les controles de temps additionnel, mi temps etc, on initialise l'affichage du temps reglementaire à 45 min 0 sec et on relance le chrono
            min = 45;
            minutes.Text = min.ToString();

            temps_add_1mt = false;

            compteur = 0;
            sec.Text = compteur.ToString();
            time.Start();
           
            label_sec_add.Text = ":  0";
            label_min_add.Text = "0";
            sec_add = 0;
            min_add = 0;
            mi_temps.Visible = false;
            reprise.Visible = false;
            indic_add.Visible = false;
            label_min_add.Visible = false;
            label_sec_add.Visible = false;

        }

        //Lorsque l'utilisateur indique la mi-temps du match
        private void mi_temps_Click(object sender, EventArgs e)
        {
            //Une fois qu'on est à la mi temps, le chrono (de temps additionnel) s'arrete, et on peut cliquer sur le bouton de reprise 
            time.Stop();
            reprise.Enabled = true;
        }

        #endregion 

        //BOUTON D'AIDE
        private void help_Click_1(object sender, EventArgs e)
        {
            string presentation = "Cette fenêtre vous permet de saisir les actions durant le match. \r\n\n";
            string action = "Pour ajouter une action, cliquez sur le bouton correspondant et sélectionnez le joueur concerné.\r\n\n";
            string cht = "Pour ajouter un changement, sélectionnez le bouton changement, sélectionnez le joueur remplacé, puis le remplaçant, et cliquez sur le logo de remplaçement.\r\n\n";
            string suppr = "Pour supprimer une action, clic droit sur l'action dans la liste et cliquez sur supprimer. En cas d'erreur de sélection d'une action, cliquez sur la croix pour réactiver les boutons.\r\n\n";
            MessageBox.Show(presentation + action + cht + suppr);
        }
        //FIN DU MATCH       
        private void Generer_Click(object sender, EventArgs e)
        {
            Program.fdm.Generer(Actions);
            //Sauvegarde au chemin spécifié avec un nom sous la forme "equipe1-equipe2.xlsx"
            Program.fdm.Sauvegarder(folderBrowserSave_fdm.SelectedPath + @"\" + Program.eq_domicile.GetName(false) + "-" + Program.eq_exterieur.GetName(false) + ".xlsx");
            Program.fdm.Close();
            this.Hide();
            this.Close();
            Application.Exit(); //On ferme l'application et on libère toutes les variables
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            time.Stop();
            end.Enabled = true;// Si on est à la fin du match, on peut activer le bouton de génération de la feuille de match
            folderBrowserSave_fdm.ShowDialog();
        }

        private void fenetre3_Load(object sender, EventArgs e)
        {

        }

      
    }
}
   

