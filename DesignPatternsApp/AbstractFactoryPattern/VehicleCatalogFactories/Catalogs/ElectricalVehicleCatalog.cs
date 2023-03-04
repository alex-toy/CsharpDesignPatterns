using FactoryPattern.Models;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Catalogs
{
    public class ElectricalVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "electrical" } };
        }
    }
}
