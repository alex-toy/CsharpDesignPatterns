using FacadePattern.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacadePattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            this._inventoryService = inventoryService;
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            return _inventoryService.Get();
        }
    }
}
