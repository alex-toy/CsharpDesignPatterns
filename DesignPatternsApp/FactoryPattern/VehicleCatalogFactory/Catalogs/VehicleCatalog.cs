using FactoryPattern.Models;

namespace FactoryPattern.Vehicles.Catalogs
{
    public class VehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "regular" } };
        }
    }
}
