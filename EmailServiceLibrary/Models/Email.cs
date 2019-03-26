using System;
using System.Collections.Generic;
using System.Text;

namespace EmailServiceLibrary.Models
{
    public class Email
    {
        public string ReceivingAddress { get; set; }
        public string SendingAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
