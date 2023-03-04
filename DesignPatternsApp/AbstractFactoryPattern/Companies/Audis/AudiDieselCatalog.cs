using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.Audis
{
    public class AudiDieselCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "Audi diesel 1"},
                new Vehicle() { Name = "Audi diesel 2"}
            };
        }
    }
}
