namespace FactoryPattern.Vehicles
{
    public class HybridVehicleCatalog : IVehiculeCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "hybrid" } };
        }
    }
}
