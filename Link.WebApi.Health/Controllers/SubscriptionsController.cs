using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionsController : ControllerBase
    {
        private readonly HealthDbContext _context;
        public SubscriptionsController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetSubscriptions")]
        public IActionResult Get()
        {
            var subscriptions = _context.Subscriptions.ToList();
            if (subscriptions == null || !subscriptions.Any())
            {
                return NotFound();
            }
            return Ok(subscriptions);
        }

        [HttpGet("GetSubscriptionDay")]
        public IActionResult GetSubscriptionDay()
        {
            var subscriptions = _context.SubscriptionDays.ToList();
            if (subscriptions == null || !subscriptions.Any())
            {
                return NotFound();
            }
            return Ok(subscriptions);
        }
        [HttpGet("GetSubscriptionDayMeal")]
        public IActionResult GetSubscriptionDayMeal()
        {
            var subscriptions = _context.SubscriptionDayMeals.ToList();
            if (subscriptions == null || !subscriptions.Any())
            {
                return NotFound();
            }
            return Ok(subscriptions);
        }


    }
}
