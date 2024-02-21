using System;
using System.Collections.Generic;
using System.IO;

public class RecipeManager
{
    private List<Recipe> recipes = new List<Recipe>();

    public void Create()
    {
        Console.WriteLine("Enter recipe name:");
        string recipeName = Console.ReadLine();

        Console.WriteLine("Select type of cookie:");
        Console.WriteLine("1. Bake");
        Console.WriteLine("2. No Chill");
        Console.WriteLine("3. No Bake");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                recipes.Add(CreateBakeRecipe(recipeName));
                break;
            case "2":
                recipes.Add(CreateNoChillRecipe(recipeName));
                break;
            case "3":
                recipes.Add(CreateNoBakeRecipe(recipeName));
                break;
            default:
                Console.WriteLine("Invalid choice. Recipe not created.");
                break;
        }
    }

    private BakeRecipe CreateBakeRecipe(string recipeName)
    {
        Console.WriteLine("Enter oven temperature (in Fahrenheit):");
        string temperature = Console.ReadLine();

        return new BakeRecipe(recipeName, CreateIngredients(), temperature, CreateInstructions());
    }

    private NoChillRecipe CreateNoChillRecipe(string recipeName)
    {
        return new NoChillRecipe(recipeName, CreateIngredients(), CreateInstructions());
    }

    private NoBakeRecipe CreateNoBakeRecipe(string recipeName)
    {
        Console.WriteLine("Select heat level:");
        Console.WriteLine("1. Low");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. High");
        string heatLevel = Console.ReadLine();
        string temperature = GetNoBakeTemperature(heatLevel);

        return new NoBakeRecipe(recipeName, CreateIngredients(), temperature, CreateInstructions());
    }

    private string GetNoBakeTemperature(string heatLevel)
    {
        switch (heatLevel)
        {
            case "1":
                return "Low heat";
            case "2":
                return "Medium heat";
            case "3":
                return "High heat";
            default:
                return "Unknown";
        }
    }

    private List<Ingredient> CreateIngredients()
    {
        List<Ingredient> ingredients = new List<Ingredient>();

        while (true)
        {
            Console.WriteLine("Enter ingredient name (leave blank to finish adding ingredients):");
            string ingredientName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ingredientName))
                break;

            Console.WriteLine("Enter quantity:");
            string quantity = Console.ReadLine();

            ingredients.Add(new Ingredient(ingredientName, quantity));
        }

        return ingredients;
    }

    private string CreateInstructions()
    {
        Console.WriteLine("Enter cooking instructions:");
        return Console.ReadLine();
    }

    public void List()
    {
        Console.WriteLine("Recipes:");
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe.Title);
        }
    }

    public void Save()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("recipes.txt"))
            {
                foreach (var recipe in recipes)
                {
                    sw.WriteLine(recipe.Title);
                    sw.WriteLine(string.Join(",", recipe.Ingredients));
                    sw.WriteLine(recipe.Temperature);
                    sw.WriteLine(recipe.Instructions);
                    sw.WriteLine();
                }
            }
            Console.WriteLine("Recipes saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving recipes: {ex.Message}");
        }
    }

    public void Make()
    {
        // Implement logic for making cookies
    }

    public void CheckInventory()
    {
        // Implement logic for checking inventory
    }
}
