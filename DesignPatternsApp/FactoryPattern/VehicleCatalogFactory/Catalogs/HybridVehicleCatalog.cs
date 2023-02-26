namespace FactoryPattern.Vehicles
{
    public class HybridVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "hybrid" } };
        }
    }
}
