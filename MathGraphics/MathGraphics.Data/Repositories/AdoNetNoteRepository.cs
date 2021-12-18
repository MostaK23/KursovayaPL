using MathGraphics.Data.Abstract;
using MathGraphics.Data.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MathGraphics.Data.Repositories
{
    public class AdoNetNoteRepository : INoteRepository
    {
        private string connectionString;

        public AdoNetNoteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(string text)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlExpression = "INSERT INTO [Table] (Text) VALUES (@text)";

                var sqlCommand = new SqlCommand(sqlExpression, connection);

                sqlCommand.Parameters.AddWithValue("@text", text);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlExpression = "DELETE [Table] WHERE Id = @id";

                var sqlCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = sqlExpression,
                    CommandType = System.Data.CommandType.Text,
                };

                SqlParameter idParameter = new SqlParameter()
                {
                    Value = id,
                    ParameterName = "id",
                };

                sqlCommand.Parameters.Add(idParameter);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public IEnumerable<NoteEntity> GetAll()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlExpression = "SELECT * FROM [Table]";

                var sqlCommand = new SqlCommand
                {
                    Connection = connection,
                    CommandText = sqlExpression,
                    CommandType = System.Data.CommandType.Text,
                };

                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        var notes = new List<NoteEntity>();

                        while (reader.Read())
                        {
                            notes.Add(new NoteEntity()
                            {
                                Id = reader.GetInt32(0),
                                Text = reader.GetString(1),
                            });
                        }

                        return notes;
                    }

                    return null;
                }
            }
        }
    }
}
