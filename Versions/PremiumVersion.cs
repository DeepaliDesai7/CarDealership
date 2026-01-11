namespace CarDealership.Versions;

/// <summary>
/// Premium version implementation with additional features
/// </summary>
public class PremiumVersion : BaseVersion
{
    public PremiumVersion(int versionNumber = 2)
    {
        VersionNumber = versionNumber;
        Description = $"Premium Version {versionNumber}";
    }
    
    public override IEnumerable<string> Features => new List<string>
    {
        "Premium audio system",
        "Automatic climate control",
        "Leather upholstery",
        "Sunroof",
        "Navigation system"
    };
}
