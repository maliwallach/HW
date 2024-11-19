using Microsoft.AspNetCore.Mvc;
using users.Services;

namespace users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController: ControllerBase
    {
        private readonly IProjectServices _projectServices;
        private readonly ITasksServices _tasksServices;
        public ProjectsController(IProjectServices projectServices, ITasksServices tasksServices)
        {
            _projectServices = projectServices;
            _tasksServices = tasksServices;
        }
        [HttpPost("{id}")]
        public IActionResult Create(Models.Task task, int id)
        {
            var project = _projectServices.GetprojectById(id);

            if (project == null)
            {
                return NotFound("project not found");
            }
            // הוספת המשתמש למסד הנתונים
            _tasksServices.AddTask(task);
            project.TaskId = task.Id;
            _projectServices.UpdateProject(project);

            return Ok(project);
        }
    }
}
