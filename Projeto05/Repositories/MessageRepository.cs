using Dapper;
using Projeto05.Entities;
using Projeto05.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.Repositories
{
    class MessageRepository : IMessageRepository
    {
        private string _connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projeto05;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Insert(Message message)
        {
            var query = @"
            INSERT INTO MESSAGE
                (
                    MESSAGEID,
                    SENDER,
                    RECIPIENT,
                    EMAIL,
                    SUBJECT,
                    CONTENT,
                    DATE
                )
            VALUES
            (
            NEWID(),
            @Sender,
            @Recipient,
            @Subject,
            @Content,
            @Date
            )
        ";
            using (var connection = new SqlConnection(_connectionstring)) 
            {
                connection.Execute(query, message);
            }
        }
    }
}
