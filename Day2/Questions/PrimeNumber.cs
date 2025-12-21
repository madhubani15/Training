using System;

namespace Questions;

public class PrimeNumber
{
    int number;

    public PrimeNumber(int n)
    {
        number = n;
    }

    public void CheckPrime()
    {
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
