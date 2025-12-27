using System;
namespace QuickMart;

public class SaleTransaction
{
    #region Fields
    public string invoiceNo;
    public string customerName;
    public string itemName;
    public int quantity;

    public decimal purchaseAmount;
    public decimal sellingAmount;

    public string profitOrLossStatus;
    public decimal profitOrLossAmount;
    public decimal profitMarginPercent;
    #endregion
}

