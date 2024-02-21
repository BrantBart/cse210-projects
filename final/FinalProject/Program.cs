using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeManager recipeManager = new RecipeManager();
        Bake bake = new Bake();
        string choice = "";
        Console.Clear();
        Console.WriteLine("Welcome to the baking recipe program!");

        do
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Create New Recipe");
            Console.WriteLine("2. List New Recipes");
            Console.WriteLine("3. Save Recipes");
            Console.WriteLine("4. Load Recipes");
            Console.WriteLine("5. Make Cookies");
            Console.WriteLine("6. Quit Program");
            Console.WriteLine();

            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    recipeManager.Create();
                    WaitForEnter();
                    break;
                case "2":
                    recipeManager.List();
                    WaitForEnter();
                    break;
                case "3":
                    recipeManager.Save();
                    WaitForEnter();
                    break;
                case "4":
                    recipeManager.Load();
                    WaitForEnter();
                    break;
                case "5":
                    bake.MakeCookies();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Terminating Program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        } while (choice != "6");
    }

    private static void WaitForEnter()
    {
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }
}
