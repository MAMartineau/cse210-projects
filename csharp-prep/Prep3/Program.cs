using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("Guess the number I am thinking");
        
        int userGuess = 0;
        
        while (userGuess != number)
        {                
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < number)
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