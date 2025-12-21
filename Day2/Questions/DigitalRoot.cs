using System;

namespace Questions;

public class DigitalRoot
{
    int number;

    public DigitalRoot(int n)
    {
        number = n;
    }

    public void Calculate()
    {
        int sum;

        while (number >= 10)
        {
            sum = 0;

            while (number > 0)
            {
                sum = sum + (number % 10);
                number = number / 10;
            }

            number = sum;
        }

        Console.WriteLine("Digital Root = " + number);
    }
}
