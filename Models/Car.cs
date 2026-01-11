using CarDealership.FuelTypes;
using CarDealership.Variants;
using CarDealership.Versions;

namespace CarDealership.Models;

/// <summary>
/// Concrete implementation of BaseCar
/// Represents a car in the dealership
/// </summary>
public class Car : BaseCar
{
    public Car(
        string modelName,
        int buyPrice,
        int sellPrice,
        Manufacturer manufacturer,
        IFuelType fuelType,
        IVariant variant,
        IVersion version)
    {
        ModelName = modelName;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
        Manufacturer = manufacturer;
        ManufacturerId = manufacturer.Id;
        FuelType = fuelType;
        VariantType = variant;
        Variant = variant.Name;
        VersionDetails = version;
        Version = version.VersionNumber;
    }
}
