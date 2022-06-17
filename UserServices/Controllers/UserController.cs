using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using UserServices.POCO.Models;
using UserServices.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository<User> _userRepo;
        public UserController(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }

        /// <summary>
        /// Returns the list of the users information.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var userList = _userRepo.GetAll();
            return new OkObjectResult(userList.ToList());
        }

        /// <summary>
        /// Returns user based on user id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public IActionResult Get([FromRoute]int userId)
        {
            var user = _userRepo.Find(userId);
            if (user == null)
            {
                return new NotFoundResult();
            }
            else
            {
                return new OkObjectResult(user);
            }
        }

        /// <summary>
        /// Insert new users information.
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] User userInfo)
        {
            _userRepo.Add(userInfo);
            return new NoContentResult();
        }

        /// <summary>
        /// Remove user based on user id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{userId}")]
        public IActionResult Delete([FromRoute]int userId)
        {
            var user = _userRepo.Find(userId);
            if (user == null)
            {
                return new NotFoundResult();
            }
            else
            {
                _userRepo.Remove(userId);
                return Ok();
            }
        }
    }
}
