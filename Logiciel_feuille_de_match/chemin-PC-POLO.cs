using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Contient l'objet Application
using System.IO; //Pour utiliser la méthode GetParent

namespace Logiciel_fdm
{
    public static class chemin
    {
        static string _debug = Application.StartupPath; // répertoire debug             
        static string _bin = Directory.GetParent(_debug).ToString(); // répertoire bin
        static string _logiciel_fdm = Directory.GetParent(_bin).ToString(); // répertoire Logiciel_fdm
        static string _racine = Directory.GetParent(_logiciel_fdm).ToString(); // racine du projet
        static string _logos = _racine + @"\Images\Logos\";
        static string _images_dispositifs = _racine + @"\Images\Dispositifs\";
        static string _dispositifs = _racine + @"\dispositifs.xlsx";
        static string _effectifs = _racine + @"\effectifs.xlsx";
        static string _entraineurs = _racine + @"\entraineurs.xlsx";
        static string _championnats = _racine + @"\championnats.xlsx";
        static string _feuilledematch = _racine + @"\feuilledematch.xlsx";

        //Dossier racine du projet
        public static string racine
        {
            get
            {
                return _racine;
            }
        }

        //Dossier contenant les logos
        public static string logos
        {
            get
            {
                return _logos;
            }
        }

        //Dossier contenant les dispositifs
        public static string images_dispositifs
        {
            get
            {
                return _images_dispositifs;
            }
        }

        //Excel contenant les postes pour chaque dispositif
        public static string dispositifs
        {
            get
            {
                return _dispositifs;
            }
        }

        //Dossier contenant les effectifs
        public static string effectifs
        {
            get
            {
                return _effectifs;
            }
        }

        //Chemin du fichier "entraineurs"
        public static string entraineurs
        {
            get
            {
                return _entraineurs;
            }
        }

        //Chemin du fichier "championnats"
        public static string championnats
        {
            get
            {
                return _championnats;
            }
        }

        //Chemin de l'excel de la feuille de match
        public static string feuilledematch
        {
            get
            {
                return _feuilledematch;
            }
        }
    }
}
