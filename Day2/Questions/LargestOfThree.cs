using System;

namespace Questions;

public class LargestOfThree
{
    public static void Check()
    {
        Console.WriteLine("Enter an integer a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an integer b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an integer c: ");
        int c = int.Parse(Console.ReadLine());

        int max;

        if (a >= b && a >= c)
        {
            max = a;
        }
        else if (b >= a && b >= c)
        {
            max = b;
        }
        else
        {
            max = c;
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}
