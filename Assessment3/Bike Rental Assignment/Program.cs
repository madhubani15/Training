using System;
using System.Collections.Generic;

namespace BikeRental;

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails =
        new SortedDictionary<int, Bike>();

    public static void Main()
    {
        BikeUtility utility = new BikeUtility();
        int choice;

        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice ");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter the brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter the price per day: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    utility.AddBikeDetails(model, brand, price);
                    Console.WriteLine();
                    Console.WriteLine("Bike details added successfully");
                    Console.WriteLine();
                    break;

                case 2:
                    SortedDictionary<string, List<Bike>> grouped =
                        utility.GroupBikesByBrand();

                    Console.WriteLine();
                    foreach (var brandGroup in grouped)
                    {
                        foreach (Bike bike in brandGroup.Value)
                        {
                            Console.WriteLine(brandGroup.Key + " " + bike.Model);
                        }
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    break;
            }

        } while (choice != 3);
    }
}
