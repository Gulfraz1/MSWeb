using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.AppEmail
{
    public class AppEmailService : IEmailService
    {
        public void Send(string to,List<string> attachments)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("gulfraz.ahmed088@gmail.com", "pakistan123!")
            };
            using (var message = new MailMessage())
            {
                message.From = new MailAddress("gulfraz.ahmed088@gmail.com");
                message.Subject = "Criminals Record";
                message.Body = "Hi, <br /><br />Below are the attached pdf reports for your criminal search request.<br /><br />Please find attachments.<br /><br />Thanks ";
                message.IsBodyHtml = true;
                message.To.Add(to);
                foreach (var pdfReport in attachments)
                {
                    var attachment = new Attachment(pdfReport, MediaTypeNames.Application.Octet);
                    var disposition = attachment.ContentDisposition;
                    disposition.FileName =Path.GetFileName(pdfReport);
                    disposition.DispositionType = DispositionTypeNames.Attachment;
                    message.Attachments.Add(attachment);
                }

                try
                {
                    smtpClient.Send(message);
                }
                catch (Exception exception)
                {
                    // Log
                }
            }
        }
    }
}
