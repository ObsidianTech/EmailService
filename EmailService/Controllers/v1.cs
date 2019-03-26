using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmailServiceLibrary.Services;
using EmailServiceLibrary.Interfaces.FactoryInterfaces;
using EmailServiceLibrary.Models;
using Microsoft.Extensions.Configuration;

namespace EmailMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class v1 : ControllerBase
    {
        public EmailService es { get; set; }
        public IConfiguration _config { get; set; }

        public v1(IEmailServiceFactory emailServiceFactory, IConfiguration config)
        {
            es = emailServiceFactory.EmailService;
            _config = config;
        }

        [Route("email")]
        // POST api/values
        [HttpPost]
        public string Post([FromBody] Email email)
        {
            email.SendingAddress = _config["ClientEmail"];
            return es.SendEmail(email);
        }
    }
}
