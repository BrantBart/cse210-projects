using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ListingActivity : Activity
{
    private static readonly string[] WordList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Who are some of your favorite people from the scriptures?"
    };

    public static void Start()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"This activity will help you reflect. Your prompt is: {randomPrompt}");

        List<string> enteredWords = GetWordsWithinTimeLimit();

        Console.WriteLine("\nActivity Results:");
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.WriteLine($"Entered Words: {string.Join(", ", enteredWords)}");
        Thread.Sleep(20000);
    }

    private static string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(WordList.Length);
        return WordList[index];
    }

    private static List<string> GetWordsWithinTimeLimit()
    {
        Console.WriteLine("You have 30 seconds to type words and hit enter. Go!");

        List<string> enteredWords = new List<string>();
        DateTime startTime = DateTime.Now;

        while (DateTime.Now - startTime < TimeSpan.FromSeconds(30))
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(word))
            {
                break;
            }

            enteredWords.Add(word);
        }

        return enteredWords;
    }
}
