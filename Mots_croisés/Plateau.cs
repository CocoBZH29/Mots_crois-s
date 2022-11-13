using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_croisés
{
    internal class Plateau
    {
        char[,] plateau;
        int nvDiff;
        int nbrLignes;
        int nbrColonnes;
        string[] motsATrouver;

        public Plateau(int nvDiff)
        {
            this.nvDiff = nvDiff;
            switch(nvDiff)
            {
                case 1:
                    {
                        this.nbrLignes = 7;
                        this.nbrColonnes = 6;
                        this.plateau = new char[nbrLignes, nbrLignes];
                    }break;
                case 2:
                    {
                        this.nbrLignes = 8;
                        this.nbrColonnes =7;
                        this.plateau = new char[nbrLignes, nbrLignes];
                    }
                    break;
                case 3:
                    {
                        this.nbrLignes = 10;
                        this.nbrColonnes = 9;
                        this.plateau = new char[nbrLignes, nbrLignes];
                    }
                    break;
                case 4:
                    {
                        this.nbrLignes = 11;
                        this.nbrColonnes = 11;
                        this.plateau = new char[nbrLignes, nbrLignes];
                    }
                    break;
                case 5:
                    {
                        this.nbrLignes = 13;
                        this.nbrColonnes = 13;
                        this.plateau = new char[nbrLignes, nbrLignes];
                    }
                    break;
            }
        }

        /// <summary>
        /// retourne une chaîne de caractères qui décrit le plateau.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string msg = "";
            switch(this.nvDiff)
            {
                case 1:
                    {
                        msg += $"Le plateau est de difficulté {this.nvDiff}. Donc, les mots sont situés sur les lignes de gauche à droite et sur les colonnes de haut en bas";
                        msg += "\n"+"Les mots à trouver sont : ";
                        for(int i = 0; i < this.motsATrouver.Length; i++)
                        {
                            msg += "\n" + $"{this.motsATrouver[i]};";
                        }
                    }break;
                case 2:
                    {
                        msg += $"Le plateau est de difficulté {this.nvDiff}. Donc, les mots répondent à la difficulté 1 et peuvent être lus de droite à gauche et de bas en haut";
                        msg += "\n" + "Les mots à trouver sont : ";
                        for (int i = 0; i < this.motsATrouver.Length; i++)
                        {
                            msg += "\n" + $"{this.motsATrouver[i]};";
                        }
                    }
                    break;
                case 3:
                    {
                        msg += $"Le plateau est de difficulté {this.nvDiff}. Donc, les mots répondent à la difficulté 2 et peuvent être sur les diagonales (NE-SO) de haut en bas";
                        msg += "\n" + "Les mots à trouver sont : ";
                        for (int i = 0; i < this.motsATrouver.Length; i++)
                        {
                            msg += "\n" + $"{this.motsATrouver[i]};";
                        }
                    }
                    break;
                case 4:
                    {
                        msg += $"Le plateau est de difficulté {this.nvDiff}. Donc, les mots répondent à la difficulté 3 et peuvent être sur les diagonales (NO-SE) de haut en bas";
                        msg += "\n" + "Les mots à trouver sont : ";
                        for (int i = 0; i < this.motsATrouver.Length; i++)
                        {
                            msg += "\n" + $"{this.motsATrouver[i]};";
                        }
                    }
                    break;
                case 5:
                    {
                        msg += $"Le plateau est de difficulté {this.nvDiff}. Donc, les mots répondent à la difficulté 4 et peuvent être sur toutes les diagonales de bas en haut";
                        msg += "\n" + "Les mots à trouver sont : ";
                        for (int i = 0; i < this.motsATrouver.Length; i++)
                        {
                            msg += "\n" + $"{this.motsATrouver[i]};";
                        }
                    }
                    break;
            }
            return msg;
        }

        public static char[] générerPlateau()
        {

        }

        /// <summary>
        /// sauvegarde l’instance du plateau dans un fichier.
        /// </summary>
        /// <param name="nomfile">C'est le nom du fichier à sauvegarder</param>
        public void ToFile(string nomfile, Joueur personne)
        {
            string[] sauvegarde =[$"{this.nvDiff}", $"{}" ]
        }
    }
}
