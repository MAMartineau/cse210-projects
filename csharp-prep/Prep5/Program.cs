using System;

class Program
{
    // The Main function calls each of these functions
    // saving the return values and passing data to them as necessary
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);
    }

    // Displays the message, "Welcome to the Program!"
     static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");    
        return int.Parse(Console.ReadLine());
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int numberSquared)
    {
        Console.WriteLine($"{name}, the square of your number is {numberSquared}");
    }    

}