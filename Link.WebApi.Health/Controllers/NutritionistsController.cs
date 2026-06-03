using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionistsController : ControllerBase
    {
        private readonly HealthDbContext _context;
        public NutritionistsController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetNutritionists")]
        public IEnumerable<Nutritionist> GetNutritionists()
        {
            return _context.Nutritionists.ToList();
        }
    }
}
