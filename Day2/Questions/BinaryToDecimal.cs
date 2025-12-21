using System;

namespace Questions;

public class BinaryToDecimal
{
    string binary;

    public BinaryToDecimal(string b)
    {
        binary = b;
    }

    public void Convert()
    {
        int decimalValue = 0;
        int baseValue = 1;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
                decimalValue = decimalValue + baseValue;

            baseValue = baseValue * 2;
        }

        Console.WriteLine("Decimal = " + decimalValue);
    }
}
