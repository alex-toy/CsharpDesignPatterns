using AbstractFactoryPattern.VehicleCatalogFactories.Factories;
using FactoryPattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace FactoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleCatalogController : ControllerBase
    {
        private readonly IVehicleCatalogAbstractFactory _vehiculeCatalogAbstractFactory;

        public VehicleCatalogController(IVehicleCatalogAbstractFactory vehiculeCatalogAbstractFactory)
        {
            _vehiculeCatalogAbstractFactory = vehiculeCatalogAbstractFactory;
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get(string manufacturer, string type)
        {
            return _vehiculeCatalogAbstractFactory
                .CreateFactory(manufacturer)
                .CreateCatalog(type)
                .GetVehicles();
        }
    }
}