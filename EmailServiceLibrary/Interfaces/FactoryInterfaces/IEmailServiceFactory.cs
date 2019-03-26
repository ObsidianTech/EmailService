using EmailServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Interfaces.FactoryInterfaces
{
    public interface IEmailServiceFactory
    {
        EmailService EmailService { get;}
    }
}
