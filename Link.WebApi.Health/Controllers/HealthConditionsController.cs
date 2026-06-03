using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthConditionsController : ControllerBase
    {
        private readonly HealthDbContext _context;
        public HealthConditionsController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetHealthConditions")]
        public IEnumerable<Condition> GetHealthConditions()
        {
            return _context.Conditions.ToList();
        }

        [HttpGet("GetUserHealthConditions")]
        public IEnumerable<UserCondition> GetUserHealthConditions()
        {
            return _context.UserConditions.ToList();
        }
    }
}
