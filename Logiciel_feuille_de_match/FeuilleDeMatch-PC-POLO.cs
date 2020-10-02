using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Logiciel_fdm
{
    class FeuilleDeMatch
    {
        //---------------ATTRIBUTS-----------------//
        private string stade;
        private string arbitre_principal, arbitre_remplaçant, arbitre_touche1, arbitre_touche2;
        private string date;
        private string championnat;

        //---------------METHODES-----------------//

        //Constructeur
        public FeuilleDeMatch(string saisie_stade, string saisie_arbitre_p, string saisie_arbitre_r, string saisie_arbitre_t1, string saisie_arbitre_t2, DateTime saisie_date, string saisie_champ)
        {
            stade = saisie_stade;
            arbitre_principal = saisie_arbitre_p;
            arbitre_remplaçant = saisie_arbitre_r;
            arbitre_touche1 = saisie_arbitre_t1;
            arbitre_touche2 = saisie_arbitre_t2;
            date = saisie_date.ToLongDateString();
            championnat = saisie_champ;
        }

        public string Generer(Equipe eq_domicile, Equipe eq_exterieur, System.Windows.Forms.ListView actions)
        {
            //Déclarations
            GestionExcel fdm = new GestionExcel();
            int buts_domicile, buts_exterieur;

            //Algo
            fdm.OuvrirFichierExistant(chemin.feuilledematch);
            buts_domicile = Program.eq_domicile.buts.Count();
            buts_exterieur = Program.eq_exterieur.buts.Count();

            
        }
    }
}
