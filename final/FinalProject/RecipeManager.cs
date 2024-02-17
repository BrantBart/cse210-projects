using System;
using System.Collections.Generic;

class RecipeManager
{
    private List<string> recipes = new List<string>();

    public void Create()
    {
        Console.WriteLine("Enter recipe name:");
        string recipeName = Console.ReadLine();
        recipes.Add(recipeName);
        Console.WriteLine("Recipe created successfully!");
    }

    public void List()
    {
        Console.WriteLine("Recipes:");
        foreach (string recipe in recipes)
        {
            Console.WriteLine(recipe);
        }
    }

    public void Save()
    {
        Console.WriteLine("Recipes saved successfully!");
    }

    public void Make()
    {
        // depending on the three making types
        Console.WriteLine("Baking cookies...");
        Console.WriteLine("Cookies baked successfully!");
    }

    public void CheckInventory()
    {
        Console.WriteLine("Inventory checked!");
    }
}