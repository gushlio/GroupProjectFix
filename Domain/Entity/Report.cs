using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Report
    {
        private readonly int _id;
        private readonly int _authorID;
        private string _title;
        private string _content;
        private readonly string _dateCreated;
        private string _category;

        public Report(int id, int authorID, string title, string content, string dateCreated, string category)
        {
            _id = id;
            _authorID = authorID;
            _title = title;
            _content = content;
            _dateCreated = dateCreated;
            _category = category; // Initialize category
        }

        public int Id { get { return _id; } }
        public string Title { get { return _title; } }
        public string Content { get { return _content; } }
        public int AuthorID { get { return _authorID; } }
        public string DateCreated { get { return _dateCreated; } }
        public string Category { get { return _category; } } // Category property
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
