namespace CarDealership.Variants;

/// <summary>
/// Interface for car variants (Strategy pattern)
/// Allows extensibility for future variant types
/// </summary>
public interface IVariant
{
    string Name { get; }
    string Description { get; }
}
