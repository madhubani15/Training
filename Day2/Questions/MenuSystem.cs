using System;

namespace Questions;

public class MenuSystem
{
    public void Run()
    {
        int choice;

        do
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Selected");
                    break;

                case 2:
                    Console.WriteLine("Subtract Selected");
                    break;

                case 3:
                    Console.WriteLine("Multiply Selected");
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 4);
    }
}
