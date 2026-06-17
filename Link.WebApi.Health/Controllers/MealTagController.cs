using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealTagController : ControllerBase
    {
        private readonly HealthDbContext _context;

        public MealTagController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetMealTagById")]
        public IActionResult GetMealTagById(int mealId, int tagId)
        {
            var mealTag = _context.MealTags.Find(mealId, tagId);
            if (mealTag == null)
            {
                return NotFound();
            }
            return Ok(mealTag);
        }

        [HttpGet("GetAllTags")]
        public IActionResult GetAllTag()
        {
            var mealTags = _context.Tags.ToList();
            if (mealTags == null || mealTags.Count == 0)
            {
                return NotFound();
            }
            return Ok(mealTags);
        }

    }

}
