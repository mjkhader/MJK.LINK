using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly HealthDbContext _context;

        public DiscountsController(HealthDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDiscounts()
        {
            var discounts = _context.DoctorRestaurantDiscounts.ToList();
            if (discounts == null || !discounts.Any())
            {
                return NotFound();
            }
            return Ok(discounts);
        }
    }
}
