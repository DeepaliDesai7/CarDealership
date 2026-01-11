namespace CarDealership.FuelTypes;

/// <summary>
/// Strategy pattern interface for fuel/transmission types
/// Allows extensibility for future fuel types
/// </summary>
public interface IFuelType
{
    string Type { get; }
    string Description { get; }
}
