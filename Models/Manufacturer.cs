namespace CarDealership.Models;

/// <summary>
/// Represents a car manufacturer
/// </summary>
public class Manufacturer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public Manufacturer(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public bool IsTata => Name.Equals("Tata", StringComparison.OrdinalIgnoreCase);
}
