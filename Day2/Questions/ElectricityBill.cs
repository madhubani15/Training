using System;
using System.Runtime.CompilerServices;

namespace Questions;

public class ElectricityBill
{
    public static void calculate()
    {
        Console.WriteLine("Enter your units consumed: ");
        int units = int.Parse(Console.ReadLine());
        double bill=0;
        double surge=0;
        if (units <= 199)
        {
            bill = units*1.20;

        }else if(units<400 && units >= 200)
        {
            bill = units*1.50;
        }else if(units>=400 && units < 600)
        {
            
            surge = (units*15)/100;
            bill = (units*1.80)+surge;
        }
        else
        {
            surge = (units*15)/100;
            bill = (units*2)+surge;
        }

        Console.WriteLine($"The bill is: {bill}");
    }
}
