using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ReflectingActivity : Activity
{
    private static readonly List<string> PromptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> QuestionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public static void Start()
    {
        DisplayRandomPrompt();
        Console.WriteLine();

        foreach (var question in QuestionList)
        {
            DisplayQuestionAndSpinner(question);
        }
    }

    private static void DisplayRandomPrompt()
    {
        Spinner spinner = new Spinner();
        string randomPrompt = GetRandomItemFromList(PromptList);
        Console.Write($"Your prompt is: {randomPrompt}");
        spinner.Start();
        Thread.Sleep(10000);
        spinner.Stop();
    }

    private static void DisplayQuestionAndSpinner(string question)
    {
        Spinner spinner = new Spinner();
        Console.Write($"Question: {question} ");
        spinner.Start();
        Thread.Sleep(10000);
        spinner.Stop();

        Console.WriteLine();
    }

    private static string GetRandomItemFromList(List<string> list)
    {
        Random random = new Random();
        int index = random.Next(list.Count);
        return list[index];
    }
}