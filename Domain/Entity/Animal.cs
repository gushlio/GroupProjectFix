using DataAccessLayer;

namespace Domain.Entity
{
    public class Animal
    {
        public int id { get; set; }
        public string species { get; set; }
        public string dateOfBirth { get; set; }
        public string locationName { get; set; }
        public string reasonForEntry { get; set; }
        public string? reasonForLeave { get; set; }
        public string? imgURL { get; set; }
        public int? motherId { get; set; }
        public int? fatherId { get; set; }
        public DateTime dateOfEntry { get; set; }
        public DateTime? dateOfLeave { get; set; }
        public List<Note> notes { get; set; }
        private NoteDataAccess noteDataAccess;
        public Animal(int id, string species, string dateOfBirth, string reasonForEntry, string? reasonForLeave, string? imgURL, string locationName, string dateOfEntry, string? dateOfLeave, int? motherId, int? fatherId)
        {
            this.id = id;
            this.species = species;
            this.dateOfBirth = dateOfBirth;
            this.reasonForEntry = reasonForEntry;
            this.locationName = locationName;
            this.imgURL = imgURL;
            this.reasonForLeave = reasonForLeave;
            this.notes = new List<Note>();
            noteDataAccess = new NoteDataAccess();
            try
            {
                this.dateOfEntry = DateTime.Parse(dateOfEntry);
                this.dateOfLeave = DateTime.Parse(dateOfLeave);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error parsing dates: {ex.Message}");
            }
            this.motherId = motherId;
            this.fatherId = fatherId;
        }
        public void LoadNotes()
        {
            notes.Clear();
            noteDataAccess.LoadNotesData();
            foreach (List<string> noteData in noteDataAccess.notesData)
            {
                if (id == Convert.ToInt32(noteData[5]))
                {
                    Note note = new Note(Convert.ToInt32(noteData[0]), Convert.ToInt32(noteData[1]), noteData[2], noteData[3], noteData[4], Convert.ToInt32(noteData[5]));
                    notes.Add(note);
                }

            }
        }
        public void AddNote(int employeeId, string title, string noteContent)
        {
            noteDataAccess.AddNoteData(id, employeeId, title, noteContent);
            LoadNotes();
        }
        public void DeleteNote(int id)
        {
            noteDataAccess.DeleteNoteData(id);
            LoadNotes();
        }
        public Note GetNoteByTitle(string name)
        {
            foreach (Note note in notes)
            {
                if (note.Title == name) return note;
            }
            return null;
        }
    }
}
