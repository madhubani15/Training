using System;

namespace Questions;

public class AdmissionEligibility
{
    public static void Validate()
    {
        /// taking input
        Console.WriteLine("Enter the marks of the following subjects in Integers: ");
        Console.WriteLine("Math: ");
        int mathematics = int.Parse(Console.ReadLine());
        Console.WriteLine("Physics: ");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

        int total = mathematics+chemistry+physics;
        int mathphysics = mathematics+physics;

        /// checking eligibility using if else
        if((mathematics>=65) || (physics>=55) || (chemistry >= 50) || (total>=180) || (mathphysics>=140))
        {
            Console.WriteLine("The person is eligible");
        }
        else
        {
            Console.WriteLine("The person is not eligible");
        }
    }
}
