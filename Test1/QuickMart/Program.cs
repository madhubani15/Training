using System;

namespace QuickMart;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            Console.ForegroundColor = ConsoleColor.White;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid option. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    TransactionService.CreateTransaction();
                    break;

                case 2:
                    TransactionService.ViewLastTransaction();
                    break;

                case 3:
                    TransactionService.CalculateProfitLoss();
                    break;

                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        }while(choice!= 4);
    }
}


