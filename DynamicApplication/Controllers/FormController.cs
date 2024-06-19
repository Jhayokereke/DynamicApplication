using DynamicApplication.BL;
using DynamicApplication.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DynamicApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpPost("/create-new")]
        public IActionResult CreateTemplate([FromBody] CreateFormFieldsDTO model)
        {
            var response = _formService.CreateFormTemplate(model);
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("/get-template")]
        public IActionResult GetTemplate([FromQuery] Guid templateId)
        {
            var response = _formService.GetFormTemplate(templateId);
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("/edit-template")]
        public IActionResult EditTemplate([FromBody] EditFormFieldsDTO model)
        {
            var response = _formService.EditFormTemplate(model);
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("/submit-form")]
        public IActionResult SubmitForm([FromBody] FormResponseDTO model)
        {
            var response = _formService.SubmitForm(model);
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }
    }
}
