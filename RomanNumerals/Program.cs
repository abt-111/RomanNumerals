class MainClass
{
    public static void Main(string[] args)
    {
        int convertedTotal = 0;
        string romanNumerals; // Chiffres entrée par l'utilisateur
        List<string> decomposedRomanNumerals = new List<string>();

        // Saisie de l'utilisateur (pour l'instant on suppose que l'entrée est toujours correct)
        Console.Write("Veuillez entrez un chiffre romains : ");
        romanNumerals = Console.ReadLine();

        // Décomposition des chiffres romains
        Fonctions.RomanNumeralsDecomposition(romanNumerals, decomposedRomanNumerals);

        // Conversion des chiffres romains et renvoie de la somme
        convertedTotal = Fonctions.RomansToDecimal(decomposedRomanNumerals);

        Console.WriteLine("Résultat de la conversion : " + convertedTotal);
    }
}