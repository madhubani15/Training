using System;

namespace Questions;

public class GcdLcm
{
    int a, b;

    public GcdLcm(int x, int y)
    {
        a = x;
        b = y;
    }

    public void Calculate()
    {
        int num1 = a;
        int num2 = b;
        int gcd = 1;

        for (int i = 1; i <= num1 && i <= num2; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
                gcd = i;
        }

        int lcm = (num1 * num2) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}
