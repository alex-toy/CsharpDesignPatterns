using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.Audis
{
    public class AudiElectricalCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "Audi electrical 1"},
                new Vehicle() { Name = "Audi electrical 2"}
            };
        }
    }
}
