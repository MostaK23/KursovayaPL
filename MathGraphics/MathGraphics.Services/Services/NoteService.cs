using MathGraphics.Data.Abstract;
using MathGraphics.Data.Entities;
using MathGraphics.Services.Abstract;
using System.Collections.Generic;

namespace MathGraphics.Services.Services
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void Create(string text)
        {
            _noteRepository.Create(text);
        }

        public void Delete(int id)
        {
            _noteRepository.Delete(id);
        }

        public IEnumerable<NoteEntity> GetAll()
        {
            return _noteRepository.GetAll();
        }
    }
}
