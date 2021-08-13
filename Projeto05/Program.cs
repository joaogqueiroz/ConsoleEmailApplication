using Projeto05.Entities;
using Projeto05.Repositories;
using Projeto05.Services;
using System;

namespace Projeto05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                var message = new Message();
                message.MessageID = Guid.NewGuid();
                Console.WriteLine("Sender name: ");
                message.Sender = Console.ReadLine();
                Console.WriteLine("Sender Recipient: ");
                message.Recipient = Console.ReadLine();
                Console.WriteLine("Sender email: ");
                message.Email = Console.ReadLine();
                Console.WriteLine("Subject: ");
                message.Subject = Console.ReadLine();
                Console.WriteLine("Content: ");
                message.Content = Console.ReadLine();
                Console.WriteLine("Date: ");
                message.Date = DateTime.Now;

                var messageService = new MessageService();
                var messageRepository = new MessageRepository();

                messageService.SendEmail(message);
                messageRepository.Insert(message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
