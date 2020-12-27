using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.IServices
{
    public interface IMailService
    {
        Task SendMailAsync(string toEmail, string ccEmail, string subject, string content);
    }
}
