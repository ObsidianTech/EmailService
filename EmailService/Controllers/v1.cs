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

        [Route("email/{emailAddress}")]
        [HttpGet]
        public string Post(string emailAddress)
        {
            return es.SendEmail(emailAddress);
        }
    }
}
