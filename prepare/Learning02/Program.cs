using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Job job1 = new Job();
        job1. _companyName ="Microsoft";
        job1. _jobTitle ="Software Engineer";
        job1. _startYear = 2001;
        job1. _endYear = 2010;
        job1.JobInformation();

        Job job2 = new Job();
        job2. _companyName = "Google";
        job2. _jobTitle = "Developer";
        job2. _startYear = 2002;
        job2 ._endYear = 2006;
        job2.JobInformation();



        

        
    }
}