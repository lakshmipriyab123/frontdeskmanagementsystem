using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Application.DTOModel;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.VisitorForm;
using VMS.Infrastructure.VMS.Infrastructure.Repository.Interface;

namespace VMS.Infrastructure.VMS.Infrastructure.Services.VisitorComponent
{
    public class VisitorForm : IVisitorForm
    {

        public readonly IVisitorDao _visitorDao;
        public VisitorForm(IVisitorDao visitorDao)
        {
            _visitorDao = visitorDao;
        }

        public async Task<List<Visitor>> GetAllVisitor()
        {
            return await _visitorDao.GetAllVisitor();
        }

        public async Task<bool> AddVisitor(VisitorFormDTO visitor)
        {
            bool value = false;
            Visitor values = new Visitor();
            if (visitor != null)
            {
                values.RoleId = 1;
                values.VisitorName = visitor.VisitorName;
                values.Email = visitor.Email;
                values.MobileNumber = visitor.MobileNumber;
                values.VisitType = visitor.VisitType;
                values.WhomToMeet = visitor.WhomToMeet;
                values.CheckInTime = DateTime.UtcNow; ;
                values.CheckOutTime = DateTime.UtcNow;
                values.SecurityInCharge = visitor.SecurityInCharge;
                values.VisitorId = visitor.VisitorId;
                values.createdBy = values.RoleId == 1 ? visitor.VisitorName : visitor.SecurityInCharge;
                values.createdOn = DateTime.UtcNow;
                values.modifiedBy = visitor.SecurityInCharge;
                values.modifiedOn = DateTime.UtcNow;
                _visitorDao.Create(values);
                value = true;
            }
            return value;
        }

        public async Task<bool> UpdateVisitor(Visitor visitor)
        {
            bool value = false;
            if (visitor != null)
            {
                var data = _visitorDao.GetAllVisitor().Result.Where(x => x.UserId == visitor.UserId).FirstOrDefault();
                Visitor result = new Visitor();
                if (data != null)
                {
                    result.VisitorName = data.VisitorName;
                    result.Email = data.Email;
                    result.MobileNumber = data.MobileNumber;
                    result.VisitType = data.VisitType;
                    result.WhomToMeet = data.WhomToMeet;
                    result.VisitorId = data.VisitorId;
                    _visitorDao.Update(result);
                    value = true;
                }
            }
            return value;
        }



    }
}

