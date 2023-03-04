using FactoryPattern.Models;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Catalogs
{
    public class HybridVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "hybrid" } };
        }
    }
}
