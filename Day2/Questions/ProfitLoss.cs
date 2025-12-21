using System;

namespace Questions;

public class ProfitLoss
{
    double costPrice;
    double sellingPrice;

    public ProfitLoss(double cp, double sp)
    {
        costPrice = cp;
        sellingPrice = sp;
    }

    public void Calculate()
    {
        if (sellingPrice > costPrice)
        {
            double profit = sellingPrice - costPrice;
            double profitPercent = (profit / costPrice) * 100;
            Console.WriteLine("Profit Percentage = " + profitPercent);
        }
        else if (sellingPrice < costPrice)
        {
            double loss = costPrice - sellingPrice;
            double lossPercent = (loss / costPrice) * 100;
            Console.WriteLine("Loss Percentage = " + lossPercent);
        }
        else
        {
            Console.WriteLine("No Profit No Loss");
        }
    }
}
