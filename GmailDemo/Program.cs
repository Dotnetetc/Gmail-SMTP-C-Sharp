using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace GmailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GEmail gmail = new GEmail();
            Console.WriteLine("Enter Sender Email");
            gmail.SenderEmail = new MailAddress(Console.ReadLine());
            Console.WriteLine("Enter Recipient Email");
            gmail.RecipientEmail = new MailAddress(Console.ReadLine());
            Console.WriteLine("Enter Subject");
            gmail.Subject = Console.ReadLine();
            Console.WriteLine("Enter email message");
            gmail.Message = Console.ReadLine();
            Console.WriteLine("Enter gmail id");
            gmail.GmailId = Console.ReadLine();
            Console.WriteLine("Enter password");
            gmail.GmailPwd = Console.ReadLine();

            try
            {
                GEmail.SendMessage(gmail);
                Console.WriteLine("Mail send");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured "+ex.Message);
                Console.ReadLine();
            }
           

        }
    }

  
}
