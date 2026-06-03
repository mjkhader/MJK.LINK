using Link.DataAccess.Core.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Link.DataAccess.UnitOfWork;
using Link.DataAccess.Repository;
using Link.DataAccess.DBContext;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly HealthDbContext _context;

        public UsersController(IUnitOfWork unitOfWork, IUserRepository userRepository, HealthDbContext context)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            IUserRepository userRepository = new UserRepository(_context);
            var user = _unitOfWork.Users.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllUser()
        {
            var user = _unitOfWork.Users.GetAll();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
