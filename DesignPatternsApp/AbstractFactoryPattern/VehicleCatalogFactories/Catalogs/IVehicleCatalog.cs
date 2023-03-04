using FactoryPattern.Models;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Catalogs
{
    public interface IVehicleCatalog
    {
        Vehicle[] GetVehicles();
    }
}
