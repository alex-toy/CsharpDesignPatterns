namespace FactoryPattern.Vehicles
{
    public class DieselVehicleCatalog : IVehiculeCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "diesel" } };
        }
    }
}
