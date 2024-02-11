using System;
// I ended up using polymorphism but not to a good extent
// I made the code show the score the current user has (load needs to be done first).
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.WriteLine("Welcome to the goal gamification program!");
        string choice = "";
        while (choice != "7")
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Check Score");
            Console.WriteLine("7. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.Create();
                    break;
                case "2":
                    goalManager.List();
                    break;
                case "3":
                    goalManager.Save();
                    break;
                case "4":
                    goalManager.Load();
                    break;
                case "5":
                    goalManager.Record();
                    break;
                case "6":
                    goalManager.CheckScore();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                    break;
            }
        }
    }
}
