using System;

namespace Questions;

public class GuessingGame
{
    int secret;

    public GuessingGame(int secretNumber)
    {
        secret = secretNumber;
    }

    public void Play()
    {
        int guess;

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < secret)
                Console.WriteLine("Too Low");
            else if (guess > secret)
                Console.WriteLine("Too High");

        } while (guess != secret);

        Console.WriteLine("Correct Guess!");
    }
}
