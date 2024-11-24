using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ex2.Services;
using ex2.Models;

namespace ex2.Controlers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksServices _taskService;

        public TasksController(ITasksServices taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] Tasks task)
        {
            try
            {
            _taskService.Add(task);
            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);

            }
            catch(Exception ex)
            {
                return BadRequest(new { Message = ex.Message });  // מחזירים תגובת שגיאה עם ההודעה הרלוונטית

            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var task = _taskService.Get();
            return Ok(task);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Tasks task)
        {
            if (id != task.Id)
            {
                return BadRequest();
            }

            _taskService.Update(task);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _taskService.Delete(id);
            return NoContent();
        }

        [HttpGet("{name}")]
        public ActionResult <List<Tasks>> getByUserName(string Name)
        {
            var tasks = _taskService.getByUserName(Name);
            if (tasks == null || tasks.Count == 0)
            {
                return NotFound("No tasks found for the specified user.");
            }
            return Ok(tasks);
        }
    }
}
