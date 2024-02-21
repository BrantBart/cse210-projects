using System;
using System.Collections.Generic;

public class Recipe
{
    public string Title { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Temperature { get; set; }
    public string Instructions { get; set; }

    public Recipe(string title, List<Ingredient> ingredients, string temperature, string instructions)
    {
        Title = title;
        Ingredients = ingredients;
        Temperature = temperature;
        Instructions = instructions;
    }

    public override string ToString()
    {
        string recipeString = $"Title: {Title}\n\nIngredients:\n";
        foreach (Ingredient ingredient in Ingredients)
        {
            recipeString += $"{ingredient.Quantity} {ingredient.Name}\n";
        }
        recipeString += $"\nTemperature: {Temperature}\n\nInstructions:\n{Instructions}";
        return recipeString;
    }
}
