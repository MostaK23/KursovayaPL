using System.Collections.Generic;

namespace MathGraphics.Data.Entities
{
    public class JsonNoteEntity
    {
        public int NextId { get; set; }

        public List<NoteEntity> Notes { get; set; }
    }
}
