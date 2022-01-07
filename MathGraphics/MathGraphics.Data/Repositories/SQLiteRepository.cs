using MathGraphics.Data.Abstract;
using MathGraphics.Data.Entities;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGraphics.Data.Repositories
{
    public class SQLiteRepository : INoteRepository
    {
        private readonly string connectionString;

        public SQLiteRepository(string connectionString)
        {
            this.connectionString = connectionString;

            if (!File.Exists(Config.DatabaseNameSQLite))
            {
                SQLiteConnection.CreateFile(Config.DatabaseNameSQLite);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string commandText = "CREATE TABLE IF NOT EXISTS [note] ([Id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, [Data] NVARCHAR(255))";
                    var command = new SQLiteCommand(commandText, connection);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Create(string text)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = "INSERT INTO [note] ([Data]) VALUES (@data)";
                var command = new SQLiteCommand(commandText, connection);
                command.Parameters.AddWithValue("@data", text);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = "DELETE FROM [note] WHERE Id=@id";
                var command = new SQLiteCommand(commandText, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<NoteEntity> GetAll()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = "SELECT * FROM [note]";
                var command = new SQLiteCommand(commandText, connection);

                using (var reader = command.ExecuteReader())
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

                    return new List<NoteEntity>();
                }
            }
        }
    }
}
