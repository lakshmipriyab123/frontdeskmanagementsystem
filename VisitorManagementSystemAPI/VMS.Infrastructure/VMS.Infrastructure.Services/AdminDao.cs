using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Infrastructure.VMS.Infrastructure.Repository;
using VMS.Infrastructure.VMS.Infrastructure.Repository.Interface;

namespace VMS.Infrastructure.VMS.Infrastructure.Services
{
    public class AdminDao : IAdminDao
    {
        private readonly CatalogDBContext _dbContext;
        public AdminDao(CatalogDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AdminLogin(string email, string password)
        {
            var login = _dbContext.Login.ToList();
            return (login.Where(users => users.Email == email && users.Password == password).FirstOrDefault()) == null ? false : true;
        }
    }
}
