using System;

namespace Questions;

public class GotoSearch
{
    int[,] data;   // 2D integer array
    int target;   // integer value to search for

    public GotoSearch(int[,] arr, int value)
    {
        data = arr;
        target = value;
    }

    public void Search()
    {
        bool found = false;
        int row = -1, col = -1;

        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (data[i, j] == target)
                {
                    row = i;
                    col = j;
                    found = true;
                    goto FOUND;
                }
            }
        }

    FOUND:
        if (found)
            Console.WriteLine("Found at row " + row + ", column " + col);
        else
            Console.WriteLine("Not Found");
    }
}
