using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._company = "Nu Skin Enterprises";
        job1._jobTitle = "QA Engineer";
        job1._startYear = 1995;
        job1._endYear = 2018;

        Jobs job2 = new Jobs();
        job2._company = "DirectScale";
        job2._jobTitle = "Software QA Engineer";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._memberName = "Austin Martineau";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayJobDetails();

    }
}