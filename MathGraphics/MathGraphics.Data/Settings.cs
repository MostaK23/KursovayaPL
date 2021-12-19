using System.IO;
using System;

namespace MathGraphics
{
    public class Config
    {
        private static string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static string databasePath = Path.GetFullPath(Path.Combine(currentDirectory, "..\\..\\"));
        public static string DataBaseName = "NotesDB.mdf";

        public static readonly string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
            $"AttachDbFilename={databasePath}{DataBaseName};" +
            "Integrated Security=True";
    }
}
