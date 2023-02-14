using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Domain.Models.EmailService;

namespace VMS.Core.Application.Interface
{
    public interface IMailService
    {
        Task SendEmailAsync(Email email);
    }
}
