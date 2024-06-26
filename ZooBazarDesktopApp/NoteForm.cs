using Domain.Entity;
using Domain.Manager;
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
    public partial class NoteForm : Form
    {
        Note newNote;
        AnimalManager animalManager;
        EmployeeManager manager;
        Employee author;
        Employee loggedEmployee;
        public NoteForm(Note note, Employee loggedIn)
        {
            loggedEmployee = loggedIn;
            animalManager = new AnimalManager();
            manager = new EmployeeManager();
            newNote = note;
            author = manager.GetEmployeeById(newNote.AuthorID);
            InitializeComponent();
            if (loggedEmployee.Id != author.Id)
            {
                btnDelete.Visible = false;

            }
        }

        private void PopulateLabels()
        {
            lblAuthor.Text = author.FirstName + " " + author.LastName + " (" + author.Username + ")";
            lblDate.Text = newNote.DateCreated;
            lblTitle.Text = newNote.Title;

      
            lblContent.AutoSize = false; 
            lblContent.MaximumSize = new Size(600, 0); 
            lblContent.AutoSize = true; 
            lblContent.Text = newNote.Content;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            animalManager.GetAnimalById(newNote.AnimalID).DeleteNote(newNote.Id);
            this.Close();
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            PopulateLabels();
        }
    }
}
