using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
// I created a spinner class, 
// I made it so that it prints out the listings after you do that part, 
// I made it so that the breathing has 2 options of how you want to do it.
class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Lets start an activity!");
            Console.WriteLine("Pick one (1-4):");
            Console.WriteLine("1: Breathing");
            Console.WriteLine("2: Listing");
            Console.WriteLine("3: Reflecting");
            Console.WriteLine("4: Quit");
            choice = Console.ReadLine();
            Console.Clear();
            Console.Write($"You picked {choice}... Loading ");

            Spinner spinner = new Spinner();
            spinner.Start();
            Thread.Sleep(3000);
            spinner.Stop();

            if (choice != "4")
            {
                Console.Clear();
                Activity.Welcome(choice);
                Console.Clear();
                Activity.Goodbye(choice);
            }
            Console.Clear();
            Console.WriteLine($"Quitting Program... Hope you feel better!");
            Console.WriteLine("");
        }
    }
}