using System;

namespace Swapping;

public class Program
{
    public static void SwapRef(ref int num1, ref int num2)
    {
        (num1,num2)=(num2,num1);

    }
    public static void SwapOut(int num1, int num2, out int swappedNum1, out int swappedNum2)

    {
        swappedNum1 = num2;
        swappedNum2 = num1;
    }

    public static void Main()
    {
        System.Console.Write("Enter the first number: ");
        int num1 = Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter the second number: ");
        int num2 = Int32.Parse(Console.ReadLine());

        SwapRef(ref num1,ref num2);
        System.Console.WriteLine($"First number after swapping : {num1}");
        System.Console.WriteLine($"Second number after swapping : {num2}");

        int swapNum1;
        int swapNum2;

        SwapOut(num1,num2, out swapNum1, out swapNum2);
        System.Console.WriteLine($"First number after swapping : {num1}");
        System.Console.WriteLine($"Second number after swapping : {num2}");

    }
}