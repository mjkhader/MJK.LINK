using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientNutritionistController : ControllerBase
    {
        private readonly HealthDbContext _context;
        public PatientNutritionistController(HealthDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetPatientNutritionists")]
        public IEnumerable<PatientNutritionist> GetPatientNutritionists()
        {
            return _context.PatientNutritionists.ToList();
        }
    }
}
