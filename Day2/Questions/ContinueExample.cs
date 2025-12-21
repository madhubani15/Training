using System;

namespace Questions;

public class ContinueExample
{
    public void Display()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0)
                continue;

            Console.WriteLine(i);
        }
    }
}
