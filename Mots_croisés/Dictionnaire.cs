using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mots_croisés
{
    internal class Dictionnaire
    {
        private string langue;
        private string[][] mots = new string[14][];//le nbr de lettres est compris entre 2 et 15

        public Dictionnaire(string langue)
        {
            this.langue = langue;
            if (langue == "FR")
            {
                string nameFile = "MotsPossiblesFR.txt";//nom fichier du dico
                string chemin = Path.GetFullPath(nameFile);//on cherhce le fichier dans les dossiers

                if (File.Exists(chemin))
                {
                    int cpt = 0;
                    string[] ttMots = File.ReadAllLines(chemin);//on met chaque mot du même nombre de lettres sous un seul string dans le tableau ttMots 
                    for (int i = 0; i < ttMots.Length; i++)
                    {
                        if (i % 2 != 0)//si la ligne est impair on sépare chaque mot du même nbr de lettres dans le tableau de tableau mots.
                        {
                            this.mots[cpt] = ttMots[i].Split(" ");
                            cpt++;
                        }
                    }
                }

            }
            else
            {
                string nameFile = "MotsPossiblesEN.txt";
                string chemin = Path.GetFullPath(nameFile);

                if (File.Exists(chemin))
                {
                    int cpt = 0;
                    string[] ttMots = File.ReadAllLines(chemin);
                    for (int i = 0; i < ttMots.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            this.mots[cpt] = ttMots[i].Split(" ");
                            cpt++;
                        }
                    }
                }
            }

        }

        public string[][] Mots
        {
            get { return this.mots; }
        }

        /// <summary>
        ///  retourne une chaîne de caractères qui décrit le dictionnaire à savoir ici le nombre de mots par longueur et la langue.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string msg;
            msg = $"Le jeu est en {this.langue}.";
            for(int i = 0; i < this.mots.Length; i++)
            {
                msg += "\n" + $"Il y a {this.mots[i].Length} mots de {i+2} lettres.";
            }
            return msg;
        }

        /// <summary>
        /// Recherche d'un mot dans le dictionnaire de façon dichotomique (réduit l'espace de recherche à chaque tour de boucle) et récursive(s'appelle elle-même)
        /// </summary>
        /// <param name="mot">mot à rechercher dans le dictionnaire</param>
        /// <param name="min">borne inférieure de la zone de recherche du dictionnaire</param>
        /// <param name="max">borne supérieure de la zone de recherche du dictionnaire</param>
        /// <returns></returns>
        public bool RechDichoRecursif(string mot, int min, int max)
        {
            int m = (min + max) / 2;//on cherche le milieu de la zone actuelle de recherche
            if (max-min == 0 && this.mots[mot.Length - 2][m] != mot)
            {
                return false;//si le dernier mot restant de la zone de recherche actuelle est différent du mot recherché alors ce dernier n'est pas dans le dictionnaire
            }
            if (this.mots[mot.Length - 2][m] == mot)
            {
                return true; //si le dernier mot restant de la zone de recherche actuelle est identique au mot recherché alors ce dernier est dans le dictionnaire
            }
            if (this.mots[mot.Length - 2][m].CompareTo(mot) > 0)//on regarde quel mot est le premier dans l'ordre alphabétique entre le mot recherché et le mot du milieu
            {
                return RechDichoRecursif(mot, min, m-1);
            }
            else
            {
                return RechDichoRecursif(mot, m+1, max);
            }
        }
    }
}
