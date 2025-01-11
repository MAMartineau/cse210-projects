using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int gradePercent = int.Parse(valueFromUser);
        string letter;
        
        if (gradePercent >= 90)
        {
           letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
           letter = "F";
        }
        
        Console.WriteLine($"Your letter grade is {letter}");

        if (gradePercent >= 70)
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