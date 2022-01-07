using MathGraphics.Data.Entities;
using System.Collections.Generic;

namespace MathGraphics.Services.Abstract
{
    public interface INoteService
    {
        void Create(string text);

        IEnumerable<NoteEntity> GetAll();

        void Delete(int id);
    }
}
