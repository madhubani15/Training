using System;

namespace Questions;

public class PascalTriangle
{
    int n;

    public PascalTriangle(int rows)
    {
        n = rows;
    }

    public void Display()
    {
        for (int i = 0; i < n; i++)
        {
            int value = 1;

            for (int space = 1; space <= n - i; space++)
                Console.Write(" ");

            for (int j = 0; j <= i; j++)
            {
                Console.Write(value + " ");
                value = value * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}
