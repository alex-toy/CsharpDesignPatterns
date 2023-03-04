using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using FactoryPattern.Models;

namespace AbstractFactoryPattern.Companies.Audis
{
    public class AudiVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "Audi 1"},
                new Vehicle() { Name = "Audi 2"}
            };
        }
    }
}
