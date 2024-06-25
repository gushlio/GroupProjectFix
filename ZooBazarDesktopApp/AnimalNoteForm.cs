using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class AnimalNoteForm : Form
    {
        Employee loggedEmployee;
        List<Note> notes = new List<Note>();
        Animal animal;
        int noteCount = 1;
        List<string> noteTitles;
        public AnimalNoteForm(Employee loggedUser, Animal a)
        {
            noteTitles = new List<string>();
            animal = a;
            animal.LoadNotes();
            foreach (Note note in animal.notes)
            {
                noteTitles.Add(note.Title);
            }
            InitializeComponent();
            this.loggedEmployee = loggedUser;

            lstBxNotes.DisplayMember = "Title";
            lstBxNotes.DataSource = noteTitles;
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string title = txtBxTitle.Text;
            string content = txtBxContent.Text;
            animal.AddNote(loggedEmployee.Id, title, content);
            animal.LoadNotes();
            foreach (Note note in animal.notes)
            {
                noteTitles.Add(note.Title);
            }
            lstBxNotes.DataSource = null;
            lstBxNotes.DataSource = noteTitles;

        }

        private void btnNoteDetails_Click(object sender, EventArgs e)
        {
            Note selectedNote = animal.GetNoteByTitle(lstBxNotes.SelectedItem.ToString());

            if (selectedNote != null)
            {
                NoteForm noteForm = new NoteForm(selectedNote, loggedEmployee);
                noteForm.ShowDialog();
            }
        }
    }
}
