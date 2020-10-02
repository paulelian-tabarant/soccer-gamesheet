using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_fdm
{
    class FeuilleDeMatch
    {
        //---------------ATTRIBUTS-----------------//

        //Infos d'avant-match
        private string stade;
        private string arbitre_principal, arbitre_remplaçant, arbitre_touche1, arbitre_touche2;
        private string date;
        private string championnat;
        private string entraineur_domicile, entraineur_exterieur;

        //Template de feuille de match (Excel)
        GestionExcel fdm;

        //Infos et cellules pour remplissage du 1er volet
        int score_domicile, score_exterieur;
        private string cellule_eq_domicile = "A1";
        private string cellule_eq_exterieur = "G1";
        private string cellule_score_domicile = "C1";
        private string cellule_score_exterieur = "E1";
        private string cellule_championnat = "B3";
        private string cellule_stade = "B4";
        private string cellule_arb_principal = "B6";
        private string cellule_arb_remplaçant = "C6";
        private string cellule_arb_touche1 = "D6";
        private string cellule_arb_touche2 = "E6";
        private string cellule_date = "D2";
        private string cellule_entraineur_domicile = "B37";
        private string cellule_entraineur_exterieur = "F37";

        private string cellule_buts_domicile = "C2";
        private string cellule_buts_exterieur = "E2";
        string liste_buts_domicile = String.Empty; //Liste des buts (joueur + minute) 
        string liste_buts_exterieur = String.Empty;

        private string cellule_remp_domicile = "A2";
        private string cellule_remp_exterieur = "G2";
        string liste_remp_domicile = String.Empty; //Liste des remplacements (Sortant --> Entrant)
        string liste_remp_exterieur = String.Empty;

        //1 point = 0.0353cm
        //Coordonnées logos sur l'Excel
        int abs_logo_domicile = 143;
        int ord_logo_domicile = 0;
        int abs_logo_exterieur = 688;
        int ord_logo_exterieur = 0;
        int largeur_logos = 100;
        int hauteur_logos = 100;

        //Coordonnées dispositifs sur l'Excel
        int abs_disp_domicile = 67;
        int ord_disp_domicile = 450;
        int abs_disp_exterieur = 548;
        int ord_disp_exterieur = 450;
        int largeur_disp = 248;
        int hauteur_disp = 248;

        int l_titulaires = 8; //Titulaires à partir de la ligne 8
        int l_remplaçants = 40;
        int c_eq1 = 1; //Colonne de stockage des titulaires et des remplaçants (équipe domicile)
        int c_eq2 = 5;

        //Ligne de démarrage actions (2ème volet)
        int index_actions = 3; 


        //---------------METHODES-----------------//

        //Constructeur
        public FeuilleDeMatch(string saisie_stade, string saisie_arbitre_p, string saisie_arbitre_r, string saisie_arbitre_t1, string saisie_arbitre_t2, DateTime saisie_date, string saisie_champ)
        {
            stade = saisie_stade; //On récupère toutes les infos spécifiées en attribut
            arbitre_principal = saisie_arbitre_p;
            arbitre_remplaçant = saisie_arbitre_r;
            arbitre_touche1 = saisie_arbitre_t1;
            arbitre_touche2 = saisie_arbitre_t2;
            date = saisie_date.ToLongDateString();
            championnat = saisie_champ;
            entraineur_domicile = Program.eq_domicile.GetEntraineur();
            entraineur_exterieur = Program.eq_exterieur.GetEntraineur();
        }
        public void Close()
        {
            fdm.QuitterXl();
        }

        public void Generer(System.Windows.Forms.ListView liste_actions)
        {
            string equiv_A1_nom; //Pour stocker l'équivalent au format "A1" de (ligne N°1, colonne N°1) sous forme de 2 entiers
            string equiv_A1_numero;
            string equiv_A1_poste;

            //Objet référençant le fichier Excel de la feuille de match
            fdm = new GestionExcel();

            //DECLARATIONS
            System.Drawing.Color rouge = System.Drawing.Color.Red; //Variable référençant la couleur rouge
            System.Drawing.Color bleu = System.Drawing.Color.Blue; //Couleur bleue
            string[] ligne_action = new string[2]; //Pour stocker Joueur, action


            //PARTIE LECTURE (conversion d'informations)
            fdm.OuvrirFichierExistant(chemin.fdm, "Feuil1"); //Ouverture de l'Excel contenant le template de feuille de match

            //Comptage des buts dans la liste des buts pour chaque équipe
            score_domicile = Program.eq_domicile.buts.Count();
            score_exterieur = Program.eq_exterieur.buts.Count();

            //Liste des buteurs pour chaque équipe
            foreach (but goal in Program.eq_domicile.buts) 
            {
                liste_buts_domicile += goal.joueur + "(" + goal.minute.ToString() + "e) \n"; //ex: John Terry (20e)
            }

            foreach (but goal in Program.eq_exterieur.buts)
            {
                liste_buts_exterieur += goal.joueur + "(" + goal.minute.ToString() + "e) \n"; 
            }

            //Liste des remplacements pour chaque équipe
            foreach(remplacement remplacement in Program.eq_domicile.remplacements)
            {
                liste_remp_domicile += remplacement.remplace + " pour " + remplacement.remplaçant + "\n";
            }

            foreach (remplacement remplacement in Program.eq_exterieur.remplacements)
            {
                liste_remp_exterieur += remplacement.remplace + " pour " + remplacement.remplaçant + "\n";
            }

            //PARTIE ECRITURE

            //1er volet de la feuille de match

            fdm.EcrireCellule(Program.eq_domicile.GetName(true), cellule_eq_domicile);
            fdm.EcrireCellule(Program.eq_exterieur.GetName(true), cellule_eq_exterieur);
            fdm.EcrireCellule(score_domicile.ToString(), cellule_score_domicile);
            fdm.EcrireCellule(score_exterieur, cellule_score_exterieur);
            fdm.EcrireCellule(date, cellule_date);
            fdm.EcrireCellule(liste_buts_domicile, cellule_buts_domicile);
            fdm.EcrireCellule(liste_buts_exterieur, cellule_buts_exterieur);
            fdm.EcrireCellule(liste_remp_domicile, cellule_remp_domicile);
            fdm.EcrireCellule(liste_remp_exterieur, cellule_remp_exterieur);
            fdm.EcrireCellule(championnat, cellule_championnat);
            fdm.EcrireCellule(stade, cellule_stade);
            fdm.EcrireCellule(arbitre_principal, cellule_arb_principal);
            fdm.EcrireCellule(arbitre_remplaçant, cellule_arb_remplaçant);
            fdm.EcrireCellule(arbitre_touche1, cellule_arb_touche1);
            fdm.EcrireCellule(arbitre_touche2, cellule_arb_touche2);
            fdm.EcrireCellule(Program.eq_domicile.GetEntraineur(), cellule_entraineur_domicile);
            fdm.EcrireCellule(Program.eq_exterieur.GetEntraineur(), cellule_entraineur_exterieur);

            //Logos
            string chemin_logo_domicile = chemin.logos + Program.eq_domicile.GetName(false) + ".jpg";
            string chemin_logo_exterieur = chemin.logos + Program.eq_exterieur.GetName(false) + ".jpg";
            fdm.InsererImage(abs_logo_domicile, ord_logo_domicile, largeur_logos, hauteur_logos, chemin_logo_domicile);
            fdm.InsererImage(abs_logo_exterieur, ord_logo_exterieur, largeur_logos, hauteur_logos, chemin_logo_exterieur);

            //Titulaires
            //Domicile
            for (UInt16 i = 0; i < 11; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_titulaires, c_eq1); //Equivalent au format "A1" des lignes colonnes référencées sous la forme (1,1)
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_titulaires, c_eq1 + 1);
                equiv_A1_poste = fdm.AdresseCellTypeA1(l_titulaires, c_eq1 + 2);
                fdm.EcrireCellule(Program.eq_domicile.titulaires[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_domicile.titulaires[i].GetNumber(), equiv_A1_numero);
                fdm.EcrireCellule(Program.eq_domicile.titulaires[i].GetPoste(), equiv_A1_poste);
                l_titulaires++;
            }

            //Extérieur
            l_titulaires -= 11;
            for(UInt16 i=0; i<11; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_titulaires, c_eq2);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_titulaires, c_eq2 + 1);
                equiv_A1_poste = fdm.AdresseCellTypeA1(l_titulaires, c_eq2 + 2);
                fdm.EcrireCellule(Program.eq_exterieur.titulaires[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_exterieur.titulaires[i].GetNumber(), equiv_A1_numero);
                fdm.EcrireCellule(Program.eq_exterieur.titulaires[i].GetPoste(), equiv_A1_poste);
                l_titulaires++;
            }

            //Dispositifs
            string chemin_disp_domicile = chemin.images_dispositifs + Program.eq_domicile.GetDisp(false) + ".jpg";
            string chemin_disp_exterieur = chemin.images_dispositifs + Program.eq_exterieur.GetDisp(false) + ".jpg";
            fdm.InsererImage(abs_disp_domicile, ord_disp_domicile, largeur_disp, hauteur_disp, chemin_disp_domicile);
            fdm.InsererImage(abs_disp_exterieur, ord_disp_exterieur, largeur_disp, hauteur_disp, chemin_disp_exterieur);

            //Remplaçants
            //Domicile
            for(UInt16 i = 0; i<7; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_remplaçants, c_eq1);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_remplaçants, c_eq1 + 1);
                fdm.EcrireCellule(Program.eq_domicile.remplaçants[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_domicile.remplaçants[i].GetNumber(), equiv_A1_numero);
                l_remplaçants++;
            }

            //Extérieur
            l_remplaçants -= 7;
            for(UInt16 i = 0; i<7; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_remplaçants, c_eq2);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_remplaçants, c_eq2 + 1);
                fdm.EcrireCellule(Program.eq_exterieur.remplaçants[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_exterieur.remplaçants[i].GetNumber(), equiv_A1_numero);
                l_remplaçants++;
            }

            //Actions durant le match (2ème volet de la feuille de match)
            fdm.ChangerDeFeuilleActive("Feuil2");
            foreach (System.Windows.Forms.ListViewItem action in liste_actions.Items)
            {
                //Les actions commencent  dans l'Excel à la ligne spécifiée dans ligne_actions (attribut).
                ligne_action[0] = action.SubItems[0].Text + "'"; //Minute
                ligne_action[1] = PhraseAction(action);          //Phrase descriptive
                fdm.EcrireLigne(ligne_action, index_actions);    //Ecriture de la ligne complète minute + action
                fdm.SelectionRange(index_actions, 1, 1, 2);      //Sélection des 2 cellules pour changer leur mise en forme
                System.Drawing.Color couleur = action.ForeColor;
                if (couleur == bleu) //Coloration des cellules de chaque action pour différencier les 2 équipes
                    fdm.MiseEnForme(ColorIndex.Azur, ColorIndex.Automatique);
                if (couleur == rouge)
                    fdm.MiseEnForme(ColorIndex.Rouge, ColorIndex.Automatique);
                index_actions++;
            }

            //Affichage de l'Excel final sous l'application Excel elle-même
            // fdm.AfficherXL();  à décommenter pour afficher l'Excel de la feuille de match à la fin
        }

        //A partir du joueur et de l'action, retourne une chaîne de caractères basique décrivant l'action
        private string PhraseAction(System.Windows.Forms.ListViewItem action)
        {
            //SubItems[0] : Minute
            //SubItems[1] : Action
            //SubItems[2] : Joueur

            string action_txt;
            string phrase = String.Empty;
            action_txt = action.SubItems[2].Text;
            //ex : carton jaune pour Loïc Perrin
            if (action_txt == "Carton jaune" || action_txt == "Carton rouge")
            {
                phrase = action_txt + " pour ";
                phrase+= action.SubItems[1].Text;
            }

            //ex : Faute de Sergio Ramos
            if (action_txt == "But" || action_txt == "Hors-jeu" || action_txt == "Faute") 
            {
                phrase = action_txt + " de ";
                phrase+= action.SubItems[1].Text;
            }
            //ex : Coup franc tiré par Lionel Messi
            if(action_txt == "Coup franc" || action_txt == "Penalty" || action_txt == "Corner")
            {
                phrase = action_txt + " tiré par ";
                phrase += action.SubItems[1].Text;
            }
            //ex : Zlatan Ibrahimovic remplacé par Edinson Cavani
            if (action_txt.Contains("Remplacé par"))
            {
                action_txt = action_txt.TrimStart('R'); //Suppression de la majuscule pour mettre une minuscule
                action_txt = "r" + action_txt;
                phrase = action.SubItems[1].Text + " " + action_txt;
            }
            return phrase;
        }

        //Sauvegarder la feuille de match à l'emplacement spécifié
        public void Sauvegarder(string path)
        {
            fdm.EnregistrerSous(path);
        }
    }

}
