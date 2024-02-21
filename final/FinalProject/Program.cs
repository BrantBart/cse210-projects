using System;

class Program
{
    static void Main(string[] args)
    {
        RecipeManager recipeManager = new RecipeManager();
        Bake bake = new Bake(); // Instantiate Bake class
        Console.Clear();
        Console.WriteLine("Welcome to the baking recipe program!");
        string choice = "";
        while (choice != "8") // Adjusting the exit option to accommodate the new functionality
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Create New Recipe");
            Console.WriteLine("2. List New Recipes");
            Console.WriteLine("3. Save Recipes");
            Console.WriteLine("4. Load Recipes");
            Console.WriteLine("5. Make Cookies");
            Console.WriteLine("6. Sell or Donate an ammount");
            Console.WriteLine("7. Check current inventory");
            Console.WriteLine("8. Quit Program");
            choice = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Main Menu");
            switch (choice)
            {
                case "1":
                    recipeManager.Create();
                    break;
                case "2":
                    recipeManager.List();
                    break;
                case "3":
                    recipeManager.Save();
                    break;
                case "4":
                    recipeManager.Load();
                    break;
                case "5":
                    recipeManager.MakeCookies();
                    break;
                case "6":
                    recipeManager.Sell();
                    recipeManager.Donate();
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    break;
                case "8":
                    Console.Clear();
                    Console.WriteLine("Terminating Program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                    break;
            }
        }
    }
}
