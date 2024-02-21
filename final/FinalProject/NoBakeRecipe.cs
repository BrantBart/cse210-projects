using System.Collections.Generic;

public class NoBakeRecipe : Recipe
{
    public NoBakeRecipe(string title, List<Ingredient> ingredients, string temperature, string instructions)
        : base(title, ingredients, temperature, instructions)
    {
        // NoBakeRecipe allows specifying temperature
    }
}
