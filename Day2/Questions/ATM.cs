using System;

namespace Questions;

public class ATM
{
    bool cardInserted;
    bool pinValid;
    double balance;

    public ATM(bool card, bool pin, double bal)
    {
        cardInserted = card;
        pinValid = pin;
        balance = bal;
    }

    public void Withdraw(double amount)
    {
        if (cardInserted)
        {
            if (pinValid)
            {
                if (balance >= amount)
                {
                    balance = balance - amount;
                    Console.WriteLine("Withdrawal Successful");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }
        }
        else
        {
            Console.WriteLine("Insert Card");
        }
    }
}
