using System;
namespace PettyCash;

public class ExpenseTransaction : Transaction, IReportable
{
    #region properties
    public string Category { get; set; }
    #endregion

    public override string GetSummary()
    {
        return $"Expense : {Date.ToShortDateString()} | {Amount} | Category: {Category}";
    }
}