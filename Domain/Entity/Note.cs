using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Note
    {
        private readonly int _id;
        private readonly int _authorID;
        private string _title;
        private string _content;
        private readonly string _DateCreated;
        private int animalID;

        public Note(int id, int authorID, string title, string content, string dateCreated, int animalID)
        {
            _id = id;
            _authorID = authorID;
            _title = title;
            _content = content;
            _DateCreated = dateCreated;
            this.animalID = animalID;
        }

        public int Id { get { return _id; } }
        public string Title { get { return _title; } }
        public string Content { get { return _content; } }
        public int AuthorID { get { return _authorID; } }
        public string DateCreated { get { return _DateCreated; } }
        public int AnimalID { get { return animalID; } }
        public void UpdateTitle(string title)
        {
            _title = title;
        }
        public void UpdateContent(string content)
        {
            _content = content;
        }
    }
}
