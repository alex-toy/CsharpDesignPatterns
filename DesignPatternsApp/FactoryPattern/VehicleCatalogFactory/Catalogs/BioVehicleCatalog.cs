using FactoryPattern.Models;
using FactoryPattern.Vehicles;

namespace FactoryPattern.VehicleCatalogFactory.Catalogs
{
    public class BioVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "bio 1" },
                new Vehicle() { Name = "bio 2" }
            };
        }
    }
}
