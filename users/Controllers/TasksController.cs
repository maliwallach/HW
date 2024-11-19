using Microsoft.AspNetCore.Mvc;
using users.Models;
using users.Services;
namespace users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController: ControllerBase
    {
        private readonly ITasksServices _tasksServices;

        private readonly IUsersServices _usersServices;
        public TasksController(ITasksServices taskService, IUsersServices usersServices)
        {
            _tasksServices = taskService;
            _usersServices = usersServices;
        }
        
        [HttpPost("{id}")]
        public IActionResult Create(Models.Task task,int id)
        {
           var user= _usersServices.GetUserById(id);

            if (user == null)
            {
                return NotFound("User not found");
            }
            // הוספת המשתמש למסד הנתונים
            _tasksServices.AddTask(task);
            user.TaskId=task.Id;
            _usersServices.UpdateUser(user);

            return Ok(user);
        }
    }
}
