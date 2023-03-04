namespace AbstractFactoryPattern.VehicleCatalogFactories.Factories
{
    public interface IVehicleCatalogAbstractFactory
    {
        IVehicleCatalogFactory CreateFactory(string manufacturer);
    }
}
