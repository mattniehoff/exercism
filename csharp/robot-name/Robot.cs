using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robot
{
    public string Name { get; set; }
    const string prefixChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string suffixChars = "1234567890";
    const int prefixLength = 2;
    const int suffixLength = 3;
    private static Random random = new Random();
    
    public Robot()
    {
        GenerateName();
    }

    internal void Reset()
    {
        GenerateName();
    }

    private void GenerateName()
    {
        string prefix = GenerateRandomString(prefixChars, prefixLength);
        string suffix = GenerateRandomString(suffixChars, suffixLength);

        Name = String.Format("{0}{1}", prefix, suffix);
    }

    private static string GenerateRandomString(string characterString, int stringLength)
    {
        var returnString = new char[stringLength];
        for (int i = 0; i < returnString.Length; i++)
        {
            returnString[i] = characterString[random.Next(characterString.Length)];
        }

        return new string(returnString);
    }
}


