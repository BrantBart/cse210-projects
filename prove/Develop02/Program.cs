using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.IO;
using System.Runtime.CompilerServices;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedOption = "";
            List<string> journalEntries = new List<string> { };
            //start
            Console.WriteLine($"Welcome to the Journal Program");
            while (selectedOption != "exit")
            {
                Menu menu = new Menu();
                Write write = new Write();
                Save save = new Save();
                FileWork fileProperties = new FileWork();

                //select option
                selectedOption = menu.PrintMenu();
                switch (selectedOption)
                {
                    case "write":
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        var promptResult = Prompts();

                        string givenPrompt = promptResult.Item1;
                        int promptNumber = promptResult.Item2;

                        Console.Write($"{givenPrompt}: ");
                        string textEntry = Console.ReadLine();

                        string postForFile = $"{dateText} - Prompt: {givenPrompt}\nResponse: {textEntry}";
                        journalEntries.Add(postForFile);

                        break;
                    case "display":
                        break;
                    case "load":
                        string filename = "test.txt";
                        string[] lines = System.IO.File.ReadAllLines(filename);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(",");

                            string firstName = parts[0];
                            string lastName = parts[1];
                        }
                        break;
                    case "save":
                        save.SaveToFile(journalEntries);
                        break;
                    case "quit":
                        break;
                    default:
                        break;
                }
                //file section

                // FileWork fileproperties = new FileWork();

                // // Get and print the list of file names in the current folder
                // List<string> fileNames = fileProperties.GetJournalNames();

                // if (fileNames.Count > 0)
                // {
                //     // Print each file name
                //     foreach (string fileName in fileNames)
                //     {
                //         Console.WriteLine(fileName);
                //     }
                // }
                // else
                // {
                //     Console.WriteLine("No files with .txt extension found in the current folder.");
                // }
            }
            Console.WriteLine($"Your program has terminated!");
        }
        public static Tuple<string, int> Prompts()
        {
            List<string> prompts = new List<string>
                {
                    "Who was the most interesting person I interacted with today?",
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?"
                };
            //pick a random prompt
            Random random = new Random();
            int randomPromptNumb = random.Next(prompts.Count);
            string randomPrompt = prompts[randomPromptNumb];

            return Tuple.Create(randomPrompt, randomPromptNumb);
        }
    }
}


// static void ListTextFiles()
// {
//     string currentDirectory = Environment.CurrentDirectory;
//     string[] textFiles = Directory.GetFiles(currentDirectory, "*.txt");

//     if (textFiles.Length > 0)
//     {
//         Console.WriteLine("Text files in the current folder:");
//         foreach (string file in textFiles)
//         {
//             Console.WriteLine(Path.GetFileName(file));
//         }
//     }
//     else
//     {
//         Console.WriteLine("No text files found in the current folder.");
//     }
// }
// }