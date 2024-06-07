class MainClass
{
    public static void Main(string[] args)
    {
        int resultatConversion = 0;
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

            if ((i + 1) < romanNumeral.Length)
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
            }
            romanNumeralsDecomposed.Add(decomposition);
        }
        foreach (string romanNumeralDecomposed in romanNumeralsDecomposed)
        {
            Console.WriteLine(romanNumeralDecomposed);
            resultatConversion += ConvertValue(romanNumeralDecomposed);
        }

        Console.WriteLine("Résultat de la conversion : " + resultatConversion);
    }

    public static int ConvertValue(string args)
    {
        switch(args)
        {
            case "I":
                return 1;
                break;
            case "IV":
                return 4;
                break;
            case "V":
                return 5;
                break;
            case "IX":
                return 9;
                break;
            case "X":
                return 10;
                break;
            case "XL":
                return 40;
                break;
            case "L":
                return 50;
                break;
            case "XC":
                return 90;
                break;
            case "C":
                return 100;
                break;
            case "CD":
                return 400;
                break;
            case "D":
                return 500;
                break;
            case "CM":
                return 900;
                break;
            case "M":
                return 1000;
                break;
            default:
                return 0;
                break;
        }
    }
}