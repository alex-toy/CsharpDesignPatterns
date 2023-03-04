using AbstractFactoryPattern.VehicleCatalogFactories.Catalogs;

namespace AbstractFactoryPattern.VehicleCatalogFactories.Factories
{
    public interface IVehicleCatalogFactory
    {
        IVehicleCatalog CreateCatalog(string type);
    }
}