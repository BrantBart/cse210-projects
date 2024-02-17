using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        RecipeManager recipeManager = new RecipeManager();
        Console.Clear();
        Console.WriteLine("Welcome to the baking recipe program!");
        string choice = "";
        while (choice != "7")
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. Create New Recipe");
            Console.WriteLine("2. List Recipes");
            Console.WriteLine("3. Save Recipes");
            Console.WriteLine("4. Bake Cookies");
            Console.WriteLine("5. Inventory Check");
            Console.WriteLine("6. Quit");
            choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                case "1":
                    recipeManager.Create();
                    // adding the different recipe types.
                    break;
                case "2":
                    recipeManager.List();
                    break;
                case "3":
                    recipeManager.Save();
                    break;
                case "4":
                    recipeManager.Make();
                    // req
                    break;
                case "5":
                    recipeManager.CheckInventory();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    //will add an animation here
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }
}
