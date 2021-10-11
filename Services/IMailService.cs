using HangFire.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFire.API.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
     
    }
}
