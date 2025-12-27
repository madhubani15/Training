using System;
namespace MediSure;

class Program
{
    public static void Main()
    {
        /*
        1. 1. Create New Bill (Enter Patient Details)

2. 2. View Last Bill

3. 3. Clear Last Bill

4. 4. Exit*/
        int choice;
        do{
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("================== MediSure Clinic Billing ==================");
            System.Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            System.Console.WriteLine("2. View Last Bill");
            System.Console.WriteLine("3. Clear Last Bill");
            System.Console.WriteLine("4. Exit");
            System.Console.Write("Enter your option: ");
            Console.ForegroundColor = ConsoleColor.White;
            
            choice = Int32.Parse(Console.ReadLine());
            

            switch (choice)
            {
                case 1:
                {
                    BillGenerator.CreateBill();
                    break;
                }

                case 2:
                {
                    BillGenerator.ViewLastBill();
                    break;
                }

                case 3:
                {
                    BillGenerator.ClearLastBill();
                    break;
                }

                case 4:
                {
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                }
            }

        }while(choice!=4);
    }

        
    

}

