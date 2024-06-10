using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main(string[] args)
    {
        int convertedTotal = 0;
        string romanNumerals; // Chiffres entrée par l'utilisateur
        string pattern1 = "^[MDCLXVI]*$";
        string pattern2 = "^[M]{0,3}([D]?[C]{0,3}|CM|CD)([L]?[X]{0,3}|XC|XL)([V]?[I]{0,3}|IX|IV)$";
        List<string> decomposedRomanNumerals = new List<string>();

        // Saisie de l'utilisateur
        Console.Write("Veuillez entrez un chiffre romains : ");

        while(true)
        {
            romanNumerals = Console.ReadLine();

            // On vérifie que l'utilisateur ne rentre que des chiffres romains (pas la validité de l'ordre etc)
            if (Regex.IsMatch(romanNumerals, pattern1))
            {
                Console.WriteLine("Valide");
            }
            else
            {
                Console.WriteLine("Invalide");
            }

            // On vérifie la validité de l'ordre etc
            if (Regex.IsMatch(romanNumerals, pattern2))
            {
                Console.WriteLine("Valide");
            }
            else
            {
                Console.WriteLine("Invalide");
            }
        }

        // Décomposition des chiffres romains
        //Fonctions.RomanNumeralsDecomposition(romanNumerals, decomposedRomanNumerals);

        // Conversion des chiffres romains et renvoie de la somme
        //convertedTotal = Fonctions.RomansToDecimal(decomposedRomanNumerals);

        //Console.WriteLine("Résultat de la conversion : " + convertedTotal);
    }
}