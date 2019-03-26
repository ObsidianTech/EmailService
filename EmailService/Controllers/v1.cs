using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmailServiceLibrary.Services;
using EmailServiceLibrary.Models;
using Microsoft.Extensions.Configuration;
using EmailServiceLibrary.Interfaces;

namespace EmailMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class v1 : ControllerBase
    {
        public IEmailService es { get; set; }

        public v1(IEmailService emailService)
        {
            es = emailService;
        }

        [Route("email")]
        // POST api/values
        [HttpPost]
        public string Post([FromBody] Email email)
        {
            return es.SendEmail(email);
        }
    }
}
