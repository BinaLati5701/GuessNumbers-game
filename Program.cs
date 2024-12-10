using System;

class Program
{
    static void Main (string [] args)
    {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 101);
        int guess;
        int numGuesses = 0;
        Console.WriteLine("Welcome to the Number Guessing Game!");
        do
        {
            Console.WriteLine("Enter your guess:");
            guess = Convert.ToInt32(Console.ReadLine());
            numGuesses++;
            if (guess > randomNumber)
            {
                Console.WriteLine("Too high, try again.");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Too low, try again.");
            }

        } while (guess != randomNumber);
        Console.WriteLine("Congratualtions, you guessed the number in" + numGuesses + " guesses!");
    }
}
