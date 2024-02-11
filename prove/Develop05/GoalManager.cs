using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();

    public void Create()
    {
        Console.WriteLine("Choose a goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string choice = Console.ReadLine();
        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal();
                break;
            case "2":
                newGoal = new EternalGoal();
                break;
            case "3":
                newGoal = new ChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Enter the text for the goal:");
        newGoal.Text = Console.ReadLine();

        Console.WriteLine("Enter the points for the goal:");
        int points;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Invalid input. Please enter an integer for points:");
        }
        newGoal.Points = points;

        goals.Add(newGoal);
        Console.WriteLine("Goal created and added successfully.");
    }

    public void List()
    {
        Console.WriteLine("Listing all goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            var goal = goals[i];
            Console.WriteLine($"{i + 1}) -----------------------------------------");
            Console.WriteLine($"Goal: {(goal.Completed ? "[x] " : "[ ] ")}{goal.Text}");
            Console.WriteLine($"Points: {goal.Points}");
            Console.WriteLine("-----------------------------------------");
        }
    }

    public void Save()
    {
        using (StreamWriter writer = new StreamWriter("test.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.Text},{goal.Points},{goal.Completed}");
            }
        }
        Console.WriteLine("Goals saved to test.txt.");
    }

    public void Load()
    {
        goals.Clear(); // Clear existing goals before loading
        if (File.Exists("test.txt"))
        {
            string[] lines = File.ReadAllLines("test.txt");
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                string text = parts[0];
                int points = int.Parse(parts[1]);
                bool completed = bool.Parse(parts[2]);

                Goal goal = new Goal { Text = text, Points = points, Completed = completed };
                goals.Add(goal);
            }
            Console.WriteLine("Goals loaded from test.txt.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    public void Record()
    {
        Console.WriteLine("Mark a goal as completed:");
        List();
        Console.WriteLine("Enter the number of the goal to mark as completed:");
        int index;
        while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > goals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        goals[index - 1].Completed = true;
        Console.WriteLine("Goal marked as completed.");
    }

    public void CheckScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            if (goal.Completed)
            {
                totalScore += goal.Points;
            }
        }
        Console.WriteLine($"You have a new high score of: {totalScore}!");
    }
}
