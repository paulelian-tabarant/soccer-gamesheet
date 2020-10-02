using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logiciel_fdm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new fenetre1());
        }

        public static GestionExcel Excel; //Lance une application Excel déclarée comme statique (instancé ci-contre)
        public static Equipe eq_domicile; //Avantage "static" --> Déclaration globale : accès avec Program.eq_domicile depuis n'importe quelle classe dans le namespace Logiciel_fdm
        public static Equipe eq_exterieur;
        public static FeuilleDeMatch fdm;
    }
}
