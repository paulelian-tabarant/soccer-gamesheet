using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel; //selon les versions d'excel 
//using Excel; //selon les versions d'excel 

namespace Logiciel_fdm
{
    public class GestionExcel
    {
        #region Déclarations
        Microsoft.Office.Interop.Excel.Application _ApplicationXL;
        Workbooks _LesWorkBooks;
        _Workbook _MonClasseur;
        _Worksheet _MaFeuille;
        public Range _MonRange; // le range est une zone selectionnée de façon virutelle ou les calculs s'effectuent. Range est cellule active sont deux chose differentes. 
        _Chart _MonGraphique;
        object _M = System.Reflection.Missing.Value;
        string _NomFichier;

        public enum TypeEncadrement { ToutesCellulesFin, ToutesCellulesMoyen, Aucun, ExtérieurRangeFin, ExtérieurRangeMoyen };
        #endregion

        #region Initialisation et enregistrement
        /// <summary> 
        ///  Classe s'interfaçant en une appli et Microsoft.Office.Interop.Excel 
        /// </summary> 
        public GestionExcel()
        {
            Init();
        }

        /// <summary> 
        ///  Classe s'interfaçant en une appli et Microsoft.Office.Interop.Excel 
        /// </summary> 
        public GestionExcel(out bool Succes)
        {
            Succes = Init();
        }

        private bool Init()
        {
            try
            {
                //Démarre Excel et récupère l'application 
                _ApplicationXL = new Microsoft.Office.Interop.Excel.Application();
                _ApplicationXL.Visible = true;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  Function créant un classeur vierge 
        /// </summary> 
        public bool CreerNouveauFichier()
        {
            return CreerNouveauFichier("Feuil1");
        }

        /// <summary> 
        ///  Function créant un classeur vierge et renommant la feuille active 
        /// </summary> 
        public bool CreerNouveauFichier(string NouveauNomFeuille)
        {
            try
            {

                //Récupère le WorkBook 
                _MonClasseur = (_Workbook)(_ApplicationXL.Workbooks.Add(_M));

                //Récupère la feuille Active 
                _MaFeuille = (_Worksheet)_MonClasseur.ActiveSheet;
                //et la remonne 
                _MaFeuille.Name = NouveauNomFeuille;
                //on initialise un Range 
                _MonRange = _MaFeuille.get_Range("A1", "A1");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        /// Teste si le fichier existe, si oui on l'ouvre sinon on le crée et l'enregistre 
        /// </summary> 
        /// <param name="NomFichier"></param> 
        /// <param name="NomFeuille"></param> 
        /// <returns></returns> 
        public bool CreerOuOuvrirFichier(string NomFichier)
        {
            if (File.Exists(NomFichier))
                return OuvrirFichierExistant(NomFichier);
            else
            {
                if (!CreerNouveauFichier()) return false;
                if (!EnregistrerSous(NomFichier)) return false;
                return true;
            }
        }

        /// <summary> 
        ///  NomFichier: chemin complet. 
        ///  Fonctionne corectement à partir de Office 2000 
        /// </summary> 
        public bool EnregistrerSous(string NomFichier)
        {
            _NomFichier = NomFichier;
            try
            //on enregistre sous 
            {
                object FileName = (object)NomFichier;

                _MonClasseur.SaveAs(FileName, _M, _M, _M, _M, _M, XlSaveAsAccessMode.xlNoChange, _M, _M, _M, _M, _M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  NomFichier: chemin complet. 
        ///  Fonctionne corectement à partir de Office 2000 
        /// </summary> 
        public bool EnregistrerSousUnicode(string NomFichier)
        {
            _NomFichier = NomFichier;
            try
            //on enregistre sous 
            {
                object FileName = (object)NomFichier;

                _MonClasseur.SaveAs(FileName, XlFileFormat.xlUnicodeText, _M, _M, _M, _M, XlSaveAsAccessMode.xlNoChange, _M, _M, _M, _M, _M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  NomFichier: chemin complet. 
        ///  Feuille de calcul XML 2003. 
        /// </summary> 
        public bool EnregistrerSousFeuilleCalculXML(string NomFichier)
        {
            _NomFichier = NomFichier;
            try
            //on enregistre sous 
            {
                object FileName = (object)NomFichier;

                _MonClasseur.SaveAs(FileName, XlFileFormat.xlXMLSpreadsheet, _M, _M, (object)false, (object)false, XlSaveAsAccessMode.xlNoChange, _M, _M, _M, _M, _M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  NomFichier : chemin complet. 
        /// </summary> 
        public bool OuvrirFichierExistant(string NomFichier)
        {
            try
            {
                _LesWorkBooks = _ApplicationXL.Workbooks;
                //ouvrir le fichier Excel désiré  
                _MonClasseur = _LesWorkBooks.Open(NomFichier, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M);

                //Active la feuille 1 
                _MaFeuille = (_Worksheet)_MonClasseur.Sheets[1];
                _MaFeuille.Activate();

                //on initialise un Range 
                _MonRange = _MaFeuille.get_Range("A1", "A1");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  NomFichier : chemin complet. 
        ///  NomFeuille : Active la feuille dans le classeur 
        /// </summary> 
        public bool OuvrirFichierExistant(string NomFichier, string NomFeuille)
        {
            try
            {
                if (!OuvrirFichierExistant(NomFichier)) return false;

                //Active la page choisie 
                _MaFeuille = (_Worksheet)_MonClasseur.Sheets[NomFeuille];
                _MaFeuille.Activate();

                //on initialise un Range 
                _MonRange = _MaFeuille.get_Range("A1", "A1");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        ///  Enregistre le document avec le nom prédéfini. 
        /// </summary> 
        public bool Sauver()
        {
            try
            {
                _MonClasseur.Save();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        ///  Sauve, ferme et libére les variables 
        /// </summary> 
        public void FermerWoorkBook()
        {
            this.FermerWoorkBook(true);
        }

        /// <summary> 
        /// Ferme et libére les variables. 
        /// </summary> 
        /// <param name="Sauver">Indique s'il faut sauver avant de fermer.</param> 
        public void FermerWoorkBook(bool Sauver)
        {
            try
            {
                //sauve 
                if (Sauver) this.Sauver();

                //libére la variable feuille 
                if (_MaFeuille != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_MaFeuille);
                    _MaFeuille = null;
                }

                //ferme le WB et libére la variable 
                if (_MonClasseur != null)
                {
                    _MonClasseur.Close(true, _NomFichier, _M);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_MonClasseur);
                    _MonClasseur = null;
                }
            }
            catch
            {
                MessageBox.Show("Impossible de fermer le classeur");
            }
        }

        /// <summary> 
        ///  Quitte, sauve, ferme et libére les variables 
        /// </summary> 
        public void QuitterXl()
        {
            this.QuitterXl(true);
        }

        /// <summary> 
        ///  Quitte, ferme et libére les variables 
        /// </summary> 
        /// <param name="Sauver">Indique s'il faut sauver avant de fermer.</param> 
        public void QuitterXl(bool Sauver)
        {
            //ferme le WB 
            FermerWoorkBook(Sauver);

            //libére la variable WorkBooks 
            if (_LesWorkBooks != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_LesWorkBooks);
                _LesWorkBooks = null;
            }

            //quitte XL et libére la variable 
            if (_ApplicationXL != null)
            {
                _ApplicationXL.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(_ApplicationXL);
                _ApplicationXL = null;
            }
        }

        public void AfficherXL ()
        {
            _ApplicationXL.Visible = true;
        }

        #endregion

        #region Ecriture Données

        /// <summary> 
        ///  Function transcrivant un tableau de string sur une ligne. Les nombres seront interprétés comme du texte. 
        /// </summary> 
        public void EcrireLigne(string[] LigneAEcrire, int NumeroLigne)
        {
            int _Col = 1;

            foreach (string Elements in LigneAEcrire)
            {
                //Ecrit cellule par cellule 
                _MaFeuille.Cells[NumeroLigne, _Col] = Elements;
                _Col++;
            }
            SelectionRange(NumeroLigne, 1, 1, 1);
        }

        /// <summary> 
        ///  Function transcrivant un tableau de objects sur une ligne. Les nombres seront reconnus comme tels. 
        /// </summary> 
        public void EcrireLigne(object[] LigneAEcrire, int NumeroLigne)
        {
            int _Col = 1;

            foreach (object Elements in LigneAEcrire)
            {
                //Ecrit cellule par cellule 
                _MaFeuille.Cells[NumeroLigne, _Col] = Elements;
                _Col++;
            }
            SelectionRange(NumeroLigne, 1, 1, 1);
        }

        /// <summary> 
        /// Ecrit la valeur dans la cellule représentée par son adresse de type A1 
        /// </summary> 
        /// <param name="Valeur"></param> 
        /// <param name="A1"></param> 
        public void EcrireCellule(object Valeur, string A1)
        {
            int ligne;
            int colonne;
            this.AdresseCellL1C1(A1, out ligne, out colonne);
            this.EcrireCellule(Valeur, ligne, colonne);
        }

        /// <summary> 
        /// Ecrit la valeur dans la cellule définie par ses numéros de ligne et de colonne 
        /// </summary> 
        /// <param name="Valeur">Valeur à écrire</param> 
        public void EcrireCellule(object Valeur, int NumeroLigne, int NumeroColonne)
        {
            _MaFeuille.Cells[NumeroLigne, NumeroColonne] = Valeur;
            SelectionRange(NumeroLigne, NumeroColonne, 1, 1);
        }

        #endregion

        #region Sélection

        /// <summary> 
        ///  Active et rennome une feuille selon son numéro 
        /// </summary> 
        public bool ChangerDeFeuilleActive(int NumeroFeuille, string NouveauNom)
        {
            try
            {
                _MaFeuille = (_Worksheet)_MonClasseur.Sheets[NumeroFeuille];
                _MaFeuille.Name = NouveauNom;
                _MaFeuille.Activate();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        /// <summary> 
        ///  Active une feuille selon son nom 
        /// </summary> 
        public bool ChangerDeFeuilleActive(string NomFeuille)
        {
            try
            {
                _MaFeuille = (_Worksheet)_MonClasseur.Sheets[NomFeuille];
                _MaFeuille.Activate();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        ///  Active une feuille selon son numéro 
        /// </summary> 
        public bool ChangerDeFeuilleActive(int NumeroFeuille)
        {
            try
            {
                _MaFeuille = (_Worksheet)_MonClasseur.Sheets[NumeroFeuille];
                _MaFeuille.Activate();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Ajoute une feuille au début et l'active 
        /// </summary> 
        public void AjouterFeuille()
        {
            ChangerDeFeuilleActive(1);
            _MonClasseur.Sheets.Add(_M, _M, _M, _M);
            ChangerDeFeuilleActive(1);
        }

        /// <summary> 
        /// Ajoute une feuille, l'active et la renomme 
        /// </summary> 
        /// <param name="NomFeuille"></param> 
        public void AjouterFeuille(string NomFeuille)
        {
            AjouterFeuille();
            RenommerFeuille(NomFeuille);
        }

        /// <summary> 
        /// Renomme la feuille active 
        /// </summary> 
        /// <param name="NomFeuille"></param> 
        public void RenommerFeuille(string NomFeuille)
        {
            try
            {
                _MaFeuille.Name = NomFeuille;
            }
            catch (Exception e)
            {
                if (e.Message == "Impossible de renommer une feuille comme une autre feuille, une bibliothèque d'objets référencée ou un classeur référencé par Visual Basic.")
                    MessageBox.Show("Une feuille est déjà nommée ainsi. La feuille ne sera pas renommée.");
                else MessageBox.Show(e.Message);
            }

        }

        /// <summary> 
        /// Supprime la feuille active 
        /// </summary> 
        public void SupprimerFeuille()
        {
            _MaFeuille.Delete();
        }

        /// <summary> 
        /// Deplace la feuille active avant l'index 
        /// </summary> 
        /// <param name="Index"></param> 
        public void DeplacerFeuilleAvant(int Index)
        {
            _MaFeuille.Move(_MonClasseur.Sheets[Index], _M);
        }

        /// <summary> 
        ///  Selectionne le range compris entre deux cellules 
        /// </summary> 
        public void SelectionRange(string CellTypA1, string CellTypB2)
        {
            _MonRange = _MaFeuille.get_Range(CellTypA1, CellTypB2);
        }

        /// <summary> 
        /// Selectionne un Range. 
        /// </summary> 
        /// <param name="Ligne">Ligne de la cellule Haut Gauche</param> 
        /// <param name="Colonne">Colonne de la cellule Haut Gauche</param> 
        /// <param name="Hauteur">Nombre de Lignes</param> 
        /// <param name="Largeur">Nombres de Colonnes</param> 
        public void SelectionRange(int Ligne, int Colonne, int Hauteur, int Largeur)
        {
            string CellTypA1 = this.AdresseCellTypeA1(Ligne, Colonne);
            string CellTypB2 = this.AdresseCellTypeA1(Ligne + Hauteur - 1, Colonne + Largeur - 1);
            _MonRange = _MaFeuille.get_Range(CellTypA1, CellTypB2);
        }

        /// <summary> 
        /// Sélectionne la colonne passée en paramètre. 
        /// </summary> 
        /// <param name="Colonne"></param> 
        public void SelectionColonne(string Colonne)
        {
            string MaColonne = string.Format("{0}:{1}", Colonne, Colonne);
            _MonRange = _MaFeuille.get_Range(MaColonne, _M);
        }

        /// <summary> 
        /// Sélectionne la ligne passée en paramètre. 
        /// </summary> 
        /// <param name="Colonne"></param> 
        public void SelectionLigne(int Ligne)
        {
            string MaLigne = string.Format("{0}:{1}", Ligne, Ligne);
            _MonRange = _MaFeuille.get_Range(MaLigne, _M);
        }

        /// <summary> 
        /// Supprime une sélection et décalle les données suivant le paramètre. 
        /// </summary> 
        /// <param name="SensDecallageDonnees"></param> 
        public void SupprimerRange(XlDeleteShiftDirection SensDecallageDonnees)
        {
            _MonRange.Delete(SensDecallageDonnees);
        }

        /// <summary> 
        /// Selectionne visuellement le Range, 
        /// s'il n'est constitué que d'une cellule, celle ci devient la cellule active 
        /// (Permet de deplacer la zone visible de la feuille vers la zone de travail). 
        /// </summary> 
        public void ActiverRange()
        {
            try
            {
                _MonRange.Select();
            }
            catch { }
        }

        /// <summary> 
        /// Atteint la derniere cellule utilisée, et retourne son adresse du type A1. 
        /// Attention, une cellule vide avec un formattage particulié 
        /// ou une cellule contenant une chaine vide est utilisée. 
        /// </summary> 
        public string AtteindreDerniereCelluleFeuille()
        {
            _MonRange.SpecialCells(XlCellType.xlCellTypeLastCell, _M).Select();
            _MonRange = _ApplicationXL.ActiveCell;
            return this.AdresseCellTypeA1(_MonRange.Row, _MonRange.Column);
        }

        /// <summary> 
        /// Atteindre la derniére Cellule utilisée d'une colonne. 
        /// Incompatible avec un fichiers texte formatté xls. 
        /// </summary> 
        /// <param name="Colonne">Numéro de la colonne concernée (de 1 à n)</param> 
        /// <returns></returns> 
        public int AtteindreDerniereCelluleColonne(int Colonne)
        {
            //on part d'en bas et on cherche la premiere cellule utilisée 
            string DerniereCelluleFeuille = this.AdresseCellTypeA1(_MaFeuille.Rows.Count, Colonne);
            _MonRange = _MonRange.get_Range(DerniereCelluleFeuille, DerniereCelluleFeuille);

            _MonRange.get_End(XlDirection.xlUp).Select();
            _MonRange = _ApplicationXL.ActiveCell;
            return _MonRange.Row;
        }

        /// <summary> 
        /// Returne l'adresse, du type A1, de la derniere cellule non vide, 
        /// en partant d'une cellule dans une direction définie 
        /// </summary> 
        /// <param name="CelluleDepart"></param> 
        /// <param name="Direction"></param> 
        /// <returns></returns> 
        public string AtteindreDerniereCelluleNonVide(string CelluleDepart, XlDirection Direction)
        {
            _MonRange = _MonRange.get_Range(CelluleDepart, CelluleDepart);
            _MonRange.get_End(Direction).Select();
            _MonRange = _ApplicationXL.ActiveCell;
            return this.AdresseCellTypeA1(_MonRange.Row, _MonRange.Column);
        }

        public void Imprime()
        {
            object Copies = (object)1;
            object PrinterName = (object)"PDFCreator sur Ne00:";
            object Vrai = (object)true;

            _ApplicationXL.ActivePrinter = PrinterName.ToString();
            _MonClasseur.PrintOut(_M, _M, Copies, _M, PrinterName, _M, Vrai, _M);

        }
        #endregion

        #region Cellule

        /// <summary> 
        ///  Convertit les adresses de Cellule type L1C1 en type A1 
        /// </summary> 
        public string AdresseCellTypeA1(string L1C1)
        {

            int Ligne = 0;
            int Colonne = 0;

            return this.AdresseCellTypeA1(L1C1, out Ligne, out Colonne);
        }

        /// <summary> 
        ///  Convertit les adresses de Cellule type L1C1 en type A1 
        /// </summary> 
        /// <param name="L1C1">Adresse d'entrée</param> 
        /// <param name="Ligne"></param> 
        /// <param name="Colonne"></param> 
        /// <returns></returns> 
        public string AdresseCellTypeA1(string L1C1, out int Ligne, out int Colonne)
        {
            int index = L1C1.IndexOf("C");
            Ligne = Convert.ToInt16(L1C1.Substring(1, index - 1));
            Colonne = Convert.ToInt16(L1C1.Substring(index + 1));

            return this.AdresseCellTypeA1(Ligne, Colonne);
        }

        /// <summary> 
        ///  Convertit les numéros de ligne et colonne en adresses de Cellule type A1 
        /// </summary> 
        public string AdresseCellTypeA1(int Ligne, int Colonne)
        {
            if (Ligne < 1 || Colonne < 1) { return null; }
            else
            {
                if (Colonne < 27)
                {
                    char Lettre = new char();
                    //convertit la valeur de colonne en lettre majuscule A = 65 
                    Lettre = Convert.ToChar(Colonne + 64);

                    return string.Format("{0}{1}", Lettre.ToString(), Ligne);
                }
                else
                {
                    ////optient la premiere lettre par division la deuxiéme est le reste 
                    //int Lettre2; 
                    //int Lettre1 = Math.DivRem(Colonne, 26, out Lettre2); 

                    ////converti la valeur de colonne et lettre majuscule A = 65 etc 
                    //char Lettre11 = new char(); 
                    //Lettre11 = Convert.ToChar(Lettre1 + 64); 
                    //char Lettre22 = new char(); 
                    //Lettre22 = Convert.ToChar(Lettre2 + 64); 

                    //optient la premiere lettre par division la deuxiéme est le reste 
                    int Lettre2;
                    int Lettre1 = Math.DivRem((Colonne - 1), 26, out Lettre2);

                    //converti la valeur de colonne et lettre majuscule A = 65 etc 
                    //                    char Lettre11 = new char(); 
                    char Lettre11;
                    Lettre11 = Convert.ToChar(Lettre1 + 64);
                    //                    char Lettre22 = new char(); 
                    char Lettre22;
                    Lettre22 = Convert.ToChar(Lettre2 + 65);
                    return string.Format("{0}{1}{2}", Lettre11.ToString(), Lettre22.ToString(), Ligne);

                }
            }
        }

        /// <summary> 
        /// Retourne l'adresse de type L1C1 depuis une adresse de type A1 
        /// </summary> 
        /// <param name="A1"></param> 
        /// <returns></returns> 
        public string AdresseCellL1C1(string A1)
        {
            int toto;
            int tutu;
            return this.AdresseCellL1C1(A1, out toto, out tutu);
        }

        /// <summary> 
        /// Retourne l'adresse de type L1C1 depuis une adresse de type A1, les paramétres numéro de ligne et de colonne sont récupérables 
        /// </summary> 
        /// <param name="A1"></param> 
        /// <returns></returns> 
        public string AdresseCellL1C1(string A1, out int NumeroLigne, out int NumeroColonne)
        {
            int[] Lettre = { 0, 0 };
            NumeroLigne = 0;
            NumeroColonne = 0;

            for (int i = 0; i < A1.Length; i++)
            {
                char Car = A1[i];

                if ((Car > 64) && (Car < 91))// c'est une lettre 
                {
                    Lettre[i] = Convert.ToInt32(Car) - 64;
                }
                else
                {
                    NumeroLigne = Convert.ToInt32(A1.Substring(i));
                    i = A1.Length;
                }
            }

            if (Lettre[1] == 0)
            {
                NumeroColonne = Lettre[0];
            }
            else
            {
                NumeroColonne = 26 * Lettre[0] + Lettre[1];
            }

            return string.Format("L{0}C{1}", NumeroLigne.ToString(), NumeroColonne.ToString());
        }

        #endregion

        #region Formats et mise en Forme

        /// <summary> 
        ///  Encadre les cellules d'un range 
        /// </summary> 
        public void EncradrementRange(TypeEncadrement Encadrement)
        {
            switch (Encadrement)
            {
                case TypeEncadrement.ToutesCellulesFin:
                    _MonRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    //_MonRange.Borders.Weight = XlBorderWeight.xlThin; 
                    break;

                case TypeEncadrement.ToutesCellulesMoyen:
                    _MonRange.Borders.LineStyle = XlLineStyle.xlContinuous;
                    _MonRange.Borders.Weight = XlBorderWeight.xlMedium;
                    break;

                case TypeEncadrement.Aucun:
                    _MonRange.Borders.LineStyle = XlLineStyle.xlLineStyleNone;
                    break;

                case TypeEncadrement.ExtérieurRangeFin:
                    _MonRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, _M);
                    break;

                case TypeEncadrement.ExtérieurRangeMoyen:
                    _MonRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, _M);
                    break;

            }
        }

        /// <summary> 
        /// Fusionne le range sélectionné 
        /// </summary> 
        public void FusionnerRange()
        {
            _MonRange.Merge(_M);
        }

        /// <summary> 
        /// Colore le fond du range sélectnionné 
        /// </summary> 
        /// <param name="MaCouleur"></param> 
        public void CouleurFondRange(Color MaCouleur)
        {
            _MonRange.Interior.Color = MaCouleur.ToArgb();
        }

        /// <summary> 
        /// Applique une mise en forme conditionnelle au Range 
        /// </summary> 
        /// <param name="A1"></param> 
        /// <param name="Formule"></param> 
        public void MiseEnFormeConditionnelle(string Formule, ColorIndex FontColorIndex, ColorIndex BackColorIndex)
        {

            _MonRange.FormatConditions.Add(XlFormatConditionType.xlExpression, _M, Formule, _M);
            int i = _MonRange.FormatConditions.Count;
            _MonRange.FormatConditions[i].Font.ColorIndex = (int)FontColorIndex;
            _MonRange.FormatConditions[i].Interior.ColorIndex = (int)BackColorIndex;
        }

        /// <summary> 
        /// Applique une couleur de police et de fond au range 
        /// </summary> 
        /// <param name="FontColorIndex"></param> 
        /// <param name="BackColorIndex"></param> 
        public void MiseEnForme(ColorIndex FontColorIndex, ColorIndex BackColorIndex)
        {
            _MonRange.Interior.ColorIndex = BackColorIndex;
            _MonRange.Font.ColorIndex = FontColorIndex;
        }

        /// <summary> 
        /// Mets le range en cours au Format % 
        /// </summary> 
        public void FormatPourcent()
        {
            //object Forma = (object)"0.00%"; 
            //_MonRange.NumberFormat = Forma; 
        }

        #endregion

        #region Graphique

        /// <summary> 
        ///  Crée une courbe sur une nouvelle page graphique 
        /// </summary> 
        public void CreerGraphique(string NomFeuilleDonnees, string CellHautGauche, int NbreLignes, int NbreColonnes, string Titre, string CellSerie, string NomFeuille)
        {
            //Creation d'une nouvelle feuille graphique au début du classeur 
            _MonGraphique = (_Chart)_MonClasseur.Sheets.Add(_MonClasseur.Sheets[1], _M, 1, XlWBATemplate.xlWBATChart);

            //type de graphique: Nuage de points avec ligne droites, sans marqueurs 
            _MonGraphique.ChartType = XlChartType.xlXYScatterLinesNoMarkers;

            //Donne un nom à la feuille 
            _MonGraphique.Name = NomFeuille;

            //Selection de la feuille ou sont les données pour ensuit creer le range 
            _MaFeuille = (_Worksheet)_MonClasseur.Sheets[NomFeuilleDonnees];

            //le range commence à CelleHautGauche, descend de NbreLignes, est large de NbreColonnes. Si CellSerie n'est pas dans le Range, alors ce sera le nom de la série 
            _MonRange = _MaFeuille.get_Range(CellHautGauche, CellSerie).get_Resize(NbreLignes + 1, NbreColonnes);

            //Injecte la premiére série 
            _MonGraphique.SetSourceData(_MonRange, XlRowCol.xlColumns);

            //Si la Série à un nom, c'est automaiquement le titre, on peut alors le modifier. 
            if (_MonGraphique.HasTitle) { _MonGraphique.ChartTitle.Text = Titre; }

            //Récupére la série 
            //Series _MaSerie = (Series)_MonGraphique.SeriesCollection(0); 

            //lui donne un tire 
            //_MaSerie.Name = NomSerie; 
            //int toto = ((Lines)_MonGraphique.Lines(1)).Count; 
            //Line maligne = (Line)_MonGraphique.Lines(0); 

            //maligne.Duplicate(); 

        }

        /// <summary> 
        ///  Ajoute une courbe au graphique actif 
        /// </summary> 
        public void AjouterCourbe(string Nom, string NomFeuilleDonnee, string CelluleHautX, string CelluleBasX, string CelluleHautY, string CelluleBasY)
        {
            //Crée la nouvelle série 
            SeriesCollection _MesSeries = ((SeriesCollection)_MonGraphique.SeriesCollection(_M));
            Series _MaSerie = _MesSeries.NewSeries();

            //passe les paramétres 
            _MaSerie.Name = Nom;

            //definiyio, des plage de données du type "='Moyennes'!$C$2:$C$5" 
            string PlageDonneesX = string.Format("='{0}'!${1}${2}:${3}${4}", NomFeuilleDonnee, CelluleHautX[0], CelluleHautX[1], CelluleBasX[0], CelluleBasX[1]);
            string PlageDonneesY = string.Format("='{0}'!${1}${2}:${3}${4}", NomFeuilleDonnee, CelluleHautY[0], CelluleHautY[1], CelluleBasY[0], CelluleBasY[1]);
            _MaSerie.XValues = PlageDonneesX;
            _MaSerie.Values = PlageDonneesY;
        }

        #endregion

        #region Lecture Données

        /// <summary> 
        /// Recherche le texte à l'intérieur des forumules et retourne l'adresse de la cellule du type A1. 
        /// La recherche débute par la cellule A1. 
        /// Ne trouve pas le resultat d'une concaténation. 
        /// </summary> 
        /// <param name="TexteATrouver"></param> 
        /// <returns></returns> 
        public string Chercher(string TexteATrouver)
        {
            //Par déaut la recherche débute à partir de la case A1 
            this.SelectionRange("A1", "A1");
            return this.ChercherSuivant(TexteATrouver);
        }

        /// <summary> 
        /// Recherche le texte à l'intérieur des forumules et retourne l'adresse de la cellule du type A1. 
        /// La recherche débute la cellule A1. 
        /// Retourne la valeur de la cellule en paramétre. 
        /// </summary> 
        /// <param name="TexteATrouver"></param> 
        /// <returns></returns> 
        public string Chercher(string TexteATrouver, out string Contenu)
        {
            int Ligne = 0;
            int Colonne = 0;

            string Cellule = this.Chercher(TexteATrouver);
            Contenu = this.LireCellule(Cellule, out  Ligne, out Colonne);
            return Cellule;
        }

        /// <summary> 
        /// Recherche le texte à l'intérieur des forumules et retourne l'adresse de la cellule du type A1. 
        /// La recherche débute aprés le Range Actif, ce qui est parfois générateur de bug. 
        /// </summary> 
        /// <param name="TexteATrouver"></param> 
        /// <returns></returns> 
        public string ChercherSuivant(string TexteATrouver)
        {
            object What = (object)TexteATrouver;

            if (_MonRange.Cells.Count != 1) this.SelectionRange("A1", "A1");
            //fonction find 
            _MonRange = _MaFeuille.Cells.Find(What, _MonRange, _M, XlLookAt.xlPart, XlSearchOrder.xlByColumns, XlSearchDirection.xlNext, (object)false, _M, (object)false);

            if (_MonRange == null)
            {
                return "Recherche infructeuse";
            }
            else
            {
                //Active la céllule trouvée 
                _MonRange.Activate();
                return string.Format("L{0}C{1}", _MonRange.Row.ToString(), _MonRange.Column.ToString());
            }
        }

        /// <summary> 
        /// Recherche le texte à l'intérieur des forumules et retourne l'adresse de la cellule du type A1. 
        /// La recherche débute aprés le Range. 
        /// Retourne la valeur de la cellule en paramétre. 
        /// </summary> 
        /// <param name="TexteATrouver"></param> 
        /// <returns></returns> 
        public string ChercherSuivant(string TexteATrouver, out string Contenu)
        {
            int Ligne = 0;
            int Colonne = 0;

            string Cellule = this.ChercherSuivant(TexteATrouver);
            Contenu = this.LireCellule(Cellule, out  Ligne, out Colonne);
            return Cellule;
        }

        /// <summary> 
        /// Remplace une chaine dans le range en cours, sans condition de casse, de texte entier ni de format 
        /// </summary> 
        /// <param name="TexteAChercher">Texte à trouver</param> 
        /// <param name="TexteAEcrire">Texte de remplacement</param> 
        public void Remplacer(string TexteAChercher, string TexteAEcrire)
        {
            _MonRange.Replace(TexteAChercher, TexteAEcrire, XlLookAt.xlPart, XlSearchOrder.xlByRows, false, _M, false, false);
        }

        /// <summary> 
        /// Remplace plusieurs chaines dans le range en cours, sans condition de casse, de texte entier ni de format 
        /// </summary> 
        /// <param name="TexteAChercher">Tableau de string comportant toutes les occurences à remplacer</param> 
        /// <param name="TexteAEcrire">Texte de remplacement</param> 
        public void Remplacer(string[] TexteAChercher, string TexteAEcrire)
        {
            foreach (string Texte in TexteAChercher)
                this.Remplacer(Texte, TexteAEcrire);
        }

        /// <summary> 
        /// Retourne le contenu de la cellule (Formule, long pour les dates etc...) 
        /// </summary> 
        /// <param name="AdresseA1"></param> 
        /// <returns></returns> 
        public string LireCellule(string AdresseA1)
        {
            this.SelectionRange(AdresseA1, AdresseA1);
            try
            {
                return (string)_MonRange.Value2;
            }
            catch
            {
                return _MonRange.Value2.ToString();
            }
        }

        /// <summary> 
        /// Retourne le contenu de la cellule (Formule, long pour les dates etc...) 
        /// </summary> 
        /// <param name="AdresseA1"></param> 
        /// <param name="Texte">Retourne le Texte de la Cellule</param> 
        /// <returns></returns> 
        public string LireCellule(string AdresseA1, out string Texte)
        {
            this.SelectionRange(AdresseA1, AdresseA1);
            Texte = (string)_MonRange.Text;
            return (string)_MonRange.Value2;
        }

        /// <summary> 
        /// Retourne le contenu de la cellule. 
        /// </summary> 
        /// <param name="AdresseA1"></param> 
        /// <returns></returns> 
        public string LireCellule(string AdresseL1C1, out int NumeroLigne, out int NumeroColonne)
        {
            string AdresseA1 = this.AdresseCellTypeA1(AdresseL1C1, out NumeroLigne, out NumeroColonne);
            return this.LireCellule(AdresseA1);

        }

        /// <summary> 
        /// Retourne le contenu de la cellule. 
        /// </summary> 
        /// <param name="AdresseA1"></param> 
        /// <returns></returns> 
        public string LireCellule(int NumeroLigne, int NumeroColonne, out string Texte)
        {
            string AdresseA1 = this.AdresseCellTypeA1(NumeroLigne, NumeroColonne);
            return this.LireCellule(AdresseA1, out Texte);
        }

        /// <summary> 
        /// Retourne le contenu de la cellule. 
        /// </summary> 
        /// <param name="AdresseA1"></param> 
        /// <param name="Texte">Retourne le Texte de la Cellule</param> 
        /// <returns></returns> 
        public string LireCellule(int NumeroLigne, int NumeroColonne)
        {
            string AdresseA1 = this.AdresseCellTypeA1(NumeroLigne, NumeroColonne);
            return this.LireCellule(AdresseA1);
        }

        /// <summary> 
        /// Protège la feuille, sans mot de passe 
        /// </summary> 
        public bool ProtegerFeuille()
        {
            object Vrai = (object)true;
            object Faux = (object)false;

            try
            {
                _MaFeuille.Protect(_M, Vrai, Vrai, Vrai, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Protège la feuille avec mot de passe 
        /// </summary> 
        /// <param name="MotDePasse">si chaine vide est saisi, il n'y aura pas de mot de passe</param> 
        public bool ProtegerFeuille(string MotDePasse)
        {
            object Vrai = (object)true;
            object Faux = (object)false;
            object Password = (object)MotDePasse;

            try
            {
                _MaFeuille.Protect(Password, Vrai, Vrai, Vrai, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M, _M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Ote la protection d'une feuille, sans mot de passe 
        /// </summary> 
        public bool OterProtectionFeuille()
        {

            try
            {
                _MaFeuille.Unprotect(_M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Ote la protection d'une feuille avec mot de passe 
        /// </summary> 
        /// <param name="MotDePasse"></param> 
        public bool OterProtectionFeuille(string MotDePasse)
        {
            object Password = (object)MotDePasse;

            try
            {
                _MaFeuille.Unprotect(MotDePasse);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Protège le classeur, sans mot de passe 
        /// </summary> 
        /// <param name="Structure">La structure est protégée</param> 
        /// <param name="Fenetres">Les fenêtre sont protégées</param> 
        public bool ProtegerClasseur(bool Structure, bool Fenetres)
        {
            object _Structure = (object)Structure;
            object _Fenetres = (object)Fenetres;

            try
            {
                _MonClasseur.Protect(_M, _Structure, _Fenetres);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Protège le classeur, avec mot de passe 
        /// </summary> 
        /// <param name="Structure">La structure est protégée</param> 
        /// <param name="Fenetres">Les fenêtre sont protégées</param> 
        public bool ProtegerClasseur(string MotDePasse, bool Structure, bool Fenetres)
        {
            object Password = (object)MotDePasse;
            object _Structure = (object)Structure;
            object _Fenetres = (object)Fenetres;

            try
            {
                _MonClasseur.Protect(_M, _Structure, _Fenetres);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Ote la protection d'un classeur 
        /// </summary> 
        public bool OterProtectionClasseur()
        {
            try
            {
                _MonClasseur.Unprotect(_M);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        /// <summary> 
        /// Ote la protection d'un classeur avec mot de passe 
        /// </summary> 
        public bool OterProtectionClasseur(string MotDePasse)
        {
            object Password = (object)MotDePasse;

            try
            {
                _MonClasseur.Unprotect(MotDePasse);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        #endregion

        //Conversion chiffre --> lettre
        static readonly string[] Alphabet = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH" };
        public static string NumberToLetter(int index)
        {
            return Alphabet[index - 1];
        }

        //Exemple : (string) L1C3 donne (UInt16) 1
        public UInt16 CvLigne(string cellule)
        {
            string ligne_str;
            UInt16 nbligne;
            char[] charselect = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            ligne_str = cellule.TrimEnd(charselect);
            ligne_str = ligne_str.Trim(new char[] { 'L', 'C' });
            nbligne = UInt16.Parse(ligne_str);
            return nbligne;
        }

        //Exemple : (string) L1C3 donne (UInt16) 3
        public UInt16 CvColonne(string cellule)
        {
            string colonne_str;
            UInt16 nbcolonne;
            char[] charselect = { 'L', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            colonne_str = cellule.TrimStart(charselect);
            colonne_str = colonne_str.Remove(0, 1);
            nbcolonne = UInt16.Parse(colonne_str);
            return nbcolonne;
        }
      
    }
    public enum ColorIndex
    {
        Jaune = 6,
        Mauve = 7,
        Orange = 44,
        Vert = 4,
        Azur = 8,
        Rouge = 3,
        Noir = 1,
        Automatique = 0
    }

}