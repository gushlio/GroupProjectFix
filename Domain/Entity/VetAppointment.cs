using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class VetAppointment
    {
        public int Id { get; set; }
        public string VetName { get; set; }
        public Animal animal { get; set; }
        public string DayOfWeek { get; set; }
        public string VetTime { get; set; }

        public VetAppointment(int id, string vetName, Animal animal, string dayOfWeek, string vetTime)
        {
            Id = id;
            VetName = vetName;
            this.animal = animal;
            DayOfWeek = dayOfWeek;
            VetTime = vetTime;
        }
    }
}
