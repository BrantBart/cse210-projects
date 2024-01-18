using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning02
{
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            // Notice the use of the custom data type "Job" in this loop
            foreach (Job job in _jobs)
            {
                // This calls the Display method on each job
                job.Display();
            }
        }
    }
}