using System;

namespace QuickMart;


public class TransactionService
{
    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction = false;

    #region Methods

    //1st option
    public static void CreateTransaction()
    {
        SaleTransaction transaction = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        transaction.invoiceNo = Console.ReadLine();

        if (transaction.invoiceNo == null || transaction.invoiceNo == "")
        {
            Console.WriteLine("Invoice No cannot be empty.");
            return;
        }


        Console.Write("Enter Customer Name: ");
        transaction.customerName = Console.ReadLine();

        Console.Write("Enter Item Name: ");
        transaction.itemName = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out transaction.quantity) || transaction.quantity <= 0)
        {
            Console.WriteLine("Quantity must be greater than 0.");
            return;
        }

        Console.Write("Enter Purchase Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out transaction.purchaseAmount) || transaction.purchaseAmount <= 0)
        {
            Console.WriteLine("Purchase Amount must be greater than 0.");
            return;
        }

        Console.Write("Enter Selling Amount (total): ");
        if (!decimal.TryParse(Console.ReadLine(), out transaction.sellingAmount) || transaction.sellingAmount < 0)
        {
            Console.WriteLine("Selling Amount cannot be negative.");
            return;
        }

        ComputeProfitLoss(transaction);

        LastTransaction = transaction;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved successfully.");
        Console.WriteLine($"Status: {transaction.profitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {transaction.profitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {transaction.profitMarginPercent:F2}");
        Console.WriteLine("------------------------------------------------------");
    }

    //2nd option
    public static void ViewLastTransaction()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        Console.WriteLine("-------------- Last Transaction --------------");
        Console.WriteLine($"InvoiceNo: {LastTransaction.invoiceNo}");
        Console.WriteLine($"Customer: {LastTransaction.customerName}");
        Console.WriteLine($"Item: {LastTransaction.itemName}");
        Console.WriteLine($"Quantity: {LastTransaction.quantity}");
        Console.WriteLine($"Purchase Amount: {LastTransaction.purchaseAmount:F2}");
        Console.WriteLine($"Selling Amount: {LastTransaction.sellingAmount:F2}");
        Console.WriteLine($"Status: {LastTransaction.profitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.profitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.profitMarginPercent:F2}");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("------------------------------------------------------");
    }

    //3rd option
    public static void CalculateProfitLoss()
    {
        if (!HasLastTransaction)
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
            return;
        }

        ComputeProfitLoss(LastTransaction);

        Console.WriteLine("Recalculation completed.");
        Console.WriteLine($"Status: {LastTransaction.profitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {LastTransaction.profitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {LastTransaction.profitMarginPercent:F2}");
        Console.WriteLine("------------------------------------------------------");
    }

    // Used in 3rd otpion
    private static void ComputeProfitLoss(SaleTransaction transaction)
    {
        if (transaction.sellingAmount > transaction.purchaseAmount)
        {
            transaction.profitOrLossStatus = "PROFIT";
            transaction.profitOrLossAmount =
                transaction.sellingAmount - transaction.purchaseAmount;
        }
        else if (transaction.sellingAmount < transaction.purchaseAmount)
        {
            transaction.profitOrLossStatus = "LOSS";
            transaction.profitOrLossAmount =
                transaction.purchaseAmount - transaction.sellingAmount;
        }
        else
        {
            transaction.profitOrLossStatus = "BREAK-EVEN";
            transaction.profitOrLossAmount = 0;
        }

        transaction.profitMarginPercent =
            (transaction.profitOrLossAmount / transaction.purchaseAmount) * 100;


    }

    #endregion
}

