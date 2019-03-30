using EmailServiceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Models
{
    public class Email : IEmail
    {
        public string emailAddress { get; set; }
    }
}
