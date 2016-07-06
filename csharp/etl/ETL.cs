using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ETL
{
    internal static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        Dictionary<string, int> newDictionary = new Dictionary<string,int>();

        foreach (var entry in old)
        {
            foreach(var letter in entry.Value)
            {
                newDictionary.Add(letter.ToLower(), entry.Key);
            }
        }

        return newDictionary;
    }
}

