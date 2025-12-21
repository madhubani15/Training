using System;

namespace Questions;

public class RPS
{
    string player1;
    string player2;

    public RPS(string p1, string p2)
    {
        player1 = p1.ToLower();
        player2 = p2.ToLower();
    }

    public void Result()
    {
        if (player1 == player2)
        {
            Console.WriteLine("Draw");
        }
        else
        {
            if (player1 == "rock")
            {
                if (player2 == "scissors")
                    Console.WriteLine("Player 1 Wins");
                else
                    Console.WriteLine("Player 2 Wins");
            }
            else if (player1 == "paper")
            {
                if (player2 == "rock")
                    Console.WriteLine("Player 1 Wins");
                else
                    Console.WriteLine("Player 2 Wins");
            }
            else if (player1 == "scissors")
            {
                if (player2 == "paper")
                    Console.WriteLine("Player 1 Wins");
                else
                    Console.WriteLine("Player 2 Wins");
            }
        }
    }
}
