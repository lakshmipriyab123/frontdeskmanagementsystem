using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Domain.Models.VisitorForm;

namespace VMS.Infrastructure.VMS.Infrastructure.Repository.Interface
{
    public interface IVisitorDao
    {
        Task<List<Visitor>> GetAllVisitor();
        bool Update(Visitor visitor);
        void Create(Visitor visitor);
        bool Delete(int id);
        
        bool AdminLogin(string email, string password);
    }
}
