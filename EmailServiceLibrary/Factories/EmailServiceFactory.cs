using EmailServiceLibrary.Interfaces.FactoryInterfaces;
using EmailServiceLibrary.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Factories
{
    public class EmailServiceFactory : IEmailServiceFactory
    {
        public EmailService EmailService { get; }

        public EmailServiceFactory()
        {
            EmailService = new EmailService();
        }
    }
}
