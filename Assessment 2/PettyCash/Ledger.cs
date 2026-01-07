using System;
using System.Collections.Generic;

namespace PettyCash;

public class Ledger<T> where T : Transaction
{
    private List<T> transactionList = new List<T>();

    
    public bool AddEntry(T entry)
    {
        if (entry == null)
        {
            return false;
        }

        transactionList.Add(entry);
        return true;
    }

    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();

        foreach (T tObj in transactionList)
        {
            if (tObj.Date.Date == date.Date)
            {
                result.Add(tObj);
            }
        }

        return result;
    }

    public int CalculateTotal()
    {
        int total = 0;

        foreach (T tObj in transactionList)
        {
            total += tObj.Amount;
        }

        return total;
    }

    public List<T> GetAll()
    {
        return transactionList;
    }
    
}
