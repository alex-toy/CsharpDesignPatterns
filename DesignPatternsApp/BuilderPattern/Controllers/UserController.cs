using Microsoft.AspNetCore.Mvc;
using PrototypePattern.Models;

namespace PrototypePattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUser _user;

        public UserController(ILogger<UserController> logger, IUser user)
        {
            _logger = logger;
            _user = user;
        }

        [HttpGet(Name = "GetUser")]
        public IUser Get()
        {
            return _user;
        }
    }
}