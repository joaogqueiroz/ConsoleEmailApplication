using Projeto05.Entities;
using Projeto05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.Services
{
    public class MessageService : IMessageService
    {
        private string _account = "1212";
        private string _password = "";
        private string _smtp = "";
        private int _port = 0;

        public void SendEmail(Message message)
        {
            var mailMessage = new MailMessage(_account, message.Email);
            mailMessage.Subject = $"{message.Sender}, sends: {message.Subject}";
            mailMessage.Body = $"Olá, {message.Recipient} \n \n {message.Content}";

            var smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(_account, _password);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
