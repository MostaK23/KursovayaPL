using MathGraphics.Data.Abstract;
using MathGraphics.Data.Entities;
using MathGraphics.Data.Resources;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MathGraphics.Data.Repositories
{
    public class JsonRepository : INoteRepository
    {
        private readonly string filePath;

        public JsonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public void Create(string text)
        {
            var notes = ReadFromFile();
            var note = new NoteEntity();

            note.Id = notes.NextId;
            note.Text = text;

            notes.NextId++;

            notes.Notes.Add(note);

            WriteToFile(notes);
        }

        public void Delete(int id)
        {

        }

        public IEnumerable<NoteEntity> GetAll()
        {
            return ReadFromFile().Notes;
        }

        private JsonNoteEntity ReadFromFile()
        {
            if (!File.Exists(filePath))
            {
                WriteToFile(null);
            }

            using (var reader = new StreamReader(filePath))
            {
                var notes = JsonConvert.DeserializeObject<JsonNoteEntity>(reader.ReadToEnd());

                if (notes == null)
                {
                    notes = new JsonNoteEntity();
                    notes.Notes = new List<NoteEntity>();
                    notes.NextId = ValueResources.InitialNoteId;
                }

                return notes;
            }
        }

        private void WriteToFile(JsonNoteEntity record)
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                writer.Write(JsonConvert.SerializeObject(record));
            }
        }
    }
}
