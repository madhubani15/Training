using System;

namespace Questions;

public class Vowel
{
    public static void Check()
    {
        Console.WriteLine("Enter a character in lowercase");
        char a = char.Parse(Console.ReadLine());
        switch (a)
        {
    
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{a} is a vowel");
                break;
            default:
                Console.WriteLine($"{a} is a consonant");
                break;


        }
    }
}
