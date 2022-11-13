using System;
using System.IO;

namespace Mots_croisés
{//idée: faire un système de ELO
 // faire la sauvegarde
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionnaire dico = new Dictionnaire("FR");
            Console.WriteLine(dico.ToString());

            string mot = "FATOS";
            int max = dico.Mots[mot.Length - 2].Length;
            bool a = dico.RechDichoRecursif(mot, 0, max);
            Console.WriteLine(a);


        }
    }
}