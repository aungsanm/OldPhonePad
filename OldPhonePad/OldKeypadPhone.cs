using System;
using System.Collections.Generic;
using System.Text;

public class OldKeypadPhone
{
    private static readonly Dictionary<char, string> KeyMap = new Dictionary<char, string>
    {
        { '2', "ABC" },
        { '3', "DEF" },
        { '4', "GHI" },
        { '5', "JKL" },
        { '6', "MNO" },
        { '7', "PQRS" },
        { '8', "TUV" },
        { '9', "WXYZ" }
    };

    public static string OldPadPhone(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "";

        StringBuilder result = new StringBuilder();
        int length = input.Length;
        int i = 0;

        while (i < length)
        {
            char currentChar = input[i];

            if (currentChar == ' ')
            {
                i++;
                continue;
            }

            if (currentChar == '#')
            {
                break;
            }

            if (currentChar == '*')
            {
                if (result.Length > 0)
                {
                    result.Length--;
                }
                i++;
                continue;
            }

            int count = 0;
            char key = currentChar;
            while (i < length && input[i] == key)
            {
                count++;
                i++;
            }

            if (KeyMap.ContainsKey(key))
            {
                string letters = KeyMap[key];
                result.Append(letters[(count - 1) % letters.Length]);
            }
        }

        return result.ToString();
    }
}