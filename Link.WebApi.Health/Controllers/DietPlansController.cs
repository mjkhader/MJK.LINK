using Link.DataAccess.DBContext;
using Link.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietPlansController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HealthDbContext _context;

        public DietPlansController(IUnitOfWork unitOfWork, HealthDbContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<DietPlan> GetDietPlans()
        {
            return _context.DietPlans.ToList();
        }

    }
}
