using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Cshap_email
{
    class Mail
    {
        private MailMessage mailMessage = new MailMessage();
        private SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

        public void SendMessage(String from,String to,String subject,String body,String user,String password,bool isHtml = false)
        {
            mailMessage.From = new MailAddress(from);

            if (isHtml)
                mailMessage.IsBodyHtml = isHtml;

            mailMessage.To.Add(to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(user, password);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
