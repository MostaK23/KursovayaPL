using System.IO;
using System;

namespace MathGraphics
{
    public class Config
    {
        private static readonly string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string databasePath = Path.GetFullPath(Path.Combine(currentDirectory, "..\\..\\"));

        public static string DatabaseNameMDF = "NotesDB.mdf";
        public static string DatabaseFullPath = Path.Combine(databasePath, DatabaseNameMDF);

        public const string DatabaseNameSQLite = "notesdata.db";
        public static string SQLiteConnectionString = $"Data Source={DatabaseNameSQLite}";

        public const string DatabaseNameJson = "notesdata.json";

        public static readonly string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            $"AttachDbFilename={DatabaseFullPath};" +
            "Integrated Security=True";
    }
}
