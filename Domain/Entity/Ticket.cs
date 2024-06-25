using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Ticket
    {
        public int Id;

        public DateTime DateTime;

        public string Type;

        public string Time;
        public Ticket(int id, DateTime dateTime, string type, string time)
        {
            this.Id = id;
            this.DateTime = dateTime;
            this.Type = type;
            this.Time = time;
        }
    }
}
