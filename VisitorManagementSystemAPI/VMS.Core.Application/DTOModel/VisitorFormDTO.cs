using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Core.Application.DTOModel
{
   public class VisitorFormDTO
    {
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string VisitorName { get; set; }
        public string VisitType { get; set; }
        public string WhomToMeet { get; set; }
        public string VisitorId { get; set; }
        public string SecurityInCharge { get; set; }
    }
}
