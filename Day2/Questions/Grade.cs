using System;

namespace Questions;

public class Grade
{
    public static void Grading()
    {
        Console.WriteLine("Enter grade in CAPITAL LETTER: ");
        char g = char.Parse(Console.ReadLine());

        switch (g)
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;
                
            case 'V':
                Console.WriteLine("Very Good");
                break;
                
            case 'G':
                Console.WriteLine("Good");
                break;
                
            case 'A':
                Console.WriteLine("Average");
                break;
                
            case 'F':
                Console.WriteLine("Fail");
                break;
                
            default:
                Console.WriteLine("Invalid Grade");
                break;
            
        }
    }
}
