using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bob
{
    public static string QuestionResponse = "Sure.";
    public static string YelledAtResponse = "Whoa, chill out!";
    public static string SilentResponse = "Fine. Be that way!";
    public static string StandardResponse = "Whatever.";

    public static string Hey(string input)
    {
        // Check empty/null first.
        if (String.IsNullOrWhiteSpace(input))
        {
            return SilentResponse;
        }

        // Clear leading/trailing whitespace
        input = input.Trim();

        // Yelling - forceful question prompts this repsonse
        if (IsAllCaps(input))
        {
            return YelledAtResponse;
        }

        if (input[input.Length - 1] == '?')
        {
            return QuestionResponse;
        }        

        return StandardResponse;
    }

    private static bool IsAllCaps(string input)
    {
        bool result = false;

        foreach (char letter in input)
        {
            if (Char.IsLetter(letter))
            {
                if (Char.IsUpper(letter))
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
        }

        return result;
    }
}

