using MathGraphics.Data.Entities;
using System.Collections.Generic;

namespace MathGraphics.Data.Abstract
{
    public interface INoteRepository
    {
        void Create(string text);

        IEnumerable<NoteEntity> GetAll();

        void Delete(int id);
    }
}
