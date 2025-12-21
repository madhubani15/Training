using System;

class Program
{
    static void Main()
    {
        int n = 100;
        bool[] isPrime = new bool[n + 1];

        for (int i = 3; i <= n; i += 2)
            isPrime[i] = true;

        isPrime[2] = true;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= n; j += 2 * i)
                    isPrime[j] = false;
            }

        }

        Console.Write("2 ");
        for (int i = 3; i <= n; i += 2)
        {
            if (isPrime[i])
                Console.Write(i + " ");
        }
    }
}
