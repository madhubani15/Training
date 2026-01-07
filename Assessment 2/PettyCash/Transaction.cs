using System;
using System.Net.NetworkInformation;
namespace PettyCash;

public abstract class Transaction
{
    #region properties
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string Description { get; set; }
    #endregion


    public abstract string GetSummary();
}