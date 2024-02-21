using System.Collections.Generic;

public class BakeRecipe : Recipe
{
    public BakeRecipe(string title, List<Ingredient> ingredients, string temperature, string instructions)
        : base(title, ingredients, temperature, instructions)
    {
        // BakeRecipe allows specifying temperature
    }
}
