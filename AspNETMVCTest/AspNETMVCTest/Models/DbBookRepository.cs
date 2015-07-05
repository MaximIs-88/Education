using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AspNETMVCTest.Models
{
    public class DbBookRepository: IBookRepository
    {
        private readonly List<BookDetails> _book = new List<BookDetails>();

        private readonly ConnectionStringSettings _connectionStringSettings =
            ConfigurationManager.ConnectionStrings["DefaultConnection"];

        public List<BookDetails> Books
        {
            get
            {
                using (var con = new SqlConnection(_connectionStringSettings.ToString()))
                {
                    con.Open();
                    using (var command = new SqlCommand("SELECT * FROM BookDetails", con))
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var bookDetails = new BookDetails
                                {
                                    Id = reader.GetInt32(0),
                                    Title = reader.GetString(1),
                                    Author = reader.GetString(2)
                                };
                                _book.Add(bookDetails);
                            }
                        }
                }
                return _book;
            }
        }

        public void Add(BookDetails newBook)
        {
            var query = string.Format(@"INSERT INTO BookDetails (Title, Author) VALUES ('{0}','{1}')", newBook.Title, newBook.Author);
            using (var con = new SqlConnection(_connectionStringSettings.ToString()))
            {
                con.Open();
                using (var command = new SqlCommand(query, con))
                    command.ExecuteNonQuery();
                    
            }
        }
    }
}