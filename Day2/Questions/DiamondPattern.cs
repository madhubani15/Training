using System;

namespace Questions;

public class DiamondPattern
{
    int n;

    public DiamondPattern(int rows)
    {
        n = rows;
    }

    public void Display()
    {
        for (int i = 1; i <= n; i++)
        {
            for (int space = i; space < n; space++)
                Console.Write(" ");

            for (int star = 1; star <= (2 * i - 1); star++)
                Console.Write("*");

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int space = n; space > i; space--)
                Console.Write(" ");

            for (int star = 1; star <= (2 * i - 1); star++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}
