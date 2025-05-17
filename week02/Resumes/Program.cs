using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1.JobTitle = "Software Engineer";
        job1.Company = "Microsoft";
        job1.StartYear = 2019;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.JobTitle = "Manager";
        job2.Company = "Apple";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume myResume = new Resume();
        myResume.Name = "Alison Rose";
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}

class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} at {Company} ({StartYear} - {EndYear})");
    }
}

class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}