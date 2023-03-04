using FactoryPattern.Models;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Catalogs
{
    public class VehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "regular" } };
        }
    }
}
