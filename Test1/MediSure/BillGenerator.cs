using System;

namespace MediSure;

public class BillGenerator
{
    public static PatientBill LastBill;
    public static bool HasLastBill = false;

    #region Methods

    // 1st option
    public static void CreateBill()
    {
        PatientBill patientBill = new PatientBill();

        System.Console.Write("Enter Bill Id: ");
        patientBill.BillId = Console.ReadLine();

        Console.Write("Enter Patient Name: ");
        patientBill.PatientName = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N): ");
        string insuranceInput = Console.ReadLine();

        if (insuranceInput=="Y")
            patientBill.HasInsurance = true;
        else if (insuranceInput=="N")
            patientBill.HasInsurance = false;
        else
        {
            Console.WriteLine("Invalid insurance input.");
            return;
        
        }

        decimal consultationFee;
        System.Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out consultationFee) || consultationFee <= 0)
        {       
            Console.WriteLine("Consultation Fee must be greater than 0.");
            return;
        }

        
        decimal labCharges;
        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out labCharges) || labCharges < 0)
        {
            Console.WriteLine("Invalid Lab Charges.");
            return;
        
        }

        decimal medicineCharges;
        
        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out medicineCharges) || medicineCharges < 0)
        {
            
            Console.WriteLine("Invalid Medicine Charges.");
            return;
        }

        patientBill.ConsultationFee = consultationFee;
        patientBill.LabCharges = labCharges;
        patientBill.MedicineCharges = medicineCharges;

        LastBill = patientBill;
        HasLastBill = true;

        
        patientBill.GrossAmount = patientBill.ConsultationFee + patientBill.LabCharges + patientBill.MedicineCharges;

        if (patientBill.HasInsurance)
            patientBill.DiscountAmount = patientBill.GrossAmount * 0.10m;
        else
            patientBill.DiscountAmount = 0;

        patientBill.FinalPayable = patientBill.GrossAmount - patientBill.DiscountAmount;

        LastBill = patientBill;
        HasLastBill = true;

        Console.WriteLine("\nBill created successfully.");
        Console.WriteLine($"Gross Amount: {patientBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {patientBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {patientBill.FinalPayable:F2}");
        

    }

    // 2nd option
    public static void ViewLastBill()
    {
        if (!HasLastBill)
        {
            Console.WriteLine("No bill available. Please create a new bill first.");
            return;
        }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {LastBill.BillId}");
        Console.WriteLine($"Patient: {LastBill.PatientName}");
        Console.WriteLine($"Insured: {(LastBill.HasInsurance ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
        Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
        Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
        Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
        Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");
        Console.WriteLine("--------------------------------");
    }

    // 3rd option
    public static void ClearLastBill()
    {
        LastBill = null;
        HasLastBill = false;
        Console.WriteLine("Last bill cleared.");
    }



    #endregion

}
