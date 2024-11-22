using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private static Random _random = new Random();
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one positive thing about me today?",
            "Was I a positive influence to somebody today?",
            "What is something new that I learned today?",
            "Random thoughts:"
        };
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }
}