using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("SpaceX", "Software Engineer", 2030, 2054);
        // Console.WriteLine(job1._company);
        job1.Display();

        Job job2 = new Job("Microsoft", "Graphic Designer", 2013, 2020);
        job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Jane Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Console.WriteLine(resume1._jobs[0]._jobTitle);
        resume1.Display();
    }
}