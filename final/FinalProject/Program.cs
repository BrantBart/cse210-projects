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
            Console.WriteLine("2. List Recipes");
            Console.WriteLine("3. Save Recipes");
            Console.WriteLine("4. Bake Cookies");
            Console.WriteLine("5. Inventory Check");
            Console.WriteLine("6. Select Recipe to Bake");
            Console.WriteLine("7. Quit");
            choice = Console.ReadLine();
            Console.Clear();
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
                    recipeManager.Make();
                    break;
                case "5":
                    recipeManager.CheckInventory();
                    break;
                case "6":
                    bake.DisplayRecipes(); // Display recipes to select from
                    Console.WriteLine("Enter the number of the recipe you want to bake:");
                    if (int.TryParse(Console.ReadLine(), out int selectedRecipeIndex))
                    {
                        bake.SelectRecipe(selectedRecipeIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                    break;
            }
        }
    }
}
