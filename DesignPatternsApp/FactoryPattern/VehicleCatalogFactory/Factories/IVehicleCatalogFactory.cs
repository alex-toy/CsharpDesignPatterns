namespace FactoryPattern.Vehicles
{
    public interface IVehicleCatalogFactory
    {
        IVehicleCatalog CreateCatalog(string type);
    }
}