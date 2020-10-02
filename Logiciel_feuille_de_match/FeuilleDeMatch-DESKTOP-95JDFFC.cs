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
        private string entraineur_domicile;
        private string entraineur_exterieur;

        //Template de feuille de match (Excel)
        GestionExcel fdm;

        //Infos et cellules pour remplissage du 1er volet
        int score_domicile, score_exterieur;
        private string cellule_eq_domicile = "A1";
        private string cellule_eq_exterieur = "E1";
        private string cellule_score_domicile = "B1";
        private string cellule_score_exterieur = "D1";
        private string cellule_date = "C2";
        private string cellule_championnat = "B3";
        private string cellule_stade = "B4";
        private string cellule_arb_principal = "B6";
        private string cellule_arb_remplaçant = "C6";
        private string cellule_arb_touche1 = "D6";
        private string cellule_arb_touche2 = "E6";
        private string cellule_entraineur_domicile = "B20";
        private string cellule_entraineur_exterieur = "E20";

        private string cellule_buts_domicile = "B2";
        private string cellule_buts_exterieur = "D2";
        string liste_buts_domicile = String.Empty; //Liste des buts (joueur + minute) 
        string liste_buts_exterieur = String.Empty;

        private string cellule_remp_domicile = "A2";
        private string cellule_remp_exterieur = "E2";
        string liste_remp_domicile = String.Empty; //Liste des remplacements (Sortant --> Entrant)
        string liste_remp_exterieur = String.Empty;

        int l_titulaires = 8; //Titulaires à partir de la ligne 8
        int l_remplaçants = 23;
        int c_eq1 = 1; //Colonne de stockage des titulaires et des remplaçants (équipe domicile)
        int c_eq2 = 4;

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

        public void Generer(System.Windows.Forms.ListView liste_actions)
        {
            string equiv_A1_nom; //Pour stocker l'équivalent au format "A1" de (ligne N°1, colonne N°1) sous forme de 2 entiers
            string equiv_A1_numero;

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
                liste_buts_domicile += goal.joueur + "( " + goal.minute.ToString() + "e) "; //ex: John Terry (20e)
            }

            foreach (but goal in Program.eq_exterieur.buts)
            {
                liste_buts_domicile += goal.joueur + "( " + goal.minute.ToString() + "e) ";
            }

            //Liste des remplacements pour chaque équipe
            foreach (remplacement remplacement in Program.eq_domicile.remplacements)
            {
                liste_remp_domicile += remplacement.remplace + " --> " + remplacement.remplaçant + "\n";
            }

            foreach (remplacement remplacement in Program.eq_exterieur.remplacements)
            {
                liste_remp_exterieur += remplacement.remplace + " --> " + remplacement.remplaçant + "\n";
            }

            //PARTIE ECRITURE

            //1er volet de la feuille de match
            fdm.EcrireCellule(Program.eq_domicile.GetName(), cellule_eq_domicile);
            fdm.EcrireCellule(Program.eq_exterieur.GetName(), cellule_eq_exterieur);
            fdm.EcrireCellule(score_domicile.ToString(), cellule_score_domicile);
            fdm.EcrireCellule(date, cellule_date);
            fdm.EcrireCellule(score_exterieur, cellule_score_exterieur);
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
            fdm.EcrireCellule(entraineur_domicile, cellule_entraineur_domicile);
            fdm.EcrireCellule(entraineur_exterieur, cellule_entraineur_exterieur);
            //Titulaires
            //Domicile
            for (UInt16 i = 0; i < 11; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_titulaires, c_eq1); //Equivalent au format "A1" des lignes colonnes référencées sous la forme (1,1)
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_titulaires, c_eq1 + 1);
                fdm.EcrireCellule(Program.eq_domicile.titulaires[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_domicile.titulaires[i].GetNumber(), equiv_A1_numero);
                l_titulaires++;
            }

            //Extérieur
            l_titulaires -= 11;
            for (UInt16 i = 0; i < 11; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_titulaires, c_eq2);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_titulaires, c_eq2 + 1);
                fdm.EcrireCellule(Program.eq_exterieur.titulaires[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_exterieur.titulaires[i].GetNumber(), equiv_A1_numero);
                l_titulaires++;
            }

            //Remplaçants
            //Domicile
            for (UInt16 i = 0; i < 7; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_remplaçants, c_eq1);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_remplaçants, c_eq1 + 1);
                fdm.EcrireCellule(Program.eq_domicile.remplaçants[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_domicile.remplaçants[i].GetNumber(), equiv_A1_numero);
                l_remplaçants++;
            }

            //Extérieur
            l_remplaçants -= 7;
            for (UInt16 i = 0; i < 7; i++)
            {
                equiv_A1_nom = fdm.AdresseCellTypeA1(l_remplaçants, c_eq2);
                equiv_A1_numero = fdm.AdresseCellTypeA1(l_remplaçants, c_eq1 + 1);
                fdm.EcrireCellule(Program.eq_exterieur.remplaçants[i].GetName(), equiv_A1_nom);
                fdm.EcrireCellule(Program.eq_exterieur.remplaçants[i].GetNumber(), equiv_A1_numero);
                l_remplaçants++;
            }

            //Actions durant le match
            fdm.ChangerDeFeuilleActive("Feuil2");
            foreach (System.Windows.Forms.ListViewItem action in liste_actions.Items)
            {
                //Les actions commencent  dans l'Excel à la ligne spécifiée dans ligne_actions (attribut).
                ligne_action[0] = action.Text + "ème"; //Minute
                ligne_action[1] = PhraseAction(action);          //Phrase descriptive
                fdm.EcrireLigne(ligne_action, index_actions);    //Ecriture de la ligne complète minute + action
                fdm.SelectionRange(index_actions, 1, 1, 2);      //Sélection des 2 cellules pour changer leur mise en forme
                fdm.CouleurFondRange(action.ForeColor);          //Met le fond des cellules sélectionnées à la couleur du texte présent dans l'élément de la ListView des actions
                index_actions++;
            }

            //Affichage de l'Excel final sous l'application Excel elle-même
            fdm.AfficherXL();
        }

        //A partir du joueur et de l'action, retourne une chaîne de caractères basique décrivant l'action
        private string PhraseAction(System.Windows.Forms.ListViewItem action)
        {
            //SubItems[0] : Minute
            //SubItems[1] : Action
            //SubItems[2] : Joueur

            string action_txt;
            string phrase = null;
            action_txt = action.SubItems[0].Text;
            //ex : carton jaune pour Loïc Perrin
            if (action_txt == "Carton jaune" || action_txt == "Carton rouge")
            {
                phrase = action_txt + "pour ";
                phrase += action.SubItems[2];
            }

            //ex : Faute de Sergio Ramos
            if (action_txt == "But" || action_txt == "Hors-jeu" || action_txt == "Faute")
            {
                phrase = action_txt + " de ";
                phrase += action.SubItems[2];
            }
            //ex : Coup franc tiré par Lionel Messi
            if (action_txt == "Coup franc" || action_txt == "Penalty" || action_txt == "Corner")
            {
                phrase = action_txt + " tiré par ";
                phrase += action.SubItems[2];
            }
            //ex : Zlatan Ibrahimovic remplacé par Edinson Cavani
            if (action_txt.Contains("Remplacé par"))
            {
                phrase = action.SubItems[2] + " " + action_txt;
            }
            return phrase;
        }
    }
}


