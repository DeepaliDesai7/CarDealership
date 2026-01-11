using CarDealership.FuelTypes;
using CarDealership.Variants;
using CarDealership.Versions;

namespace CarDealership.Models;

/// <summary>
/// Abstract base class for all cars
/// Template Method pattern - defines the skeleton of car structure
/// </summary>
public abstract class BaseCar
{
    public string ModelName { get; set; } = string.Empty;
    public int BuyPrice { get; set; }
    public int SellPrice { get; set; }
    public string Variant { get; set; } = string.Empty;
    public int Version { get; set; }
    public int ManufacturerId { get; set; }
    
    // Composition - Strategy pattern for fuel type
    public IFuelType FuelType { get; set; } = null!;
    
    // Composition - Strategy pattern for variant
    public IVariant VariantType { get; set; } = null!;
    
    // Composition - Strategy pattern for version features
    public IVersion VersionDetails { get; set; } = null!;
    
    // Reference to manufacturer
    public Manufacturer Manufacturer { get; set; } = null!;
    
    /// <summary>
    /// Template method for getting airbag count
    /// Can be overridden by derived classes if needed
    /// </summary>
    /// <returns>Number of airbags</returns>
    public virtual int GetAirbagsCount()
    {
        // If manufacturer is Tata, return 4 by default
        if (Manufacturer?.IsTata ?? false)
        {
            return 4;
        }
        
        // Default implementation - can be overridden
        return GetDefaultAirbagsCount();
    }
    
    /// <summary>
    /// Hook method for default airbag count
    /// Can be overridden by derived classes
    /// </summary>
    /// <returns>Default number of airbags</returns>
    protected virtual int GetDefaultAirbagsCount()
    {
        return 2; // Default airbag count
    }
}
