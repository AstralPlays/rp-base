namespace astral_base.SCPRP;

[GameResource("Team", ".team", "")]
public class Team : GameResource
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public Color Color { get; set; }
    public List<Item> Items { get; set; }
    public float MaxHealth { get; set; }
    public float MaxArmor { get; set; }
    public string Model { get; set; }

    public Team(string name, string description, string category, Color color, List<Item> items, float maxHealth, float maxArmor, string model)
    {
        Name = name;
        Description = description;
        Category = category;
        Color = color;
        Items = items ?? new List<Item>(); // Default to an empty list if null
        MaxHealth = maxHealth;
        MaxArmor = maxArmor;
        Model = model;
    }
}
