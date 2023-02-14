using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Domain.Models.VisitorForm;
using VMS.Infrastructure.VMS.Infrastructure.Repository;
using VMS.Infrastructure.VMS.Infrastructure.Repository.Interface;

namespace VMS.Infrastructure.VMS.Infrastructure.Services
{
    public class VisitorDao : IVisitorDao
    {
        private readonly CatalogDBContext _dbContext;
        public VisitorDao(CatalogDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool AdminLogin(string email, string password)
        {
            var login = _dbContext.Login.ToList();
            return (login.Where(users => users.Email == email && users.Password == password).FirstOrDefault()) == null ? false : true;
        }


        public bool Delete(int id)
        {
            var result = _dbContext.Visitor.ToListAsync().Result;
            _dbContext.Remove(result.Where(c => c.UserId.Equals(id)).FirstOrDefault());
            _dbContext.SaveChangesAsync();
            return true;
        }

        public Task<List<Visitor>> GetAllVisitor()
        {
            return _dbContext.Visitor.ToListAsync();
        }


        public bool Update(Visitor visitor)
        {
            _dbContext.Update(visitor);
            _dbContext.SaveChanges();
            return true;
        }

        public void Create(Visitor customers)
        {
            _dbContext.Add(customers);
            _dbContext.SaveChanges();

        }
    }
}
