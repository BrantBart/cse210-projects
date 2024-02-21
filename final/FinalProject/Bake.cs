using System;
using System.Collections.Generic;
using System.IO;

public class Bake
{
    public void MakeCookies()
    {
        List<Recipe> recipes = new List<Recipe>();

        try
        {
            using (StreamReader sr = new StreamReader("recipes.txt"))
            {
                Console.Clear();
                Console.WriteLine("Recipes available:");
                Console.WriteLine("-----------------------------------------");
                int recipeCount = 0;
                while (!sr.EndOfStream)
                {
                    string titleLine = sr.ReadLine();
                    string ingredientsLine = sr.ReadLine();
                    string temperatureLine = sr.ReadLine();
                    string quantityPerBatchLine = sr.ReadLine();
                    string instructionsLine = sr.ReadLine();
                    sr.ReadLine();

                    if (titleLine != null && titleLine.StartsWith("Title:"))
                    {
                        recipeCount++;
                        string title = titleLine.Substring("Title:".Length).Trim();
                        List<Ingredient> ingredients = ParseIngredients(ingredientsLine?.Substring("Ingredients:".Length).Trim() ?? "");
                        string temperature = temperatureLine?.Substring("Temperature:".Length).Trim() ?? "";
                        string quantityPerBatch = quantityPerBatchLine?.Substring("Quantity per Batch:".Length).Trim() ?? "";
                        string instructions = instructionsLine?.Substring("Instructions:".Length).Trim() ?? "";

                        Recipe recipe = new Recipe(title, ingredients, temperature, instructions, quantityPerBatch);
                        recipes.Add(recipe);

                        Console.WriteLine($"{recipeCount}: {title}");
                    }
                }
            }

            Console.Write("Enter the number of the recipe you want to make: ");
            int recipeChoice;

            if (int.TryParse(Console.ReadLine(), out recipeChoice) && recipeChoice >= 1 && recipeChoice <= recipes.Count)
            {
                Recipe selectedRecipe = recipes[recipeChoice - 1];
                Console.Clear();
                Console.WriteLine($"You've selected recipe: {selectedRecipe.Title}");

                Console.Write("Number of batches: ");
                int batches;
                if (int.TryParse(Console.ReadLine(), out batches) && batches > 0)
                {
                    ProcessBatches(selectedRecipe, batches);
                }
                else
                {
                    Console.WriteLine("Invalid input for number of batches.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for recipe number.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading recipes: {ex.Message}");
        }
    }



    private List<Ingredient> ParseIngredients(string ingredientsLine)
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        if (!string.IsNullOrEmpty(ingredientsLine))
        {
            string[] ingredientPairs = ingredientsLine.Split(',');
            foreach (string pair in ingredientPairs)
            {
                string[] parts = pair.Trim().Split('(');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string quantity = parts[1].Trim().TrimEnd(')');
                    ingredients.Add(new Ingredient(name, quantity));
                }
            }
        }
        return ingredients;
    }

    private void ProcessBatches(Recipe recipe, int batches)
    {
        Console.WriteLine($"Recipe: {recipe.Title}");
        Console.WriteLine($"Number of batches: {batches}");

        Console.WriteLine("Ingredients:");
        foreach (var ingredient in recipe.Ingredients)
        {
            string[] parts = ingredient.Quantity.Split(' ');
            if (parts.Length == 2 && int.TryParse(parts[0], out int quantity) && parts[1].ToLower() != "batch")
            {
                // Extract the numeric value and multiply by batches
                if (int.TryParse(parts[0], out int numericQuantity))
                {
                    int scaledQuantity = numericQuantity * batches;
                    Console.WriteLine($"{ingredient.Name} ({scaledQuantity} {parts[1]})");
                }
                else
                {
                    Console.WriteLine($"{ingredient.Quantity} {ingredient.Name}");
                }
            }
            else
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Name}");
            }
        }

        Console.WriteLine($"Oven temperature: {recipe.Temperature}");
        Console.WriteLine($"Instructions: {recipe.Instructions}");
        int quantityPerBatch = int.Parse(recipe.QuantityPerBatch);
        Console.WriteLine($"Quantity: {quantityPerBatch * batches}");
    }
}
