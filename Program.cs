using CarDealership.Models;
using CarDealership.FuelTypes;
using CarDealership.Variants;
using CarDealership.Versions;

namespace CarDealership;

/// <summary>
/// Main entry point for the Car Dealership application
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create Tata manufacturer
        var tataManufacturer = new Manufacturer(1, "Tata");
        
        // Create petrol fuel type
        var petrolFuelType = new PetrolFuelType();
        
        // Create sport variant
        var sportVariant = new SportVariant();
        
        // Create a version (using StandardVersion as example)
        var standardVersion = new StandardVersion(1);
        
        // Create Tata's petrol car with sports variant
        var tataPetrolSportsCar = new Car(
            modelName: "Tata Nexon",
            buyPrice: 700000,
            sellPrice: 800000,
            manufacturer: tataManufacturer,
            fuelType: petrolFuelType,
            variant: sportVariant,
            version: standardVersion
        );
        
        // Display car details
        Console.WriteLine("=== Tata Petrol Sports Car ===");
        Console.WriteLine($"Model: {tataPetrolSportsCar.ModelName}");
        Console.WriteLine($"Manufacturer: {tataPetrolSportsCar.Manufacturer.Name}");
        Console.WriteLine($"Fuel Type: {tataPetrolSportsCar.FuelType.Type}");
        Console.WriteLine($"Variant: {tataPetrolSportsCar.VariantType.Name}");
        Console.WriteLine($"Version: {tataPetrolSportsCar.VersionDetails.Description}");
        Console.WriteLine($"Buy Price: {tataPetrolSportsCar.BuyPrice:C}");
        Console.WriteLine($"Sell Price: {tataPetrolSportsCar.SellPrice:C}");
        Console.WriteLine($"Airbags Count: {tataPetrolSportsCar.GetAirbagsCount()}");
        Console.WriteLine($"Version Features: {string.Join(", ", tataPetrolSportsCar.VersionDetails.Features)}");
    }
}
