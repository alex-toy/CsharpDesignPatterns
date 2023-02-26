using FactoryPattern.Models;

namespace FactoryPattern.Vehicles
{
    public class DieselVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "diesel 1" },
                new Vehicle() { Name = "diesel 2" },
                new Vehicle() { Name = "diesel 3" }
            };
        }
    }
}
