using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logiciel_fdm
{ 
    class Joueur
    {
        //---------------ATTRIBUTS-----------------//
        private string nom;
        private UInt16 numero;
        public string poste;
        public bool jaune;
        

        //---------------METHODES-----------------//

        //Constructeur
        public Joueur(string name, UInt16 nb)
        {
            nom = name;
            numero = nb;
            poste = null;
            jaune = false;
        }

        #region Retours d'attributs

        //Méthodes de lecture des attributs à remplir...
        public string GetName()
        {
            return nom;
        }

        public UInt16 GetNumber()
        {
            return numero;
        }

        public string GetPoste()
        {
            return poste;
        }

        public void MettreCapitaine()
        {
            nom = "(cap) " + nom;
        }

        #endregion 

        #region Enregistrement d'un éventuel carton jaune

        //Met le booléen "jaune" à "true" si le joueur n'a pas encore de carton jaune et renvoie "true", sinon renvoie "false"
        public bool CartonJaune()
        {
            bool res = false;
            if (!jaune)
            {
                jaune = true;
                res = true;
            }
            return res;
        }

        public void AnnulerCarton()
        {
            jaune = false;
        }

        #endregion 
    }
}
