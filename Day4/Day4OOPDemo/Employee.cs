using System;
using System.Diagnostics.Contracts;
namespace Day4OOPDemo;

public class Employee
//abstract public class Employee{
// Abstract class
//}
{
    
/// if someone uses Employee em1 = new Employee(); and I don't want them to use this
/// (Employee can be Manager or clerk) so I'll mark Employee Class 
/// as abstract using "abstract" keyword
/// ===============================================================================================
/// 
/// When marking a class ABSTRACT, you have to define AT LEAST ONE ABSTRACT method
/// Then, multiple child classes can be created but an object cannot be created for this class
    #region Properties
    public int EmployeeID {get;set; }
    public int MyProperty {get;set; }
    public string Name{get;set;}
    public string BasicSal {get; set; }


    #endregion
    
    public virtual int CalculateSalary(int sal)
    // virtual keyword here allows us to overwrite the function in child class
    {
        int mySal=0;
        mySal = sal+35000+12000+4500-8500;
        // NetSalary = Salary +HRA+TA+DA-PF
        return mySal;
    }

    // public abstract int CalculateSalary1(int sal);
    // abstract method
    
}