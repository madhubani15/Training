using System;
namespace PettyCash;

public class IncomeTransaction : Transaction, IReportable
{
    #region properties
    public string Source { get; set; }
    #endregion

    public override string GetSummary()
    {
        return $"Expense : {Date.ToShortDateString()} | {Amount} | Source: {Source}";
    }


}
