using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Year
{
    /// <summary>
    /// return true
    /// on every year that is evenly divisible by 4
    ///  except every year that is evenly divisible by 100
    ///    unless the year is also evenly divisible by 400
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static bool IsLeap(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }

        if (year % 4 == 0 && year % 100 != 0)
        {
            return true;
        }

        return false;
    }
}

