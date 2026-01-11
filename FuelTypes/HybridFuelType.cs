namespace CarDealership.FuelTypes;

/// <summary>
/// Hybrid fuel type implementation
/// </summary>
public class HybridFuelType : IFuelType
{
    public string Type => "Hybrid";
    public string Description => "Hybrid powered vehicle (Petrol/Electric combination)";
}
