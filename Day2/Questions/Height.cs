using System;

namespace Questions
{
    public class Height
    {
        public static void CheckHeight()
        {
            Console.WriteLine("Enter height in cms: ");
            int h = int.Parse(Console.ReadLine());

            if (h < 0)
            {
                Console.WriteLine("Enter a valid number");
            }
            else if (h < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (h >= 150 && h < 165)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Abnormal");
            }
        }
    }
}
