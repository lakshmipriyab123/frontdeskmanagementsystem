using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.EmailService;

namespace VMS.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentEmailController : ControllerBase
    {
        private readonly IMailService mailService;
        public SentEmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail(Email email)
        {
            try
            {
                await mailService.SendEmailAsync(email);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
