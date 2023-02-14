using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Application.DTOModel;
using VMS.Core.Domain.Models.VisitorForm;

namespace VMS.Core.Application.Interface
{
    public interface IVisitorForm
    {
        Task<List<Visitor>> GetAllVisitor();
        Task<bool> AddVisitor(VisitorFormDTO visitor);
        Task<bool> UpdateVisitor(Visitor visitor);
    }
}

