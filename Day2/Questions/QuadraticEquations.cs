using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace Questions;

public class QuadraticEquations
{
    public static void Calculate()
    {
        Console.WriteLine("Enter the variables in ax^2+bx+c");
        Console.WriteLine("Enter a: ");
        int a= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b= int.Parse(Console.ReadLine());
        Console.WriteLine("Enter c: ");
        int c= int.Parse(Console.ReadLine());

        /// Discriminant
        double d = (b*b)-4*a*c;
        if (d > 0)
        {
            Console.WriteLine("Real and distinct roots");
            double r1 = (-b+Math.Sqrt(d))/2*a;
            double r2 = (-b-Math.Sqrt(d))/2*a;
            Console.WriteLine($"The two roots are: {r1} and {r2}");
        }
        else if (d == 0.00)
        {
            Console.WriteLine("Real and equal roots");
            double r1 = -b/2*a;
            Console.WriteLine($"The root is: {r1}");

        }
        else
        {
            Console.WriteLine("Imaginary roots");
        }
    }
}
