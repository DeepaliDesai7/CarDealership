namespace CarDealership.Versions;

/// <summary>
/// Base implementation of IVersion
/// Template method pattern for versions
/// </summary>
public abstract class BaseVersion : IVersion
{
    public int VersionNumber { get; protected set; }
    public string Description { get; protected set; } = string.Empty;
    public abstract IEnumerable<string> Features { get; }
}
