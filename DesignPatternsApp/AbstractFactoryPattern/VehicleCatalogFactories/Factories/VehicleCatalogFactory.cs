using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Factories
{
    public class VehicleCatalogFactory : IVehicleCatalogFactory
    {
        public IVehicleCatalog CreateCatalog(string type)
        {
            return type switch
            {
                "diesel" => new DieselVehicleCatalog(),
                "electrical" => new ElectricalVehicleCatalog(),
                "hybrid" => new HybridVehicleCatalog(),
                "ethanol" => new EthanolVehicleCatalog(),
                _ => new VehicleCatalog(),
            };
        }
    }
}
