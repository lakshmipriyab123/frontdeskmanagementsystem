using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VMS.Core.Application.DTOModel;
using VMS.Core.Application.Interface;

namespace VMS.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService= loginService;
        }
        [HttpPost("adminLogin")]
        public async Task<IActionResult> AdminLogin(LoginDTO login)
        {
            try
            {
                var result = _loginService.Login(login);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
