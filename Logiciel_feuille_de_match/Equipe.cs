using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_fdm
{
    struct remplacement //Enregistrement pour la feuille de match finale
    {
        public string remplaçant;
        public string remplace;
    }

    struct but
    {
        public string minute;
        public string joueur;
    }

    // Définition de la classe EQUIPE
    class Equipe
    {
        //---------------ATTRIBUTS-----------------//
        public static UInt16 i_postes;
        private string nom;
        private string nom_nospace; //Nom sans espace
        private string entraineur;
        private string dispositif;
        private string dispositif_nospace;
        public List<remplacement> remplacements;
        public List<but> buts;
        private List<Joueur> effectif; //Taille variable
        public Joueur[] titulaires; //Taille fixe --> Tableau plus adapté
        public Joueur[] remplaçants;

        //---------------METHODES-----------------//

        #region Initialisations

        //Constructeur
        public Equipe(string nom_eq, string disp)
        {
            i_postes = 1;
            nom = nom_eq;
            nom_nospace = nom.Replace(" ", String.Empty); //Suppression des espaces
            dispositif = disp;
            dispositif_nospace = dispositif.Replace(", ", String.Empty);
            effectif = new List<Joueur>();
            titulaires = new Joueur[11];
            remplaçants = new Joueur[7];
            remplacements = new List<remplacement>();
            buts = new List<but>();
        }

        //Lit dans la table de l'effectif la cellule où l'on a normalement l'entraîneur
        public void SetCoach()
        {
            entraineur = Program.Excel.LireCellule(1, 3); //Cellule où est rangé le nom de l'entraîneur pour toutes les équipes
        }

        //Ajout d'un joueur à l'effectif
        public void AddEffectif(string j_name, UInt16 j_num)
        {
            Joueur j = new Joueur(j_name, j_num);
            effectif.Add(j);
        }

        //Mettre un joueur de l'effectif titulaire à partir de son nom et du rang du joueur entre 1 et 11          


        public void MettreTitulaire(string nom_joueur, UInt16 rang, string poste)
        {
            Joueur j = effectif.Find(x => x.GetName().Contains(nom_joueur)); //Recherche du joueur et affectation au rang voulu
            titulaires[rang] = j;
            j.poste = poste;
        }

        //Remplir les remplaçants 
        public void AjouterRemplaçant(string r1, UInt16 rang)
        {
            Joueur remp = effectif.Find(x => x.GetName().Contains(r1));
            remplaçants[rang] = remp;
        }

        #endregion 

        #region Retours d'attributs

        //Retourne le nom de l'équipe avec booléen pour sélectionner le format (avec ou sans espaces)
        public string GetName(bool spaces)
        {
            string res;
            if (spaces)
                res = nom;
            else
                res = nom_nospace;
            return res;
        }

        //Retourne le nom de l'entraîneur
        public string GetEntraineur()
        {
            return entraineur;
        }

        //Retourne le dispositif actuel (avec ou sans espaces)
        public string GetDisp(bool spaces)
        {
            string res;
            if (spaces)
                res = dispositif;
            else
                res = dispositif_nospace;
            return res;
        }

        #endregion 

        #region Enregistrement d'actions durant le match

        //Procédure de remplacement dans une équipe (avec vérification de possibilité)
        public bool remplacement(string entrant, string sortant)
        {
            bool ok = false;
            remplacement r;
            //Si entrant sélectionné comme remplaçant, sortant sans carton rouge et moins de 3 remplacements effectués
            if (remplacements.Count < 3)
            {
                r.remplaçant = entrant;
                r.remplace = sortant;
                remplacements.Add(r);
                ok = true;
            }
            return ok;
        }

        //Annulation d'un remplacement
        public void annuler_remp(string sortant)
        {
            foreach(remplacement r in remplacements)
            {
                if(r.remplace == sortant) //Si le nom du joueur sortant est présent (i.e. le remplacement demandé) 
                {
                    remplacements.Remove(r); //On annule le remplacement associé
                    break; //On sort de la boucle étant donné qu'on a supprimé l'élément voulu
                }
            }
        }

        //Ajout d'un but à la liste des buts de l'équipe + renvoie le score sous format string
        public string ajouter_but(string minute, string joueur)
        {
            but b;
            string nb_buts;
            b.minute = minute;
            b.joueur = joueur;
            buts.Add(b);
            nb_buts = buts.Count().ToString();
            return nb_buts;
        }

        //Annulation d'un but
        public string annuler_but(string min, string joueur)
        {
            string score;
            foreach (but b in buts)
            {
                if(b.minute == min && b.joueur == joueur)
                {
                    buts.Remove(b);
                    break; //On sort de la boucle une fois qu'on a supprimé l'élément voulu.
                }
            }
            score = buts.Count().ToString();
            return score; //On retourne le nouveau score
        }

        //Enregistrement d'un carton sur un joueur de l'effectif
        public bool ajouter_carton(string joueur)
        {
             int i = rechercher_index(joueur);             
             return effectif[i].CartonJaune(); //effectif[i] désigne un objet de la classe joueur, la méthode CartonJaune renvoie "true" si succès et false si le joueur avait déjà un jaune      
        }

        //Annulation de saisie d'un carton durant le match
        public void annuler_carton(string joueur)
        {
            int i = rechercher_index(joueur);
            effectif[i].AnnulerCarton();
        }

        #endregion 

        //Retourne l'indice du joueur recherché dans l'effectif
        public int rechercher_index(string joueur)
        {
            int i = 0;
            while (effectif[i].GetName() != joueur)
            {
                i++;
            }
            return i;
        }

    }
}

