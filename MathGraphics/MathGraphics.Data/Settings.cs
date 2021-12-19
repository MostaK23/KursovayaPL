using System.IO;
using System;

namespace MathGraphics
{
    public class Config
    {
        private static readonly string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string databasePath = Path.GetFullPath(Path.Combine(currentDirectory, "..\\..\\"));

        public static string DatabaseName = "NotesDB.mdf";
        public static string DatabaseFullPath = Path.Combine(databasePath, DatabaseName);

        public static readonly string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            $"AttachDbFilename={DatabaseFullPath};" +
            "Integrated Security=True";
    }
}
