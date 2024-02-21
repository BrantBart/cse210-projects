using System;
using System.Collections.Generic;
using System.IO;

public class Bake
{
    private List<string> recipes;

    public Bake()
    {
        recipes = LoadRecipes();
    }

    public void DisplayRecipes()
    {
        Console.WriteLine("Recipes:");
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i]}");
        }
    }

    public void SelectRecipe(int index)
    {
        // Assuming index is within range
        string selectedRecipe = recipes[index - 1]; // Adjusting for 0-based index
        Console.WriteLine($"You selected '{selectedRecipe}'.");

        // Ask for the number of batches
        Console.WriteLine("How many batches do you want to make?");
        int batches;
        while (!int.TryParse(Console.ReadLine(), out batches) || batches <= 0)
        {
            Console.WriteLine("Please enter a valid number of batches.");
        }

        // Display adjusted recipe
        Console.WriteLine($"Adjusted recipe for {batches} batch(es) of '{selectedRecipe}':");
        // Here you would need to implement logic to adjust the quantities of ingredients
        // based on the number of batches chosen by the user.
    }

    private List<string> LoadRecipes()
    {
        List<string> recipes = new List<string>();
        // Assuming recipes are stored in a text file named "recipes.txt" in the same directory as the program
        string filePath = "recipes.txt";

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    recipes.Add(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: '{filePath}' not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading '{filePath}': {ex.Message}");
        }

        return recipes;
    }
}
