using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.VolkWagens
{
    public class VolksWagenDieselCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "VW diesel 1"},
                new Vehicle() { Name = "VW diesel 2"}
            };
        }
    }
}
