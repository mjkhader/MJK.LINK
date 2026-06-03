using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly HealthDbContext _context;

        public MealsController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Meal> GetMeals()
        {
            return _context.Meals.ToList();
        }

    }
}
