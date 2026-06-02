using Link.DataAccess.Core.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess.DBContext;
using Link.DataAccess.Core.UnitOfWork;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public UsersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            var user = unitOfWork.Users.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllUser()
        {
            var user = unitOfWork.Users.GetAll();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
