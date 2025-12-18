/*
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
}*/


using System;

class Program1
{
    static void Main()
    {
        Console.Write("Enter age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            bool isAdult = age >= 18;
            Console.WriteLine("Adult? " + isAdult);
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a whole number.");
        }
    }
}
