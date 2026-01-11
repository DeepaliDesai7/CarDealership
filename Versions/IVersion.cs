namespace CarDealership.Versions;

/// <summary>
/// Interface for car version features
/// Each version can have different features
/// </summary>
public interface IVersion
{
    int VersionNumber { get; }
    string Description { get; }
    IEnumerable<string> Features { get; }
}
