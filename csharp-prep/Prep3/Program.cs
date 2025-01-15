using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask the user for the magic number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Step 3: Generate a random number as the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("Guess the number I am thinking of (between 1 and 100)");

        int userGuess = 0;

        // Step 2: Add a loop to keep asking until the guess is correct
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}