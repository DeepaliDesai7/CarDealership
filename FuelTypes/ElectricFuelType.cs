namespace CarDealership.FuelTypes;

/// <summary>
/// Electric fuel type implementation
/// </summary>
public class ElectricFuelType : IFuelType
{
    public string Type => "Electric";
    public string Description => "Electric powered vehicle";
}
