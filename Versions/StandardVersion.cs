namespace CarDealership.Versions;

/// <summary>
/// Standard version implementation
/// </summary>
public class StandardVersion : BaseVersion
{
    public StandardVersion(int versionNumber = 1)
    {
        VersionNumber = versionNumber;
        Description = $"Standard Version {versionNumber}";
    }
    
    public override IEnumerable<string> Features => new List<string>
    {
        "Basic audio system",
        "Manual AC",
        "Standard upholstery"
    };
}
