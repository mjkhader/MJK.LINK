using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly HealthDbContext _healthDbContext;

        public PaymentsController(HealthDbContext healthDbContext)
        {
            _healthDbContext = healthDbContext;
        }
        [HttpGet("GetPayments")]
        public IActionResult Get()
        {
            return Ok(_healthDbContext.Payments.ToList());
        }
    }
}
