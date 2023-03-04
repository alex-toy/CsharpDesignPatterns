using AbstractFactoryPattern.Companies.Audis;
using AbstractFactoryPattern.Companies.VolkWagens;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Factories
{
    public class VehicleCatalogAbstractFactory : IVehicleCatalogAbstractFactory
    {
        public IVehicleCatalogFactory CreateFactory(string manufacturer)
        {
            return manufacturer switch
            {
                "wolkswagen" => new VolksWagenVehicleCatalogFactory(),
                "audi" => new AudiVehicleCatalogFactory(),
                _ => new VehicleCatalogFactory(),
            };
        }
    }
}
