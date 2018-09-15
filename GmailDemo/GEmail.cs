using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace GmailDemo
{
    public class GEmail
    {
        public MailAddress SenderEmail { get; set; }
        public MailAddress RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string GmailId { get; set; }
        public string GmailPwd { get; set; }

        public static void SendMessage(GEmail gm)
        {
            MailMessage gmail = new MailMessage(gm.SenderEmail, gm.RecipientEmail);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(gm.GmailId, gm.GmailPwd);

            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            gmail.Subject = gm.Subject;
            gmail.Body = gm.Message;
            client.Send(gmail);
        }
    }
}
