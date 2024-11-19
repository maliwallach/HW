using Microsoft.AspNetCore.Mvc;
using users.Services;
using System.Data;
using users.Models;

namespace users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttachmentsController : ControllerBase
    {
        private readonly IAttachmentsService _attachmentsService;
        public AttachmentsController(IAttachmentsService attachmentsService)
        {
            _attachmentsService = attachmentsService;
        }

        [HttpPost]
        public IActionResult CreateAttachment([FromBody] Attachment a)
        {
            if (a == null || string.IsNullOrEmpty(a.Name) || string.IsNullOrEmpty(a.Path) || string.IsNullOrEmpty(a.DateUplode))
            {
                return BadRequest("All fields are required.");
            }

            DataTable result = _attachmentsService.CreateAttachment(a.Name, a.Path, a.DateUplode);
            return Ok(result); 
        }
    }
}

