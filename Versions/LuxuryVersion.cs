namespace CarDealership.Versions;

/// <summary>
/// Luxury version implementation with premium features
/// </summary>
public class LuxuryVersion : BaseVersion
{
    public LuxuryVersion(int versionNumber = 3)
    {
        VersionNumber = versionNumber;
        Description = $"Luxury Version {versionNumber}";
    }
    
    public override IEnumerable<string> Features => new List<string>
    {
        "Premium sound system",
        "Dual-zone automatic climate control",
        "Premium leather upholstery",
        "Panoramic sunroof",
        "Advanced navigation system",
        "360-degree camera",
        "Adaptive cruise control"
    };
}
