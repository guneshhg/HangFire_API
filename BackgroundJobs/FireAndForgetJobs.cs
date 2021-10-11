using HangFire.API.Models;
using HangFire.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFire.API.BackgroundJobs
{
    public class FireAndForgetJobs
    {

        public static void EmailSendToUserJob(MailRequest mailRequest)
        {
            Hangfire.BackgroundJob.Enqueue<IMailService>(x => x.SendEmailAsync(mailRequest));
        }

    }
}
