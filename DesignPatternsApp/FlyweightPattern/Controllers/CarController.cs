using FlyweightPattern.Managers;
using Microsoft.AspNetCore.Mvc;

namespace FlyweightPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarManager[] _carManagers;

        public CarController(ICarManager[] carManagers)
        {
            this._carManagers = carManagers;
        }

        [HttpGet(Name = "SetLocation")]
        public void SetLocation()
        {
            decimal lat = 1;
            decimal lon = 1;
            foreach (var carManager in _carManagers)
            {
                carManager.SetLocation(lat++, lon++);
            }
        }
    }
}