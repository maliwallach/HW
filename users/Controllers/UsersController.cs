using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using users.Models;
using users.Services;

namespace users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersServices _usersServices;
        public UsersController(IUsersServices userService)
        {
            _usersServices = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _usersServices.GetUsers();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _usersServices.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            // בדיקת תקינות השדות
            if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                return BadRequest("FirstName and LastName are required.");
            }

            // הוספת המשתמש למסד הנתונים
            _usersServices.AddUser(user);

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }
        //[HttpPost]
        //public IActionResult Create(User user)
        //{
        //    _usersServices.AddUser(user);
        //    return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        //}

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _usersServices.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usersServices.DeleteUser(id);
            return NoContent();
        }
        [HttpGet("{id}/tasks")]
        public IActionResult GetTasksByUserId(int id)
        {
            var tasks = _usersServices.GetTasksByUserId(id);
            if (tasks == null || tasks.Count == 0)
            {
                return NotFound();
            }
            return Ok(tasks);
        }



    }
}
