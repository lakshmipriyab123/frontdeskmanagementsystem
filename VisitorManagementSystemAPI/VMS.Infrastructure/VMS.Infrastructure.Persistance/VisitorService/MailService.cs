using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Core.Application.Interface;
using VMS.Core.Domain.Models.EmailService;
using System.Net;
using System.Net.Mail;
using Org.BouncyCastle.Utilities.Net;
using System.Xml.Linq;

namespace VMS.Infrastructure.VMS.Infrastructure.Services.VisitorService
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendEmailAsync(Email email)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                var basicCredential = new NetworkCredential(_mailSettings.mail, _mailSettings.password);
                MailMessage mail = new MailMessage();
                mail.To.Add(email.toEmail);
                mail.From = new MailAddress(_mailSettings.mail);
                mail.Subject = email.subject;
                mail.Body = email.body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(_mailSettings.host, _mailSettings.port);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_mailSettings.mail, _mailSettings.password);
                smtp.Send(mail);
            }
        }
    }
}

