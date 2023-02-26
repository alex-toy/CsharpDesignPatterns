using FactoryPattern.Vehicles.Catalogs;

namespace FactoryPattern.Vehicles
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
                _ => new VehicleCatalog(),
            };
        }
    }
}
