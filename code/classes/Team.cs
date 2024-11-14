namespace astral_base.SCPRP;

[GameResource("Team", "team", "", Category = "Roleplay")]
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
}
