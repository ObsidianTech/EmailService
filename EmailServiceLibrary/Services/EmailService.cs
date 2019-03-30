using EmailServiceLibrary.Interfaces;
using EmailServiceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace EmailServiceLibrary.Services
{
    public class EmailService : IEmailService
    {
        public IConfiguration configuration { get; set; }

        public EmailService(IConfiguration config)
        {
            configuration = config;
        }

        //public string SendEmail(Email email)
        //{
        //    using (var msg = new MailMessage())
        //    {
        //        msg.To.Add(new MailAddress(email.ReceivingAddress, "To Name"));
        //        msg.From = new MailAddress(configuration["ClientEmail"], "From Name" );
        //        msg.Subject = email.Subject;
        //        msg.Body = email.Body;
        //        msg.IsBodyHtml = true;

        //        using (var client = new SmtpClient("smtp.gmail.com"))
        //        {
        //            client.Port = 587;
        //            client.Credentials = new NetworkCredential("obasiservices@gmail.com", "Obsidian12!");
        //            client.EnableSsl = true;
        //            client.Send(msg);
        //        }
        //    }

        //    return "Sucessful!";
        //}

        public string SendEmail(string emailAddress)
        {
            using (var msg = new MailMessage())
            {
                msg.To.Add(new MailAddress(configuration["Receiver"], "To Name"));
                msg.Bcc.Add(new MailAddress(configuration["ClientEmail"], "To Name"));
                msg.From = new MailAddress(configuration["ClientEmail"], "Obasi Emailing Services");
                msg.Subject = "New user submission!";
                msg.Body = "A visitor to your page submitted their information: " + emailAddress;
                msg.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("obasiservices@gmail.com", "Obsidian12!");
                    client.EnableSsl = true;
                    client.Send(msg);
                }
            }

            return "Thank you for submitting. We will reach out to you shortly.";
        }
    }
}
