using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;
using ServiceLogic;

namespace UILogic
{
    [Doctor(Name = "Neha", CheckedOnDate ="12/04/2025")]
    [Doctor(Name = "Ravi", CheckedOnDate = "6/03/2025")]
    [Doctor(Name = "Shashi", CheckedOnDate = "12/02/2025")]
    [Serializable]
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();
            int numResult = logic.AddMe(num1, num2);
            Console.WriteLine($"The Sum Of {num1} And {num2} is {numResult}");
            Console.ReadLine();


        }
    }
}