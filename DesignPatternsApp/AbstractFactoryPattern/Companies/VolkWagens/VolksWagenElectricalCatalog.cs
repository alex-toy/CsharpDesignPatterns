using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.VolkWagens
{
    public class VolksWagenElectricalCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "VW electrical 1"},
                new Vehicle() { Name = "VW electrical 2"}
            };
        }
    }
}
