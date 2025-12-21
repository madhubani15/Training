using System;

namespace Questions;

public class Armstrong
{
    int number;

    public Armstrong(int n)
    {
        number = n;
    }

    public void CheckArmstrong()
    {
        int temp = number;
        int digits = 0;
        int sum = 0;

        while (temp > 0)
        {
            digits++;
            temp = temp / 10;
        }

        temp = number;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum = sum + (int)Math.Pow(digit, digits);
            temp = temp / 10;
        }

        if (sum == number)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
