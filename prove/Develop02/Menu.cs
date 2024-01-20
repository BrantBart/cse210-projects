using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Menu
    {
        public string PrintMenu()
        {
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. List Text Files");
            Console.WriteLine($"6. Quit");
            Console.Write($"What would you like to do?: ");
            string stringEntered = Console.ReadLine();
            int optionSelected = 0;
            if (int.TryParse(stringEntered, out _))
            {
                optionSelected = int.Parse(stringEntered);
                switch (optionSelected)
                {
                    case 1:
                        return "write";
                    case 2:
                        return "display";
                    case 3:
                        return "load";
                    case 4:
                        return "save";
                    case 5:
                        return "exit";
                    default:
                        return "You typed {optionSelected}, are you stupid? That isn't 1-5";
                }
            }
            else
            {
                return "Not a number... you had one job...";
            }
        }
    }
}