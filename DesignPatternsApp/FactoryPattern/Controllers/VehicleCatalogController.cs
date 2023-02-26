using FactoryPattern.Vehicles;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleCatalogController : ControllerBase
    {
        private readonly IVehiculeCatalog _vehiculeCatalog;

        public VehicleCatalogController(IVehiculeCatalog vehiculeCatalog)
        {
            _vehiculeCatalog = vehiculeCatalog;
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get(string type)
        {
            return null;
        }
    }
}