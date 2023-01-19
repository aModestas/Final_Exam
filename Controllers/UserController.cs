using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserrepository _userrepository;
        public UserController(IUserrepository userrepository)
        {
            _userrepository = userrepository;
        }
        [HttpGet]
        public List<User> GetUsers()
        {
            return _userrepository.GetAllUsers();
        }
        [HttpGet("username, password")]
        public ActionResult<User> UserLogin(string username, string password)
        {
            var login = _userrepository.GetLogin(username, password);
            return Ok(login);
            if (login == null)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public User Add([FromBody] UserDTO user)
        {
            return _userrepository.AddNewUser(user);
        }
    }
}
