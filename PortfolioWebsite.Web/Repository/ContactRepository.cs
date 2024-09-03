using Dapper;
using Microsoft.Data.SqlClient; // Use this if you are using Microsoft.Data.SqlClient instead of System.Data.SqlClient
using PortfolioWebsite.Web.Models;
using System;
using System.Threading.Tasks;

namespace PortfolioWebsite.Web.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly string _connectionString;

        public ContactRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task InsertContactMessageAsync(ContactMessage contactMessage)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO ContactMessages (Name, Email, Message, SubmittedDate) VALUES (@Name, @Email, @Message, @SubmittedDate)";
                await connection.ExecuteAsync(query, new
                {
                    contactMessage.Name,
                    contactMessage.Email,
                    contactMessage.Message,
                    SubmittedDate = DateTime.Now
                });
            }
        }
    }
}
