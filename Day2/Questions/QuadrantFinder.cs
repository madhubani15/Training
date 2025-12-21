using System;
using System.Threading.Tasks.Dataflow;

namespace Questions;

public class QuadrantFinder
{
    public static void  Find()
    {
        Console.WriteLine("Enter (x,y) coordinates");
        Console.WriteLine("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        /// logic
        if(x==0 && y == 0)
        {
            Console.WriteLine("Origin");
        }else if(x>0 && y > 0)
        {
            Console.WriteLine("First quadrant");
        }else if(x<0 && y > 0)
        {
            Console.WriteLine("Second quadrant");
        }else if(x<0 && y < 0)
        {
            Console.WriteLine("Third quadrant");
        }
        else
        {
            Console.WriteLine("Fourth Quadrant");
        }
    }
}
