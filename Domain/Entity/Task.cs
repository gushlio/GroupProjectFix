using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsDone { get; set; }

        public Task(int id, string title, string description, string category, string location, DateTime deadline)
        {
            Id = id;
            Title = title;
            Description = description;
            Category = category;
            Location = location;
            Deadline = deadline;
            IsDone = false;
        }
    }
}
