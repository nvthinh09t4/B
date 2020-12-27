using ASPNetCore3.IServices;
using ASPNetCore3.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ASPNetCore3.ServiceImpl
{
    public class MailService : IEmailSender
    {
        private MailConfigModel _mailConfig;

        public MailService(IOptions<MailConfigModel> mailConfig)
        {
            _mailConfig = mailConfig.Value;
        }

        public async Task SendMailAsync(string toEmail, string ccEmail, string subject, string content)
        {
            await Execute(toEmail, ccEmail, subject, content);
        }

        public async Task Execute(string toEmail, string ccEmail, string subject, string message)
        {
            try
            {
                MailMessage mail = new MailMessage() {
                    From = new MailAddress(_mailConfig.Email, _mailConfig.FromName),
                };
                mail.To.Add(new MailAddress(toEmail));
                if (!string.IsNullOrEmpty(ccEmail))
                    mail.CC.Add(new MailAddress(ccEmail));

                mail.Subject = "From reading.nvthinh - " + subject;
                mail.Body = message;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(_mailConfig.Domain, _mailConfig.Port))
                {
                    smtp.Credentials = new NetworkCredential(_mailConfig.Email, _mailConfig.Password);
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(mail);
                }
            }
            catch (Exception ex)
            {
                //do something here
            }
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            await Execute(email, "", subject, htmlMessage);
        }
    }
}
