using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_croisés
{
    internal class Joueur
    {
        private string nom;
        private int score;
        private List<string> mots_trouvés;
        private Plateau plateauActuel;

        public Joueur(string nom)
        {
            this.nom = nom;
            this.score = 0;
            this.mots_trouvés = new List<string>();
        }
        /// <summary>
        /// Ajoute un mot trouvé par le joueur à la liste des mots trouvés.
        /// </summary>
        /// <param name="mot">mot trouvé par le joueur</param>
        public void Add_Mot(string mot)
        {
            this.mots_trouvés.Add(mot);
        }

        /// <summary>
        /// retourne une chaîne de caractères qui décrit un joueur.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Ce joueur est " + this.nom + " et possède un score de " + this.score + "pts.");
        }

        /// <summary>
        /// ajoute une valeur au score.
        /// </summary>
        /// <param name="val">valeur à ajouter au score</param>
        public void Add_Score(int val)
        {
            this.score += val;
        }
    }
}
