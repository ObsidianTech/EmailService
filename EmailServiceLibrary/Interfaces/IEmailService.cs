using EmailServiceLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Interfaces
{
    public interface IEmailService
    {
        IConfiguration configuration { get; set; }

        string SendEmail(Email email);
    }
}
