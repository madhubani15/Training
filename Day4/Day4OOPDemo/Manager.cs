using System;

namespace Day4OOPDemo;

public class Manager:Employee
{
    public int ManagerId{get; set;}
    public int Incentive{get;set; }

    public int CalculateSalary(int sal) 
    /// Function Shadowing
    /// This will throw an error in legacy system and we will have to create a new function with 
    /// some other keyword
    
    /// But here (in newer systems) this function hides the original function from Base Class
    
    /// FUNCTION SHADOWING:
    /// if you use "new" keyword in front of the function, then you can use this function 
    /// without even using "virtual" keyword in front of the base class but this will create a 
    /// seperate class ( the base class method will be called only through base class
    /// and not through child one)
   
    /// FUNCTION OVERRIDING:
    /// 1. APPROACH : after writing the "virtual" keyword in base class, you can override the function here in 
    /// child class using override function
    /// 
    /// 2. APPROACH: mark the base class as abstract and then override it
    {
        int mySal=0;
        mySal = sal+35000+12000+4500-8500;
        // NetSalary = Salary +HRA+TA+DA-PF
        return mySal;
    }
}

/// EXAMPLE =======================================================================================
/// function shadowing
/// Base bas = new Base(); uses the func from Base class
/// Derived der = new Derived(); uses the func from Derived class
/// Base ba = new Derived();  this will use the func from the BASE CLASS and not the DERIVED CLASS
/// it is getting the reference of base class func through derived class
/// ===============================================================================================
/// Employee ba = new Manager(); Bank account opening example
/// JEE example
/// 
/// ===============================================================================================
/// function overriding
/// Base bas = new Base(); uses the func from Base class
/// Derived der = new Derived(); uses the func from Derived class
/// Base ba = new Derived();  this will use the func from the DERIVED CLASS 
/// and not the BASE CLASS
/// ===============================================================================================
/// 
/// if someone uses Employee em1 = new Employee(); and I don't want them to use this
/// (Employee can be Manager or clerk) so I'll mark Employee Class as abstract
