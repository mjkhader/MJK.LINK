using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly HealthDbContext _context;
        public DeliveryController(HealthDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetDeliveries")]
        public IActionResult GetDeliveries()
        {
            var deliveries = _context.Deliveries.ToList();
            if (deliveries == null || !deliveries.Any())
            {
                return NotFound();
            }
            return Ok(deliveries);
        }

        [HttpGet("GetDriver")]
        public IActionResult GetDriver(int id)
        {
            var driver = _context.Drivers.Find(id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }

        [HttpGet("GetDriverLocation")]
        public IActionResult GetDriverLocation(int id)
        {
            var driver = _context.DriverLocations.Find(id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }
    }
}
