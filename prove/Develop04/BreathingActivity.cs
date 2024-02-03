using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class BreathingActivity : Activity
{
    public static void BreathIn(double count)
    {
        Console.Write("breath in...... ");
        for (int i = 1; i <= count; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            Thread.Sleep(500);
        }
    }
    public static void BreathOut(double count)
    {
        Console.Write("breath out...... ");
        for (int i = 1; i <= count; i++)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            Thread.Sleep(500);
        }
    }
    public static void Start()
    {
        Console.WriteLine("Pick a speed (1-2):");
        Console.WriteLine("1. Calming");
        Console.WriteLine("2. Anxiety Relief");
        string pick = Console.ReadLine();
        Spinner spinner = new Spinner();

        if (pick == "1")
        {
            int counter = 0;

            while (counter < 3)
            {
                BreathingActivity.BreathIn(5);
                Console.WriteLine("Hold");
                Thread.Sleep(5000);
                BreathingActivity.BreathOut(5);
                counter++;
            }
            Console.WriteLine("Well done!");

        }
        else if (pick == "2")
        {
            int counter = 0;
            Console.WriteLine("Ready?...");
            Thread.Sleep(1000);
            Console.WriteLine("set!");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(1000);
            while (counter < 10)
            {
                Console.Clear();
                Console.WriteLine("IN!");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("out!");
                Thread.Sleep(500);
                counter++;
            }
            Console.WriteLine("Ok, don't actually do that!");
            Console.WriteLine("Well done!");
            Thread.Sleep(3000);
        }
        else
        {
            Console.WriteLine("Returning to Main Menu...");
        }
    }
}
