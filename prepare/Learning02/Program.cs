using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._company = "Nu Skin Enterprises";
        job1._jobTitle = "Manufacturing QA Engineer";
        job1._startYear = 1995;
        job1._endYear = "2018";

        Jobs job2 = new Jobs();
        job2._company = "DirectScale";
        job2._jobTitle = "Software QA Engineer";
        job2._startYear = 2019;
        job2._endYear = "2023";

        Jobs job3 = new Jobs();
        job3._company = "Purple";
        job3._jobTitle = "Software QA Engineer";
        job3._startYear = 2024;
        job3._endYear = "present";

        Resume myResume = new Resume();
        myResume._memberName = "Austin Martineau";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayJobDetails();
    }
}