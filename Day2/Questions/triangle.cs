using System;

namespace Questions;

public class triangle
{
    public static void check()
    {
        Console.WriteLine("Enter the length of the sides of a triangle");
        Console.WriteLine("Enter the length of side a");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side b");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of side c");
        double c = double.Parse(Console.ReadLine());

        if (a == b && b==c)
        {
            Console.WriteLine("The triangle is equilateral");
        }
        else if(a==b || b==c || a == c){
        
            Console.WriteLine("Triangle is isosceles");

        }
        else
        {
            Console.WriteLine("The triangle is scalene");
        }
    }
}
