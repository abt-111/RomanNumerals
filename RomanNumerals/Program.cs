using System;
using System.Text.RegularExpressions;

class MainClass
{
    public static void Main(string[] args)
    {
        int convertedTotal = 0;
        string romanNumerals; // Chiffres entrée par l'utilisateur
        string pattern = "^[MDCLXVI]*$";
        List<string> decomposedRomanNumerals = new List<string>();

        // Saisie de l'utilisateur
        Console.Write("Veuillez entrez un chiffre romains : ");
        
        romanNumerals = Console.ReadLine();


        // On vérifie que l'utilisateur ne rentre que des chiffres romains (on ne vérifie pas l'order)
        if (Regex.IsMatch(romanNumerals, pattern))
        {
            Console.WriteLine("Valide");
        }
        else
        {
            Console.WriteLine("Invalide");
        }

        // Décomposition des chiffres romains
        //Fonctions.RomanNumeralsDecomposition(romanNumerals, decomposedRomanNumerals);

        // Conversion des chiffres romains et renvoie de la somme
        //convertedTotal = Fonctions.RomansToDecimal(decomposedRomanNumerals);

        //Console.WriteLine("Résultat de la conversion : " + convertedTotal);
    }
}