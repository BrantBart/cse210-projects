using System;

public class Goal
{
    public string Text { get; set; }
    public int Points { get; set; }
    public bool Completed { get; set; }

    public virtual void goalDetails()
    {
        Console.WriteLine("Goal Description");
    }
}