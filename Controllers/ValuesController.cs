using HangFire.API.BackgroundJobs;
using HangFire.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFire.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpPost]
        public IActionResult SendEmailToUser([FromBody]MailRequest mailRequest)
        {
            FireAndForgetJobs.EmailSendToUserJob(mailRequest);

            return NoContent();
        }

    }
}
