using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    internal interface BookRepository
    {
        void AddBooks(int count);
    }

    public class IBookRepository : BookRepository
    {
        private readonly Database _database;

        public IBookRepository(Database database)
        {
            _database = database;
        }

        public void AddBooks(int count)
        {
            _database.openConnection();
            try
            {
                for (int i = 0; i < count; i++)
                {
                    string title = $"Книга {i}";
                    string author = $"Автор {i}";
                    int year = 2000 + (i % 20);

                    string query = "INSERT INTO books (title, author, year) VALUES (@title, @author, @year)";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, _database.getConnection()))
                    {
                        command.Parameters.AddWithValue("title", title);
                        command.Parameters.AddWithValue("author", author);
                        command.Parameters.AddWithValue("year", year);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при добавлении книг: {ex.Message}");
            }
            finally
            {
                _database.closeConnection();
            }
        }
    }
}