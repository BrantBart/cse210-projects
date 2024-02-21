public class Ingredient
{
    public string Name { get; set; }
    public string Quantity { get; set; }

    public Ingredient(string name, string quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Name} ({Quantity})";
    }
}