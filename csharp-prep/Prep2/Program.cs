using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade score?(0-100) ");
        string scoreFromUser = Console.ReadLine();
        int score = int.Parse(scoreFromUser);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string grade = "";
        bool status = true;

        if (score > a)
        {
            grade = "A";
        }
        else if (score > b)
        {
            grade = "B";
        }
        else if (score > c)
        {
            grade = "C";
        }
        else if (score > d)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (score >= c)
        {
            status = true;
        }
        else
        {
            status = false;
        }

        Console.WriteLine($"Your final grade is: {grade} - {score}%");
        if (status == true)
        {
            Console.WriteLine($"Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine($"You did not pass the course. Better luck next time!");
        }
    }
}