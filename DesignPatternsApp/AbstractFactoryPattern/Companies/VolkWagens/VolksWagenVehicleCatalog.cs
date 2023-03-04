using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.VolkWagens
{
    public class VolksWagenVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "VW 1"},
                new Vehicle() { Name = "VW 2"}
            };
        }
    }
}
