// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
Scenario:
Sam is planning to buy a laptop or a computer from Bejoy Computers. 
The final price of the selected device will depend on the type of processor 
and any additional accessories added to the purchase. To facilitate this process, 
an application will be used to gather input from the user regarding their
 preferred processor type and accessories, and subsequently calculate the 
 total price of the selected device.
 Help them to create an application using your C# coding skills.
Functionalities:
In class Computer, implement the below-given properties.
    Data Type
   Property Name
    string
  Processor
    int
  RamSize
    int
  HardDiskSize
    int
  GraphicCard
In class Desktop, implement the below-given properties and method and also inherit the 
class Computer.
    Data Type
   Property Name
    int
  MonitorSize
    int
  PowerSupplyVolt
    Method
   Description
   public double DesktopPriceCalculation()
 This method is used to calculate the price of the desktop and return it.
To calculate the price of the desktop, the processor and other accessories prices are given below.
In class Laptop, implement the below-given properties and method and also inherit the class Computer.
    Data Type
   Property Name
    int
  DisplaySize
    int
  BatteryVolt
    Method Description
   public double LaptopPriceCalculation()
 This method is used to calculate the price of the laptop and return it.
To calculate the price of the laptop, the processor and other accessories prices are given below.
Formula 1:
Desktop Price = Processor Cost + (RamSize * Ram Price) 
+ (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price) +
 (MonitorSize * Monitor Price) + (PowerSupplyVolt * Power Supply Volt Price);
    Processor
   Processor Cost
    i3
  1500
    i5
  3000
    i7
  4500
   Ram price (per GB)
  Hard disk (per TB)
  Graphic Card (per GB)
  Power supply (per Volt)
  Monitor (per inch)
    200
   1500
   2500
   20
 250
Formula 2:
Laptop Price = Processor Cost + (RamSize * Ram Price)
 + (HardDiskSize * Hard Disk Price) + (GraphicCard * Graphic Card Price)
  + (Display Size* Display Price) + (BatteryVolt * Battery Volt Price);
    Processor
   Processor Cost
    i3
  2500
    i5
  5000
    i7
  6500
  Ram price (per GB)
  Hard disk (per TB)
 Graphic Card (per GB)
 Battery(per Volt)
 Display(per inch)
    200
   1500
   2500
   20
 250
Note:
Processor is Case-sensitive.
In Program class - Main method,
1.    Get the values from the user as per the Sample Input.
2.    Call the methods accordingly and display the result as per the Sample Output.
Note:
Keep the properties, methods and classes as public.
Please read the method rules clearly.
Do not use Environment.Exit() to terminate the program.
Do not change the given code template.
Summary :
Through creating this application, they have learned about Inheritance in C#.
Inheritance is a mechanism in object-oriented programming that allows a class to inherit 
properties and behaviors from a parent class, thus avoiding code duplication and promoting
 code reuse.
Sample Input 1:
1.Desktop
2.Laptop
Choose the option
1
Enter the processor
i3
Enter the ram size
8
Enter the hard disk size
32
Enter the graphic card size
32
Enter the monitor size
22
Enter the power supply volt
240
Sample Output 1:
Desktop price is 141400
Sample Input 2:
1.Desktop
2.Laptop
Choose the option
2
Enter the processor
i7
Enter the ram size
16
Enter the hard disk size
32
Enter the graphic card size
22
Enter the display size
13
Enter the battery volt
240
Sample Output 2:
Laptop price is 120750

*/



using System;
using System.Runtime.InteropServices;
using Assignments;

public class Program
{
    public static void Main()
    {
        

    

        System.Console.WriteLine("Select the type of device that you want to purchase. \n 1. Desktop \n 2. Laptop");
        System.Console.WriteLine("Choose the option");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                #region Take input
                Desktop d = new Desktop();
                System.Console.WriteLine("Enter the processor");
                d.Processor = Console.ReadLine();

                System.Console.WriteLine("Enter the ram size");
                d.RamSize = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the hard disk size");
                d.HardDiskSize = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the graphic card size");
                d.GraphicCard = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the monitor size");
                d.MonitorSize = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the power supply volt");
                d.PowerSupplyVolt = int.Parse(Console.ReadLine());
                #endregion

                System.Console.WriteLine(d.DesktopPriceCalculation());
                break;

            case 2:
                #region Take input
                Laptop l = new Laptop();
                System.Console.WriteLine("Enter the processor");
                l.Processor = Console.ReadLine();

                System.Console.WriteLine("Enter the ram size");
                l.RamSize = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the hard disk size");
                l.HardDiskSize = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the graphic card size");
                l.GraphicCard = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the display size");
                l.DisplaySize= int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter the battery volt");
                l.BatteryVolt = int.Parse(Console.ReadLine());
                #endregion  

                System.Console.WriteLine(l.LaptopPriceCalculation());

                break;

            default:
                System.Console.WriteLine("Invalid Input");
                break;
        }

        
    }
}
