using System;

public class Resume
{
    public string _memberName;

    public List<Jobs> _jobs = new List<Jobs>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_memberName}");
        Console.WriteLine($"Jobs: ");

        foreach (Jobs job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }


}