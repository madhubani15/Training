using System;
namespace Day4OOPDemo;

public class classDemo
{
    static void Main(string[] args)
    {
        // classDemo demoObj = new classDemo("Pankaj");
        /// had I not commented the line above, I would have required to make a new constructor (parameterized)
        /// along with a default one
        classDemo d1 = new classDemo(); // this default constructor is created by CLR
    }
}