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
    public class EmailService
    {
        public string SendEmail(Email email)
        {
            using (var msg = new MailMessage())
            {
                msg.To.Add(new MailAddress(email.ReceivingAddress, "To Name"));
                msg.From = new MailAddress(email.SendingAddress, "From Name" );
                msg.Subject = "Subject";
                msg.Body = "Body";
                msg.IsBodyHtml = true;

                using (var client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential("obasiservices@gmail.com", "Obsidian12!");
                    client.EnableSsl = true;
                    client.Send(msg);
                }
            }

            return "Sucessful!";
        }
    }
}
