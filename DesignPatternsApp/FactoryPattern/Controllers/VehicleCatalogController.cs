using FactoryPattern.Models;
using FactoryPattern.Vehicles;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleCatalogController : ControllerBase
    {
        private readonly IVehicleCatalogFactory _vehiculeCatalogFactory;

        public VehicleCatalogController(IVehicleCatalogFactory vehiculeCatalogFactory)
        {
            _vehiculeCatalogFactory = vehiculeCatalogFactory;
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get(string type)
        {
            return _vehiculeCatalogFactory.CreateCatalog(type).GetVehicles();
        }
    }
}