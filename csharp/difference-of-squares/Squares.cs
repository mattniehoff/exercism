using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Squares
{
    private int p;

    public Squares(int p)
    {
        if (p < 0)
        {
            throw new ArgumentException("Input cannot be negative.");
        }

        this.p = p;
    }

    internal int SquareOfSums()
    {
        int sum = 0;        

        for (int i = p; i > 0; i--)
        {
            sum += i;
        }

        return sum * sum;
    }

    internal int SumOfSquares()
    {
        int total = 0;

        for (int i = p; i > 0; i--)
        {
            total += i * i;
        }

        return total;
    }

    internal int DifferenceOfSquares()
    {
        return SquareOfSums() - SumOfSquares();
    }
}

