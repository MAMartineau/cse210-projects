using System;

public class Jobs
{

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public string _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}