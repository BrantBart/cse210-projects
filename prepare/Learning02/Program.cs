using System;
using System.Collections.Generic;

namespace Learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Microsoft";
            job1._startYear = 2019;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._jobTitle = "Manager";
            job2._company = "Apple";
            job2._startYear = 2022;
            job2._endYear = 2023;

            Resume brantsResume = new Resume();
            brantsResume._name = "Brant Barton";
            brantsResume._jobs.Add(job1);
            brantsResume._jobs.Add(job2);

            brantsResume.Display();
        }
    }
}