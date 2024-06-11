using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main(string[] args)
    {
        bool invalide = true;
        int convertedTotal = 0;
        string romanNumerals; // Chiffres entrée par l'utilisateur
        // Pattern (["Milieu"]?["Unité"]{0,3}|cas particulier 1|cas particulier 2)
        string pattern = "^[M]{0,3}([D]?[C]{0,3}|CM|CD)([L]?[X]{0,3}|XC|XL)([V]?[I]{0,3}|IX|IV)$";
        List<string> decomposedRomanNumerals = new List<string>();

        do
        {
            // Saisie de l'utilisateur
            Console.Write("Veuillez entrez un chiffre romains : ");
            romanNumerals = Console.ReadLine();

            // On vérifie la validité de l'ordre, les cas particuliers
            if (Regex.IsMatch(romanNumerals, pattern))
            {
                Console.WriteLine("Valide");
                invalide = false;
            }
            else
            {
                Console.WriteLine("Invalide");
            }
        }
        while (invalide);

        // Décomposition des chiffres romains
        Fonctions.RomanNumeralsDecomposition(romanNumerals, decomposedRomanNumerals);

        // Conversion des chiffres romains et renvoie de la somme
        convertedTotal = Fonctions.RomansToDecimal(decomposedRomanNumerals);

        // Affichage du résultat en valeur décimal
        Console.WriteLine("Résultat de la conversion : " + convertedTotal);
    }
}