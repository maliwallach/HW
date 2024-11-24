using Microsoft.AspNetCore.Mvc;
using ex2.Models;
using ex2.Repositories;
using System.Data;
using ex2.Services;
[Route("api/[controller]")]
[ApiController]
public class AttachmentsController : ControllerBase
{
    private readonly IAttachmentsService _attachmentsService;
    public AttachmentsController(IAttachmentsService attachmentsService)
    {
        _attachmentsService = attachmentsService;
    }

    [HttpPost("create")]
    public IActionResult CreateAttachment([FromBody] Attachment a)
    {
        if (a == null || string.IsNullOrEmpty(a.Name) || string.IsNullOrEmpty(a.Path))
        {
            return BadRequest("All fields are required.");
        }

        DataTable result = _attachmentsService.CreateAttachment(a.Name, a.Path);
        return Ok(result);
    }


    [HttpPost]
    public IActionResult Create([FromBody] AttachmentWithTask model)
    {
        if (model == null || model.Attachment == null || model.Task == null)
        {
            return BadRequest("Attachment and Task are required.");
        }

        bool success = _attachmentsService.Create(model);
        if (success)
        {
            return Ok("Transaction completed successfully.");
        }
        return StatusCode(500, "Failed to process transaction.");
    }



}