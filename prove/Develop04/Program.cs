using System;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            DisplayMenu();
            string choice = GetUserChoice();

            if (choice == "4")
                break;

            RunActivity(choice);
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an activity: ");
    }

    static string GetUserChoice()
    {
        return Console.ReadLine();
    }

    static void RunActivity(string choice)
    {
        Activity activity = choice switch
        {
            "1" => new BreathingActivity(),
            "2" => new ReflectingActivity(),
            "3" => new ListingActivity(),
            _ => null
        };

        if (activity != null)
            activity.RunActivity();
    }
}