using System;

namespace Questions;

public class Fibonacci
{

}
using System;

namespace Questions;

public class Fibonacci
{
    int n;

    public Fibonacci(int terms)
    {
        n = terms;
    }

    public void Display()
    {
        int a = 0, b = 1, c;

        if (n >= 1)
            Console.Write(a + " ");

        if (n >= 2)
            Console.Write(b + " ");

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
