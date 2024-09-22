using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        string letter;
        
        if (x >= 90)
        {
           letter = "A";
        }
        else if (x >= 80 && x <= 89)
        {
            letter = "B";
        }
        else if (x >= 70 && x <= 79)
        {
            letter = "C";
        }
        else if (x >= 60 && x <= 69)
        {
            letter = "D";
        }
        else
        {
           letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("You did not pass this class. Try again.");
            Console.WriteLine("You have what it takes to pass. You can do this!");
        }
    }
}