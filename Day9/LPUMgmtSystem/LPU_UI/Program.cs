using System;
using LPU_BL;
using LPU_Entity;
using LPU_Exceptions;
using System.Collections.Generic;

namespace LPU_UI;

class Program
{
    static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===============================================================");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                   Student Management System                   ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("===============================================================");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Search Student By ID ");
        Console.WriteLine("2. Show All Students");
        Console.WriteLine("3. Add Student Details");
        Console.WriteLine("4. Update Student Details");
        Console.WriteLine("5. Drop Student Details");
        Console.WriteLine("6. Exit");
        Console.ForegroundColor = ConsoleColor.White;

    }
    public static void Main()
    {
        // Encapsulation : Data is coming from UI to BL, this is encapsulated from DAL

        StudentBL sblObj = null;
        // We don't want this to create multiple copies in the loop and switch case for
        // every case. Therefore, we are declaring it here
        sblObj = new StudentBL();

        // MENU DRIVEN APPLICATION FOR USER
        do
        {
            Menu();
            int choice = 0;
            Console.Write("Please enter your choice : ");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    {
                        // 1. Search Student By ID

                        try
                        {
                            Console.Write("Enter ID of Student : ");
                            int id = Int32.Parse(Console.ReadLine()); // camel Casing

                            Student sObj = sblObj.SearchStudentByID(id);

                            if (sObj != null) 
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("ID \t|  Name \t|  Course \t|  Address");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("===============================================================");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{sObj.StudentID}\t|{sObj.Name}\t|{sObj.Course}\t|{sObj.Address}");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (LPUException e) // custom exception
                        { 
                            Console.WriteLine(e.Message);
                        }catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    }

                case 2:
                    {
                        // 2. Show All Students
                        try
                        {
                            Console.Write("Enter Student Name for search:");
                            string name = Console.ReadLine();
                            List<Student> studList = sblObj.SearchStudentByName(name);

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("ID \t|  Name \t|  Course \t|  Address");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("===============================================================");

                            foreach (var sObj in studList)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"{sObj.StudentID}\t|{sObj.Name}\t|{sObj.Course}\t|{sObj.Address}");

                            }
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (LPUException e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("We Are Coming Soon");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("We Are Coming Soon");
                            Console.ForegroundColor = ConsoleColor.White;
                        }


                        break;
                    }

                case 3:
                    {
                        // 3. Add Student Details

                        try
                        {
                            Student sObj  
                        }

                        break;
                    }

                case 4:
                    {
                        // 4. Update Student Details

                        break;
                    }

                case 5:
                    {
                        // 5. Drop Student Details

                        break;
                    }

                case 6:
                    {
                        // 6. Exit

                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }while(true);

    }
}