using System.Collections.Generic;

public class NoChillRecipe : Recipe
{
    public NoChillRecipe(string title, List<Ingredient> ingredients, string instructions)
        : base(title, ingredients, "Room temperature", instructions)
    {
        // NoChillRecipe typically uses room temperature
    }
}
