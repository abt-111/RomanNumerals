class MainClass
{
    public static void Main(string[] args)
    {
        int resultatConversion;
        string romanNumeral;
        string decomposition;
        List<string> romanNumeralsDecomposed = new List<string>();

        // Saisie de l'utilisateur (pour l'instant on suppose que l'entrée est toujours correct)
        Console.Write("Veuillez entrez un chiffre romains : ");
        romanNumeral = Console.ReadLine();

        for(int i = 0; i < romanNumeral.Length; i++)
        {
            decomposition = "";
            decomposition += romanNumeral[i];

            if (romanNumeral[i] != romanNumeral[i + 1])
            {
                switch (decomposition)
                {
                    case "C":
                        if (romanNumeral[i + 1] == 'M' || romanNumeral[i + 1] == 'D')
                        {
                            decomposition += romanNumeral[i + 1];
                            i++;
                        }
                        break;
                    case "X":
                        if (romanNumeral[i + 1] == 'C' || romanNumeral[i + 1] == 'L')
                        {
                            decomposition += romanNumeral[i + 1];
                            i++;
                        }
                        break;
                    case "I":
                        if (romanNumeral[i + 1] == 'X' || romanNumeral[i + 1] == 'V')
                        {
                            decomposition += romanNumeral[i + 1];
                            i++;
                        }
                        break;
                    default:
                        break;
                }
                romanNumeralsDecomposed.Add(decomposition);
            }
            else
            {
                while (romanNumeral[i] == romanNumeral[i + 1])
                {
                    decomposition += romanNumeral[i + 1];
                    i++;
                }
                romanNumeralsDecomposed.Add(decomposition);
            }
        }
        foreach (string romanNumeralDecomposed in romanNumeralsDecomposed)
        {
            Console.WriteLine(romanNumeralDecomposed);
        }
    }
}