using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Shift
    {
        public int Id { get; set; }
        public string DayOfWeek { get; set; }
        public string ShiftTime { get; set; }
        public int EmployeeId { get; set; }
    }
}
