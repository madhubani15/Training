using System;
using System.Numerics;

namespace Questions;

public class Factorial
{
    int n;

    public Factorial(int num)
    {
        n = num;
    }

    public void Calculate()
    {
        BigInteger fact = 1;

        if (n < 0)
        {
            Console.WriteLine("Factorial not defined");
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}
x   