using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VMS.Core.Application.DTOModel;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.VisitorForm;

namespace VMS.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        private readonly IVisitorForm _visitor;
        public VisitorsController(IVisitorForm visitorBL)
        {
            _visitor = visitorBL;
        }

        [HttpGet("GetAllVistors")]
        public async Task<IActionResult> GetAllVistors()
        {
            try
            {
                var list = await _visitor.GetAllVisitor();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddVisitor")]
        public async Task<IActionResult> AddVisitor(VisitorFormDTO visitor)
        {
            try
            {
                await _visitor.AddVisitor(visitor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

    
