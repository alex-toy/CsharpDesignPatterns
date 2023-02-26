namespace FactoryPattern.Vehicles
{
    public class ElectricalVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "electrical" } };
        }
    }
}
