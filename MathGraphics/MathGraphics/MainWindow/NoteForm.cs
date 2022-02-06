using MathGraphics.Data.Entities;
using MathGraphics.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MathGraphics
{
    public partial class FrmNote : Form
    {
        private readonly INoteService _noteService;

        public FrmNote(INoteService noteService)
        {
            InitializeComponent();

            _noteService = noteService;
        }

        private void frmTheory_Load(object sender, EventArgs e)
        {
            FillOutputBox(_noteService.GetAll());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add(InputBox.Text);

            InputBox.Clear();

            FillOutputBox(_noteService.GetAll());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();

            FillOutputBox(_noteService.GetAll());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete(int.Parse(DeleteIdInput.Text));

            FillOutputBox(_noteService.GetAll());
        }

        private void FillOutputBox(IEnumerable<NoteEntity> notes)
        {
            OutputBox.Clear();

            if (notes != null)
            {
                foreach (var note in notes)
                {
                    OutputBox.Text += note.Id + "." + note.Text.Trim() + Environment.NewLine;
                }
            }
            else
            {
                OutputBox.Text = "No notes";
            }
        }

        private void Add(string text)
        {
            _noteService.Create(text);
        }

        private void Delete(int id)
        {
            _noteService.Delete(id);
        }

        private void DisableLetters(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
