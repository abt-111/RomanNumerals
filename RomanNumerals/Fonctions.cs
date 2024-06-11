public static class Fonctions
{
    public static void RomanNumeralsDecomposition(string romanNumerals, List<string> decomposedRomanNumerals)
    {
        string decomposedRomanNumeral;

        for (int i = 0; i < romanNumerals.Length; i++)
        {
            decomposedRomanNumeral = "";
            decomposedRomanNumeral += romanNumerals[i];

            // Traitement des cas particuliers de CM, CD, XC, XL, IX et IV
            if ((i + 1) < romanNumerals.Length)
            {
                if (romanNumerals[i] != romanNumerals[i + 1])
                {
                    switch (decomposedRomanNumeral)
                    {
                        case "C":
                            if (romanNumerals[i + 1] == 'M' || romanNumerals[i + 1] == 'D')
                            {
                                decomposedRomanNumeral += romanNumerals[i + 1];
                                i++;
                            }
                            break;
                        case "X":
                            if (romanNumerals[i + 1] == 'C' || romanNumerals[i + 1] == 'L')
                            {
                                decomposedRomanNumeral += romanNumerals[i + 1];
                                i++;
                            }
                            break;
                        case "I":
                            if (romanNumerals[i + 1] == 'X' || romanNumerals[i + 1] == 'V')
                            {
                                decomposedRomanNumeral += romanNumerals[i + 1];
                                i++;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            decomposedRomanNumerals.Add(decomposedRomanNumeral);
        }
    }

    public static int RomansToDecimal(List<string> decomposedRomanNumerals)
    {
        int convertedTotal = 0;

        foreach (string decomposedRomanNumeral in decomposedRomanNumerals)
        {
            Console.WriteLine(decomposedRomanNumeral);
            convertedTotal += Fonctions.RomanToDecimal(decomposedRomanNumeral);
        }

        return convertedTotal;
    }

    public static int RomanToDecimal(string args)
    {
        switch (args)
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