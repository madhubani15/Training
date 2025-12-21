using System;

namespace Questions;

public class LeapYearChecker
{
    public static void Check()
    {
        Console.WriteLine("Enter the year in yyyy format: ");
        int y = int.Parse(Console.ReadLine());
        bool res = false;
        if (y % 400 == 0)
        {
            res = true;
        }else if(y%4==0 && y % 100 != 0)
        {
            res=true;
        }
        if (res)
        {
            Console.WriteLine($"The year {y} is a leap year");

        }
        else
        {
            Console.WriteLine($"The year {y} is not a leap year");
        }
    }
}
