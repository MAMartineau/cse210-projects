public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt grateful recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.", 0)
    {
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetUserInput()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a response: ");
            responses.Add(Console.ReadLine());
        }

        return responses;
    }

    public override void RunActivity()
    {
        StartMessage();
        Console.WriteLine("\n" + GetRandomPrompt());
        PauseWithCountdown(5);

        List<string> responses = GetUserInput();

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        EndMessage();
    }
}