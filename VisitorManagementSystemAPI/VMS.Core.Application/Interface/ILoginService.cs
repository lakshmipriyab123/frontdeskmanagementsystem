using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Application.DTOModel;

namespace VMS.Core.Application.Interface
{
    public interface ILoginService
    {
        Task<bool> Login(LoginDTO login);
    }
}
