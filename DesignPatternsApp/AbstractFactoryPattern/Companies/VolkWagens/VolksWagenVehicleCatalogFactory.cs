
using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;
using AbstractFactoryPattern.VehicleCatalogFactories.Factories;

namespace AbstractFactoryPattern.Companies.VolkWagens
{
    public class VolksWagenVehicleCatalogFactory : IVehicleCatalogFactory
    {
        public IVehicleCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "diesel" => new VolksWagenDieselCatalog(),
                "electrical" => new VolksWagenElectricalCatalog(),
                _ => new VolksWagenVehicleCatalog(),
            };
        }
    }
}
