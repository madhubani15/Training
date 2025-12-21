using System;

namespace Questions;

public class Calculator
{
    double num1, num2;
    char op;

    public Calculator(double n1, double n2, char operation)
    {
        num1 = n1;
        num2 = n2;
        op = operation;
    }

    public void Calculate()
    {
        switch (op)
        {
            case '+':
                Console.WriteLine("Result = " + (num1 + num2));
                break;

            case '-':
                Console.WriteLine("Result = " + (num1 - num2));
                break;

            case '*':
                Console.WriteLine("Result = " + (num1 * num2));
                break;

            case '/':
                if (num2 != 0)
                    Console.WriteLine("Result = " + (num1 / num2));
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
