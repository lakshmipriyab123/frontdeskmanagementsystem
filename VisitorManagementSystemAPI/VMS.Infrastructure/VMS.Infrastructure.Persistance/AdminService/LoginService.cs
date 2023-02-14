using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Application.DTOModel;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.Admin;
using VMS.Infrastructure.VMS.Infrastructure.Repository.Interface;

namespace VMS.Infrastructure.VMS.Infrastructure.Services.AdminService
{
  public class LoginService : ILoginService
    {
        private readonly IAdminDao _adminDao;
        
        public LoginService(IAdminDao adminDao)
        {
            _adminDao = adminDao;
        }

        public async Task<bool> Login(LoginDTO login)
        {
            var result = await _adminDao.AdminLogin(login.Email, login.Password);
            return result;
        }
    }
}
