using Link.DataAccess.Core.Base;
using Link.DataAccess.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Link.WebApi.Health.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IBaseRepository<Restaurant> _userRepository;

        public RestaurantController(IBaseRepository<Restaurant> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetRestaurantById")]
        public IActionResult GetRestaurantById(int id)
        {
            var restaurant = _userRepository.GetById(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return Ok(restaurant);
        }
    }
}
