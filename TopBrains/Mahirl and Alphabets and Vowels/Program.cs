using System;
using System.Collections.Generic;
using System.Text;

namespace ConsonantsAndVowels;

public class Program
{

    static bool IsVowel(char character)
    {
        character = char.ToLower(character);
        return character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u';
    }
    public static void Main()
    {
        System.Console.Write("Enter the first word : ");
        string word1 = Console.ReadLine();

        System.Console.Write("Enter the second word : ");
        string word2 = Console.ReadLine();

        HashSet<char> consonants = new HashSet<char>();

        foreach (char ch in word2)
        {
            char c = char.ToLower(ch);
            if (!IsVowel(c))
                consonants.Add(c);
        }

        StringBuilder temp = new StringBuilder();

        foreach (char ch in word1)
        {
            char c = char.ToLower(ch);

            if (IsVowel(c) || !consonants.Contains(c))
                temp.Append(ch);
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < temp.Length; i++)
        {
            if (i == 0 || temp[i] != temp[i - 1])
                result.Append(temp[i]);
        }

        Console.WriteLine(result.ToString());
    }


}