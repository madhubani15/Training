using System;
using System.Collections.Generic;
namespace MultiplicationTable;

class Program
{
    public static List<int> MultiplicationTableRow(int firstNum, int lastNum)
    {
        List<int> multiplicationList = null;
        if(firstNum!=0 && lastNum != 0)
        {
            multiplicationList = new List<int>();
            for(int i = 1; i < lastNum + 1; i++)
            {
                multiplicationList.Add(firstNum *i);
            }
        }
        
        return multiplicationList;

    }

    public static void Main()
    {
        System.Console.WriteLine("Enter the first number : ");
        int num1 = Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the second number : ");
        int num2 = Int32.Parse(Console.ReadLine());

        
        List<int> multiplyList = MultiplicationTableRow(num1,num2);

        foreach(int item in multiplyList)
        {
            System.Console.Write($"{item} ");
        }
    }
}