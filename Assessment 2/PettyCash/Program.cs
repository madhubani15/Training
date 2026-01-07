using System;
using System.Collections.Generic;
namespace PettyCash;



class Program
{
    static void Main()
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        int choice = 0;

        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===================== DIGITAL PETTY CASH LEDGER =====================");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Total Income");
            Console.WriteLine("4. View Total Expense");
            Console.WriteLine("5. View Net Balance");
            Console.WriteLine("6. View All Transactions");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write("Please enter your choice : ");
            choice = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("==============================================================");
            Console.ForegroundColor = ConsoleColor.White;
            switch (choice)
            {
                case 1:
                {
                    AddIncome(incomeLedger);
                    break;
                }
                case 2:
                {
                    AddExpense(expenseLedger);
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Total Income: {incomeLedger.CalculateTotal()}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Total Expense: {expenseLedger.CalculateTotal()}");
                    break;
                }
                case 5:
                {
                    int netBalance = incomeLedger.CalculateTotal() - expenseLedger.CalculateTotal();
                    Console.WriteLine($"Net Balance: {netBalance}");
                    break;
                }
                case 6:
                {
                    DisplayAllTransactions(incomeLedger, expenseLedger);
                    break;
                }
                case 7:
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Exiting application...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                default:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }while(choice!=7);
    }



    static void AddIncome(Ledger<IncomeTransaction> incomeLedger)
    {
        Console.Write("Enter amount: ");
        int amount = int.Parse(Console.ReadLine());

        Console.Write("Enter source: ");
        string source = Console.ReadLine();

        incomeLedger.AddEntry(new IncomeTransaction
        {
            Id = new Random().Next(1000),
            Date = DateTime.Today,
            Amount = amount,
            Source = source,
            Description = "Income Entry"
        });

        Console.WriteLine("Income added successfully.");
    }

    
    static void AddExpense(Ledger<ExpenseTransaction> expenseLedger)
    {
        Console.Write("Enter amount: ");
        int amount = int.Parse(Console.ReadLine());

        Console.Write("Enter category: ");
        string category = Console.ReadLine();

        expenseLedger.AddEntry(new ExpenseTransaction
        {
            Id = new Random().Next(1000),
            Date = DateTime.Today,
            Amount = amount,
            Category = category,
            Description = "Expense Entry"
        });

        Console.WriteLine("Expense added successfully.");
    }

    static void DisplayAllTransactions(
        Ledger<IncomeTransaction> incomeLedger,
        Ledger<ExpenseTransaction> expenseLedger)
    {
        Console.WriteLine("TRANSACTION SUMMARY");

        List<Transaction> allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.GetAll());
        allTransactions.AddRange(expenseLedger.GetAll());

        foreach (Transaction t in allTransactions)
        {
            Console.WriteLine(t.GetSummary());
        }
    }
    
}
