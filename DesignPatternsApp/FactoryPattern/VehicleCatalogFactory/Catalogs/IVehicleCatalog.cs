using FactoryPattern.Models;

namespace FactoryPattern.Vehicles
{
    public interface IVehicleCatalog
    {
        Vehicle[] GetVehicles();
    }
}
