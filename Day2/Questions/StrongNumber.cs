using System;

namespace Questions;

public class StrongNumber
{
    int number;

    public StrongNumber(int n)
    {
        number = n;
    }

    int Factorial(int n)
    {
        int fact = 1;

        for (int i = 1; i <= n; i++)
            fact = fact * i;

        return fact;
    }

    public void CheckStrong()
    {
        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum = sum + Factorial(digit);
            temp = temp / 10;
        }

        if (sum == number)
            Console.WriteLine("Strong Number");
        else
            Console.WriteLine("Not a Strong Number");
    }
}
