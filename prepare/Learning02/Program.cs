using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Generic Tech Company Name";
        job1._startYear = 2000;
        job1._endYear = 2099;
        Job job2 = new Job();
        job2._jobTitle = "Chair Warmer";
        job2._company = "Nuclear Power Plant";
        job2._startYear = 1945;
        job2._endYear = 4012;
        Resume resume1 = new Resume();
        resume1._name = "homer simpson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}