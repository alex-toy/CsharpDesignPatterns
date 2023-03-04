using FactoryPattern.Models;
using FactoryPattern.Vehicles;

namespace FactoryPattern.VehicleCatalogFactory.Catalogs
{
    public class EthanolVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "ethanol" } };
        }
    }
}
