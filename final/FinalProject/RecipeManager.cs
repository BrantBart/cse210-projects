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

        recipes.Add(new Recipe(recipeName, CreateIngredients(), CreateTemperature(), CreateInstructions(), CreateQuantityMade()));
        Console.Clear();
    }

    private List<Ingredient> CreateIngredients()
    {
        List<Ingredient> ingredients = new List<Ingredient>();

        while (true)
        {
            Console.WriteLine("Enter an ingredient name (leave blank if no more ingredients):");
            string ingredientName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ingredientName))
                break;

            Console.WriteLine("Enter quantity:");
            string quantity = Console.ReadLine();

            ingredients.Add(new Ingredient(ingredientName, quantity));
        }

        return ingredients;
    }

    private string CreateTemperature()
    {
        Console.WriteLine("Oven temperature:");
        return Console.ReadLine();
    }

    private string CreateInstructions()
    {
        Console.WriteLine("Enter cooking notes or directions:");
        return Console.ReadLine();
    }

    private string CreateQuantityMade()
    {
        Console.WriteLine("How many cookies does one batch make?:");
        return Console.ReadLine();
    }

    public void List()
    {
        Console.WriteLine("Recipes ready to be saved:");
        for (int i = 0; i < recipes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {recipes[i].Title}");
        }
        Console.WriteLine();
    }

    public void Save()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("recipes.txt", true))
            {
                foreach (var recipe in recipes)
                {
                    sw.WriteLine($"Title: {recipe.Title}");
                    sw.WriteLine($"Ingredients: {string.Join(",", recipe.Ingredients.Select(ing => $"{ing.Name} ({ing.Quantity})"))}");
                    sw.WriteLine($"Temperature: {recipe.Temperature}");
                    sw.WriteLine($"Quantity per Batch: {recipe.QuantityPerBatch}");
                    sw.WriteLine($"Instructions: {recipe.Instructions}");
                    sw.WriteLine();
                }
            }
            Console.Clear();
            Console.WriteLine("Recipes saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving recipes: {ex.Message}");
        }
        recipes.Clear();
    }

    public void Load()
    {
        Console.Clear();
        try
        {
            using (StreamReader sr = new StreamReader("recipes.txt"))
            {
                Console.Clear();
                Console.WriteLine("Loaded Recipes:");
                Console.WriteLine("_______________________________");

                while (!sr.EndOfStream)
                {
                    string titleLine = sr.ReadLine();
                    string ingredientsLine = sr.ReadLine();
                    string instructionsLine = sr.ReadLine();
                    sr.ReadLine(); // Read the empty line separating recipes

                    if (titleLine != null && titleLine.StartsWith("Title:"))
                    {
                        string title = titleLine.Substring("Title:".Length).Trim();
                        string ingredients = ingredientsLine?.Substring("Ingredients:".Length).Trim() ?? "";
                        string instructions = instructionsLine?.Substring("Instructions:".Length).Trim() ?? "";

                        Console.WriteLine($"Title: {title}");
                        Console.WriteLine($"Ingredients: {ingredients}");
                        Console.WriteLine($"Instructions: {instructions}");
                        Console.WriteLine("_______________________________");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading recipes: {ex.Message}");
        }
    }

}

