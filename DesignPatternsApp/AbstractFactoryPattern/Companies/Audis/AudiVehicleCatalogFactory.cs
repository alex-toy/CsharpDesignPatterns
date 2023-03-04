using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using AbstractFactoryPattern.VehicleCatalogFactories.Factories;

namespace AbstractFactoryPattern.Companies.Audis
{
    public class AudiVehicleCatalogFactory : IVehicleCatalogFactory
    {
        public IVehicleCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "diesel" => new AudiDieselCatalog(),
                "electrical" => new AudiElectricalCatalog(),
                _ => new AudiVehicleCatalog(),
            };
        }
    }
}
