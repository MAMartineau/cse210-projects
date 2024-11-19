using System;

public class Entry
{
    public string Date { get; private set; }
    public string PromptText { get; private set; }
    public string EntryText { get; private set; }

    public Entry(string promptText, string entryText)
    {
        Date = DateTime.Now.ToShortDateString();
        PromptText = promptText;
        EntryText = entryText;
    }

    public Entry(string date, string promptText, string entryText) // Overloaded constructor for loading entries
    {
        Date = date;
        PromptText = promptText;
        EntryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{Date} | Prompt: {PromptText} | Entry: {EntryText}");
    }
}