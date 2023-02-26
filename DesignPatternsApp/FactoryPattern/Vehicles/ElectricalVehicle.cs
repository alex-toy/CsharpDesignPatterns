namespace FactoryPattern.Vehicles
{
    public class ElectricalVehicle
    {
        public Vehicle[] GetVehicles()
        {
            return new[] { new Vehicle() { Name = "electrical" } };
        }
    }
}
