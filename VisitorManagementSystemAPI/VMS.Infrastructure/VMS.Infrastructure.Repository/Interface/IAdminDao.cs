using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Infrastructure.VMS.Infrastructure.Repository.Interface
{
    public interface IAdminDao
    {
        Task<bool> AdminLogin(string email, string password);
    }
}
