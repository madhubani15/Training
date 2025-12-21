using System;

namespace Questions;

public class ReversePalindrome
{
    int number;

    public ReversePalindrome(int n)
    {
        number = n;
    }

    public void Check()
    {
        int temp = number;
        int reverse = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp = temp / 10;
        }

        Console.WriteLine("Reverse = " + reverse);

        if (reverse == number)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
