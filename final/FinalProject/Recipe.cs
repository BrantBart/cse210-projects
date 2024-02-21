public class Recipe
{
    public string Title { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Instructions { get; set; }

    public string Temperature { get; set; }

    public string QuantityPerBatch { get; set; }

    public Recipe(string title, List<Ingredient> ingredients, string temperature, string instructions, string quantityPerBatch)
    {
        Title = title;
        Ingredients = ingredients;
        Temperature = temperature;
        Instructions = instructions;
        QuantityPerBatch = quantityPerBatch;
    }
}