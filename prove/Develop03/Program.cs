using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;



class Program
{
    static void Main()
    {
        Reference reference = new Reference("John 3:16");
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        string input = "";
        while(!scripture.AllWordsHidden() && input != "quit")
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to end:");
            input = Console.ReadLine().ToLower();
            scripture.HideRandomWords();
        }
    }
}