using FactoryPattern.Models;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Catalogs
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
