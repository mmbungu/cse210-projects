using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job._jobTitle = "Software Engineer";
        job._startYear = 2018;
        job._endYear = 2020;

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Product Manager";
        job1._startYear = 2020;
        job1._endYear = 2022;

        Resume resume = new Resume();
        resume._name = "Goms";

        resume._jobs.Add(job);
        resume._jobs.Add(job1);

        resume.Display();

    }
}